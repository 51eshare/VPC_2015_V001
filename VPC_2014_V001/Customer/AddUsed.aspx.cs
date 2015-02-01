using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class AddUsed : P_Base
    {

        public tbUsedArea _tbUsedArea
        {
            get { 
                 int _id=GetParaInt("ID");
                 if (GetParaInt("ID") > 0)
                     return new b_tbUsedArea().Get(_id);
                 else
                     return default(tbUsedArea);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (GetParaInt("ID") > 0)
                {
                    DistrictF(_tbUsedArea.iDistrict);
                    CommonMethod.Entity_to_Controls(_tbUsedArea, InfoChangeForm);
                    iPdClassId.Value = _tbUsedArea.iPdClassId.ToString();
                    iDistrict.Value = _tbUsedArea.iDistrict.ToString();
                    faceImg.Value = _tbUsedArea.faceImg;
                    if (_tbUsedArea.photolist.Count > 0)
                    {
                        for (int i = 0; i < _tbUsedArea.photolist.Count; i++)
                        {

                            (Master.FindControl("MainContent").FindControl("sImagePath_" + (i + 1).ToString()) as HtmlInputText).Value = _tbUsedArea.photolist[i];
                        }  
                    }
                }
                else
                {
                    DistrictF(-1);
                }
                iPdClass();
            }
        }
        private void iPdClass()
        {
            if (_tbUsedArea != null)
            {
                var _class = b_Cache.GetProductClasses().SingleOrDefault(p => p.iPdClassId == _tbUsedArea.iPdClassId);
                if (_class != null && _class.iPdFatherId > 0)
                {
                    BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
                    foreach (ListItem item in DropDownList7.Items)
                    {
                        item.Selected = item.Value == _class.iPdFatherId.ToString();
                    }
                    BindPdClass(DropDownList8, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == _class.iPdFatherId));
                    foreach (ListItem item in DropDownList8.Items)
                    {
                        item.Selected = item.Value == _tbUsedArea.iPdClassId.ToString();
                    }
                }
                else
                {
                    BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
                    foreach (ListItem item in DropDownList7.Items)
                    {
                        item.Selected = item.Value == _tbUsedArea.iPdClassId.ToString();
                    }
                }
            }
            else
            {
                BindPdClass(DropDownList7, b_Cache.GetProductClasses().Where(p => p.iPdFatherId == 0));
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
            var _info = new tbUsedArea();
            CommonMethod.Controls_to_Entity(_info, InfoChangeForm);
            _info.iUserId = UserInfo.RealID;
            _info.ID = GetParaLong("ID");
            List<string> _sb = new List<string>();
            if (!string.IsNullOrWhiteSpace(sImagePath_1.Value))
                _sb.Add(sImagePath_1.Value);
            if (!string.IsNullOrWhiteSpace(sImagePath_2.Value))
                _sb.Add(sImagePath_2.Value);
            if (!string.IsNullOrWhiteSpace(sImagePath_3.Value))
                _sb.Add(sImagePath_3.Value);
            _info.photolist = _sb;
            if (_info.ID > 0)
            {
                if (new b_tbUsedArea().Update(_info))
                    Response.Redirect("UsedArea");
                else
                {
                    tipclass = string.Empty;
                    message.Text = "更新失败！";
                }
            }
            else
            {
                if (new b_tbUsedArea().Insert(_info).Value > 0)
                    Response.Redirect("UsedArea");
                else
                {
                    tipclass = string.Empty;
                    message.Text = "添加失败！";
                }
            }
        }
    }
}