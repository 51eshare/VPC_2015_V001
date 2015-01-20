using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VPC_2014_V001.VPC.Account
{
    public class Role
    {
        /// <summary>
        /// 是否允许成为供应商
        /// </summary>
        private bool m_bVendorAllow;
        /// <summary>
        /// 是否允许成为小伙伴
        /// </summary>
        private bool m_bPartnerAllow;

        private bool m_bIsVendor;
        private Int64 m_iVendorId;

        private bool m_bVendorRegisted;

        private bool m_AddPd;

        private bool m_bIsPartner;
        private Int64 m_iShopId;
        private bool m_bPartnerRegisted;

        public bool Checked(String sUserId)
        {

            System.Data.DataSet ds = new System.Data.DataSet();

            #region 检索数据库
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch{ return false; }

                try
                {
                    _clsVPCDB.CmdSQL = "Select * from tbUser where iUserId=" + (string.IsNullOrEmpty(sUserId) ? "0" : sUserId);//用户
                    _clsVPCDB.ExecuteQuery(ref ds, "User");

                    _clsVPCDB.CmdSQL = "Select * from tbUserTypeRefUser where iUserId=" + (string.IsNullOrEmpty(sUserId) ? "0" : sUserId) + " and iUserTypeId=5000";//供应商
                    _clsVPCDB.ExecuteQuery(ref ds, "Vendor");

                    _clsVPCDB.CmdSQL = "Select * from tbUserTypeRefUser where iUserId=" + (string.IsNullOrEmpty(sUserId) ? "0" : sUserId) + " and iUserTypeId=3000";//小伙伴
                    _clsVPCDB.ExecuteQuery(ref ds, "Partner");
                }
                catch{ return false; }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }
            #endregion

            if (ds.Tables["User"].Rows.Count < 1)
            {
                return false;
            }
            else
            {
                m_bVendorAllow = (ds.Tables["User"].Rows[0]["bVendorAllow"].ToString() == "True") ? true : false;
                m_bPartnerAllow = (ds.Tables["User"].Rows[0]["bPartnerAllow"].ToString() == "True") ? true : false;
            }


            if (ds.Tables["Vendor"].Rows.Count < 1)
            {
                m_bVendorRegisted = true;
                m_bIsVendor = false;
            }
            else
            {

                m_bIsVendor = true;
                m_bVendorRegisted = false;
                if (Int64.TryParse(ds.Tables["Vendor"].Rows[0]["iVendorId"].ToString(), out m_iVendorId))
                {
                    m_bIsVendor = true;
                    m_AddPd=(ds.Tables["Vendor"].Rows[0]["iStatus"].ToString()=="3005")?true:false;
                }
                else
                {
                    m_bIsVendor = false;
                }
            }

            if (ds.Tables["Partner"].Rows.Count < 1)
            {
                m_bPartnerRegisted = true;
                m_bIsPartner = false;
            }
            else
            {
                m_bIsPartner = true;
                m_bPartnerRegisted = false;

                if (Int64.TryParse(ds.Tables["Partner"].Rows[0]["iShopId"].ToString(), out m_iShopId))
                {
                    m_bIsPartner = true;

                }
                else
                {
                    m_bIsPartner = false;
                }
            }

            return true;
        }

        public bool bIsVendor
        {
            get
            { return m_bIsVendor; }
        }

        public Int64 iVendorId
        {
            get
            { return m_iVendorId; }
        }

        public bool bVendorAllow
        {
            get
            { return m_bVendorAllow; }
        }

        public bool bVendorRegisted
        {
            get
            { return m_bVendorRegisted; }
        }

        public bool bAddPd
        {
            get
            { return m_AddPd; }
        }

        public bool bIsPartner
        {
            get
            { return m_bIsPartner; }
        }

        public Int64 iShopId
        {
            get
            { return m_iShopId; }
        }

        public bool bPartnerAllow
        {
            get
            { return m_bPartnerAllow; }
        }

        public bool bPartnerRegisted
        {
            get
            { return m_bPartnerRegisted; }
        }
    }
}