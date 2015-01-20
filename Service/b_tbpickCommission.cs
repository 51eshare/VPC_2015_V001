using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbpickCommission : B_Base<tbpickCommission>
    {
        public b_tbpickCommission()
        {

        }

        public bool UpdateStatus(tbpickCommission _info)
        {
            string sql = "UPDATE tbpickCommission SET SState =@SState WHERE pickCommissionId=@pickCommissionId";
            DynamicParameter.Add("SState",_info.SState);
            DynamicParameter.Add("pickCommissionId", _info.pickCommissionId);
            return Execute(sql, DynamicParameter, commandtype: System.Data.CommandType.Text) > 0;
        }
    }
}
