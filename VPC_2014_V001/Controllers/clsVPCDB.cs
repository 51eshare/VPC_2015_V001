using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VPC_2014_V001.VPC.Sample
{
    public class clsVPCDB : Xavier.DbBase.SqlServer
    {
        public override void SetConnectString()
        {
            m_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
    }
}
