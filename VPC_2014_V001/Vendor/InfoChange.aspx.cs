using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class InfoChange : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                IsLogin();
                if (!IsPostBack)
                {
                    DataSet ds = new DataSet();
                    using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
                    {
                        try { _clsVPCDB.OpenCon(); }
                        catch (Exception ex) { throw ex; }

                        try
                        {
                            _clsVPCDB.CmdProc = "pcVendorInfo";
                            _clsVPCDB.AddParam("@iVendorId", System.Data.SqlDbType.BigInt, UserInfo.RealID);
                            _clsVPCDB.ExecuteQuery(ref ds, "UI");

                        }
                        catch (Exception ex) { throw ex; }
                        finally { try { _clsVPCDB.CloseCon(); } catch { } }
                    }
                    var _list = b_Cache.GettbDistricts();
                    DropDownList4.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
                    DropDownList4.DataTextField = "sDistrict";
                    DropDownList4.DataValueField = "iDistrict";
                    DropDownList4.SelectedValue = ds.Tables["UI"].Rows[0]["iDistrictContory"].ToString();
                    DropDownList4.DataBind();

                    if (!string.IsNullOrWhiteSpace(ds.Tables["UI"].Rows[0]["iDistrictProvince"].ToString()))
                    {
                        int _province = _list.SingleOrDefault(c => c.iDistrict == Int32.Parse(ds.Tables["UI"].Rows[0]["iDistrictProvince"].ToString())).iDistrictFatherId;
                        DropDownList5.DataSource = _list.Where(p => p.iDistrictFatherId == _province && !string.IsNullOrWhiteSpace(p.sProvince));
                        DropDownList5.DataTextField = "sProvince";
                        DropDownList5.DataValueField = "iDistrict";
                        DropDownList5.SelectedValue = ds.Tables["UI"].Rows[0]["iDistrictProvince"].ToString();
                        DropDownList5.DataBind();
                    }
                    else
                    {
                        DropDownList5.Enabled = false;
                        DropDownList6.Enabled = false;
                    }

                    ShowCityList(ds.Tables["UI"].Rows[0]["iDistrictCity"].ToString());

                    ListItem _ListItem2;

                    _ListItem2 = new ListItem();
                    _ListItem2.Text = "增值税专用发票";
                    _ListItem2.Value = "Z";
                    _ListItem2.Selected = (ds.Tables["UI"].Rows[0]["开票类型"].ToString() == "增值税专用发票") ? true : false;
                    ddlsTaxType.Items.Add(_ListItem2);

                    _ListItem2 = new ListItem();
                    _ListItem2.Text = "增值税普通发票";
                    _ListItem2.Value = "P";
                    _ListItem2.Selected = (ds.Tables["UI"].Rows[0]["开票类型"].ToString() == "增值税普通发票") ? true : false;
                    ddlsTaxType.Items.Add(_ListItem2);
                    txtsVenName.Text = ds.Tables["UI"].Rows[0]["供应商名称"].ToString();
                    txtsContactName.Text = ds.Tables["UI"].Rows[0]["联系人姓名"].ToString();
                    txtsContactPhoneNumber.Text = ds.Tables["UI"].Rows[0]["联系人电话"].ToString();
                    txtsContactMP.Text = ds.Tables["UI"].Rows[0]["联系人手机"].ToString();
                    txtsContactMail.Text = ds.Tables["UI"].Rows[0]["联系人邮件"].ToString();
                    txiRegistCapital.Text = ds.Tables["UI"].Rows[0]["注册资金"].ToString();
                    txsRegistAddress.Text = ds.Tables["UI"].Rows[0]["供应商注册地址"].ToString();
                    txsBussinessLicenceCode.Text = ds.Tables["UI"].Rows[0]["营业执照编号"].ToString();
                    txdBussinessLicenceExpDate.Text = ds.Tables["UI"].Rows[0]["营业执照到期日"].ToString();
                    txsOrganizationCode.Text = ds.Tables["UI"].Rows[0]["组织机构代码"].ToString();
                    txsBankName.Text = ds.Tables["UI"].Rows[0]["开户银行（包含支行）"].ToString();
                    txsTaxCode.Text = ds.Tables["UI"].Rows[0]["税号"].ToString();
                    txsBankAccountName.Text = ds.Tables["UI"].Rows[0]["帐号名称"].ToString();
                    txsBankAccountCode.Text = ds.Tables["UI"].Rows[0]["银行帐号"].ToString();
                    txtsBillAccountPhone.Text = ds.Tables["UI"].Rows[0]["开票电话"].ToString();
                    txsBillAccountName.Text = ds.Tables["UI"].Rows[0]["开票抬头"].ToString();
                    txtsBillAccountAddress.Text = ds.Tables["UI"].Rows[0]["开票地址"].ToString();
                    txtsBillRecieveAddress.Text = ds.Tables["UI"].Rows[0]["发票收件地址"].ToString();
                    txtsBillRecieveContactName.Text = ds.Tables["UI"].Rows[0]["发票收件人"].ToString();
                    txtsBillRecievePhone.Text = ds.Tables["UI"].Rows[0]["发票收件人联系电话"].ToString();
                    txtsBillRecieveZip.Text = ds.Tables["UI"].Rows[0]["发票收件邮编"].ToString();
                    sPhotos.Value = ds.Tables["UI"].Rows[0]["sPhotos"].ToString();
                }
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch (Exception ex) { throw ex; }

                try
                {
                    _clsVPCDB.CmdSQL = "SELECT * FROM vwDistrict2 WHERE iDistrictFatherId=" + DropDownList4.SelectedValue;
                    _clsVPCDB.ExecuteQuery(ref ds, "vwDistrict2");
                }
                catch (Exception ex) { throw ex; }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }

            DropDownList5.Items.Clear();

            if (ds.Tables["vwDistrict2"].Rows.Count > 0)
            {
                DropDownList5.DataSource = ds.Tables["vwDistrict2"];
                DropDownList5.DataTextField = "sProvince";
                DropDownList5.DataValueField = "iDistrict";
                if (DropDownList4.SelectedValue == "601")
                {
                    DropDownList5.SelectedValue = "522";
                }
                DropDownList5.DataBind();
                DropDownList5.Enabled = true;
            }
            else
            {
                DropDownList5.Items.Clear();
                DropDownList6.Items.Clear();
                DropDownList5.Enabled = false;
                DropDownList6.Enabled = false;
            }
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCityList("");
        }

        private void ShowCityList(string sSelectedCity)
        {
            if (DropDownList5.Enabled && DropDownList5.SelectedValue != null)
            {
                DataSet ds = new DataSet();
                using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
                {
                    try { _clsVPCDB.OpenCon(); }
                    catch (Exception ex) { throw ex; }

                    try
                    {
                        _clsVPCDB.CmdSQL = "SELECT * FROM vwDistrict3 WHERE iDistrictFatherId=" + DropDownList5.SelectedValue;
                        _clsVPCDB.ExecuteQuery(ref ds, "vwDistrict3");
                    }
                    catch (Exception ex) { throw ex; }
                    finally { try { _clsVPCDB.CloseCon(); } catch { } }
                }

                DropDownList6.Items.Clear();

                if (ds.Tables["vwDistrict3"].Rows.Count > 0)
                {
                    DropDownList6.DataSource = ds.Tables["vwDistrict3"];
                    DropDownList6.DataTextField = "sCity";
                    DropDownList6.DataValueField = "iDistrict";
                    DropDownList6.SelectedValue = string.IsNullOrEmpty(sSelectedCity) ? ds.Tables["vwDistrict3"].Rows[0]["iDistrict"].ToString() : sSelectedCity;
                    DropDownList6.DataBind();
                    DropDownList6.Enabled = true;
                }
                else
                {
                    DropDownList6.Enabled = false;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool bError = false;
            string sError = "";


            //数据有效性验证

            //供应商所属地区不为空
            if (string.IsNullOrEmpty(DropDownList4.SelectedValue))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "供应商所属地区必须填写";
            }
            //联系人姓名不为空
            if (string.IsNullOrEmpty(txtsContactName.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人姓名必须填写";
            }
            if (txtsContactName.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人姓名不能超过25个字符";

            }

            //联系人电话不为空
            if (string.IsNullOrEmpty(txtsContactPhoneNumber.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人电话必须填写";
            }
            if (txtsContactPhoneNumber.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人电话不能超过25个字符";

            }

            //联系人手机不为空
            if (string.IsNullOrEmpty(txtsContactMP.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人手机必须填写";
            }
            if (txtsContactMP.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人手机不能超过25个字符";

            }

            //联系人邮箱不为空
            if (string.IsNullOrEmpty(txtsContactMail.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人邮箱必须填写";
            }
            if (txtsContactMail.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系人邮箱不能超过25个字符";

            }

            //开票类型不为空
            if (string.IsNullOrEmpty(ddlsTaxType.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "开票类型必须填写";
            }
            //开票电话不为空
            if (string.IsNullOrEmpty(txtsBillAccountPhone.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "开票电话必须填写";
            }
            if (txtsBillAccountPhone.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "开票电话不能超过25个字符";

            }

            //开票地址不为空
            if (string.IsNullOrEmpty(txtsBillAccountAddress.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "开票地址必须填写";
            }
            if (txtsBillAccountAddress.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "开票地址不能超过50个字符";

            }
            //发票收件地址不为空
            if (string.IsNullOrEmpty(txtsBillRecieveAddress.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "发票收件地址必须填写";
            }
            if (txtsBillRecieveAddress.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "发票收件地址不能超过50个字符";

            }
            //邮编不为空
            if (string.IsNullOrEmpty(txtsBillRecieveZip.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "邮编必须填写";
            }
            //发票收件人不为空
            if (string.IsNullOrEmpty(txtsBillRecieveContactName.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "发票收件人必须填写";
            }
            if (txtsBillRecieveContactName.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "发票收件人不能超过25个字符";

            }
            //联系电话不为空
            if (string.IsNullOrEmpty(txtsBillRecievePhone.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "联系电话必须填写";
            }
            if (txtsBillRecievePhone.Text.Trim().Length > 50)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "发票收件人不能超过25个字符";

            }

            if (bError)
            {
                sError = @"<div class=""alert alert-danger"" role=""alert"">" + sError + @"</div>";
                return;
            }


            //获取地区ID
            int iDistrict = 0;

            if (int.TryParse(DropDownList6.SelectedValue, out iDistrict)) { }
            else if (int.TryParse(DropDownList5.SelectedValue, out iDistrict)) { }
            else if (int.TryParse(DropDownList4.SelectedValue, out iDistrict)) { }

            //Int64 iVendorId;

            #region 数据库检索
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }

                try
                {
                    //存储过程名称
                    _clsVPCDB.CmdProc = "pctbVendorUpdate";

                    //存储过程参数
                    _clsVPCDB.AddParam("@iVendorId", System.Data.SqlDbType.BigInt, 0);
                    _clsVPCDB.AddParam("@iDistrict", System.Data.SqlDbType.Int, iDistrict);
                    _clsVPCDB.AddParam("@sContactName", System.Data.SqlDbType.NVarChar, txtsContactName.Text.Trim());
                    _clsVPCDB.AddParam("@sContactPhoneNumber", System.Data.SqlDbType.NVarChar, txtsContactPhoneNumber.Text.Trim());
                    _clsVPCDB.AddParam("@sContactMP", System.Data.SqlDbType.NVarChar, txtsContactMP.Text.Trim());
                    _clsVPCDB.AddParam("@sContactMail", System.Data.SqlDbType.NVarChar, txtsContactMail.Text.Trim());
                    _clsVPCDB.AddParam("@sTaxType", System.Data.SqlDbType.NVarChar, ddlsTaxType.SelectedItem.Text);
                    _clsVPCDB.AddParam("@sBillAccountPhone", System.Data.SqlDbType.NVarChar, txtsBillAccountPhone.Text.Trim());
                    _clsVPCDB.AddParam("@sBillAccountAddress", System.Data.SqlDbType.NVarChar, txtsBillAccountAddress.Text.Trim());
                    _clsVPCDB.AddParam("@sBillRecieveAddress", System.Data.SqlDbType.NVarChar, txtsBillRecieveAddress.Text.Trim());
                    _clsVPCDB.AddParam("@sBillRecieveZip", System.Data.SqlDbType.NVarChar, txtsBillRecieveZip.Text.Trim());
                    _clsVPCDB.AddParam("@sBillRecieveContactName", System.Data.SqlDbType.NVarChar, txtsBillRecieveContactName.Text.Trim());
                    _clsVPCDB.AddParam("@sBillRecievePhone", System.Data.SqlDbType.NVarChar, txtsBillRecievePhone.Text.Trim());
                    _clsVPCDB.AddParam("@iUserID", System.Data.SqlDbType.BigInt, UserInfo.RealID);
                    _clsVPCDB.AddParam("@sPhotos", System.Data.SqlDbType.NVarChar, sPhotos.Value);
                    //执行存储过程,获取返回值
                    _clsVPCDB.ExecuteNonQuery();

                    ////结束事务处理
                    _clsVPCDB.CommitTrans();

                }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }
            #endregion
            if (bError)
            {
                sError = @"<div class=""alert alert-danger"" role=""alert"">" + "供应商修改时发生错误，请稍候再试！" + @"</div>";
                return;
            }
            else
            {
                Response.Redirect("Info");
            }
        }
    }
}