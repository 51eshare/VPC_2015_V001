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
    public partial class tbInfos : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                binddata();
                loaddata();
            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var _info = new tbInfo();
            _info.ID= Int32.Parse(e.CommandArgument.ToString());
            _info.Enabled = true;
            if (bool.Parse((e.Item.FindControl("input_iStatus") as HtmlInputHidden).Value))
                _info.Enabled = false;

            if (new b_tbInfo().UpdateState(_info))
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
        public void binddata()
        {
            BindClass(InfoType, b_Cache.GetStatus().Where(p => p.StateType == 6), "请选择信息类型");
        }
        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Empty, _sort = "a.ID desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" a.TTitle like '%{0}%'", where.Value);
            if(!string.IsNullOrWhiteSpace(InfoType.SelectedValue))
                _where += string.IsNullOrWhiteSpace(_where) ? " a.InfoType=" + InfoType.SelectedValue : string.Format(" and a.InfoType ={0}", InfoType.SelectedValue);
            var _paging = new p_PageList<tbInfo>();
            _paging.Fields = "a.*,b.sStatus AS 'sInfoType'";
            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @"tbInfo AS a INNER JOIN tbStatus AS b ON a.InfoType=b.StateValue AND b.StateType=6";
            var _list = new b_tbInfo().PageList<tbInfo>(_paging);
            aspnetpagerpaging.RecordCount = _list.TotalCount;
            Repeater1.DataSource = _list.DataList;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType== ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
            {
                var _info = e.Item.DataItem as tbInfo;
                if (_info.Enabled)
                    (e.Item.FindControl("btn_del") as Button).Text = "禁用";
                else
                    (e.Item.FindControl("btn_del") as Button).Text = "启用";
            }
            
           
        }
    }

}