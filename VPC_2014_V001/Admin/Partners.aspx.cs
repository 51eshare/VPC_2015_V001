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
    public partial class Partners : P_Base
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
            var _info = new tbUserTypeRefUser() { iUserTypeId=3000};
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
            string _where = string.Empty, _sort = "a.iLevel desc,a.iVolumeSum desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" a.sShopName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbShop>();
            _paging.Fields = "a.iShopId,a.sShopName,a.cOwnerName,a.cOwnerMail,b.sLoginId,a.iUserId,a.dDate,c.iStatus,d.sStatus,a.iLevel,a.iVolumeSum";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbShop AS a
INNER JOIN tbUser AS b ON a.iUserId=b.iUserId
INNER JOIN tbUserTypeRefUser AS c ON a.iUserId=c.iUserId AND c.iUserTypeId=3000
INNER JOIN tbStatus AS d ON c.iStatus=d.StateValue AND d.StateType=1";
            var _list = new b_tbShop().PageList<tbShop>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbShop;
                if (_info.iStatus == 2)
                    (e.Item.FindControl("btn_del") as Button).Text = "禁止";
                else
                    (e.Item.FindControl("btn_del") as Button).Text = "审核通过";
            }
            
           
        }
    }

}