using Common;
using Entity;
using Service;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Partner
{
    public partial class VendorRegist : U_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LoadData();
                shareuid.Value = RequestQuery(URL.shareuid, "0");
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
            var _uinfo = new tbVendorRegist();
            Common.CommonMethod.Controls_to_Entity(_uinfo, RegistInfo);
            _uinfo.sPassword = Security.MD5(_uinfo.sPassword);
            var _result = new b_tbShop().Add_Up_VendorRegist(_uinfo);
            tipclass = string.Empty;
            if (_result == 1)
            {
                ReUserInfo(_uinfo.iUserId);
                Alert.ShowRedirect("注册成功！",RequestQuery("urlreferrer"));
            }
            else if (_result == 3)
            {
                message.Text = "注册失败，该用户名或者邮箱已经存在";
            }
            else
            {
                message.Text = "注册失败，请核对信息再提交";
            }
        }
    }
}