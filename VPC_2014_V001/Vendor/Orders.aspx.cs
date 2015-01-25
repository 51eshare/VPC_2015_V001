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
    public partial class Orders : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                BindOrderState(state);
                BindtbExpress(ExpressID);
                loaddata();
            }
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = "c.iVendorId="+UserInfo.RealID, _sort = "a.iOrderId desc";
            if (!string.IsNullOrWhiteSpace(startdate.Text.Trim()) && !string.IsNullOrWhiteSpace(enddate.Text.Trim()))
                _where = string.Concat("a.dDate BETWEEN '", startdate.Text.Trim(), "' AND '", enddate.Text.Trim(), "'");
            if (!string.IsNullOrWhiteSpace(numberno.Text))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.sOrderNum='", numberno.Text.Trim(), "'") : string.Concat(" and a.sOrderNum='", numberno.Text.Trim(), "'");
            if (!string.IsNullOrWhiteSpace(state.SelectedValue))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.iStatus=", state.SelectedValue.Trim()) : string.Concat(" and a.iStatus=", state.SelectedValue.Trim());
            var _paging = new p_PageList<tbOrder>();
            _paging.Fields = "a.iOrderId,a.iStatus,a.dDate,c.sPdName,a.iOrderNum,a.iOrderNum*a.fSaPrice fSaPrice,d.sStatus,a.sOrderNum";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbOrder AS a INNER JOIN tbShopRefProduct AS b ON a.iShopRefPdId=b.iShopRefPdId INNER JOIN tbProduct AS c ON b.iPdId=c.iPdId INNER JOIN tbStatus AS d ON a.iStatus=d.StateValue AND d.StateType=2";
            var _list = new b_tbOrder().PageList<tbOrder>(_paging);
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
            var _payreturn_row = e.CommandName;
            var _iPdId = e.CommandArgument.ToString();
            var _info = new tbOrder();
            if (_payreturn_row.Equals("payreturn_row"))
            {
                _info.iOrderId = long.Parse(_iPdId);
                _info.iStatus = 7;
                if (new b_tbOrder().Updatepayreturn(_info))
                {
                    tipclass = string.Empty;
                    message.Text = "确认退款成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "确认退款失败！";
                }

            }
            else
            {
                _info.iOrderId = long.Parse(_iPdId);
                _info.iStatus = 8;
                if (new b_tbOrder().Updatepayreturn(_info))
                {
                    tipclass = string.Empty;
                    message.Text = "确认退货退款成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "确认退货退款失败！";
                }
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var _payreturn_row = e.Item.FindControl("payreturn_row") as Button;
                var _salesreturn_row = e.Item.FindControl("salesreturn_row") as Button;
                var _info = e.Item.DataItem as tbOrder;
                if (_info.iStatus == 9) //未付款
                {
                    _payreturn_row.Visible = true;
                }
                else if (_info.iStatus == 10)
                {
                    _salesreturn_row.Visible = true;
                }
            }
        }
    }
}