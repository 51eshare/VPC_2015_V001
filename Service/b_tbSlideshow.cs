using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbSlideshow : B_Base<tbSlideshow>
    {
        public b_tbSlideshow()
        {

        }

        #region 更改幻灯片状态
        /// <summary>
        /// 更改幻灯片状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool UpdateState(tbSlideshow info)
        {
            string _sql = "UPDATE tbSlideshow SET [Enabled] =@Enabled WHERE ID=@ID";
            return Execute(_sql, new { Enabled = info.Enabled, ID=info.ID}) > 0;
        }
        #endregion 
    }
}
