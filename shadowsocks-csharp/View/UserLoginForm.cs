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
        public class data
        {
            public string token;
            public string user_id;
            public string ssrlink;
        }

        private ShadowsocksController controller;
        private Configuration _modifiedConfiguration;


        public UserLoginForm(ShadowsocksController m_Controller)
        {
            controller = m_Controller;
            _modifiedConfiguration = controller.GetConfiguration();
            this.FormClosed += userLoginForm_FormClosed;
            UpdateHomePageByGitHub();
           // _modifiedConfiguration.configs.Clear();

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


            string url = controller.GetConfiguration().homePageUrl + "/client/login";
            string data = "email=" + useremail + "&" +
                                "passwd=" + userkey + "&+" +
                                "remember_me=" + "1";


            string con = SendDataByPost(url, data);
   
            LoadReceiveInfo(con);
         
            bu_login.Enabled = true;
            this.Cursor = Cursors.Default;//正常状态
        }
        /// <summary>
        /// 加载登录信息
        /// </summary>
        /// <param name="postBack"></param>
        private void LoadReceiveInfo(string postBack) {

          JsonObject d=  (JsonObject)SimpleJson.SimpleJson.DeserializeObject(postBack);
            Object tempObject ;
            //是否登录成功
            d.TryGetValue("ret", out tempObject);
            if (tempObject.ToString().Equals("1"))
            {
                //记录Token
                d.TryGetValue("data", out tempObject);
                data loginData = SimpleJson.SimpleJson.DeserializeObject<data>(tempObject.ToString());

                //是否自动登录
                if (ck_remeberme.Checked)
                {
                    _modifiedConfiguration.userToken = loginData.token;
                }
                else {
                    _modifiedConfiguration.userToken = "";
                }

                //记录SSR链接
                _modifiedConfiguration.userSSRLink = controller.GetConfiguration().homePageUrl + "/link/" + loginData.ssrlink + "?mu=0";
               

                controller.SaveServersConfig(_modifiedConfiguration);
     
                Program._viewController = new MenuViewController(controller);
               
                this.Close();
            }
            //登录失败
            else {
                d.TryGetValue("msg", out tempObject);
                MessageBox.Show(tempObject.ToString());

            }

        }
        /// <summary>
        /// 通过POST方式发送数据
        /// </summary>
        /// <param name="Url">url</param>
        /// <param name="postDataStr">Post数据</param>
        /// <param name="cookie">Cookie容器</param>
        /// <returns></returns>
        public string SendDataByPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Proxy = null;


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
        /// 更新官网首页
        /// </summary>
        public void UpdateHomePageByGitHub()
        {
            try
            {
                WebClient http = new WebClient();
                http.Proxy = null;
                http.DownloadStringCompleted += delegate (object sender, DownloadStringCompletedEventArgs e)
                {
                    string homePageURL = e.Result;
                    homePageURL = homePageURL.Substring(0, homePageURL.Length - 1);

                    //如果网址更新
                    
                    if (_modifiedConfiguration.homePageUrl != homePageURL)
                    {

                        _modifiedConfiguration.homePageUrl = homePageURL;
                        controller.SaveServersConfig(_modifiedConfiguration);
                    }

                };
                http.DownloadStringAsync(new Uri("https://raw.githubusercontent.com/ImDebuger/WebInfo/master/index.txt"));
            }
            catch (Exception e)
            {
                Logging.LogUsefulException(e);
            }
        }

        //关闭登录界面
        void userLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Util.Utils.ReleaseMemory();
            if (Program._viewController==null) {
                controller.Stop();
                Application.Exit();
            }
        }
        private void freelogin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(controller.GetConfiguration().homePageUrl);
        }

        private void image_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(controller.GetConfiguration().homePageUrl);
        }

        private void bt_forget_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(controller.GetConfiguration().homePageUrl + "/password/reset");
        }


    }
}
