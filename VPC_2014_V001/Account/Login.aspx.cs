using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Common;

namespace VPC_2014_V001.VPC.Account
{
    public partial class Login : Page_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
                if (Cookie.IsExist(Cookie_Key.sLoginId))
                {
                    txtsLoginId.Value = Cookie.GetCookieValue(Cookie_Key.sLoginId);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            #region 对比MD5密码

            #endregion

            bool bError = false;
            string sError = "";

            //数据有效性验证

            //判读用户名的有效性
            //用户名不为空
            if (string.IsNullOrEmpty(txtsLoginId.Value.Trim()))
            {
                bError = true; sError = "用户名必须填写";
            }
            //用户名长度不超过30个字节
            if (txtsLoginId.Value.Trim().Length > 15)
            {
                bError = true; sError = "用户名不能超过15个字符";
            }
            //判读密码的有效性
            //密码不为空
            if (string.IsNullOrEmpty(txtsPassword.Value.Trim()))
            {
                bError = true; sError = "密码必须填写";
            }
            //密码长度不超过30个字节
            if (txtsPassword.Value.Trim().Length > 15)
            {
                bError = true; sError = "密码不能超过15个字符";
            }
            var _userinfo = new b_tbUser().GetUserInfo(txtsLoginId.Value.Trim(), Security.MD5(txtsPassword.Value.Trim()), string.Empty);
            if (_userinfo == null)
            {
                bError = true; sError = "登录错误，请重新输入正确的用户名和密码！";
            }
            else
            {
                string _redirect = string.Empty;
                Session["UserInfo"] = _userinfo;
                if (_userinfo.UserType.Contains(9000))
                    _redirect = "/Admin/";
                else if (_userinfo.UserType.Contains(3000) || _userinfo.UserType.Contains(3001))
                    _redirect = "/Partner/";
                else if (_userinfo.UserType.Contains(5000))
                    _redirect = "/Vendor/";
                else
                    _redirect = "/Customer/";

                _redirect = string.Concat(_redirect, "Default");
                if (Request.QueryString["urlreferrer"] != null)
                    _redirect = StringDecode(Request.QueryString["urlreferrer"]);
                Response.Redirect(_redirect);
            }
            if (bError)
            {
                Label1.Text = @"<div class=""alert alert-danger"" role=""alert"">" + sError + @"</div>";

            }
        }
    }
}