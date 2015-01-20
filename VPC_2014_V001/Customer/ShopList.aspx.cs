using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;
using Entity;
using Service;


namespace VPC_2014_V001.VPC.Customer
{
    public partial class ShopList : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }

        private void loaddata()
        {
            string _where = "1=1", _sort = "b.dDate desc,a.店铺Id desc";
            if (!string.IsNullOrWhiteSpace(sort_where.SelectedValue))
                _sort = sort_where.SelectedValue;
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" and (a.店铺名称 like '%{0}%' or a.店铺描述 like '%{0}%')", where.Value);
            var _paging = new p_PageList<vwShopList>();
            _paging.Fields = "a.*,b.iCollectId";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = string.Concat("vwShopList AS a inner join tbCollect AS b ON a.店铺Id=b.iShopId  and b.iUserId=", UserInfo.RealID);
            var _list = new b_vwShopList().PageList<vwShopList>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
            
        }

        protected void btn_search_ServerClick(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string _ishopid = e.CommandArgument.ToString();
            string _iCollectId = e.CommandName;
            long _icollectid = 0;
            long.TryParse(_iCollectId,out _icollectid);
            tbCollect _tb = new tbCollect();
            _tb.iShopId = long.Parse(_ishopid);
            _tb.iUserId = UserInfo.RealID;
            if (_icollectid > 0)
            {
                if (new b_tbCollect().Delete(_icollectid))
                {
                    tipclass = "";
                    message.Text = "取消成功！";
                    loaddata();
                }
                else
                {
                    tipclass = "";
                    message.Text = "取消失败！"; 
                }
            }
            else
            {
                if (new b_tbCollect().Insert(_tb).Value > 0)
                {
                    tipclass = "";
                    message.Text = "收藏成功！";
                    loaddata();
                }
                else
                {
                    tipclass = "";
                    message.Text = "收藏失败！";
                }
            } 
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var _data = e.Item.DataItem as vwShopList;
                if (_data.iCollectId > 0)
                    (e.Item.FindControl("Collect") as Button).Text = "取消收藏";
            }
        }
    }
}