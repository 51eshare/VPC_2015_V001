using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Entity
{
    public class tbReply
    {
        [Key]
        public long iReplyId { get; set;}
        /// <summary>
        /// 咨询人
        /// </summary>
        public long iQuestionId { get; set;}

        /// <summary>
        /// 回复人
        /// </summary>
        public long iReplyUserId { get; set;}

        /// <summary>
        /// 咨询人
        /// </summary>
        public long iUserId { get; set;}

        public string sReplyText { get; set;}
        public DateTime dDate { get; set;}
    }
}
