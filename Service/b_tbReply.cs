using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbReply : B_Base<tbReply>
    {
        #region 添加回复
        /// <summary>
        /// 添加回复
        /// </summary>
        /// <param name="_tbreply"></param>
        /// <returns></returns>
        public bool AddtbReply(tbReply _tbreply)
        {
            string _sql = @"INSERT INTO tbReply(iQuestionId,iReplyUserId,iUserId,sReplyText)
            SELECT @iQuestionId,@iReplyUserId,iQuestionUserId,@sReplyText FROM tbQuestion WHERE iQuestionId=@iQuestionId";
            DynamicParameter.Add("iQuestionId",_tbreply.iQuestionId);
            DynamicParameter.Add("iReplyUserId", _tbreply.iReplyUserId);
            DynamicParameter.Add("sReplyText", _tbreply.sReplyText);
            return Execute(_sql,DynamicParameter)>0;
        }
        #endregion
    }
}
