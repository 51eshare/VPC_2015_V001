using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Dynamic;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class OperationManageHistory : P_Base
    {
        private string back_url
        {
            get {
                if (Request.QueryString["urlreferrer"] != null)
                {
                    return RequestQuery("urlreferrer");
                }
                else
                    return "OperationManage";
            }
        }
        private int iUserId
        {
           get{
              return GetParaInt("iUserId");
           } 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                if (iUserId > 0)
                {
                    var _user = new b_tbUser().Get(iUserId);
                    CommonMethod.Entity_to_Controls(_user, OperationManageform);
                }
            }
        }
        protected void btn_add_ServerClick(object sender, EventArgs e)
        {
            var _suerinfo = new tbUser();
            CommonMethod.Controls_to_Entity(_suerinfo, OperationManageform);
            _suerinfo.iParentID = UserInfo.RealID;
            _suerinfo.sPassword = Security.MD5(_suerinfo.sPassword);
            if (iUserId < 1)
            {
                if (new b_tbUser().Insert(_suerinfo).Value > 0)
                {
                    Response.Redirect(back_url);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else {
                _suerinfo.iUserId = iUserId;
                if (new b_tbUser().Update(_suerinfo))
                {

                    Response.Redirect(back_url);
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "提交失败！";
                }
            }
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(back_url);
        }
    }
}