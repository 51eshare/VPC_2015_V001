using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class b_tbExpress:B_Base<tbExpress>
    {
       public b_tbExpress()
       {

       }

       /// <summary>
       /// 更新状态
       /// </summary>
       /// <param name="id"></param>
       /// <param name="enabled"></param>
       /// <returns></returns>
       public bool updateStatus(int id, bool enabled)
       {
           string _sql = "UPDATE tbExpress SET [enabled] = @enabled WHERE ID=@ID";
           return Execute(_sql, new { enabled = enabled, ID = id }) > 0;
       }
    }
}
