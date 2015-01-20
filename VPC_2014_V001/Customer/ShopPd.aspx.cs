using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entity;
using Service;
using Common;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class ShopPd : P_Base
    {
        Int64 iPdid {
            get { return GetParaInt("iPdid"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var _info = new b_vwProduct4Partner().Get(iPdid);
                if (_info != null && _info.iStatus == 2)
                {
                    CommonMethod.Entity_to_Controls(_info, ShopPdInfo);
                    if (UserInfo != null)
                    {
                        iquestionuserid.Value = UserInfo.RealID.ToString();
                        if (GetParaInt("shopid") > 0)
                        {
                            var _tbcollect = new tbCollect() { iShopId = GetParaInt("shopid"), iUserId = UserInfo.RealID };
                            new b_tbCollect().Insert(_tbcollect);
                        }
                    }
                }
                else
                {
                    ShopPdInfo.Visible = false;
                    TipMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }

        private bool gwc_ServerClick()
        {
            IsLogin();
                var _tbShoppingCart = new tbShoppingCart();
                _tbShoppingCart.iUserid = UserInfo.RealID;
                _tbShoppingCart.iShopRefPdId = iPdid;
                _tbShoppingCart.iOrderNum = Int32.Parse(txtiOrderNum.Text);
                return new b_tbShoppingCart().add_updatetbShoppingCart(_tbShoppingCart);
        }

        protected void gwc_ServerClick(object sender, EventArgs e)
        {
            if (gwc_ServerClick())
            {
                tipclass = string.Empty;
                message.Text = "成功加入购物车！";
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "加入购物车失败！";            
            }
        }

        protected void ljgm_ServerClick(object sender, EventArgs e)
        {
            if (gwc_ServerClick())
            {
                Response.Redirect("ShoppingCart");
            }
            else
            {
                tipclass = string.Empty;
                message.Text = "加入购物车失败！";
            }
        }
    }
}