using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbCollect : B_Base<tbCollect>
    {
        public b_tbCollect()
        {

        }

        /// <summary>
        /// 根据iUserId 获取第一个关注的网店
        /// </summary>
        /// <param name="iUserId"></param>
        /// <returns></returns>
        public tbCollect GetInfoById(long iUserId)
        {
            string _sql = "SELECT TOP 1 * FROM tbCollect WHERE iUserId=@iUserId ORDER BY iCollectId asc ";
            DynamicParameter.Add("iUserId",iUserId);
            return Get(_sql,DynamicParameter);
        }
    }
}
