using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbCommission:B_Base<tbCommission>
    {
        public b_tbCommission()
        {

        }
        public bool UpdateStatus(tbCommission tbinfo)
        {
            string _sql = "UPDATE tbCommission SET	iState = @iState WHERE iCommissionId=@iCommissionId";
            DynamicParameter.Add("iState",tbinfo.iState);
            DynamicParameter.Add("iCommissionId", tbinfo.iCommissionId);
            return Execute(_sql, DynamicParameter, commandtype: CommandType.Text) > 0;
        }

        #region 批量更新提现状态
        /// <summary>
        /// 批量更新提现状态
        /// </summary>
        /// <param name="iCommissionIds"></param>
        /// <returns></returns>
        public bool UpdatebatchStatus(long[] iCommissionIds, int iState=2)
        {
            string _sql = "UPDATE tbCommission SET	iState = @iState WHERE iCommissionId in @iCommissionId";
            DynamicParameter.Add("iState", iState);
            DynamicParameter.Add("iCommissionId", iCommissionIds);
            return Execute(_sql, DynamicParameter, commandtype: CommandType.Text) > 0;
        }
        #endregion

    }
}
