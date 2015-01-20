using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Configuration;
using Service;
using Common;

namespace VPC_2014_V001
{
    public class Page_Base : System.Web.UI.Page
    {
        /// <summary>
        /// 获取
        /// </summary>
        /// <returns></returns>
        protected string RequestQuery(string querypara,string defaulturl="/")
        {
            if (HttpContext.Current.Request.QueryString[querypara] != null)
                return StringDecode(HttpContext.Current.Request.QueryString[querypara]);
            else
                return defaulturl;
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        protected string StringEncode(string str)
        {
            return HttpUtility.UrlEncode(str, Encoding.UTF8);
        }
        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        protected string StringDecode(string str)
        {
            return HttpUtility.UrlDecode(str, Encoding.UTF8);
        }

        public Page_Base()
        {
            tipclass = "hidden";
        }
        public string tipclass { get; set; }
        #region 网站信息
        /// <summary>
        /// 网站信息
        /// </summary>
        public Entity.SiteInfo SiteInfo
        {
            get
            {
                return Service.b_SiteInfo.Site_Info;
            }
        }
        #endregion 

        
        #region 用户信息
        /// <summary>
        /// 用户信息
        /// </summary>
        protected tbUser UserInfo
        {
            get
            {
                if (Session["UserInfo"] != null)
                    return Session["UserInfo"] as tbUser;
                else
                {
                    return default(tbUser);
                }
            }
        }
        #endregion

        #region 刷新用户信息
        /// <summary>
        /// 刷新用户信息
        /// </summary>
        protected void ReUserInfo()
        {
            Session["UserInfo"] = new b_tbUser().GetUserInfo(UserInfo.sLoginId, UserInfo.sPassword, string.Empty);
        }
        protected void ReUserInfo(long iuserid)
        {
            Session["UserInfo"] = new b_tbUser().GetUserInfoByUid(iuserid);
        }
        #endregion

        public List<tbDistrict> Districts(Int32 idistrict = 0)
        {
            return b_Cache.GettbDistricts().Where(p => p.iDistrictFatherId == idistrict).ToList();
        }

        #region 发送邮件
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="_emailcontext"></param>
        /// <returns></returns>
        public bool SendEmail(EmailContext _emailcontext)
        { 
            var _email=b_Cache.GetEmail();
            bool sendok=false;
            MailHelper.sendMail(_emailcontext.Subjct, _emailcontext.Body, _email.mailFrom, _emailcontext.mailAddress, _email.HostIP, _email.port, _email.username, _email.password, _email.ssl, string.Empty, out sendok);
            return sendok;
        }
        #endregion 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        protected Dictionary<string,string> GetURL(string query) 
        {
            Dictionary<string,string> _list =new Dictionary<string,string>();
            string[] _para = query.Split('&');
            foreach (var item in _para)
            {
                string[] _temp = item.Split('=');
                _list.Add(_temp[0], _temp[1]);
            }
            return _list;
        }
    }
}