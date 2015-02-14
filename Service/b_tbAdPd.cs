using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbAdPd:B_Base<tbAdPd>
    {
        public b_tbAdPd()
        {

        }

        #region 更新广告状态
        /// <summary>
        /// 更新广告状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool updateiStatus(int p)
        {
            DynamicParameter.Add("iAdPdId",p);
            return Execute("p_d_tbAdPd", DynamicParameter,commandtype:System.Data.CommandType.StoredProcedure) > 0;
        }
        #endregion 
    }
}
