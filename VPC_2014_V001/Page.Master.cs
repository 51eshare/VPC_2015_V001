using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using Common;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001
{
    public partial class Page : M_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                #region Xavier Add WEIXIN
                if (UserInfo == null)
                {
                    if (Request.Cookies["WXB"] != null)
                    {
                        if (Request.Cookies["WXB"].Value.ToString() == "1")
                        {
                            HttpCookie cook = Request.Cookies["WXB"];
                            cook.Value = "2";
                            Response.Redirect("https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + "wx7e2b2037bdda3a37" + "&redirect_uri=http://www.51eshare.com/weixin/OAuth1.aspx?reurl=" + Request.Url.AbsoluteUri + "&response_type=code&scope=snsapi_base&state=1#wechat_redirect");
                        }
                        else if (Request.Cookies["WXB"].Value.ToString() == "2")
                        {
                            string sWxOpenId=string.Empty;
                            string code = "";
                            if (Request.QueryString["code"] != null && Request.QueryString["code"] != "")
                            {
                                //获取微信回传的code
                                code = Request.QueryString["code"].ToString();
                                OAuth_Token Model = Get_token(code);  //获取token
                                sWxOpenId = Model.openid;
                                var _userinfo=new b_tbUser().GetUserInfoBysWxOpenId(sWxOpenId);
                                if (_userinfo.iUserId > 0)
                                    Session["UserInfo"] = _userinfo;
                                else
                                    Alert.ShowClose("注册失败！");
                                //增加微信号后台自动登录代码
                                //设置一个Session存放当前使用微信浏览器标志位，后续页面可以根据他来判别是不是微信浏览器
                                
                            }
                        }
                    }
                }
                #endregion

            }
        }

        #region  微信
        private OAuth_Token Get_token(string code)
        {
            //获取微信回传的openid、access token
            string Str = GetJson("https://api.weixin.qq.com/sns/oauth2/access_token?appid=" + "wx7e2b2037bdda3a37" + "&secret=" + "83ffff4de1604fb29bd2801f2e5fe93c" + "&code=" + code + "&grant_type=authorization_code");
            //微信回传的数据为Json格式，将Json格式转化成对象
            OAuth_Token Oauth_Token_Model = JsonHelper.ParseFromJson<OAuth_Token>(Str);
            return Oauth_Token_Model;
        }

        private string GetJson(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            wc.Encoding = Encoding.UTF8;
            string returnText = wc.DownloadString(url);
            if (returnText.Contains("errcode"))
            {
                //可能发生错误
            }
            return returnText;
        }

        public class JsonHelper
        {
            /// <summary>  
            /// 生成Json格式  
            /// </summary>  
            /// <typeparam name="T"></typeparam>  
            /// <param name="obj"></param>  
            /// <returns></returns>  
            public static string GetJson<T>(T obj)
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    json.WriteObject(stream, obj);
                    string szJson = Encoding.UTF8.GetString(stream.ToArray()); return szJson;
                }
            }
            /// <summary>  
            /// 获取Json的Model  
            /// </summary>  
            /// <typeparam name="T"></typeparam>  
            /// <param name="szJson"></param>  
            /// <returns></returns>  
            public static T ParseFromJson<T>(string szJson)
            {
                T obj = Activator.CreateInstance<T>();
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                    return (T)serializer.ReadObject(ms);
                }
            }
        }
        #endregion
    }

    #region 微信
    public class OAuth_Token
    {
        public OAuth_Token()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        //access_token 网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
        //expires_in access_token接口调用凭证超时时间，单位（秒）
        //refresh_token 用户刷新access_token
        //openid 用户唯一标识，请注意，在未关注公众号时，用户访问公众号的网页，也会产生一个用户和公众号唯一的OpenID
        //scope 用户授权的作用域，使用逗号（,）分隔
        public string _access_token;
        public string _expires_in;
        public string _refresh_token;
        public string _openid;
        public string _scope;
        public string access_token
        {
            set { _access_token = value; }
            get { return _access_token; }
        }
        public string expires_in
        {
            set { _expires_in = value; }
            get { return _expires_in; }
        }
        public string refresh_token
        {
            set { _refresh_token = value; }
            get { return _refresh_token; }
        }
        public string openid
        {
            set { _openid = value; }
            get { return _openid; }
        }
        public string scope
        {
            set { _scope = value; }
            get { return _scope; }
        }
    }
    #endregion 微信

}
