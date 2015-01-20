using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data;
using System.Threading.Tasks;

namespace Service
{
    public class b_tbVendor:B_Base<b_tbVendor>
    {
        public b_tbVendor()
        {

        }

        /// <summary>
        /// 添加及修改微商城
        /// </summary>
        /// <param name="tbvendor"></param>
        /// <returns></returns>
        public int Add_Up_tbVendor(tbVendor tbvendor)
        {
            DynamicParameter.Add("iVendorId", tbvendor.iVendorId);
            DynamicParameter.Add("iDistrict", tbvendor.iDistrict);
            DynamicParameter.Add("iLevel", tbvendor.iLevel);
            DynamicParameter.Add("iStatus", tbvendor.iStatus);
            DynamicParameter.Add("sVenName", tbvendor.sVenName);
            DynamicParameter.Add("iRegistCapital", tbvendor.iRegistCapital);
            DynamicParameter.Add("sRegistAddress", tbvendor.sRegistAddress);
            DynamicParameter.Add("sBussinessLicenceCode", tbvendor.sBussinessLicenceCode);
            DynamicParameter.Add("dBussinessLicenceExpDate", tbvendor.dBussinessLicenceExpDate);
            DynamicParameter.Add("sOrganizationCode", tbvendor.sOrganizationCode);
            DynamicParameter.Add("sContactName", tbvendor.sContactName);
            DynamicParameter.Add("sContactPhoneNumber", tbvendor.sContactPhoneNumber);
            DynamicParameter.Add("sContactMP", tbvendor.sContactMP);
            DynamicParameter.Add("sContactMail", tbvendor.sContactMail);
            DynamicParameter.Add("sTaxCode", tbvendor.sTaxCode);
            DynamicParameter.Add("sBankName", tbvendor.sBankName);
            DynamicParameter.Add("sBankAccountCode", tbvendor.sBankAccountCode);
            DynamicParameter.Add("sBankAccountName", tbvendor.sBankAccountName);
            DynamicParameter.Add("sTaxType", tbvendor.sTaxType);
            DynamicParameter.Add("sBillAccountName", tbvendor.sBillAccountName);
            DynamicParameter.Add("sBillAccountPhone", tbvendor.sBillAccountPhone);
            DynamicParameter.Add("sBillAccountAddress", tbvendor.sBillAccountAddress);
            DynamicParameter.Add("@sBillRecieveAddress", tbvendor.sBillRecieveAddress);
            DynamicParameter.Add("sBillRecieveZip", tbvendor.sBillRecieveZip);
            DynamicParameter.Add("sBillRecieveContactName", tbvendor.sBillRecieveContactName);
            DynamicParameter.Add("sBillRecievePhone", tbvendor.sBillRecievePhone);
            DynamicParameter.Add("iUserID", tbvendor.iUserId);
            DynamicParameter.Add("DServiceEndDate", tbvendor.DServiceEndDate);
            DynamicParameter.Add("iCashDeposit", tbvendor.iCashDeposit);
            DynamicParameter.Add("iServiceFee", tbvendor.iServiceFee);
            DynamicParameter.Add("sCustomerServicePhone", tbvendor.sCustomerServicePhone);
            DynamicParameter.Add("sPhotos", tbvendor.sPhotos);
            DynamicParameter.Add("result", 1, DbType.Int32, ParameterDirection.Output);
            Execute("pctbVendorAdd", DynamicParameter, CommandType.StoredProcedure);
            return DynamicParameter.Get<Int32>("result");
        }
    }
}
