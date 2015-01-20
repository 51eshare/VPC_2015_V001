using Common;
using Entity;
using Service;
using System;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class AddSlideshow : P_Base
    {

        private Int32 iPdId
        {
            get {
                return GetParaInt("islideshow");
            }
        }
        private tbSlideshow tbProductInfo
        {
            get {
                if (iPdId > 0)
                {
                    return new b_tbSlideshow().Get(iPdId);
                }
                return null;
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
            if (iPdId > 0)
            {
                var _pinfo = new b_tbSlideshow().Get(iPdId);
                Common.CommonMethod.Entity_to_Controls(_pinfo, AddSlideshowInfo);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbSlideshow();
            CommonMethod.Controls_to_Entity(_info, AddSlideshowInfo);
            if (iPdId > 0)
            {
                tipclass = string.Empty;
                _info.ID = iPdId;
                if (new b_tbSlideshow().Update(_info))
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.tbslideshow);
                }
                else
                {
                    message.Text = "提交失败！";
                }
            }
            else
            {
                tipclass = string.Empty;
                if (new b_tbSlideshow().Insert(_info).Value > 0)
                {
                    message.Text = "提交成功！";
                    b_Cache.RemoveData(Cache_Key.tbslideshow);
                    CommonMethod.ClearValue(AddSlideshowInfo);
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
            NContent.Value = string.Empty;
           
        }

        protected void btn_back_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}
