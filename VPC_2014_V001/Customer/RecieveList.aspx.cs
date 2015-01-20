using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Entity;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class RecieveList : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            bindData();
        }
        void bindData()
        {
            p_PageList<tbRecieveInfo> _para = new p_PageList<tbRecieveInfo>();
            _para.Fields = "a.iRecieveInfoId,a.sRecieveName,a.sAddress,a.sPhoneNum";
            _para.Tables = "tbRecieveInfo as a";
            _para.Where = "iUserId=" + UserInfo.RealID;
            _para.OrderFields = "iRecieveInfoId";
            b_tbRecieveInfo _info = new b_tbRecieveInfo();
            var _page=_info.PageList<tbRecieveInfo>(_para);
            DataList1.DataSource = _page.DataList;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string _commandname = e.CommandName;
            if (_commandname.Equals("edit_row"))
            {
                Response.Redirect("RecieveEdit.aspx?iRecieveInfoId=" + e.CommandArgument.ToString());
            }
            else
            {
                if (!new b_tbRecieveInfo().Delete(Int32.Parse(e.CommandArgument.ToString())))
                {
                    tipclass = "";
                    message.Text = "删除失败！";
                }
                else
                    bindData();
            }
        }
    }
}