using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;
using Service;
using Common;
using Entity;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Reply : P_Base
    {

        private string operate
        {
            get {
                return GetParaStr("operate");
            }
        }
        private long iquestionid
        {
            get { return GetParaInt("iQuestionId"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                if (operate.Equals("view"))
                    InfoReply.Visible = false;
                loaddata();
            }
        }
        private void loaddata()
        {
            var _info = new b_tbQuestion().GetQuestion(iquestionid);
            CommonMethod.Entity_to_Controls(_info,ReplyInfo);
            if (_info.bApply)
            {
                divsiReplyUserId.Attributes["class"] = divReplyDate.Attributes["class"] = divReplyText.Attributes["class"] = "row";
                divReply.Attributes["class"] = "row hidden";
                InfoReply.Attributes["class"] = "hidden";
            }
        }

        protected void InfoReply_ServerClick(object sender, EventArgs e)
        {
            var _info = new tbReply();
            _info.iQuestionId = iquestionid;
            _info.iReplyUserId = UserInfo.RealID;
            _info.sReplyText = sReplyText.Value;
            tipclass = string.Empty;
            if (new b_tbReply().AddtbReply(_info))
            {
                message.Text = "提交成功！";
                Response.Redirect(RequestQuery(URL.urlreferrer));
            }
            else {
                message.Text = "提交失败！";
            }
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}