using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbPartnerCommission
    {
        public tbPartnerCommission()
        {

        }

        /// <summary>
        /// 标识号
        /// </summary>
        public long iCommissionId { get; set;}

        public long iOrderId { get; set;}
        /// <summary>
        /// 费用
        /// </summary>
        public decimal nprice { get; set;}

        public long iUserId { get; set;}

        /// <summary>
        /// 用户名称
        /// </summary>
        public string sUserId { get; set;}

        public DateTime dDate { get; set; }
    }
}
