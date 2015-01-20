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
    public partial class Orders : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                BindOrderState(iStatus);
                loaddata();
            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _info = new tbProduct();
            _info.iPdId= Int32.Parse(e.CommandArgument.ToString());
            _info.iStatus = 2;
            if ((e.Item.FindControl("input_iException") as HtmlInputHidden).Value.Equals("2"))
                _info.iStatus = 1;

            if (new b_tbOrder().UpdateException(_info.iPdId, _info.iStatus))
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
            string _where = string.Empty, _sort = "a.iOrderId desc";
            if (!string.IsNullOrWhiteSpace(iStatus.Value))
                _where += string.Format(" a.iStatus={0}", iStatus.Value);
            if (!string.IsNullOrWhiteSpace(sVenName.Value))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Format(" h.sVenName like '%{0}%'", sVenName.Value) : string.Format(" and .sVenName like '%{0}%'", sVenName.Value);
            if (!string.IsNullOrWhiteSpace(sShopName.Value))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Format(" e.sShopName like '%{0}%'", sShopName.Value) : string.Format(" and e.sShopName like '%{0}%'", sShopName.Value);
            if (!string.IsNullOrWhiteSpace(dDate.Value))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Format(" CONVERT(VARCHAR(10),a.dDate,120)='{0}'", dDate.Value) : string.Format(" and CONVERT(VARCHAR(10),a.dDate,120)='{0}'", dDate.Value);
            if (!string.IsNullOrWhiteSpace(sOrderNum.Value))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Format(" a.sOrderNum like '%{0}%'", sOrderNum.Value) : string.Format(" and a.sOrderNum like '%{0}%'", sOrderNum.Value);
            var _paging = new p_PageList<tbOrder>();
            _paging.Fields = "a.iOrderId,a.sOrderNum,h.sVenName,b.sLoginId,a.fSaPriceSum,a.dDate,a.iStatus,c.sStatus,e.sShopName,f.sPdName,a.iException,g.sStatus sException,a.Datastatus";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbOrder AS a
            INNER JOIN tbUser AS b ON a.iUserid=b.iUserId
            INNER JOIN tbStatus AS c ON a.iStatus=c.StateValue AND c.StateType=2
            INNER JOIN tbShopRefProduct AS d ON a.iShopRefPdId=d.iShopRefPdId
            INNER JOIN tbShop AS e ON d.iShopId=e.iShopId
            INNER JOIN tbProduct AS f ON d.iPdId=f.iPdId
            INNER JOIN tbStatus AS g ON a.iException=g.StateValue AND g.StateType=5
            inner join tbVendor as h on f.iVendorId=h.iVendorId
            ";
            var _list = new b_tbOrder().PageList<tbOrder>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbOrder;
                if (_info.iException == 1)
                    (e.Item.FindControl("btn_del") as Button).Text = "异常";
                else
                    (e.Item.FindControl("btn_del") as Button).Text = "正常";
            }
            
           
        }
    }

}