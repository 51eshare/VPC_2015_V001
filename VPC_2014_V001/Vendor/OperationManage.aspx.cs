using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Entity;
using Service;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class OperationManage : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _iuserid = e.CommandArgument;
            if (new b_tbUser().Delete(Int32.Parse(_iuserid.ToString())))
            {
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
            }
        }

        private void loaddata()
        {
            string _sql = "SELECT * FROM tbUser a WHERE a.iParentID=@iParentID";
            var _list = new b_tbUser().GetList(_sql,new { iParentID=UserInfo.RealID});
            Repeater1.DataSource = _list;
            Repeater1.DataBind();
            a_btn.Visible = _list.Count() < 5 ? true : false;
        }
    }

}