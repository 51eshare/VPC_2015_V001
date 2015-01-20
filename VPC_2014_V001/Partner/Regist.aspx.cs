using Service;
using System;
using Entity;
using Common;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Partner
{
    public partial class Regist :U_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (UserInfo == null)
                    Response.Redirect(string.Concat("/Account/Regist?urlreferrer=", StringEncode("/Partner/Regist")));
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
            var _sprovince=Districts(601);
            sProvince.DataSource = _sprovince;
            sProvince.DataTextField = "sProvince";
            sProvince.DataValueField = "iDistrict";
            sProvince.DataBind();
            sProvince.Items.Insert(0, new ListItem("--请选择--", ""));
        }


        protected void Btn_Regist_Click(object sender, EventArgs e)
        {
            var _uinfo = new tbShop();
            Common.CommonMethod.Controls_to_Entity(_uinfo, RegistInfo);
            _uinfo.iUserId = UserInfo.RealID;
            var _result = new b_tbShop().Add_Up_tbShop(_uinfo);
            tipclass = string.Empty;
            if (_result == 0)
            {
                message.Text = "注册失败，请核对信息再提交";
            }
            else if (_result==1)
            {
                ReUserInfo();
                Alert.ShowRedirect("注册成功！","/");
            }
            else if (_result == 2)
            {
                message.Text = "注册失败，您已经申请过微店主";
            }
            else if (_result == 3)
            {
                message.Text = "注册失败，该微店名已经存在";
            }
            else
            {
                message.Text = "注册失败，请核对信息再提交";
            }
        }
    }
}