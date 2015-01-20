using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Account
{
    public partial class UserInfo : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                iUserId.Value = UserInfo.RealID.ToString();
                LoadData();
            }
        }
        private void LoadData()
        {
            var _suerinfo = new b_tbUser().Get(UserInfo.iUserId);
            CommonMethod.Entity_to_Controls(_suerinfo, RegistForm);
        }
        protected void btn_add_ServerClick(object sender, EventArgs e)
        {
            var _suerinfo = new tbUser();
            CommonMethod.Controls_to_Entity(_suerinfo, RegistForm);
            _suerinfo.sPassword = Security.MD5(_suerinfo.sPassword);
            _suerinfo.iUserId = UserInfo.iUserId;
            tipclass = string.Empty;
            if (new b_tbUser().Update(_suerinfo))
            {
                message.Text = "提交成功！";
            }
            else
            {
                message.Text = "提交失败！";
            }
        }

        protected void btn_sUserEmail_Click(object sender, EventArgs e)
        {
            string _url = "{0}/changeemail?{1}";
            string _parameter = "email={0}&uid={1}&date={2}";
            _url=string.Format(_url,b_Cache.GetSiteInfo().url,Encrypt.DESEncrypt(string.Format(_parameter,UserInfo.sUserEmail,UserInfo.RealID,DateTime.Now.ToLongDateString())));
            EmailContext _context = new EmailContext();
            _context.Body = string.Format("您已经申请邮箱修改，如果确认修改请点击<a href=\"{0}\" target=\"_blank\">{1}</a>,进行修改。", _url, string.Format("{0}/changeemail", b_Cache.GetSiteInfo().url));
            _context.Subjct = "邮箱修改";
            _context.mailAddress.Add(UserInfo.sUserEmail);
            if (SendEmail(_context))
            {
                Alert.Show("已经发送邮件，请查收！", Page);
            }
            else
            {
                Alert.Show("邮件发送失败，请核对您的邮件，再重试！", Page);
            }
        }

        protected void btn_ilipay_ServerClick(object sender, EventArgs e)
        {

        }
    }
}