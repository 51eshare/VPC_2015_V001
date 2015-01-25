using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class Orders : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                BindOrderState(state,1);
                BindtbExpress(itbExpress);
                loaddata();
            }
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Concat("a.iUserid=", UserInfo.RealID), _sort = "a.iOrderId desc";
            if (!string.IsNullOrWhiteSpace(startdate.Text.Trim()) && !string.IsNullOrWhiteSpace(enddate.Text.Trim()))
                _where = string.Concat("a.dDate BETWEEN '", startdate.Text.Trim(), "' AND '", enddate.Text.Trim(), "'");
            if (!string.IsNullOrWhiteSpace(numberno.Text))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.sOrderNum='", numberno.Text.Trim(), "'") : string.Concat(" and a.sOrderNum='", numberno.Text.Trim(), "'");
            if (!string.IsNullOrWhiteSpace(state.SelectedValue))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Concat("a.iStatus=", state.SelectedValue.Trim()) : string.Concat(" and a.iStatus=", state.SelectedValue.Trim());
            var _paging = new p_PageList<tbOrder>();
            _paging.Fields = "a.iOrderId,a.iStatus,a.sOrderNum,c.sPdName,a.fSaPrice,a.dDate,d.sStatus sStatus";

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
            var _iorderid = e.CommandArgument;
            var _commandname = e.CommandName;
            if (_commandname.Equals("pay_row"))
            {
                if (new b_tbOrder().UpdateStatus(Int32.Parse(_iorderid.ToString()), 2))
                {
                    tipclass = string.Empty;
                    message.Text = "付款成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "付款失败！";
                }
            }
            else if (_commandname.Equals("del_row"))
            {
                if (new b_tbOrder().UpdateStatus(Int32.Parse(_iorderid.ToString()), 6))
                {
                    tipclass = string.Empty;
                    message.Text = "取消成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "取消失败！";
                }
            }
            else if (_commandname.Equals("sign_row"))
            {
                if (new b_tbOrder().UpdateStatus(Int32.Parse(_iorderid.ToString()), 5))
                {
                    tipclass = string.Empty;
                    message.Text = "签收成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "签收失败！";
                }
            }
            else if (_commandname.Equals("payreturn_row"))
            {
                if (new b_tbOrder().UpdateStatus(Int32.Parse(_iorderid.ToString()), 9))
                {
                    tipclass = string.Empty;
                    message.Text = "退款申请成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "退款申请失败！";
                }
            }
            else if (_commandname.Equals("pass_all"))
            {
                if (new b_tbProduct().update(check_all_value.Value.Trim()))
                {
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                }
            }
            else
            {
                if (new b_tbOrder().UpdateStatus(Int32.Parse(_iorderid.ToString()), 10))
                {
                    tipclass = string.Empty;
                    message.Text = "退货退款申请成功！";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "退货退款申请失败！";
                }
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var _pay_row = e.Item.FindControl("pay_row") as Button;
                var _del_row = e.Item.FindControl("del_row") as Button;
                var _sign_row = e.Item.FindControl("sign_row") as Button;
                var _payreturn_row = e.Item.FindControl("payreturn_row") as Button;
                var _salesreturn_row = e.Item.FindControl("salesreturn_row") as HtmlInputButton;
                var _info = e.Item.DataItem as tbOrder;
                if (_info.iStatus == 1) //未付款
                {
                    _pay_row.Visible = _del_row.Visible = true;
                }
                else if (_info.iStatus == 2)
                {   
                    _payreturn_row.Visible = true;
                }
                else if (_info.iStatus == 3)
                {
                   _sign_row.Visible=_payreturn_row.Visible = _salesreturn_row.Visible= true;
                }
                if(_info.iStatus!=1)
                    e.Item.FindControl("checkbox_p").Visible = false;
            }
        }
    }
}