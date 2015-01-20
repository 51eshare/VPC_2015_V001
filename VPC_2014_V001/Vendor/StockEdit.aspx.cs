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

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class StockEdit :P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Concat("a.iVendorId=", UserInfo.RealID), _sort = "a.iPdId desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and a.sPdName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbProduct>();
            _paging.Fields = "a.sPdName,a.iQuantity,a.iPdId";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbProduct AS a ";
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
               var _iquantity = Int32.Parse((e.Item.FindControl("intiQuantity") as TextBox).Text);
               var _iPdId = e.CommandArgument;
               if (new b_tbProduct().updateQuantity(Int32.Parse(_iPdId.ToString()), _iquantity))
               {
                   tipclass = string.Empty;
                   message.Text = "操作成功！";
                   loaddata();
               }
               else
               {
                   tipclass = string.Empty;
                   message.Text = "操作失败！";
               }
        }
    }
}
