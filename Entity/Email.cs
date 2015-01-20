using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Email
    {
        public Email()
        {

        }
        public string HostIP { get; set;}
        public int port { get; set;}
        public bool ssl { get; set;}
        public string username { get; set;}
        public string password { get; set;}
        public string mailFrom { get; set;}
    }
    public class EmailContext
    {
        public EmailContext()
        {
            mailAddress = new List<string>();
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Subjct { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 收件人列表
        /// </summary>
        public List<string> mailAddress { get; set;}

        /// <summary>
        /// 附件
        /// </summary>
        public string file { get; set;}
    }
}
