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
    public partial class picklist : P_Base
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
            var _info = new tbCommission();
            string _op = e.CommandName;
            _info.iCommissionId=Int32.Parse(e.CommandArgument.ToString());
            _info.iState = 2;
            if (_op.Equals("del"))
                _info.iState = 4;
            if (new b_tbCommission().UpdateStatus(_info))
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
            string _where = string.Empty, _sort = "a.iCommissionId desc";
            if (!string.IsNullOrWhiteSpace(sLoginId.Value))
                _where += string.Format(" c.sLoginId like '%{0}%'", sLoginId.Value);
            if(!string.IsNullOrWhiteSpace(startdate.Text)&&!string.IsNullOrWhiteSpace(enddate.Text))
                _where += string.IsNullOrWhiteSpace(_where) ? string.Format(" CONVERT(VARCHAR(10),a.dDate,120) BETWEEN '{0}' AND '{0}'", startdate.Text.Trim(), enddate.Text.Trim()) : string.Format(" AND  CONVERT(VARCHAR(10),a.dDate,120) BETWEEN '{0}' AND '{0}'", startdate.Text.Trim(), enddate.Text.Trim());
            var _paging = new p_PageList<tbCommission>();
            _paging.Fields = "a.iCommissionId,a.nprice,a.dDate,b.sStatus,a.iState,a.iUserId,c.sLoginId,c.ilipay";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @" tbCommission AS a INNER JOIN tbStatus AS b ON a.iState=b.StateValue AND b.StateType=8 INNER JOIN tbUser AS c ON a.iUserId=c.iUserId WHERE a.iOrderId=0";
            var _list = new b_tbCommission().PageList<tbCommission>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbCommission;
                if (_info.iState == 1)
                {
                    (e.Item.FindControl("btn_pay") as Button).Visible = true;
                }
                else
                {
                    e.Item.FindControl("checkbox_p").Visible = false;
                }
            }
        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            long[] iCommissionIds = ClassChange.ToLongArray(check_all_value.Value.Split(','));
            if (new b_tbCommission().UpdatebatchStatus(iCommissionIds))
            {
                loaddata();
            }
            else
            {
                tipclass = string.Empty;
            }
        }
    }

}