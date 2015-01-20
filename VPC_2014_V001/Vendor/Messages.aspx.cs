using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Messages : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                BindQuestionType(state);
                loaddata();
            }
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = "a.iQuestionUserId=" + UserInfo.RealID, _sort = "a.iQuestionId desc";
            if (!string.IsNullOrWhiteSpace(startdate.Text.Trim()) && !string.IsNullOrWhiteSpace(enddate.Text.Trim()))
                _where = string.Concat("a.dDate BETWEEN '", startdate.Text.Trim(), "' AND '", enddate.Text.Trim(), "'");
            if (!string.IsNullOrWhiteSpace(numberno.Text))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.bTopic like '%", numberno.Text.Trim(), "%'") : string.Concat(" and a.bTopic='%", numberno.Text.Trim(), "%'");
            if (!string.IsNullOrWhiteSpace(state.SelectedValue))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.iQuestionType=", state.SelectedValue.Trim()) : string.Concat(" and a.iQuestionType=", state.SelectedValue.Trim());
            var _paging = new p_PageList<tbQuestion>();
            _paging.Fields = "a.*,b.sLoginId sUserId,c.sLoginId sQuestionUserId";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbQuestion AS a INNER JOIN tbUser AS b ON a.iUserId=b.iUserId INNER JOIN tbUser AS c ON a.iQuestionUserId=c.iUserId";
            var _list = new b_tbQuestion().PageList<tbQuestion>(_paging);
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
            var _iPdId = e.CommandArgument;
            if (new b_tbShopRefProduct().Delete(Int32.Parse(_iPdId.ToString())))
            {
                tipclass = string.Empty;
                message.Text = "下架成功！";
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "下架失败！";
            }
        }
    }
}