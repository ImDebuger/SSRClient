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



namespace Shadowsocks.View
{
    public partial class UserLoginForm : Form
    {
        private ShadowsocksController controller;
        private Configuration _modifiedConfiguration;

        public UserLoginForm(ShadowsocksController m_Controller)
        {
            controller = m_Controller;
            _modifiedConfiguration = controller.GetConfiguration();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CookieContainer cc = new CookieContainer();
            cc.Add(new System.Uri("https://ss.91zhiyun.cn/client/login"), new Cookie("91zhiyunlogin", "xx"));
            string url = "https://ss.91zhiyun.cn/client/login";
            string data = "email=632339219@qq.com&passwd=lisong648&remember_me=dd";
            //  MessageBox.Show(PostHttp(url, data, "application/x-www-form-urlencoded"));
            //\u6b22\u8fce\u56de\u6765
            string con = SendDataByPost(url, data, ref cc);
            MessageBox.Show(con);
            LoadBackInfo(con);


        }
        private void LoadBackInfo(string postBack) {
            //  JsonData jsonData2 = JsonMapper.ToObject(postBack);
          JsonObject d=  (JsonObject)SimpleJson.SimpleJson.DeserializeObject(postBack);
            Object temp ;
            d.TryGetValue("ssrlink", out temp);
            MessageBox.Show((String)temp);
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

    }
}
