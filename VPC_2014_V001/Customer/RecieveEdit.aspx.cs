using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Common;
using Entity;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class RecieveEdit : P_Base
    {
        private int iRecieveInfoId
        {
            get {
                return GetParaInt("iRecieveInfoId");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                Re_back.HRef = RequestQuery(URL.urlreferrer, "RecieveList");
            }
            if (iRecieveInfoId > 0)
                loaddata();
            else
                DistrictF(new tbRecieveInfo());
        }
        public void loaddata()
        {
            var _bll = new b_tbRecieveInfo();
            var _entity=_bll.Get(iRecieveInfoId);
            DistrictF(_entity);
            CommonMethod.Entity_to_Controls(_entity, editform);
        }
        private void District()
        {
            var _list = b_Cache.GettbDistricts();
            sDistrict.DataSource = _list.Where(p=>p.iDistrictFatherId==0);

        }
        private void DistrictF(tbRecieveInfo dis)
        {
            var _list = b_Cache.GettbDistricts();
            var _selected = _list.SingleOrDefault(p => p.iDistrict == dis.iDistrictId);
            sDistrict.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
            sDistrict.DataTextField = "sDistrict";
            sDistrict.DataValueField = "iDistrict";
            sDistrict.DataBind();
            sDistrict.Items.Insert(0, new ListItem("--请选择--", ""));
            sDistrict.Value = "601";
            iDistrictId.Value = "601";
            if (_selected!=null)
            foreach (ListItem item in sDistrict.Items)
            {
                item.Selected = item.Text == _selected.sDistrict;
            }
            if (_selected != null)
            {
                if (!string.IsNullOrWhiteSpace(_selected.sProvince))
                {
                    int _province = _list.SingleOrDefault(c => c.iDistrict == dis.iDistrictId).iDistrictFatherId;
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
            }
            else
            {
                var _sprovince = Districts(601);
                sProvince.DataSource = _sprovince;
                sProvince.DataTextField = "sProvince";
                sProvince.DataValueField = "iDistrict";
                sProvince.DataBind();
                sProvince.Items.Insert(0, new ListItem("--请选择--", ""));
            }
           
            if (_selected != null)
            if (!string.IsNullOrWhiteSpace(_selected.sCity))
            {
                int _province = _list.SingleOrDefault(c => c.iDistrict == dis.iDistrictId).iDistrictFatherId;
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
            var _info = new tbRecieveInfo();
            CommonMethod.Controls_to_Entity(_info, editform);
            string _iDistrictId = Request.Form[iDistrictId.UniqueID];
            _info.iRecieveInfoId = iRecieveInfoId;
            _info.iUserId = UserInfo.iUserId;
            _info.iDistrictId = Int32.Parse(_iDistrictId);
            _info.sRecieveName = Request.Form[sRecieveName.UniqueID];
            _info.sAddress = Request.Form[sAddress.UniqueID];
            _info.sPhoneNum = Request.Form[sPhoneNum.UniqueID];
            _info.sPostCode = Request.Form[sPostCode.UniqueID];
            _info.bDefault = string.IsNullOrWhiteSpace(Request.Form[bDefault.UniqueID])?false:true;
            if (iRecieveInfoId > 0)
            {
                if (new b_tbRecieveInfo().Update(_info))
                    Response.Redirect("RecieveList");
                else
                {
                    tipclass = "";
                    message.Text = "编辑出错！";
                }
            }
            else
            {
                if (new b_tbRecieveInfo().Insert(_info).Value > 0)
                    Response.Redirect(RequestQuery(URL.urlreferrer, "RecieveList"));
                else
                {
                    tipclass = "";
                    message.Text = "编辑出错！";
                }
            }
        }
    }
}