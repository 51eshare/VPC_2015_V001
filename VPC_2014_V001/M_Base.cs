using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace VPC_2014_V001
{
    public class M_Base : MasterPage
    {
        public M_Base()
        {

        }
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
                    return null;
                }
            }
        }
        protected void ReUserInfo()
        {
            Session["UserInfo"] = new b_tbUser().GetUserInfo(UserInfo.sLoginId, Security.MD5(UserInfo.sPassword), string.Empty);
        }
        #endregion
    }
}