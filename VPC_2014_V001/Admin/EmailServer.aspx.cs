using Common;
using Entity;
using Service;
using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Admin
{
    public partial class EmailServer : P_Base
    {
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
            var _info = new FileOperate().Read_Txt("Email");
            if (!string.IsNullOrWhiteSpace(_info))
            {
                var _pinfo = JsonConvert.DeserializeObject<Email>(_info);
                Common.CommonMethod.Entity_to_Controls(_pinfo, AddtbInfos);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var _info = new Email();
            CommonMethod.Controls_to_Entity(_info, AddtbInfos);
            try
            {
                new FileOperate().Write_Txt("Email", JsonConvert.SerializeObject(_info));
                tipclass = string.Empty;
                message.Text = "保存成功！";
                b_Cache.RemoveData(Cache_Key.email);
            }
            catch
            {
                message.Text = "保存失败！";
            }

        }
    }
}
