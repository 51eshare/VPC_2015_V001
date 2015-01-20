using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_vwProduct4Partner : B_Base<vwProduct4Partner>
    {
        public b_vwProduct4Partner()
        {

        }

        public vwProduct4Partner GetById(long P)
        {
            DynamicParameter.Add("P",P);
            return Get("select * from vwProduct4Vendor where P=@P", DynamicParameter);
        }
    }
}
