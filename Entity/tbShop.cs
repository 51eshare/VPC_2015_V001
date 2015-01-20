using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbShop。
	/// </summary>
	[Serializable]
	public partial class tbShop
	{
		public tbShop()
        {
            iShareNum = 0;
            dBussinessLicenceExpDate = DateTime.Now;
            iRegistCapital = 0;
            _cownermail = string.Empty;
        }

        public string sImagePath { get; set;}

         /// <summary>
        /// 帐号名称
        /// </summary>
        public string sBankAccountName { get; set;}
        /// <summary>
        /// 银行帐号
        /// </summary>
        public string sBankAccountCode { get; set;}

        /// <summary>
        /// 开户银行（包含支行）
        /// </summary>
        public string sBankName { get; set;}
        /// <summary>
        /// 税号
        /// </summary>
        public string sTaxCode { get; set;}
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string sOrganizationCode { get; set;}
        /// <summary>
        /// 营业执照到期日
        /// </summary>
        public DateTime dBussinessLicenceExpDate { get; set;}
        /// <summary>
        /// 营业执照编号
        /// </summary>
        public string sBussinessLicenceCode { get; set;}
        /// <summary>
        /// 供应商注册地址
        /// </summary>
        public string sRegistAddress { get; set;}
        /// <summary>
        /// 注册资金
        /// </summary>
        public int iRegistCapital { get; set;}
        [Editable(false)]
        /// <summary>
        /// 企业名称
        /// </summary>
        public string sPartnerName { get; set;}
        /// <summary>
        /// 总分享次数
        /// </summary>
        public int iShareNum { get; set;}
		#region Model
		private long _ishopid;
		private string _sshopname;
		private string _sshopdesc;
		private long _iuserid;
		private DateTime _ddate= DateTime.Now;
		private int _istatus=2;
		private int _ilevel;
		private int _idistrict;
		private long _icollection;
		private long _ivolumenum;
		private decimal _ivolumesum;
		private long _ivolumenummonth1;
		private decimal _ivolumesummonth1;
		private long _ivolumenummonth3;
		private decimal _ivolumesummonth3;
		private string _cownername;
		private string _cowneraccout;
		private string _cownermp;
		private string _cownermail;
		private long _iproductnum;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sShopName
		{
			set{ _sshopname=value;}
			get{return _sshopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sShopDesc
		{
			set{ _sshopdesc=value;}
			get{return _sshopdesc;}
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
		public int iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
        [Editable(false)]
        /// <summary>
        /// 
        /// </summary>
        public string sStatus { get; set;}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public int iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
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
        /// 总收藏量
		/// </summary>
		public long iCollection
		{
			set{ _icollection=value;}
			get{return _icollection;}
		}
        [Editable(false)]
		/// <summary>
        /// 总成交数量
		/// </summary>
		public long iVolumeNum
		{
			set{ _ivolumenum=value;}
			get{return _ivolumenum;}
		}
        [Editable(false)]
		/// <summary>
        /// 总成交金额
		/// </summary>
		public decimal iVolumeSum
		{
			set{ _ivolumesum=value;}
			get{return _ivolumesum;}
		}
        [Editable(false)]
		/// <summary>
        /// 当月成交数量
		/// </summary>
		public long iVolumeNumMonth1
		{
			set{ _ivolumenummonth1=value;}
			get{return _ivolumenummonth1;}
		}
        [Editable(false)]
		/// <summary>
        /// 当月成交金额
		/// </summary>
		public decimal iVolumeSumMonth1
		{
			set{ _ivolumesummonth1=value;}
			get{return _ivolumesummonth1;}
		}
        [Editable(false)]
		/// <summary>
        /// 近3个月成交数量
		/// </summary>
		public long iVolumeNumMonth3
		{
			set{ _ivolumenummonth3=value;}
			get{return _ivolumenummonth3;}
		}
        [Editable(false)]
		/// <summary>
        /// 近3个月成交金额
		/// </summary>
		public decimal iVolumeSumMonth3
		{
			set{ _ivolumesummonth3=value;}
			get{return _ivolumesummonth3;}
		}
		/// <summary>
        /// 微店主姓名
		/// </summary>
		public string cOwnerName
		{
			set{ _cownername=value;}
			get{return _cownername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerAccout
		{
			set{ _cowneraccout=value;}
			get{return _cowneraccout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerMP
		{
			set{ _cownermp=value;}
			get{return _cownermp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerMail
		{
			set{ _cownermail=value;}
			get{return _cownermail;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public long iProductNum
		{
			set{ _iproductnum=value;}
			get{return _iproductnum;}
		}
        [Editable(false)]
        /// <summary>
        /// 会员账号名称
        /// </summary>
        public string sLoginId { get; set;}

		#endregion Model
	}
}

