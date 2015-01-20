using Common;
using Entity;
using Service;
using System;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class AddtbExpresses : P_Base
    {

        private Int32 iPdId
        {
            get {
                return GetParaInt("id");
            }
        }
        private tbExpress tbProductInfo
        {
            get {
                if (iPdId > 0)
                {
                    return new b_tbExpress().Get(iPdId);
                }
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                loaddata();
            }
        }
        public void loaddata()
        {
            if (iPdId > 0)
            {
                var _pinfo = new b_tbExpress().Get(iPdId);
                Common.CommonMethod.Entity_to_Controls(_pinfo, AddtbExpress);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbExpress();
            CommonMethod.Controls_to_Entity(_info, AddtbExpress);
            if (iPdId > 0)
            {
                tipclass = string.Empty;
                _info.ID = iPdId;
                if (new b_tbExpress().Update(_info))
                {
                    message.Text = "提交成功！";
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else
            {
                tipclass = string.Empty;
                if (new b_tbExpress().Insert(_info).Value > 0)
                {
                    message.Text = "提交成功！";
                    CommonMethod.ClearValue(AddtbExpress);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}
