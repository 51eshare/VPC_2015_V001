using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 快递公司列表
    /// </summary>
    public class tbExpress
    {
        public tbExpress()
        {

        }
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set;}

        /// <summary>
        /// 快递公司名称
        /// </summary>
        public string sName { get; set;}

        /// <summary>
        /// 联系电话
        /// </summary>
        public string sPhone { get; set;}

        /// <summary>
        /// 联系电话
        /// </summary>
        public string sURL { get; set;}

        /// <summary>
        /// 联系人
        /// </summary>
        public string sUser { get; set;}
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool enabled { get; set; }

        private  string _senabled = string.Empty;
        [Editable(false)]
        public string senabled
        {
            get
            {
                return enabled ? "启用" : "禁用";
            }
            set {
                _senabled = value;
            }
        }
    }
}
