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
    public partial class pickCommission : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                allnprice.InnerHtml = nprice.Text = new b_tbCommission().GetList().Where(p => p.iUserId == UserInfo.RealID).Sum(p => p.nprice).ToString();
                loaddata();
                Sname.Text = UserInfo.sLoginId;
                ilipay.Text = UserInfo.ilipay;
                mobile.Text = UserInfo.mobile;
            }
        }

        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Concat("a.iUserId=", UserInfo.RealID), _sort = "a.iCommissionId desc";
            var _paging = new p_PageList<tbCommission>();
            _paging.Fields = "a.*,b.sStatus";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbCommission AS a INNER JOIN tbStatus AS b ON a.iState=b.StateValue AND b.StateType=8";
            var _list = new b_tbCommission().PageList<tbCommission>(_paging);
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
            if (string.IsNullOrWhiteSpace(Sname.Text) || string.IsNullOrWhiteSpace(ilipay.Text) || string.IsNullOrWhiteSpace(mobile.Text))
            {
                Response.Redirect("/Account/UserInfo?urlreferrer=/Customer/pickCommission");
            }
            else
            {
                var _tbpickCommission = new tbCommission();
                _tbpickCommission.iUserId = UserInfo.RealID;
                _tbpickCommission.iOrderId = 0;
                _tbpickCommission.nprice = -decimal.Parse(nprice.Text);
                _tbpickCommission.aprice = decimal.Parse(allnprice.InnerHtml) - decimal.Parse(nprice.Text);
                _tbpickCommission.iState = 1;
                _tbpickCommission.remark = "客户提现";
                if (new b_tbCommission().Insert(_tbpickCommission).Value > 0)
                {
                    tipclass = string.Empty;
                    message.Text = "提现正在处理中";
                    loaddata();
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "提现失败，请检查后再次提交";
                }
            }
        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            //{
            //    var _info = e.Item.DataItem as tbpickCommission;
            //    if (_info.SState == 1)
            //    {
            //        (e.Item.FindControl("btn_finally") as Button).Visible = (e.Item.FindControl("btn_del") as Button).Visible = true;
            //    }
            //    else if (_info.SState == 2)
            //        (e.Item.FindControl("btn_finally") as Button).Visible = true;
            //}
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _info = new tbpickCommission();
            string _op = e.CommandName;
            _info.pickCommissionId = Int32.Parse(e.CommandArgument.ToString());
            _info.SState = 3;
            if (_op.Equals("del"))
                _info.SState = 4;
            if (new b_tbpickCommission().UpdateStatus(_info))
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