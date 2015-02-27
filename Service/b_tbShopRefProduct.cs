using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbShopRefProduct : B_Base<tbShopRefProduct>
    {
        public bool p_a_u_tbShopRefProduct(tbShopRefProduct para)
        {
            DynamicParameter.Add("iuid",para.iUserid);
            DynamicParameter.Add("iPdId", para.iPdId);
            return Execute("p_a_u_tbShopRefProduct", DynamicParameter, System.Data.CommandType.StoredProcedure) > 0;
        }

        #region 根据Uid获取已经上架的商品
        /// <summary>
        /// 根据Uid获取已经上架的商品
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public IEnumerable<tbShopRefProduct> GettbShopRefProductByUid(long uid)
        {
            string _url = "SELECT a.* FROM tbShopRefProduct AS a INNER JOIN tbShop AS b on a.iShopId=b.iShopId WHERE b.iUserId=@iUserId";
            DynamicParameter.Add("iUserId",uid);
            return GetList(_url, DynamicParameter);
        }
        #endregion 
    }
}
