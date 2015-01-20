using Common;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Vendor
{


    public partial class Order : P_Base
    {

        /// <summary>
        /// 订单编号
        /// </summary>
        private long iOrderId
        {
            get
            {
                return GetParaInt("iOrderId");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }
        private void LoadData()
        {
            var _detail = new b_tbOrder().GetOrderDetail(iOrderId);
            CommonMethod.Entity_to_Controls(_detail, OrderDetail);
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer", "Orders"));
        }
    }
}
