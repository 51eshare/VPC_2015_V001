using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbInfo : B_Base<tbInfo>
    {

        public bool UpdateState(tbInfo _info)
        {
            string _sql = "UPDATE tbInfo SET [Enabled] =@Enabled WHERE ID=@ID";
            return Execute(_sql, new { Enabled = _info.Enabled, ID = _info.ID }) > 0;
        }
        public tbInfo GetInfo(int infotype)
        {
            string _sql = "SELECT * FROM tbInfo WHERE InfoType=@InfoType";
            DynamicParameter.Add("InfoType",infotype);
            return Get(_sql, DynamicParameter);
        }
    }
}
