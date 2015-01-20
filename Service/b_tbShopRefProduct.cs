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
    }
}
