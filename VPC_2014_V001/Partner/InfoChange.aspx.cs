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

namespace VPC_2014_V001.VPC.Partner
{
    public partial class InfoChange : P_Base
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var _info = new b_tbShop().GetList(string.Concat("SELECT * FROM tbShop WHERE iUserId=",UserInfo.RealID));
                if (_info.Count() > 0)
                {
                    var _tbshop = _info.FirstOrDefault();
                    DistrictF(_tbshop.iDistrict);
                    CommonMethod.Entity_to_Controls(_tbshop, InfoChangeForm);
                }
                else
                {
                    DistrictF(-1);
                }
                
            }
        }
        private void District()
        {
            var _list = b_Cache.GettbDistricts();
            sDistrict.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
        }
        private void DistrictF(int dis)
        {
            var _list = b_Cache.GettbDistricts();
            var _selected = _list.SingleOrDefault(p => p.iDistrict == dis);
            sDistrict.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
            sDistrict.DataTextField = "sDistrict";
            sDistrict.DataValueField = "iDistrict";
            sDistrict.DataBind();
            sDistrict.Items.Insert(0, new ListItem("--请选择--", ""));
            if (_selected != null)
                foreach (ListItem item in sDistrict.Items)
                {
                    item.Selected = item.Text == _selected.sDistrict;
                }
            if (_selected != null)
                if (!string.IsNullOrWhiteSpace(_selected.sProvince))
                {
                    int _province = _list.SingleOrDefault(c => c.iDistrict == dis).iDistrictFatherId;
                    if (_selected.iGrade == 3)
                        _province = _list.SingleOrDefault(c => c.iDistrict == _province).iDistrictFatherId;
                    sProvince.DataSource = _list.Where(p => p.iDistrictFatherId == _province && !string.IsNullOrWhiteSpace(p.sProvince));
                    sProvince.DataTextField = "sProvince";
                    sProvince.DataValueField = "iDistrict";
                    sProvince.DataBind();
                    foreach (ListItem item in sProvince.Items)
                    {
                        item.Selected = item.Text == _selected.sProvince;
                    }
                }
            if (_selected != null)
                if (!string.IsNullOrWhiteSpace(_selected.sCity))
                {
                    int _province = _list.SingleOrDefault(c => c.iDistrict == dis).iDistrictFatherId;
                    sCity.DataSource = _list.Where(p => p.iDistrictFatherId == _province && !string.IsNullOrWhiteSpace(p.sProvince));
                    sCity.DataTextField = "sCity";
                    sCity.DataValueField = "iDistrict";
                    sCity.DataBind();
                    foreach (ListItem item in sCity.Items)
                    {
                        item.Selected = item.Text == _selected.sCity;
                    }
                }
        }

        protected void btn_add_ServerClick(object sender, EventArgs e)
        {
            var _info = new tbShop();
            CommonMethod.Controls_to_Entity(_info, InfoChangeForm);
            _info.iUserId = UserInfo.RealID;
            if (_info.iShopId > 0)
            {
                if (new b_tbShop().Update(_info))
                    Response.Redirect("Info");
                else
                {
                    tipclass = string.Empty;
                    message.Text = "更新失败！";
                }
            }
            else
            {
                if (new b_tbShop().Insert(_info).Value>0)
                    Response.Redirect("Info");
                else
                {
                    tipclass = string.Empty;
                    message.Text = "添加失败！";
                }
            }
        }
    }
}