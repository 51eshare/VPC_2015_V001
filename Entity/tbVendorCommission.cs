using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 供应商资金清单
    /// </summary>
    public class tbVendorCommission
    {
        public tbVendorCommission()
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
