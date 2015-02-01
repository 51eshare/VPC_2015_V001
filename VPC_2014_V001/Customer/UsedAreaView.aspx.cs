using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using Entity;
using Service;
using Common;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Customer
{
    public partial class UsedAreaView : P_Base
    {
        long iPdid
        {
            get { return GetParaLong("ipdid"); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var _info = new b_tbUsedArea().GetUserAreaByID(iPdid);
                if (_info != null)
                {
                    CommonMethod.Entity_to_Controls(_info, ShopPdInfo);
                    StringBuilder _sb = new StringBuilder();
                    foreach (var item in _info.photolist)
                    {
                        _sb.AppendFormat("<img src=\"{0}\" class=\"img-responsive\" />", item); 
                    }
                    imgs.InnerHtml = _sb.ToString();
                }
                else
                {
                    ShopPdInfo.Visible = false;
                    TipMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }
    }
}