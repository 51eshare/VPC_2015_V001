using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (Session["EPS"] == null) ? "遇到错误了" : Session["EPS"].ToString();

            if (Session["EPSA"] != null && !string.IsNullOrEmpty(Session["EPSA"].ToString()))
            {
                LinkButton1.Enabled = true;
                LinkButton1.Visible = true;
            }
            else
            {
                LinkButton1.Enabled = false;
                LinkButton1.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["EPSA"] != null && !string.IsNullOrEmpty(Session["EPSA"].ToString()))
            {
                string sUrl = Session["EPSA"].ToString();
                Session["EPSA"] = null;
                Response.Redirect(sUrl);
            }
        }
    }
}