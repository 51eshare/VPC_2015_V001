using Entity;
using Service;
using System.IO;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using Common;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class ShoppingCart : P_Base
    {
        public string show_dialog = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loaddata();
        }
        private void loaddata()
        {
            IEnumerable<vwShoppingCart> _vwShoppingCart = new b_vwShoppingCart().GetList("SELECT * FROM vwShoppingCart where 用户Id=" + UserInfo.RealID);
            IEnumerable<vwReceiveInfo> _vwReceiveInfo = new b_vwReceiveInfo().GetList("SELECT * FROM vwReceiveInfo where 用户Id=" + UserInfo.RealID);
            Repeater1.DataSource = _vwShoppingCart;
            Repeater1.DataBind();
            Repeater2.DataSource = _vwReceiveInfo;
            Repeater2.DataBind();
            price.InnerText = _vwShoppingCart.Sum(p => p.订单数量 * p.售价).ToString();
            if (_vwReceiveInfo.Any() && _vwReceiveInfo.SingleOrDefault(p => p.是否默认)!=null)
            iDistrictId.Value = _vwReceiveInfo.SingleOrDefault(p => p.是否默认).收货信息Id.ToString();
        }
        private DataTable GetDataTable()
        {
            var _data = new DataTable("t_ordertype");
            _data.Columns.Add("ID", typeof(int));
            _data.Columns.Add("iShopRefPdId", typeof(long));
            _data.Columns.Add("iOrderNum", typeof(long));
            _data.Columns.Add("iScId", typeof(long));
            _data.Columns[0].AutoIncrement = true;
            _data.Columns[0].AutoIncrementSeed = 1;
            return _data;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            var _order = new tbOrder();
            var _id = string.Empty;
            var _table = GetDataTable();
            DataRow _datarow;
            foreach (RepeaterItem item in Repeater1.Items)
            {
                if ((item.FindControl("select_iscid") as HtmlInputCheckBox).Checked)
                {
                    _datarow = _table.NewRow();
                    _id = (item.FindControl("iScId") as HiddenField).Value;
                    _datarow["iOrderNum"] = long.Parse(Request.Form["number_" + _id]);
                    _order.iUserid = long.Parse((item.FindControl("iUserid") as HiddenField).Value);
                    _datarow["iShopRefPdId"] = long.Parse((item.FindControl("iShopRefPdId") as HiddenField).Value);
                    _datarow["iScId"] = long.Parse((item.FindControl("iScId") as HiddenField).Value);
                    _table.Rows.Add(_datarow);
                }
            }
            _order.Data = _table;
            _order.bBill = bBill.Checked;
            _order.BillType = Int32.Parse(Request.Form["BillType"]);
            _order.Comhead = comhead.Value;
            _order.Remark = Remark.Value;
            _order.iDistrictId = Int32.Parse(iDistrictId.Value);
            if (true)//new b_tbOrder().Add_Up_tbOrder(_order)
            {
                attrsordernum.Value = "EC0001";
                show_dialog = "show_dialog();";
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "提交失败";
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            tipclass = string.Empty;
            string _iscid = e.CommandArgument.ToString();
            if (new b_tbShoppingCart().Delete(long.Parse(_iscid)))
            {
                message.Text = "删除成功";
                loaddata();
            }
            else
            {
                message.Text = "删除失败";
            }
        }
    }
}