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
    public partial class tbExpresses : P_Base
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
            var _info = new tbExpress();
            _info.ID= Int32.Parse(e.CommandArgument.ToString());
            _info.enabled = bool.Parse((e.Item.FindControl("input_iStatus") as HtmlInputHidden).Value);
            if (new b_tbExpress().updateStatus(_info.ID, _info.enabled))
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
            string _where = string.Empty, _sort = "a.ID asc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" a.sName like '%{0}%'", where.Value);
            var _paging = new p_PageList<tbExpress>();
            _paging.Fields = "a.*";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbExpress AS a";
            var _list = new b_tbExpress().PageList<tbExpress>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbExpress;
                if (_info.enabled)
                    (e.Item.FindControl("btn_del") as Button).Text = "禁用";
                else
                    (e.Item.FindControl("btn_del") as Button).Text = "启用";
            }
            
           
        }
    }

}