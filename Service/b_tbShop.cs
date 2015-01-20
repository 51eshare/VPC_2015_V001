using Entity;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class b_tbShop : B_Base<tbShop>
    {
        /// <summary>
        /// 添加及修改微店
        /// </summary>
        /// <param name="tbshop"></param>
        /// <returns></returns>
        public int Add_Up_tbShop(tbShop tbshop)
        {
            DynamicParameter.Add("iShopId", tbshop.iShopId);
            DynamicParameter.Add("sShopName", tbshop.sShopName);
            DynamicParameter.Add("sShopDesc", tbshop.sShopDesc);
            DynamicParameter.Add("iUserId", tbshop.iUserId);
            DynamicParameter.Add("iDistrict", tbshop.iDistrict);
            DynamicParameter.Add("cOwnerName", tbshop.cOwnerName);
            DynamicParameter.Add("cOwnerAccout", tbshop.cOwnerAccout);
            DynamicParameter.Add("cOwnerMP", tbshop.cOwnerMP);
            DynamicParameter.Add("cOwnerMail", tbshop.cOwnerMail);
            DynamicParameter.Add("sImagePath", tbshop.sImagePath);
            DynamicParameter.Add("sPartnerName", tbshop.sPartnerName);
            DynamicParameter.Add("iRegistCapital", tbshop.iRegistCapital);
            DynamicParameter.Add("sRegistAddress", tbshop.sRegistAddress);
            DynamicParameter.Add("sBussinessLicenceCode", tbshop.sBussinessLicenceCode);
            DynamicParameter.Add("dBussinessLicenceExpDate", tbshop.dBussinessLicenceExpDate);
            DynamicParameter.Add("sOrganizationCode", tbshop.sOrganizationCode);
            DynamicParameter.Add("sTaxCode", tbshop.sTaxCode);
            DynamicParameter.Add("sBankName", tbshop.sBankName);
            DynamicParameter.Add("sBankAccountCode", tbshop.sBankAccountCode);
            DynamicParameter.Add("sBankAccountName", tbshop.sBankAccountName);
            DynamicParameter.Add("result",1,DbType.Int32,ParameterDirection.Output);
            Execute("pctbShopAdd",DynamicParameter,CommandType.StoredProcedure);
            return DynamicParameter.Get<Int32>("result");
        }

        /// <summary>
        /// 快速添加微店
        /// </summary>
        /// <param name="_uinfo"></param>
        /// <returns>1：成功，2：失败，3：名称已经被注册</returns>
        public int Add_Up_VendorRegist(tbVendorRegist _uinfo)
        {
            DynamicParameter.Add("iUserId",_uinfo.iUserId,DbType.Int64, ParameterDirection.Output);
            DynamicParameter.Add("sLoginId", _uinfo.sLoginId);
            DynamicParameter.Add("sPassword", _uinfo.sPassword);
            DynamicParameter.Add("sUserEmail", _uinfo.sUserEmail);
            DynamicParameter.Add("iParentID", _uinfo.iParentID);
            DynamicParameter.Add("sShopName", _uinfo.sShopName);
            DynamicParameter.Add("iDistrict", _uinfo.iDistrict);
            DynamicParameter.Add("shareuid", _uinfo.shareuid);
            DynamicParameter.Add("result", 1, DbType.Int32, ParameterDirection.Output);
            Execute("pcUserAddPartner", DynamicParameter, CommandType.StoredProcedure);
            _uinfo.iUserId = DynamicParameter.Get<Int64>("iUserId");
            return DynamicParameter.Get<Int32>("result");
        }
    }
}
