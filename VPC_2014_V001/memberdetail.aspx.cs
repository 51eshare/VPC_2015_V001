using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entity;
using Service;
using System.Web.UI.WebControls;
using Common;

namespace VPC_2014_V001
{
    public partial class memberdetail : U_Base
    {
        private int infotype
        {
            get {
                if (Request.QueryString["infotype"] != null)
                    return Int32.Parse(Request.QueryString["infotype"]);
                else
                    return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (infotype > 0)
                {
                    var _info = new b_tbInfo().GetInfo(infotype);
                    CommonMethod.Entity_to_Controls(_info,info);
                }
                else
                  DefaltPage();
            }
        }
    }
}