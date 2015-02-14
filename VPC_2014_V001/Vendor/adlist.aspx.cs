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
using System.Web.UI.HtmlControls;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class adlist : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { loaddata(); BindiStatus(); }
                
        }
        private void BindiStatus()
        {
            var _list = b_Cache.GetStatus().Where(p => p.StateType == StateType.ad);
            BindClass(iStatus,_list,"--请选择广告状态--");
        }
        protected void paging_PageChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            string _where = string.Empty, _sort = "a.iAdPdId desc";
            if (!string.IsNullOrWhiteSpace(where.Value))
                _where += string.Format(" c.sPdName like '%{0}%'", where.Value);
            if(!string.IsNullOrEmpty(iStatus.Value))
                _where += string.IsNullOrEmpty(_where) ? "a.iStatus=" + iStatus.Value : " and a.iStatus.Value=" + iStatus.Value;
            var _paging = new p_PageList<tbAdPd>();
            _paging.Fields = "a.iAdPdId,a.iStatus,b.sStatus AS 'siStatus',c.sPdName,a.dBeginDate,a.dEndDate";

            _paging.OrderFields = _sort;
            _paging.PageIndex = aspnetpagerpaging.CurrentPageIndex;
            _paging.PageSize = aspnetpagerpaging.PageSize;
            _paging.Where = _where;
            _paging.Tables = @" tbAdPd AS a INNER JOIN tbStatus AS b ON a.iStatus=b.StateValue AND b.StateType=9 INNER JOIN tbProduct AS c ON  a.iPdId=c.iPdId ";
            var _list = new b_tbAdPd().PageList<tbAdPd>(_paging);
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
               var _iPdId = e.CommandArgument;
               if (new b_tbAdPd().updateiStatus(Int32.Parse(_iPdId.ToString())))
               {
                   tipclass = string.Empty;
                   message.Text = "操作成功！";
                   loaddata();
               }
               else
               {
                   tipclass = string.Empty;
                   message.Text = "操作失败！";
               }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var _item = e.Item.DataItem as tbAdPd;
                if (_item.iStatus == 1)
                {
                    (e.Item.FindControl("Button2") as Button).Visible = true;
                }
            }
        }
    }
}
