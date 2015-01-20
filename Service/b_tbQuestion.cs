using Entity;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class b_tbQuestion:B_Base<tbQuestion>
    {
       public tbQuestion GetQuestion(long iQuestionId)
       {
           DynamicParameter.Add("iQuestionId", iQuestionId);
           string _sql = @"SELECT  a.*,b.sLoginId as 'sQuestionUserId',c.sReplyText ReplyText 
            FROM tbQuestion AS a
        INNER JOIN tbUser AS b ON a.iQuestionUserId=b.iUserId
        LEFT OUTER JOIN tbReply AS c ON a.iQuestionId=c.iQuestionId
                    WHERE a.iQuestionId=@iQuestionId";
                    return Get(_sql,DynamicParameter);
       }

       public bool addtbquestion(tbQuestion info)
       {
           DynamicParameter.Add("iUserId",info.iUserId);
           DynamicParameter.Add("iQuestionUserId",info.iQuestionUserId);
           DynamicParameter.Add("sQuestionText",info.sQuestionText);
           DynamicParameter.Add("bTopic",info.bTopic);
           DynamicParameter.Add("ServicePrice", info.ServicePrice);
           DynamicParameter.Add("ServiceDate", info.ServiceDate);
           DynamicParameter.Add("Class", info.Class);
           DynamicParameter.Add("result",1,DbType.Boolean,ParameterDirection.Output);
           Execute("addtbquestion", DynamicParameter, CommandType.StoredProcedure);
           return DynamicParameter.Get<bool>("result");
       }
    }
}
