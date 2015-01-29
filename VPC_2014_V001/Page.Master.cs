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
                            Response.Redirect("https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + "wx7e2b2037bdda3a37" + "&redirect_uri=http://www.51eshare.com/WEIXIN_Login.aspx?reurl=" + Request.Url.AbsoluteUri + "&response_type=code&scope=snsapi_base&state=1#wechat_redirect");
                        }
                    }
                }
                #endregion

            }
        }

    }


}
