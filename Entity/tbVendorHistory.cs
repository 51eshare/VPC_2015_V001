using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbVendorHistory。
	/// </summary>
	[Serializable]
	public partial class tbVendorHistory
	{
		public tbVendorHistory()
		{}
		#region Model
		private long _ivenhistoryid;
		private long? _ivendorid;
		private long? _ivenclass;
		private int? _idistrict;
		private int? _ilevel;
		private int? _istatus;
		private string _svenname;
		private long? _iregistcapital;
		private string _sregistaddress;
		private string _sbussinesslicencecode;
		private DateTime? _dbussinesslicenceexpdate;
		private string _sorganizationcode;
		private string _scontactname;
		private string _scontactphonenumber;
		private string _scontactmp;
		private string _scontactmail;
		private string _staxcode;
		private string _sbankname;
		private string _sbankaccountcode;
		private string _sbankaccountname;
		private string _staxtype;
		private string _sbillaccountname;
		private string _sbillaccountphone;
		private string _sbillaccountaddress;
		private string _sbillrecieveaddress;
		private string _sbillrecievezip;
		private string _sbillrecievecontactname;
		private long? _iuserid;
		private DateTime? _ddate;
		private string _sventype;
		private string _sbillrecievephone;
		/// <summary>
		/// 
		/// </summary>
		public long iVenHistoryId
		{
			set{ _ivenhistoryid=value;}
			get{return _ivenhistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVendorId
		{
			set{ _ivendorid=value;}
			get{return _ivendorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVenClass
		{
			set{ _ivenclass=value;}
			get{return _ivenclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iDistrict
		{
			set{ _idistrict=value;}
			get{return _idistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sVenName
		{
			set{ _svenname=value;}
			get{return _svenname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iRegistCapital
		{
			set{ _iregistcapital=value;}
			get{return _iregistcapital;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sRegistAddress
		{
			set{ _sregistaddress=value;}
			get{return _sregistaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBussinessLicenceCode
		{
			set{ _sbussinesslicencecode=value;}
			get{return _sbussinesslicencecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dBussinessLicenceExpDate
		{
			set{ _dbussinesslicenceexpdate=value;}
			get{return _dbussinesslicenceexpdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sOrganizationCode
		{
			set{ _sorganizationcode=value;}
			get{return _sorganizationcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sContactName
		{
			set{ _scontactname=value;}
			get{return _scontactname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sContactPhoneNumber
		{
			set{ _scontactphonenumber=value;}
			get{return _scontactphonenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sContactMP
		{
			set{ _scontactmp=value;}
			get{return _scontactmp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sContactMail
		{
			set{ _scontactmail=value;}
			get{return _scontactmail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sTaxCode
		{
			set{ _staxcode=value;}
			get{return _staxcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBankName
		{
			set{ _sbankname=value;}
			get{return _sbankname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBankAccountCode
		{
			set{ _sbankaccountcode=value;}
			get{return _sbankaccountcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBankAccountName
		{
			set{ _sbankaccountname=value;}
			get{return _sbankaccountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sTaxType
		{
			set{ _staxtype=value;}
			get{return _staxtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillAccountName
		{
			set{ _sbillaccountname=value;}
			get{return _sbillaccountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillAccountPhone
		{
			set{ _sbillaccountphone=value;}
			get{return _sbillaccountphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillAccountAddress
		{
			set{ _sbillaccountaddress=value;}
			get{return _sbillaccountaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillRecieveAddress
		{
			set{ _sbillrecieveaddress=value;}
			get{return _sbillrecieveaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillRecieveZip
		{
			set{ _sbillrecievezip=value;}
			get{return _sbillrecievezip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillRecieveContactName
		{
			set{ _sbillrecievecontactname=value;}
			get{return _sbillrecievecontactname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sVenType
		{
			set{ _sventype=value;}
			get{return _sventype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sBillRecievePhone
		{
			set{ _sbillrecievephone=value;}
			get{return _sbillrecievephone;}
		}
		#endregion Model
	}
}

