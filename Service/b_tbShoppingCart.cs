using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbShoppingCart :B_Base<tbShoppingCart>
    {
        /// <summary>
        /// 添加或者更新购物车
        /// </summary>
        /// <param name="tbshoppingcart"></param>
        /// <returns></returns>
        public bool add_updatetbShoppingCart(tbShoppingCart tbshoppingcart)
        {
            DynamicParameter.Add("iUserid", tbshoppingcart.iUserid);
            DynamicParameter.Add("iShopRefPdId", tbshoppingcart.iShopRefPdId);
            DynamicParameter.Add("iOrderNum", tbshoppingcart.iOrderNum);
            return new b_tbShoppingCart().Execute("add_updatetbShoppingCart", DynamicParameter, System.Data.CommandType.StoredProcedure) > 0;
        }
    }
}
