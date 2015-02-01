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

namespace VPC_2014_V001.VPC.Customer
{
    public partial class ShopPds :P_Base
    {
        public tbShop tbshop;
        private long iShopId { get {
            return GetParaInt("iShopId");
        } }
        protected void Page_Load(object sender, EventArgs e)
        {
            tbshop = new tbShop();
            tbshop = b_Cache.GetShops().SingleOrDefault(p => p.iShopId == iShopId);
            if (!IsPostBack)
            {
                loaddata();
            }
        }
        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            string _where = string.Concat("状态Id=", DataState.passcheck, " and 微店Id=", iShopId), _sort = "P desc";
            if (!string.IsNullOrWhiteSpace(sort_where.SelectedValue))
                _sort = sort_where.SelectedValue;
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and (商品名称 like '%{0}%')", where.Value);
            var _paging = new p_PageList<vwProduct4Partner>();
            _paging.Fields = "*";
            
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = "vwProduct4Partner";
            var _list = new b_vwProduct4Partner().PageList<vwProduct4Partner>(_paging);
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
            var _command = e.CommandName;
            var _ipdid = e.CommandArgument.ToString();
            if (_command.Equals("buy"))
            {
                IsLogin();
                var _tbShoppingCart = new tbShoppingCart();
                _tbShoppingCart.iUserid = UserInfo.RealID;
                _tbShoppingCart.iShopRefPdId = long.Parse(_ipdid);
                _tbShoppingCart.iOrderNum = 1;
                if (new b_tbShoppingCart().add_updatetbShoppingCart(_tbShoppingCart))
                {
                    tipclass = string.Empty;
                    message.Text = "购买成功！";
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "购买失败！";
                }
            }
        }
    }
}