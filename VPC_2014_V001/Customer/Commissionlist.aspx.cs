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
    public partial class Commissionlist : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                allnprice.InnerHtml = new b_tbCommission().GetList().Where(p => p.iUserId == UserInfo.RealID).Sum(p=>p.nprice).ToString();
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
            _paging.Fields = "a.*";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbCommission a";
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
                var _tbpickCommission = new tbpickCommission();
                _tbpickCommission.Uid = UserInfo.RealID;
                _tbpickCommission.Nprice = decimal.Parse(nprice.Text);
                if (new b_tbpickCommission().Insert(_tbpickCommission).Value > 0)
                {
                    tipclass = string.Empty;
                    message.Text = "提现正在处理中";
                }
                else
                {
                    tipclass = string.Empty;
                    message.Text = "提现失败，请检查后再次提交";
                }
            }
        }

    }
}