using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbCommission
    {
        public tbCommission()
        {

        }
        [Key]
        /// <summary>
        /// 佣金流水号
        /// </summary>
        public long iCommissionId { get; set;}
        
        /// <summary>
        /// 订单ID
        /// </summary>
        public long iOrderId { get; set;}
        
        /// <summary>
        /// 佣金
        /// </summary>
        public decimal nprice { get; set;}

        [Editable(false)]
        public string snprice
        { 
            get{
                if (nprice > 0)
                    return string.Format("<label class=\" text-bold text-success\">+{0}</label>", nprice);
                else
                    return string.Format("<label class=\" text-bold text-danger\">{0}</label>", nprice);
            }
        }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal aprice { get; set;}

        [Editable(false)]
        public string saprice
        {
            get {
                if (aprice > 0)
                    return string.Format("<label class=\" text-bold text-success\">{0}</label>", aprice);
                else
                    return string.Format("<label class=\" text-bold text-danger\">{0}</label>", aprice);
            }
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long iUserId { get; set;}

        [Editable(false)]
        public string sLoginId { get; set;}

        public int iState { get;set;}

        [Editable(false)]
        public string sStatus { get; set;}
        [Editable(false)]
        /// <summary>
        /// 佣金分佣时间
        /// </summary>
        public DateTime dDate { get; set;}

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set;}

        [Editable(false)]
        /// <summary>
        /// 支付宝账号
        /// </summary>
        public string ilipay { get; set;}

    }
}
