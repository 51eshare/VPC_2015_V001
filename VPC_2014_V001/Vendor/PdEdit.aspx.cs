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
    public partial class PdEdit : P_Base
    {
        private Int64 iPdid
        {
            get
            {
                return GetParaInt("iPdId");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataSet ds = new DataSet();
                using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
                {
                    try { _clsVPCDB.OpenCon(); }
                    catch (Exception ex) { throw ex; }

                    try
                    {
                        _clsVPCDB.CmdSQL = "SELECT * FROM vwDistrict1";
                        _clsVPCDB.ExecuteQuery(ref ds, "vwDistrict1");

                        _clsVPCDB.CmdSQL = "SELECT * FROM vwDistrict2 WHERE iDistrictFatherId=601";
                        _clsVPCDB.ExecuteQuery(ref ds, "vwDistrict2");

                        _clsVPCDB.CmdSQL = "SELECT * FROM vwProductClassL1";
                        _clsVPCDB.ExecuteQuery(ref ds, "vwProductClassL1");

                        _clsVPCDB.CmdSQL = "SELECT * FROM vwProductClassL2";
                        _clsVPCDB.ExecuteQuery(ref ds, "vwProductClassL2");

                        _clsVPCDB.CmdProc = "pcProductInfo";
                        _clsVPCDB.AddParam("@iPdId", SqlDbType.BigInt, iPdid);
                        _clsVPCDB.ExecuteQuery(ref ds, "vwPd");


                    }
                    catch (Exception ex) { throw ex; }
                    finally { try { _clsVPCDB.CloseCon(); } catch { } }
                }

                DropDownList7.DataSource = ds.Tables["vwProductClassL1"];
                DropDownList7.DataTextField = "cPdClass";
                DropDownList7.DataValueField = "iPdClassId";
                DropDownList7.SelectedValue = ds.Tables["vwPd"].Rows[0]["iPdClass1"].ToString();
                DropDownList7.DataBind();

                DropDownList8.DataSource = ds.Tables["vwProductClassL2"];
                DropDownList8.DataTextField = "cPdClass";
                DropDownList8.DataValueField = "iPdClassId";
                DropDownList8.SelectedValue = ds.Tables["vwPd"].Rows[0]["iPdClass2"].ToString();
                DropDownList8.DataBind();

                DropDownList4.DataSource = ds.Tables["vwDistrict1"];
                DropDownList4.DataTextField = "sDistrict";
                DropDownList4.DataValueField = "iDistrict";
                DropDownList4.SelectedValue = ds.Tables["vwPd"].Rows[0]["iDistrictContory"].ToString();
                DropDownList4.DataBind();

                if (ds.Tables["vwPd"].Rows[0]["iDistrictContory"].ToString() == "601")
                {
                    DropDownList5.DataSource = ds.Tables["vwDistrict2"];
                    DropDownList5.DataTextField = "sProvince";
                    DropDownList5.DataValueField = "iDistrict";
                    DropDownList5.SelectedValue = ds.Tables["vwPd"].Rows[0]["iDistrictProvince"].ToString();
                    DropDownList5.DataBind();
                }
                else
                {
                    DropDownList5.Enabled = false;
                    DropDownList6.Enabled = false;
                }

                ShowCityList(ds.Tables["vwPd"].Rows[0]["iDistrictCity"].ToString());


                txtsPdName.Text = ds.Tables["vwPd"].Rows[0]["商品名称"].ToString();
                txtsPdBrand.Text = ds.Tables["vwPd"].Rows[0]["商品品牌"].ToString();
                txtsPdStd.Text = ds.Tables["vwPd"].Rows[0]["商品规格"].ToString();
                //国产，进口等，xavier
                txtsPdCpu.Text = ds.Tables["vwPd"].Rows[0]["最小销售单位"].ToString();
                txtiPdBaseNum.Text = ds.Tables["vwPd"].Rows[0]["最小销售数量"].ToString();
                txtsPdPackage.Text = ds.Tables["vwPd"].Rows[0]["包装"].ToString();
                txtsQualityPeriod.Text = ds.Tables["vwPd"].Rows[0]["食品有效期"].ToString();
                txtsbarCode.Text = ds.Tables["vwPd"].Rows[0]["条码"].ToString();
                intiQuantity.Text = ds.Tables["vwPd"].Rows[0]["可售数量"].ToString();
                numfPurPrice.Text = ds.Tables["vwPd"].Rows[0]["供应商结算价"].ToString();
                numfSaPrice.Text = ds.Tables["vwPd"].Rows[0]["零售价"].ToString();
                numfBdPrice.Text = ds.Tables["vwPd"].Rows[0]["市场价"].ToString();
                datedValidDate.Text = ds.Tables["vwPd"].Rows[0]["价格有效期"].ToString();
            }
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

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch (Exception ex) { throw ex; }

                try
                {
                    _clsVPCDB.CmdSQL = "SELECT * FROM vwProductClassL2 WHERE iPdFatherId=" + DropDownList7.SelectedValue;
                    _clsVPCDB.ExecuteQuery(ref ds, "vwProductClassL2");
                }
                catch (Exception ex) { throw ex; }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }

            DropDownList8.Items.Clear();

            if (ds.Tables["vwProductClassL2"].Rows.Count > 0)
            {
                DropDownList8.DataSource = ds.Tables["vwProductClassL2"];
                DropDownList8.DataTextField = "cPdClass";
                DropDownList8.DataValueField = "iPdClassId";
                if (DropDownList8.SelectedValue == "1")
                {
                    DropDownList8.SelectedValue = "5";
                }
                DropDownList8.DataBind();
                DropDownList8.Enabled = true;
            }
            else
            {
                DropDownList8.Items.Clear();
                DropDownList8.Enabled = false;
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
                    DropDownList6.SelectedValue = ds.Tables["vwDistrict3"].Rows[0]["iDistrict"].ToString();
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
            int iPdBaseNum = 0;
            int iQuantity = 0;
            float fPurPrice = 0;
            float fSaPrice = 0;
            float fBdPrice = 0;
            //数据有效性验证
            //商品分类不为空,xavier
            if (string.IsNullOrEmpty(DropDownList7.Text.Trim()))
            {
                bError = true; sError = "商品分类必须填写";
            }
            if (string.IsNullOrEmpty(DropDownList8.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "商品分类必须填写";
            }

            //商品名称不为空
            if (string.IsNullOrEmpty(txtsPdName.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "商品名称必须填写";
            }
            //商品名称不能超过50个字符
            if (txtsPdName.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "商品名称不能超过50个字符";
            }
            //品牌不为空
            if (string.IsNullOrEmpty(txtsPdBrand.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError = "品牌必须填写";
            }
            if (txtsPdBrand.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "品牌名称不能超过50个字符";
            }
            //规格不为空
            if (string.IsNullOrEmpty(txtsPdStd.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "规格必须填写";
            }
            if (txtsPdStd.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "规格不能超过50个字符";
            }
            //产地不为空,xavier
            if (string.IsNullOrEmpty(DropDownList4.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "产地必须填写";
            }
            //最小销售单位不为空
            if (string.IsNullOrEmpty(txtsPdCpu.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "最小销售单位必须填写";
            }
            if (txtsPdCpu.Text.Trim().Length > 30)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "最小销售单位不能超过15个字符";
            }
            //最小销售数量
            if (string.IsNullOrEmpty(txtiPdBaseNum.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "最小销售数量必须填写";
            }

            if (!int.TryParse(txtiPdBaseNum.Text.Trim(), out iPdBaseNum))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "最小销售数量不是整数";
            }
            if (iPdBaseNum < 1)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "最小销售数量应为正整数";
            }

            //包装方式不为空
            if (string.IsNullOrEmpty(txtsPdPackage.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "包装方式必须填写";
            }
            if (txtsPdPackage.Text.Trim().Length > 100)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "包装方式不能超过50个字符";
            }
            //食品有效期不为空
            if (string.IsNullOrEmpty(txtsQualityPeriod.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "食品有效期必须填写";
            }
            //条码不为空
            if (string.IsNullOrEmpty(txtsbarCode.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "条码必须填写";
            }
            if (txtsbarCode.Text.Trim().Length > 30)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "条码不能超过15个字符";
            }
            //可售数量
            if (string.IsNullOrEmpty(intiQuantity.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "可售数量必须填写";
            }

            if (!int.TryParse(intiQuantity.Text.Trim(), out iQuantity))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "可售数量不是整数";
            }
            if (iQuantity < 1)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "可售数量应为正整数";
            }
            //供应商供价
            if (string.IsNullOrEmpty(numfPurPrice.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "供应商供价不为空";
            }
            if (!float.TryParse(numfPurPrice.Text.Trim(), out fPurPrice))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "供应商供价应为数字";
            }
            if (fPurPrice < 0)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "供应商供价应为正数";
            }
            //前台售价
            if (string.IsNullOrEmpty(numfSaPrice.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "前台售价不为空";
            }
            if (!float.TryParse(numfSaPrice.Text.Trim(), out fSaPrice))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "前台售价应为数字";
            }
            if (fSaPrice < 0)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "前台售价应为正数";
            }
            //市场价
            if (string.IsNullOrEmpty(numfBdPrice.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "市场价不为空";
            }
            if (!float.TryParse(numfBdPrice.Text.Trim(), out fBdPrice))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "市场价为数字";
            }
            if (fBdPrice < 0)
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "市场价为正数";
            }
            //价格有效日期不为空
            if (string.IsNullOrEmpty(datedValidDate.Text.Trim()))
            {
                bError = true;
                sError += string.IsNullOrEmpty(sError) ? "" : "<br />";
                sError += "价格有效日期必须填写";
            }
            if (bError)
            {
                sError = @"<div class=""alert alert-danger"" role=""alert"">" + sError + @"</div>";
                Label1.Text = sError;
                return;
            }
            //获取地区ID
            int iDistrict = 0;
            int ipdClassId = 0;
            string sDistrict = null;

            if (int.TryParse(DropDownList6.SelectedValue, out iDistrict)) { sDistrict = DropDownList4.SelectedItem.Text + "-" + DropDownList5.SelectedItem.Text + "-" + DropDownList6.SelectedItem.Text; }
            else if (int.TryParse(DropDownList5.SelectedValue, out iDistrict)) { sDistrict = DropDownList4.SelectedItem.Text + "-" + DropDownList5.SelectedItem.Text; }
            else if (int.TryParse(DropDownList4.SelectedValue, out iDistrict)) { sDistrict = DropDownList4.SelectedItem.Text; }



            if (int.TryParse(DropDownList8.SelectedValue, out ipdClassId)) { }
            else if (int.TryParse(DropDownList7.SelectedValue, out ipdClassId)) { }

            System.Data.DataSet ds = new System.Data.DataSet();
            if (!bError)
            {

                #region 数据库检索
                using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
                {
                    try { _clsVPCDB.OpenCon(); }
                    catch (Exception ex) { bError = true; sError = ex.ToString(); }

                    try
                    {
                        //存储过程名称
                        _clsVPCDB.CmdProc = "pctbProductUpdate";

                        //存储过程参数
                        _clsVPCDB.AddParam("@iPdId", System.Data.SqlDbType.BigInt, iPdid);
                        _clsVPCDB.AddParam("@iVendorId", System.Data.SqlDbType.BigInt, Session["V"].ToString());
                        _clsVPCDB.AddParam("@iDistrict", System.Data.SqlDbType.Int, iDistrict);
                        _clsVPCDB.AddParam("@iPdClassId", System.Data.SqlDbType.Int, ipdClassId);
                        _clsVPCDB.AddParam("@sPdName", System.Data.SqlDbType.NVarChar, txtsPdName.Text.Trim());
                        _clsVPCDB.AddParam("@sPdBrand", System.Data.SqlDbType.NVarChar, txtsPdBrand.Text.Trim());
                        _clsVPCDB.AddParam("@sPdStd", System.Data.SqlDbType.NVarChar, txtsPdStd.Text.Trim());
                        _clsVPCDB.AddParam("@sPdCpu", System.Data.SqlDbType.NVarChar, txtsPdCpu.Text.Trim());
                        _clsVPCDB.AddParam("@iPdBaseNum", System.Data.SqlDbType.BigInt, iPdBaseNum);
                        _clsVPCDB.AddParam("@sPdPackage", System.Data.SqlDbType.NVarChar, txtsPdPackage.Text.Trim());
                        _clsVPCDB.AddParam("@sQualityPeriod", System.Data.SqlDbType.NVarChar, txtsQualityPeriod.Text.Trim());
                        _clsVPCDB.AddParam("@sbarCode", System.Data.SqlDbType.NVarChar, txtsbarCode.Text.Trim());
                        _clsVPCDB.AddParam("@iQuantity", System.Data.SqlDbType.Float, iQuantity);
                        _clsVPCDB.AddParam("@fPurPrice", System.Data.SqlDbType.Float, fPurPrice);
                        _clsVPCDB.AddParam("@fSaPrice", System.Data.SqlDbType.Float, fSaPrice);
                        _clsVPCDB.AddParam("@fBdPrice", System.Data.SqlDbType.Float, fBdPrice);
                        _clsVPCDB.AddParam("@dValidDate", System.Data.SqlDbType.Date, datedValidDate.Text.Trim());
                        //商品历史数据Id，xavier
                        //_clsVPCDB.AddParam("@iPdHistoryId", System.Data.SqlDbType.NVarChar, null);
                        //描述，xavier
                        //_clsVPCDB.AddParam("@sMemo", System.Data.SqlDbType.NVarChar, null);

                        //执行存储过程,获取返回值
                        _clsVPCDB.ExecuteNonQuery();


                        //结束事务处理
                        _clsVPCDB.CommitTrans();
                    }
                    catch (Exception ex) { bError = true; sError = ex.ToString(); }
                    finally { try { _clsVPCDB.CloseCon(); } catch { } }


                }
                #endregion
                if (bError)
                {
                    sError = @"<div class=""alert alert-danger"" role=""alert"">" + "商品档案修改时发生错误，请稍候再试！" + @"</div>";
                    Label1.Text = sError;
                    return;
                }
                else
                {
                    Response.Redirect("Pd?P=" + iPdid.ToString());
                }
            }

        }
    }
}