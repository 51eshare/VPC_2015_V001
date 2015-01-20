using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbCommonParameter
    {
        public tbCommonParameter()
        {
            Orders = string.Empty;
        }
        [Key]
        public int ID { get; set;}

        /// <summary>
        /// 自动确认收货的时间设定
        /// </summary>
        public int AutoConfirm { get; set;}

        /// <summary>
        /// 供应商服务到期前提示的时间设定
        /// </summary>
        public int AutoPrompt { get; set;}

        /// <summary>
        /// 比率
        /// 1元销售额对应多少积分
        /// </summary>
        public int Rate { get; set;}

        /// <summary>
        /// 分享奖励积分
        /// </summary>
        public int SharePoint { get; set;}

        /// <summary>
        /// 商品综合排序的公式定义
        /// </summary>
        public string Orders { get; set;}
    }

    #region 小伙伴配置
    /// <summary>
    /// 小伙伴配置
    /// </summary>
    public class tbPartnerLevel
    {
        public tbPartnerLevel()
        {

        }
        [Key]
        public int ID { get; set;}

        /// <summary>
        /// 销售额
        /// </summary>
        public decimal price { get; set;}

        /// <summary>
        /// 级别
        /// </summary>
        public string llevel { get; set; }

        /// <summary>
        /// 橱窗数
        /// </summary>
        public int windows { get; set;}

        /// <summary>
        /// 对应是否可以修改商品前台售价
        /// </summary>
        public bool ismodify { get; set;}

        public int Rate { get; set;}
    }
    #endregion
}
