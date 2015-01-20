using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Reconciliation : System.Web.UI.Page
    {
        bool bError = false;
        string sError = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }

                try
                {
                    _clsVPCDB.CmdSQL = "SELECT * FROM vwOrderList";
                    _clsVPCDB.ExecuteQuery(ref ds, "vwOrders");

                }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }
            Repeater1.DataSource = ds.Tables["vwOrders"];
            Repeater1.DataBind();

        }
    }
}