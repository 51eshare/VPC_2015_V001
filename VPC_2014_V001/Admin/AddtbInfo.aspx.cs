using Common;
using Entity;
using Service;
using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class AddtbInfo : P_Base
    {

        private Int32 iPdId
        {
            get {
                return GetParaInt("id");
            }
        }
        private tbInfo tbProductInfo
        {
            get {
                if (iPdId > 0)
                {
                    return new b_tbInfo().Get(iPdId);
                }
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                binddata();
                loaddata();
            }
        }
        public void binddata()
        {
            BindClass(InfoType, b_Cache.GetStatus().Where(p => p.StateType == 6),"请选择信息类型");
        }
        public void loaddata()
        {
            if (iPdId > 0)
            {
                var _pinfo = new b_tbInfo().Get(iPdId);
                Common.CommonMethod.Entity_to_Controls(_pinfo, AddtbInfos);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbInfo();
            CommonMethod.Controls_to_Entity(_info, AddtbInfos);
            if (iPdId > 0)
            {
                tipclass = string.Empty;
                _info.ID = iPdId;
                if (new b_tbInfo().Update(_info))
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.tbInfos);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else
            {
                tipclass = string.Empty;
                if (new b_tbInfo().Insert(_info).Value > 0)
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.tbInfos);
                    CommonMethod.ClearValue(AddtbInfos);
                    ClearControl();
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
        }
        private void ClearControl()
        {
            CContent.Value = string.Empty;
           
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}
