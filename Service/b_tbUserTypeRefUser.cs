using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class b_tbUserTypeRefUser : B_Base<tbUserTypeRefUser>
    {
        public b_tbUserTypeRefUser()
        {

        }

        #region 获取用户类型
        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="iuserid"></param>
        /// <returns></returns>
        public IEnumerable<int> GetUser(string iuserid)
        { 
            DynamicParameter.Add("iUserId",iuserid);
            return GetList<int>("select iUserTypeId from tbUserTypeRefUser where iUserId=8 and iStatus in (1003,2005,3005) ", DynamicParameter);
        }
        #endregion 
    }
}
