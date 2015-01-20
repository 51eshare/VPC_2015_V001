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
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Partner
{
    public partial class Pds : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
            string _where = string.Concat("c.iUserId=",UserInfo.RealID), _sort = "a.iPdId desc";
            if (!string.IsNullOrWhiteSpace(sort_where.SelectedValue))
                _sort = sort_where.SelectedValue;
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and a.sPdName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbProduct>();
            _paging.Fields = "a.*,b.iShopRefPdId,b.iShopId";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbProduct AS a INNER JOIN tbShopRefProduct AS b ON a.iPdId=b.iPdId INNER JOIN tbShop AS c ON b.iShopId=c.iShopId";
            var _list = new b_tbProduct().PageList<tbProduct>(_paging);
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