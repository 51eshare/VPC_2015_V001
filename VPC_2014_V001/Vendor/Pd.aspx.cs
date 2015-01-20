using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Common;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Pd : P_Base
    {
        bool bError = false;
        Int64 iPdid {
            get {
                return GetParaInt("iPdId");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (RequestQuery("operate") == Operate.view)
                    Button1.Visible = false;
                var _info = new b_tbProduct().ProductImages(iPdid);
                Common.CommonMethod.Entity_to_Controls(_info,PdInfo);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!bError)
            {
                Response.Redirect("PdAdd?iPdId=" + iPdid.ToString());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(RequestQuery("urlreferrer"));
        }
    }
}