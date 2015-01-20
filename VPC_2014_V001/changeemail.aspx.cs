using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service;

namespace VPC_2014_V001
{
    public partial class changeemail : U_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string _parameter = Request.Url.Query;
                if (string.IsNullOrWhiteSpace(_parameter))
                {
                    tipclass = string.Empty;
                    message.Text = "参数出错，请重新发送修改邮件";
                }
                else
                {
                    _parameter = _parameter.Substring(1);
                    _parameter = Encrypt.DESDecrypt(_parameter);
                    var _list = GetURL(_parameter);
                    DateTime _date = DateTime.Parse(_list["date"]);
                    if (_date.AddDays(1) < DateTime.Now)
                    {
                        tipclass = string.Empty;
                        message.Text = "操作超时，请重新发送修改邮件";
                    }
                    else
                    {
                        oldemail.Text = _list["email"];
                        uid.Value = _list["uid"];
                    }
                }
            }
        }

        protected void btn_add_ServerClick(object sender, EventArgs e)
        {
            tbUser _user = new tbUser();
            _user.iUserId = Int32.Parse(uid.Value);
            _user.sUserEmail = email.Text;
            if (new b_tbUser().UpdateEmail(_user))
            {
                tipclass = string.Empty;
                if (Session["UserInfo"] != null)
                    ReUserInfo();
                message.Text = "修改成功";
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "修改失败，请核对信息";
            }
        }
    }
}