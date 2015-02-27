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

namespace VPC_2014_V001.VPC.Partner
{
    public partial class ShopPds : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                bind_control();
                loaddata();
                loadaddate();
                loadnewdate();
            }
        }
        private IEnumerable<tbShopRefProduct> tbShopRefProductList
        {
            get {
                return new b_tbShopRefProduct().GettbShopRefProductByUid(UserInfo.RealID);
            }
        }
        private void bind_control()
        {
            BindPdClass(ProductClass_A, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        /// <summary>
        /// 最新商品
        /// </summary>
        private void loadnewdate()
        {
            newproduct.DataSource = b_Cache.GetRandomProduct();
            newproduct.DataBind();
        }
        /// <summary>
        /// 广告商品
        /// </summary>
        private void loadaddate()
        {
            string _where = string.Concat("b.iShopRefPdId IS NULL and a.iStatus=", DataState.passcheck), _sort = "a.iPdId desc", _ipdclass = string.Empty;
            if (!string.IsNullOrWhiteSpace(sort_where.SelectedValue))
                _sort = sort_where.SelectedValue;
            if (!string.IsNullOrWhiteSpace(iPdClassId.Value) && !iPdClassId.Value.Equals("0"))
                _ipdclass = string.Format(" INNER JOIN f_productclass({0}) AS d ON a.iPdClassId=d.bid", iPdClassId.Value);
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and a.sPdName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbProduct>();
            _paging.Fields = "a.*";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = string.Concat(@"tbProduct AS a
            LEFT OUTER JOIN (SELECT a.iShopRefPdId,a.iPdId,b.iUserId FROM tbShopRefProduct AS a INNER JOIN  tbShop AS b ON a.iShopId=b.iShopId) AS b
            ON a.iPdId=b.iPdId and b.iUserId=", UserInfo.RealID, _ipdclass, " INNER JOIN tbAdPd AS c ON a.iPdId=c.iPdId AND c.iStatus=2");
            var _list = new b_tbProduct().PageList<tbProduct>(_paging);
            adproduct.DataSource = _list.DataList;
            adproduct.DataBind();
        }

        private void loaddata()
        {
            string _where = string.Concat("b.iShopRefPdId IS NULL and a.iStatus=", DataState.passcheck), _sort = "a.iPdId desc", _ipdclass = string.Empty;
            if (!string.IsNullOrWhiteSpace(sort_where.SelectedValue))
                _sort = sort_where.SelectedValue;
            if (!string.IsNullOrWhiteSpace(iPdClassId.Value) &&!iPdClassId.Value.Equals("0"))
                _ipdclass = string.Format(" INNER JOIN f_productclass({0}) AS d ON a.iPdClassId=d.bid", iPdClassId.Value);
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and a.sPdName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbProduct>();
            _paging.Fields = "a.*";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = string.Concat(@"tbProduct AS a
            LEFT OUTER JOIN (SELECT a.iShopRefPdId,a.iPdId,b.iUserId FROM tbShopRefProduct AS a INNER JOIN  tbShop AS b ON a.iShopId=b.iShopId) AS b
            ON a.iPdId=b.iPdId and b.iUserId=", UserInfo.RealID, _ipdclass);
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
            var _para= new tbShopRefProduct();
            _para.iUserid=UserInfo.RealID;
            _para.iPdId=long.Parse(_iPdId.ToString());
            if (new b_tbShopRefProduct().p_a_u_tbShopRefProduct(_para))
            {
                tipclass = string.Empty;
                message.Text = "上架成功！";
                loadaddate();
                loadnewdate();
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "上架失败！";
            }
        }

        protected void ProductClass_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductClass_A.SelectedValue))
            {
                var _item = b_Cache.GetProductClasses().Where(p => p.iPdFatherId == Int32.Parse(ProductClass_A.SelectedValue)).ToList();
                BindPdClass(ProductClass_B, _item);
            }
            loaddata();
        }

        protected void ProductClass_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void adproduct_ItemCommand(object source, DataListCommandEventArgs e)
        {
            var _iPdId = e.CommandArgument;
            var _para = new tbShopRefProduct();
            _para.iUserid = UserInfo.RealID;
            _para.iPdId = long.Parse(_iPdId.ToString());
            if (new b_tbShopRefProduct().p_a_u_tbShopRefProduct(_para))
            {
                tipclass = string.Empty;
                message.Text = "上架成功！";
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "上架失败！";
            }
        }

        protected void adproduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var _item = e.Item.DataItem as tbProduct;
            var _control = e.Item.FindControl("sj");
            _control.Visible = tbShopRefProductList.Any(p => p.iPdId == _item.iPdId)?true:false;
        }
    }
}