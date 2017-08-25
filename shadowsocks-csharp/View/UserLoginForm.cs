using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SimpleJson;
using Shadowsocks.Controller;
using Shadowsocks.Model;
using System.Text.RegularExpressions;
using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;


namespace Shadowsocks.View
{
    public partial class UserLoginForm : CCSkinMain
    {
        private ShadowsocksController controller;
        private Configuration _modifiedConfiguration;
        private UpdateFreeNode updateFreeNodeChecker;
        private UpdateSubscribeManager updateSubscribeManager;

        public UserLoginForm(ShadowsocksController m_Controller)
        {
            controller = m_Controller;
            _modifiedConfiguration = controller.GetConfiguration();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;//等待
            bu_login.Enabled = false;

            if (userEmailInput.SkinTxt.Text.Length == 0 || userKeyInput.SkinTxt.Text.Length == 0)
            {
                MessageBox.Show("请输入正确的91智云加速登录信息！");
                bu_login.Enabled = true;
                this.Cursor = Cursors.Default;//正常状态
                return;
            }

            SentPostToLogin(userEmailInput.SkinTxt.Text, userKeyInput.SkinTxt.Text);
        }
        private void SentPostToLogin(string useremail,string userkey) {
            string url = Program._controller.HomePageURL + "/client/login";
            string data = "email="+ useremail + "&" +
                                "passwd="+ userkey + "&+" +
                                "remember_me="+"1";

            CookieContainer cc = new CookieContainer();
            cc.Add(new System.Uri(Program._controller.HomePageURL), new Cookie("91zhiyunlogin", "xx"));

            string con = SendDataByPost(url, data, ref cc);
            LoadReceiveInfo(con);

            bu_login.Enabled = true;
            this.Cursor = Cursors.Default;//正常状态
        }
        private void LoadReceiveInfo(string postBack) {
            //  JsonData jsonData2 = JsonMapper.ToObject(postBack);
          JsonObject d=  (JsonObject)SimpleJson.SimpleJson.DeserializeObject(postBack);
            Object tempObject ;
            d.TryGetValue("ssrlink", out tempObject);
            //设置收到的SSR订阅链接
            ServerSubscribe newServerSub = new ServerSubscribe();
            newServerSub.URL = Program._controller.HomePageURL + "/link/" + tempObject + "?mu=0";
            newServerSub.Group = "91智云加速";
            //存储

            if (_modifiedConfiguration.serverSubscribes.Count >= 1)
            {
                _modifiedConfiguration.serverSubscribes[0] = newServerSub;
            }
            else
            {
                _modifiedConfiguration.serverSubscribes.Add(newServerSub);
            }

            controller.SaveServersConfig(_modifiedConfiguration);

            //更新订阅链接
              updateFreeNodeChecker = new UpdateFreeNode();
            updateFreeNodeChecker.NewFreeNodeFound +=updateFreeNodeChecker_NewFreeNodeFound;
            updateSubscribeManager = new UpdateSubscribeManager();
            updateSubscribeManager.CreateTask(controller.GetCurrentConfiguration(), updateFreeNodeChecker, -1, false);

        }
        /// <summary>
        /// 通过POST方式发送数据
        /// </summary>
        /// <param name="Url">url</param>
        /// <param name="postDataStr">Post数据</param>
        /// <param name="cookie">Cookie容器</param>
        /// <returns></returns>
        public string SendDataByPost(string Url, string postDataStr, ref CookieContainer cookie)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Proxy = null;
            if (cookie.Count == 0)
            {
                request.CookieContainer = new CookieContainer();
                cookie = request.CookieContainer;
            }
            else
            {
                request.CookieContainer = cookie;
            }

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postDataStr.Length;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        /// <summary>
        /// 更新节点列表,回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void updateFreeNodeChecker_NewFreeNodeFound(object sender, EventArgs e)
        {
            int count = 0;
            if (!String.IsNullOrEmpty(updateFreeNodeChecker.FreeNodeResult))
            {
                List<string> urls = new List<string>();
                updateFreeNodeChecker.FreeNodeResult = updateFreeNodeChecker.FreeNodeResult.TrimEnd('\r', '\n', ' ');
                Configuration config = controller.GetCurrentConfiguration();
                Server selected_server = null;
                if (config.index >= 0 && config.index < config.configs.Count)
                {
                    selected_server = config.configs[config.index];
                }
                try
                {
                    updateFreeNodeChecker.FreeNodeResult = Util.Base64.DecodeBase64(updateFreeNodeChecker.FreeNodeResult);
                }
                catch
                {
                    updateFreeNodeChecker.FreeNodeResult = "";
                }
                int max_node_num = 0;

                Match match_maxnum = Regex.Match(updateFreeNodeChecker.FreeNodeResult, "^MAX=([0-9]+)");
                if (match_maxnum.Success)
                {
                    try
                    {
                        max_node_num = Convert.ToInt32(match_maxnum.Groups[1].Value, 10);
                    }
                    catch
                    {

                    }
                }
               MenuViewController. URL_Split(updateFreeNodeChecker.FreeNodeResult, ref urls);
                for (int i = urls.Count - 1; i >= 0; --i)
                {
                    if (!urls[i].StartsWith("ssr"))
                        urls.RemoveAt(i);
                }
                if (urls.Count > 0)
                {
                    bool keep_selected_server = false; // set 'false' if import all nodes
                    if (max_node_num <= 0 || max_node_num >= urls.Count)
                    {
                        urls.Reverse();
                    }
                    else
                    {
                        Random r = new Random();
                        Util.Utils.Shuffle(urls, r);
                        urls.RemoveRange(max_node_num, urls.Count - max_node_num);
                        if (!config.isDefaultConfig())
                            keep_selected_server = true;
                    }
                    string lastGroup = null;
                    string curGroup = null;
                    foreach (string url in urls)
                    {
                        try // try get group name
                        {
                            Server server = new Server(url, null);
                            if (!String.IsNullOrEmpty(server.group))
                            {
                                curGroup = server.group;
                                break;
                            }
                        }
                        catch
                        { }
                    }
                    string subscribeURL = updateSubscribeManager.URL;
                    if (String.IsNullOrEmpty(curGroup))
                    {
                        curGroup = subscribeURL;
                    }
                    for (int i = 0; i < config.serverSubscribes.Count; ++i)
                    {
                        if (subscribeURL == config.serverSubscribes[i].URL)
                        {
                            lastGroup = config.serverSubscribes[i].Group;
                            config.serverSubscribes[i].Group = curGroup;
                            break;
                        }
                    }
                    if (lastGroup == null)
                    {
                        lastGroup = curGroup;
                    }

                    if (keep_selected_server && selected_server.group == curGroup)
                    {
                        bool match = false;
                        for (int i = 0; i < urls.Count; ++i)
                        {
                            try
                            {
                                Server server = new Server(urls[i], null);
                                if (selected_server.isMatchServer(server))
                                {
                                    match = true;
                                    break;
                                }
                            }
                            catch
                            { }
                        }
                        if (!match)
                        {
                            urls.RemoveAt(0);
                            urls.Add(selected_server.GetSSRLinkForServer());
                        }
                    }

                    // import all, find difference
                    {
                        Dictionary<string, Server> old_servers = new Dictionary<string, Server>();
                        if (!String.IsNullOrEmpty(lastGroup))
                        {
                            for (int i = config.configs.Count - 1; i >= 0; --i)
                            {
                                if (lastGroup == config.configs[i].group)
                                {
                                    old_servers[config.configs[i].id] = config.configs[i];
                                }
                            }
                        }
                        foreach (string url in urls)
                        {
                            try
                            {
                                Server server = new Server(url, curGroup);
                                bool match = false;
                                foreach (KeyValuePair<string, Server> pair in old_servers)
                                {
                                    if (server.isMatchServer(pair.Value))
                                    {
                                        match = true;
                                        old_servers.Remove(pair.Key);
                                        pair.Value.CopyServerInfo(server);
                                        ++count;
                                        break;
                                    }
                                }
                                if (!match)
                                {
                                    config.configs.Add(server);
                                    ++count;
                                }
                            }
                            catch
                            { }
                        }
                        foreach (KeyValuePair<string, Server> pair in old_servers)
                        {
                            for (int i = config.configs.Count - 1; i >= 0; --i)
                            {
                                if (config.configs[i].id == pair.Key)
                                {
                                    config.configs.RemoveAt(i);
                                    break;
                                }
                            }
                        }
                        controller.SaveServersConfig(config);
                    }
                    config = controller.GetCurrentConfiguration();
                    if (selected_server != null)
                    {
                        bool match = false;
                        for (int i = config.configs.Count - 1; i >= 0; --i)
                        {
                            if (config.configs[i].id == selected_server.id)
                            {
                                config.index = i;
                                match = true;
                                break;
                            }
                            else if (config.configs[i].group == selected_server.group)
                            {
                                if (config.configs[i].isMatchServer(selected_server))
                                {
                                    config.index = i;
                                    match = true;
                                    break;
                                }
                            }
                        }
                        if (!match)
                        {
                            config.index = config.configs.Count - 1;
                        }
                    }
                    else
                    {
                        config.index = config.configs.Count - 1;
                    }
                    controller.SaveServersConfig(config);

                }
            }
            if (count > 0)
            {
                Program._viewController.ShowBalloonTip(I18N.GetString("Success"),
                    I18N.GetString("Update subscribe SSR node success"), ToolTipIcon.Info, 10000);
            }
            else
            {
            Program._viewController. ShowBalloonTip(I18N.GetString("Error"),
                    I18N.GetString("Update subscribe SSR node failure"), ToolTipIcon.Info, 10000);
            }
            if (updateSubscribeManager.Next())
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program._controller.HomePageURL);
        }


    }
}
