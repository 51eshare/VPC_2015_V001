using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbDelivery
    {
        public tbDelivery()
        {

        }
        [Key]
        /// <summary>
        /// 标识号
        /// </summary>
        public long DeliveryID { get;set;}

        public long iOrderId { get; set;}
        [Editable(false)]
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime Shippingdate { get;set;}

        /// <summary>
        /// 物流公司
        /// </summary>
        public int ExpressID { get; set;}

        /// <summary>
        /// 物流号
        /// </summary>
        public string No { get; set;}
        [Editable(false)]
        /// <summary>
        /// 收货方式
        /// 1:支付宝，2：财付通
        /// </summary>
        public int ReceivingStyle { get; set;}

        [Editable(false)]
        public string sReceivingStyle { get; set; }
        [Editable(false)]
        /// <summary>
        /// 收货日期
        /// </summary>
        public int ReceivingDate { get; set;}
    }
}
