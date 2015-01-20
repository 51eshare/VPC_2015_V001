using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbOrder:B_Base<tbOrder>
    {
        public b_tbOrder()
        {
        }
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="iorderid"></param>
        /// <returns></returns>
        public tbOrderDetail GetOrderDetail(long iorderid)
        {
            DynamicParameter.Add("iOrderId",iorderid);
            string _sql = @"SELECT a.dDate,a.sOrderNum,c.sPdName,c.sPdStd,a.iOrderNum,a.fSaPrice,a.fSaPriceSum,e.sRecieveName,e.sAddress,e.sPhoneNum,a.bBill,d.sStatus,a.iStatus,i.sName as sExpressID,h.sStatus as sStyle,
                            a.dPay,f.Shippingdate,f.No,f.ReceivingStyle,f.ReceivingDate
                            FROM tbOrder AS a INNER JOIN tbShopRefProduct AS b ON a.iShopRefPdId=b.iShopRefPdId
                            INNER JOIN tbProduct AS c ON b.iPdId=c.iPdId
                            INNER JOIN tbStatus AS d ON a.iStatus=d.StateValue AND d.StateType=2
                            INNER JOIN tbRecieveInfo AS e ON a.iDistrictId=e.iRecieveInfoId
                            left outer join tbDelivery as f on a.iOrderId=f.iOrderId
                            left outer join tbStatus as h on a.iStyle=h.StateValue and h.StateType=7
                            left outer join tbExpress as i on f.ExpressID=i.ID
                            WHERE a.iOrderId=@iOrderId";
            return GetList<tbOrderDetail>(_sql, DynamicParameter).FirstOrDefault();
        }

        #region 更新订单状态
        /// <summary>
        /// 更新订单状态
        /// </summary>
        /// <param name="iorderid"></param>
        /// <param name="istatus"></param>
        /// <returns></returns>
        public bool UpdateStatus(long iorderid, int istatus)
        {
            string _sql = "UPDATE tbOrder SET iStatus = @istatus WHERE iOrderId=@iorderid";
            return Execute(_sql, new { istatus = istatus, iorderid = iorderid})>0;
        }
        public bool UpdateException(long iorderid, int iexception)
        {
            string _sql = "UPDATE tbOrder SET iException = @iexception WHERE iOrderId=@iorderid";
            return Execute(_sql, new { iexception = iexception, iorderid = iorderid }) > 0;
        }
        #endregion 

        public bool Add_Up_tbOrder(tbOrder tborder)
        {
            DynamicParameter.Add("iUserid", tborder.iUserid);
            DynamicParameter.Add("iShopRefPdId", tborder.iShopRefPdId);
            DynamicParameter.Add("iDistrictId", tborder.iDistrictId);
            DynamicParameter.Add("iOrderNum", tborder.iOrderNum);
            DynamicParameter.Add("bBill", tborder.bBill);
            DynamicParameter.Add("sOrderNum", tborder.sOrderNum);
            DynamicParameter.Add("iScId", tborder.iScId);
            DynamicParameter.Add("Result",1,dbType:DbType.Int32,direction:ParameterDirection.Output);
            Execute("Add_Up_tbOrder", DynamicParameter,CommandType.StoredProcedure);
            int _Result = DynamicParameter.Get<int>("Result");
            return _Result == 1;
        }
    }
}
