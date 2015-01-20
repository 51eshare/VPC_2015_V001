using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;
using Service;
using Entity;
using Common;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class PdAdd : P_Base
    {
        private Int32 iPdId
        {
            get {
                return GetParaInt("iPdId");
            }
        }
        private tbProduct tbProductInfo
        {
            get {
                if (iPdId > 0)
                {
                   return new b_tbProduct().Get(iPdId);
                }
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (GetParaStr("operate").Equals("view"))
                {
                    Button1.Visible = false;
                }
                IsLogin();
                iPdClass();
                DistrictF();
                loaddata();
            }
        }
        public void loaddata()
        {
            if (iPdId > 0)
            {
                var _pinfo = new b_tbProduct().Get(iPdId);
                Common.CommonMethod.Entity_to_Controls(_pinfo, PdAddInfo);
            }
        }

        private void iPdClass()
        {
            if(tbProductInfo!=null)
            {
                var _class = b_Cache.GetProductClasses().SingleOrDefault(p => p.iPdClassId == tbProductInfo.iPdClassId);
                if (_class!=null&&_class.iPdFatherId > 0)
                {
                    BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
                    foreach (ListItem item in DropDownList7.Items)
                    {
                        item.Selected = item.Value == _class.iPdFatherId.ToString();
                    }
                    BindPdClass(DropDownList8, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == _class.iPdFatherId));
                    foreach (ListItem item in DropDownList8.Items)
                    {
                        item.Selected = item.Value == tbProductInfo.iPdClassId.ToString();
                    }
                }
                else
                {
                    BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
                    foreach (ListItem item in DropDownList7.Items)
                    {
                        item.Selected = item.Value == tbProductInfo.iPdClassId.ToString();
                    }
                }
            }
            else
            {
                BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
            }
        }
        private void DistrictF()
        {
            if (tbProductInfo != null)
            {
                int dis = tbProductInfo.iDistrict;
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
            else
            {
                var _list = b_Cache.GettbDistricts();
                sDistrict.DataSource = _list.Where(p => p.iDistrictFatherId == 0);
                sDistrict.DataTextField = "sDistrict";
                sDistrict.DataValueField = "iDistrict";
                sDistrict.DataBind();
                sDistrict.Items.Insert(0, new ListItem("--请选择--", ""));
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbProduct();
            CommonMethod.Controls_to_Entity(_info, PdAddInfo);
            _info.iVendorId = UserInfo.RealID;
            _info.iUserId = UserInfo.iUserId;
            if (iPdId > 0)
            {
                _info.iPdId = iPdId;
                tipclass = string.Empty;
                if (new b_tbProduct().Update(_info))
                {
                    message.Text = "提交成功！";
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else
            {
                tipclass = string.Empty;
                if (new b_tbProduct().Insert(_info).Value > 0)
                {
                    Alert.ShowRedirect("提交成功！", "PdAdd");
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
        }
        private void ClearControl()
        {
            iPdClassId.Value="0";
            iDistrict.Value = "0";
           
        }

        protected void btn_return_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer", "Pds"));
        }
    }
}
