using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Info : P_Base
    {

        private long RealID
        {
            get {
                var _RealID = RequestQuery("RealID","");
                if (!string.IsNullOrWhiteSpace(_RealID))
                {
                    btn_return.Visible = true;
                    return long.Parse(_RealID);
                }
                else
                {
                    a_modify.Visible = true;
                    return UserInfo.RealID;
                }
            }
        }

        bool bError = false;
        string sError = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                System.Data.DataSet ds = new System.Data.DataSet();
                #region 数据库检索
                using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
                {
                    try { _clsVPCDB.OpenCon(); }
                    catch (Exception ex) { bError = true; sError = ex.ToString(); }

                    try
                    {
                        //存储过程名称
                        _clsVPCDB.CmdProc = "pcVendorInfo";

                        //存储过程参数
                        _clsVPCDB.AddParam("@iVendorId", System.Data.SqlDbType.BigInt, RealID);

                        //执行存储过程,获取返回值
                        _clsVPCDB.ExecuteQuery(ref ds, "UI");


                        ////结束事务处理
                        //_clsVPCDB.CommitTrans();
                    }
                    catch (Exception ex) { bError = true; sError = ex.ToString(); }
                    finally { try { _clsVPCDB.CloseCon(); } catch { } }


                }
                #endregion
                LbsVenName.Text = ds.Tables["UI"].Rows[0]["供应商名称"].ToString();
                LbiDistrict.Text = ds.Tables["UI"].Rows[0]["供应商所属地区"].ToString();
                LbsContactName.Text = ds.Tables["UI"].Rows[0]["联系人姓名"].ToString();
                LbsContactPhoneNumber.Text = ds.Tables["UI"].Rows[0]["联系人电话"].ToString();
                LbsContactMP.Text = ds.Tables["UI"].Rows[0]["联系人手机"].ToString();
                LbsContactMail.Text = ds.Tables["UI"].Rows[0]["联系人邮件"].ToString();
                LbiRegistCapital.Text = ds.Tables["UI"].Rows[0]["注册资金"].ToString();
                LbsRegistAddress.Text = ds.Tables["UI"].Rows[0]["供应商注册地址"].ToString();
                LbsBussinessLicenceCode.Text = ds.Tables["UI"].Rows[0]["营业执照编号"].ToString();
                LbdBussinessLicenceExpDate.Text = ds.Tables["UI"].Rows[0]["营业执照到期日"].ToString();
                LbsOrganizationCode.Text = ds.Tables["UI"].Rows[0]["组织机构代码"].ToString();
                LbsTaxType.Text = ds.Tables["UI"].Rows[0]["开票类型"].ToString();
                LbsBankName.Text = ds.Tables["UI"].Rows[0]["开户银行（包含支行）"].ToString();
                LbsTaxCode.Text = ds.Tables["UI"].Rows[0]["税号"].ToString();
                LbsBankAccountName.Text = ds.Tables["UI"].Rows[0]["帐号名称"].ToString();
                LbsBankAccountCode.Text = ds.Tables["UI"].Rows[0]["银行帐号"].ToString();
                LbsBillAccountPhone.Text = ds.Tables["UI"].Rows[0]["开票电话"].ToString();
                LbsBillAccountName.Text = ds.Tables["UI"].Rows[0]["开票抬头"].ToString();
                LbsBillAccountAddress.Text = ds.Tables["UI"].Rows[0]["开票地址"].ToString();
                LbsBillRecieveAddress.Text = ds.Tables["UI"].Rows[0]["发票收件地址"].ToString();
                LbsBillRecieveContactName.Text = ds.Tables["UI"].Rows[0]["发票收件人"].ToString();
                LbsBillRecievePhone.Text = ds.Tables["UI"].Rows[0]["发票收件人联系电话"].ToString();
                LbsBillRecieveZip.Text = ds.Tables["UI"].Rows[0]["发票收件邮编"].ToString();
                if (ds.Tables["UI"].Rows[0]["sPhotos"] != null)
                    sPhotos.Text = ds.Tables["UI"].Rows[0]["sPhotos"].ToString();
            }
        }

        protected void btn_return_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}