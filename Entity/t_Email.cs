using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Entity
{
    public class t_Email
    {
        public t_Email()
        {
            To = new List<string>();
            CC = new List<string>();
            Bcc = new List<string>();
        }

        /// <summary>
        /// 接收邮件
        /// </summary>
        public List<string> To { get; set;}

        /// <summary>
        /// 发送消息
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Subject { get; set;}

        /// <summary>
        /// 抄送
        /// </summary>
        public  List<string> CC { get; set;}

        /// <summary>
        /// 密送
        /// </summary>
        public List<string> Bcc { get; set;}
    }
    public class SMTP
    {
        public string HostIP { get; set;}
        public string username { get; set; }
        public string password { get; set; }
        public int smtpport { get; set; }
    }
}
