using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Service;
using System.Dynamic;
using Entity;
using Dapper;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class ShoppingCart : P_Base
    {
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            var _order = new tbOrder();
            foreach (RepeaterItem item in Repeater1.Items)
            {
                _order.iOrderNum = long.Parse((item.FindControl("iOrderNum") as HiddenField).Value);
                _order.iUserid = long.Parse((item.FindControl("iUserid") as HiddenField).Value);
                _order.iShopRefPdId = long.Parse((item.FindControl("iShopRefPdId") as HiddenField).Value);
                _order.iScId = long.Parse((item.FindControl("iScId") as HiddenField).Value);
            }
            _order.bBill = bBill.Checked;
            _order.iDistrictId = Int32.Parse(iDistrictId.Value);
            if (new b_tbOrder().Add_Up_tbOrder(_order))
                Response.Redirect("Orders");
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