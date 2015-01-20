using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SiteInfo
    {   
        /// <summary>
        /// 站点名称
        /// </summary>
        public string title { get; set;}

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string keywords { get; set; }

        /// <summary>
        /// 网站地址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>
        public string Address { get; set;}

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set;}

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set;}

        /// <summary>
        /// 版权
        /// </summary>
        public string Copyright { get; set;}

        /// <summary>
        /// 水印
        /// </summary>
        public string Watermark { get; set;}
    }
}
