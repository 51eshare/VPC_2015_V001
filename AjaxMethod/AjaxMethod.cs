using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxFramework;
using System.Web;
using Entity;
using Service;

namespace AjaxMethod
{
    public class Ajax
    {
        public Ajax()
        {

        }

        [WebMethodAttr(RequestType.Get)]
        public List<tbDistrict> Districts(Int32 idistrict=0)
        { 
            return b_Cache.GettbDistricts().Where(p=>p.iDistrictFatherId==idistrict).ToList();
        }

        [WebMethodAttr(RequestType.Get)]
        public List<tbProductClass> ProductClasses(Int32 ipdfatherid = 0)
        {
            return b_Cache.GetProductClasses().Where(p => p.iPdFatherId == ipdfatherid).ToList();
        }

        [WebMethodAttr(RequestType.Get)]
        public int AddQuestion(tbQuestion _question)
        {
            var _result = new b_tbQuestion().Insert(_question);
            return _result.Value;
        }

        /// <summary>
        /// 商品审核
        /// </summary>
        /// <param name="iPdId"></param>
        /// <param name="iclass"></param>
        /// <param name="squestiontext"></param>
        /// <returns></returns>
        [WebMethodAttr(RequestType.All)]
        public bool CheckProduct(int iPdId, int iclass, string squestiontext="")
        {
            return new b_tbProduct().updateStatus(iPdId, iclass, squestiontext);
        }

        [WebMethodAttr(RequestType.All)]
        public bool CheckStop(long _iuserid, string squestiontext,string servicedate="",long serviceprice =0,int iclass=1)
        {
            if (HttpContext.Current.Session["UserInfo"] == null)
            {
                return false;
            }
            else
            {
                var _tbquestion = new tbQuestion();
                if (iclass == 1)
                {
                    squestiontext = "供应商审核通过！";
                }
                _tbquestion.iQuestionUserId = 10037;
                _tbquestion.iUserId = _iuserid;
                _tbquestion.bTopic="供应商审核结果通知";
                _tbquestion.sQuestionText = squestiontext;
                _tbquestion.iQuestionType = 3;
                if(!string.IsNullOrWhiteSpace(servicedate))
                _tbquestion.ServiceDate = DateTime.Parse(servicedate);
                if(serviceprice>0)
                _tbquestion.ServicePrice = serviceprice;
                _tbquestion.Class = iclass;
                _tbquestion.sQuestionText = squestiontext;
                var _result = new b_tbQuestion().addtbquestion(_tbquestion);
                return _result;
            }
        }

        #region 发货确认
        /// <summary>
        /// 发货确认
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [WebMethodAttr(RequestType.All)]
        public bool CheckExpress(tbDelivery info)
        {
            if (HttpContext.Current.Session["UserInfo"] == null)
            {
                return false;
            }
            else
            {
                var _result = new b_tbDelivery().Insert(info).Value > 0;
                return _result;
            }
        }
        #endregion 

        [WebMethodAttr(RequestType.All)]
        public bool changeilipay(long iUserId,string ilipay)
        {
            if (HttpContext.Current.Session["UserInfo"] == null)
            {
                return false;
            }
            else
            {
                var _tbuser = new tbUser();
                _tbuser.iUserId = iUserId;
                _tbuser.ilipay = ilipay;
               return new b_tbUser().Updateilipay(_tbuser);
            }
        }
    }
}
