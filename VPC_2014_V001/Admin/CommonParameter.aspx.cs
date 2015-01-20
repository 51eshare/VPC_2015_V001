using Common;
using Entity;
using Service;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class CommonParameter : P_Base
    {
        private tbCommonParameter tbProductInfo
        {
            get {
                return new b_tbCommonParameter().GetList().FirstOrDefault();
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
            Common.CommonMethod.Entity_to_Controls(tbProductInfo, AddCommonParameter);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new tbCommonParameter();
            CommonMethod.Controls_to_Entity(_info, AddCommonParameter);
            tipclass = string.Empty;
            _info.ID = tbProductInfo.ID;
            if (new b_tbCommonParameter().Update(_info))
            {
                message.Text = "提交成功！";
            }
            else
            {
                message.Text = "提交失败！";
            }
        }
    }
}
