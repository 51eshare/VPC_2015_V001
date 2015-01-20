using Common;
using Entity;
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
    public partial class Regist : U_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (UserInfo == null)
                    Response.Redirect(string.Concat("/Account/Regist?urlreferrer=", StringEncode("/Vendor/Regist")));
                LoadData();
            }
        }
        private void LoadData()
        {
            var _list = b_Cache.GettbDistricts();
            sDistrict.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
            sDistrict.DataTextField = "sDistrict";
            sDistrict.DataValueField = "iDistrict";
            sDistrict.DataBind();
            sDistrict.Items.Insert(0, new ListItem("--请选择--", ""));
            sDistrict.Value = "601";
            iDistrict.Value = "601";
            var _sprovince = Districts(601);
            sProvince.DataSource = _sprovince;
            sProvince.DataTextField = "sProvince";
            sProvince.DataValueField = "iDistrict";
            sProvince.DataBind();
            sProvince.Items.Insert(0, new ListItem("--请选择--", ""));
        }

        protected void Btn_Regist_Click(object sender, EventArgs e)
        {
            var _tbvendor = new tbVendor();
            Common.CommonMethod.Controls_to_Entity(_tbvendor, RegistInfo);
            _tbvendor.iUserId = UserInfo.RealID;
            _tbvendor.sTaxType = Request.Form["sTaxType"];
            var _result = new b_tbVendor().Add_Up_tbVendor(_tbvendor);
            tipclass = string.Empty;
            if (_result == 0)
            {
                message.Text = "注册失败，请核对信息再提交";
            }
            else if (_result == 1)
            {
                ReUserInfo();
                Alert.ShowRedirect("注册成功！", "/");
            }
            else if (_result == 2)
            {
                message.Text = "注册失败，您已经申请过供应商";
            }
            else if (_result == 3)
            {
                message.Text = "注册失败，该供应商已经存在";
            }
            else
            {
                message.Text = "注册失败，请核对信息再提交";
            }
        }

    }
}


