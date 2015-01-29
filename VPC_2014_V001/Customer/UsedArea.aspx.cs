using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class UsedArea : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                loaddata();
            }
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = "a.iUserId=" + UserInfo.RealID, _sort = "a.ID desc";
            if (!string.IsNullOrWhiteSpace(UsedName.Text))
                _where += string.Concat(" and a.UsedName like '%", UsedName.Text,"%'");
            var _paging = new p_PageList<tbUsedArea>();
            _paging.Fields = "a.*,b.cPdClass AS siPdClassId";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbUsedArea AS a INNER JOIN tbProductClass AS b ON a.iPdClassId=b.iPdClassId";
            var _list = new b_tbUsedArea().PageList<tbUsedArea>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void sort_where_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void btn_search_ServerClick(object sender, EventArgs e)
        {
            loaddata();
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _id = e.CommandArgument;
            if (new b_tbUsedArea().Delete(Int32.Parse(_id.ToString())))
            {
                tipclass = string.Empty;
                message.Text = "删除成功！";
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "删除失败！";
            }
        }
    }
}