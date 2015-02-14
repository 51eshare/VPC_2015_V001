using Common;
using Entity;
using Service;
using System;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class Addad : P_Base
    {

        private Int32 iAdPdId
        {
            get {
                return GetParaInt("iadpdid");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsLogin();
                loaddata();
            }
        }
        public void loaddata()
        {
            if (iAdPdId > 0)
            {
                var _pinfo = new b_tbAdPd().Get(iAdPdId);
                Common.CommonMethod.Entity_to_Controls(_pinfo, AddSlideshowInfo);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbAdPd();
            CommonMethod.Controls_to_Entity(_info, AddSlideshowInfo);
            _info.iUserId = UserInfo.RealID;
            _info.iAdPdId = iAdPdId;
            if (iAdPdId > 0)
            {
                tipclass = string.Empty;
                if (new b_tbAdPd().Update(_info))
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.adproduct);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else
            {
                tipclass = string.Empty;
                if (new b_tbAdPd().Insert(_info).Value > 0)
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.adproduct);
                    CommonMethod.ClearValue(AddSlideshowInfo);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
        }
        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}
