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
    public partial class Vendors : P_Base
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
            var _info = new tbUserTypeRefUser() { iUserTypeId=5000};
            _info.iUserId=Int32.Parse(e.CommandArgument.ToString());
            _info.iStatus = 2;
            if ((e.Item.FindControl("input_iStatus") as HtmlInputHidden).Value.Equals("2"))
                _info.iStatus = 3;

            if (new b_tbUser().UpdateStatus(_info))
            {
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
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
            string _where = string.Empty, _sort = "a.iVendorId desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" a.sVenName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbVendor>();
            _paging.Fields = "a.sVenName,a.iVendorId,e.cVenClass as sVenClass,a.Products,a.iVolumeSum,a.dDate,a.iUserId,c.sLoginId,b.iStatus,d.sStatus";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbVendor AS a
            INNER JOIN tbUserTypeRefUser AS b ON a.iUserId=b.iUserId AND b.iUserTypeId=5000
            INNER JOIN tbUser AS c ON b.iUserId=c.iUserId
            INNER JOIN tbStatus AS d ON b.iStatus=d.StateValue AND d.StateType=1
            inner join tbVendorClass as e on a.iVenClass=e.iVenClassId";
            var _list = new b_tbShop().PageList<tbVendor>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbVendor;
                if (_info.iStatus == 1 || _info.iStatus == 4)
                {
                    (e.Item.FindControl("show_hand") as HtmlInputButton).Visible = true;
                }
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