using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Entity;

namespace VPC_2014_V001
{
    public partial class index : U_Base
    {
        public IEnumerable<tbProduct> HotProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHotSell();
                #region 
                if (UserInfo != null)
                {
                    if (UserInfo.UserType.Contains(3000))
                        partner.Visible = false;
                    if (UserInfo.UserType.Contains(5000))
                        vendor.Visible = false;
                }
                #endregion
            }
        }
        /// <summary>
        /// 热卖商品
        /// </summary>
        private void LoadHotSell()
        {
            HotProduct = new b_tbProduct().GetList("SELECT distinct top 4 b.*,a.iShopRefPdId FROM tbShopRefProduct AS a INNER JOIN tbProduct AS b ON a.iPdId=b.iPdId WHERE b.iUserId=8");
        }
    }
}