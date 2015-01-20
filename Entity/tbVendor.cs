using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbVendor。
	/// </summary>
	[Serializable]
	public partial class tbVendor
	{
		public tbVendor()
		{

            DServiceEndDate = DateTime.Now;
            iCashDeposit = 0;
            iServiceFee = 0;
            sCustomerServicePhone = string.Empty;
        }
        /// <summary>
        /// 售后服务电话
        /// </summary>
        public string sCustomerServicePhone { get; set;}
        [Editable(false)]
        /// <summary>
        /// 服务费
        /// </summary>
        public int iServiceFee { get; set;}
        /// <summary>
        /// 保证金金额
        /// </summary>
        [Editable(false)]
        public int iCashDeposit { get; set;}
        [Editable(false)]
        public DateTime DServiceEndDate { get; set;}
        /// <summary>
        /// 主要客户或销售渠道
        /// </summary>
        public string sMainCustomer { get; set;}
		#region Model
		private long _ivendorid;
		private long _ivenclass=2;
		private int _idistrict;
		private int _ilevel=3001;
		private int _istatus=1;
		private string _svenname;
		private long _iregistcapital;
		private string _sregistaddress;
		private string _sbussinesslicencecode;
		private DateTime _dbussinesslicenceexpdate;
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
		private long _iuserid;
		private DateTime _ddate;
		private string _scompanytype;
		private string _sventype;
		private string _sbillrecievephone;
		/// <summary>
		/// 
		/// </summary>
		public long iVendorId
		{
			set{ _ivendorid=value;}
			get{return _ivendorid;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public long iVenClass
		{
			set{ _ivenclass=value;}
			get{return _ivenclass;}
		}
        [Editable(false)]
        public string sVenClass { get; set;}
		/// <summary>
		/// 
		/// </summary>
		public int iDistrict
		{
			set{ _idistrict=value;}
			get{return _idistrict;}
		}
        [Editable(false)]
		/// <summary>
        ///3001: 普通供应商,3002: VIP供应商
		/// </summary>
		public int iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
        [Editable(false)]
		/// <summary>
        /// 1:审核中,2:审核通过,3:禁止
		/// </summary>
		public int iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
        [Editable(false)]
        public string sStatus { get; set;}
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
		public long iRegistCapital
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
		public DateTime dBussinessLicenceExpDate
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
		public long iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
        [Editable(false)]
        public string sLoginId { get; set;}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public DateTime dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public string sCompanyType
		{
			set{ _scompanytype=value;}
			get{return _scompanytype;}
		}
        [Editable(false)]
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

        /// <summary>
        /// 资质照片
        /// </summary>
        public string sPhotos { get; set;}

        [Editable(false)]
        /// <summary>
        /// 商品数
        /// </summary>
        public long Products { get; set; }
        [Editable(false)]
        /// <summary>
        /// 总销量
        /// </summary>
        public Decimal iVolumeSum { get; set;}

        [Editable(false)]
        /// <summary>
        /// 服务费金额
        /// </summary>
        public decimal ServicePrice { get; set;}

        [Editable(false)]
        /// <summary>
        /// 服务到期日
        /// </summary>
        public decimal ServiceDate { get; set;}
		#endregion Model
	}
}

