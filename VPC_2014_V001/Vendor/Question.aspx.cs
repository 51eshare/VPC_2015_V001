using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Question : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                IsLogin();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                //tbQuestion _question
        }
    }
}