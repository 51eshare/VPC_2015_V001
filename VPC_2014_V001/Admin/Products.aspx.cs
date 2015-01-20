using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Common;
using Entity;
using Service;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class Products : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                loaddata();
            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _commandname = e.CommandName.ToString();
            if (_commandname.Equals("pass_all"))
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
                var _info = new tbProduct();
                _info.iPdId = Int32.Parse(e.CommandArgument.ToString());
                _info.iStatus = 2;
                if ((e.Item.FindControl("input_iStatus") as HtmlInputHidden).Value.Equals("2"))
                    _info.iStatus = 3;

                if (new b_tbProduct().updateStatus(_info.iPdId, _info.iStatus))
                {
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                }
            }
        }
        protected void btn_search_ServerClick(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Empty, _sort = "a.iPdId desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" a.sPdName like '%{0}%'", where.Value);
            if (!string.IsNullOrWhiteSpace(sVenName.Value))
                _where += string.IsNullOrWhiteSpace(sVenName.Value) ? string.Format(" b.sVenName like '%{0}%'", sVenName.Value) : string.Format(" and b.sVenName like '%{0}%'", sVenName.Value);
            var _paging = new p_PageList<tbProduct>();
            _paging.Fields = "a.iPdId,a.sPdName,b.sVenName,c.sStatus,a.iStatus,a.fPurPrice,a.fCommission,a.fSaPrice,a.fBdPrice";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbProduct AS a
            INNER JOIN tbVendor AS b ON a.iVendorId=b.iVendorId
            INNER JOIN tbStatus AS c ON a.iStatus=c.StateValue AND c.StateType=1";
            var _list = new b_tbProduct().PageList<tbProduct>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbProduct;
                if (_info.iStatus == 1 || _info.iStatus == 4)
                    (e.Item.FindControl("show_hand") as HtmlInputButton).Visible = true;
                else if (_info.iStatus == 2)
                {
                    var _btn = e.Item.FindControl("btn_del") as Button;
                    _btn.Visible = true;
                    _btn.Text = "禁止";
                }
                else
                {
                    var _btn = e.Item.FindControl("btn_del") as Button;
                    _btn.Visible = true;
                    _btn.Text = "正常";
                }
            }
            
           
        }
    }

}