using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Account
{
    public partial class Regist : U_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
            }
        }

        protected void btn_add_ServerClick(object sender, EventArgs e)
        {
            var _suerinfo = new tbUser();
            CommonMethod.Controls_to_Entity(_suerinfo, RegistForm);
            _suerinfo.sPassword = Security.MD5(_suerinfo.sPassword);
            tipclass = string.Empty;
            if (new b_tbUser().AddUserInfo(_suerinfo))
            {
                message.Text = "注册成功！<a href=\"Login\">点击登录系统</a>";
            }
            else
            {
                message.Text = "注册失败！";
            }
        }
    }
}
