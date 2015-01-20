using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbProduct。
	/// </summary>
	[Serializable]
	public partial class tbProduct
	{
		public tbProduct()
		{
            iShareNum = 0;
        }
        [Editable(false)]
        /// <summary>
        /// 总分享次数
        /// </summary>
        public int iShareNum { get; set; }
		#region Model
		private long _ipdid;
		private long _ivendorid;
        private int _iselltype=1;
		private int _idistrict;
		private int _ipdclassid;
		private bool _bgift;
		private string _spdname;
		private string _spdbrand;
		private string _spdstd;
		private string _spdpackage;
		private string _squalityperiod;
		private string _sbarcode;
		private bool _bimport;
		private int _iquantity;
		private decimal _fpurprice;
		private decimal _fcommission;
		private decimal _fsaprice;
		private decimal _fbdprice;
		private DateTime _dvaliddate;
		private long _iuserid;
		private DateTime _ddate=DateTime.Now;
		private int _istatus;
		private long _iordernum;
		private long _ireviewnum;
		private long _iratenum;
		private long _ipdgood;
		private long _ipdnormal;
		private long _ipdbad;
		private long _iservicegood;
		private long _iservicenormal;
		private long _iservicebad;
		private long _ilogisticgood;
		private long _ilogisticnormal;
		private long _ilogisticbad;
		private string _smemo;
		private long _ipoint;
		private bool _bpointonly;
        private string _sImagePath;
        private long _ishoprefpdid;
        [Editable(false)]
        public long iShopRefPdId
        {
            get { return _ishoprefpdid; }
            set { _ishoprefpdid = value; }
        }
        public string sImagePath
        {
            get { return _sImagePath; }
            set { _sImagePath = value; }
        }
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iPdId
		{
			set{ _ipdid=value;}
			get{return _ipdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iVendorId
		{
			set{ _ivendorid=value;}
			get{return _ivendorid;}
		}
        [Editable(false)]
        public string sVenName { get; set;}
		

        /// <summary>
		/// 
		/// </summary>
        public int iSellType
		{
            set { _iselltype = value; }
            get { return _iselltype; }
		}
		/// <summary>
		/// 
		/// </summary>
		public int iDistrict
		{
			set{ _idistrict=value;}
			get{return _idistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iPdClassId
		{
			set{ _ipdclassid=value;}
			get{return _ipdclassid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bGift
		{
			set{ _bgift=value;}
			get{return _bgift;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPdName
		{
			set{ _spdname=value;}
			get{return _spdname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPdBrand
		{
			set{ _spdbrand=value;}
			get{return _spdbrand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPdStd
		{
			set{ _spdstd=value;}
			get{return _spdstd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPdPackage
		{
			set{ _spdpackage=value;}
			get{return _spdpackage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sQualityPeriod
		{
			set{ _squalityperiod=value;}
			get{return _squalityperiod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sbarCode
		{
			set{ _sbarcode=value;}
			get{return _sbarcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bImport
		{
			set{ _bimport=value;}
			get{return _bimport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iQuantity
		{
			set{ _iquantity=value;}
			get{return _iquantity;}
		}

        #region 供应商结算价格
        /// <summary>
		/// 供应商结算价格
		/// </summary>
		public decimal fPurPrice
		{
			set{ _fpurprice=value;}
			get{return _fpurprice;}
		}
        #endregion 

        #region 
        [Editable(false)]
        /// <summary>
        ///小伙伴佣金 
		/// </summary>
		public decimal fCommission
		{
			set{ _fcommission=value;}
			get{return _fcommission;}
		}
        #endregion

        /// <summary>
        /// 零售价
		/// </summary>
		public decimal fSaPrice
		{
			set{ _fsaprice=value;}
			get{return _fsaprice;}
		}
		/// <summary>
        /// 市场价
		/// </summary>
		public decimal fBdPrice
		{
			set{ _fbdprice=value;}
			get{return _fbdprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dValidDate
		{
			set{ _dvaliddate=value;}
			get{return _dvaliddate;}
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
        /// 建档日期
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
        public string sStatus
        {
            get;
            set;
        }
        [Editable(false)]
		/// <summary>
        /// 成交总数量
		/// </summary>
		public long iOrderNum
		{
			set{ _iordernum=value;}
			get{return _iordernum;}
		}
        [Editable(false)]
		/// <summary>
        /// 评论总数量
		/// </summary>
		public long iReviewNum
		{
			set{ _ireviewnum=value;}
			get{return _ireviewnum;}
		}
        [Editable(false)]
		/// <summary>
        /// 点击总数量
		/// </summary>
		public long iRateNum
		{
			set{ _iratenum=value;}
			get{return _iratenum;}
		}
        [Editable(false)]
		/// <summary>
        /// 商品好评总数量
		/// </summary>
		public long iPdGood
		{
			set{ _ipdgood=value;}
			get{return _ipdgood;}
		}
        [Editable(false)]
		/// <summary>
        /// 商品中评总数量
		/// </summary>
		public long iPdNormal
		{
			set{ _ipdnormal=value;}
			get{return _ipdnormal;}
		}
        [Editable(false)]
		/// <summary>
        /// 商品差评总数量
		/// </summary>
		public long iPdBad
		{
			set{ _ipdbad=value;}
			get{return _ipdbad;}
		}
        [Editable(false)]
		/// <summary>
        /// 服务好评总数量
		/// </summary>
		public long iServiceGood
		{
			set{ _iservicegood=value;}
			get{return _iservicegood;}
		}
        [Editable(false)]
		/// <summary>
        /// 服务中评总数量
		/// </summary>
		public long iServiceNormal
		{
			set{ _iservicenormal=value;}
			get{return _iservicenormal;}
		}
        [Editable(false)]
		/// <summary>
        /// 服务差评总数量
		/// </summary>
		public long iServiceBad
		{
			set{ _iservicebad=value;}
			get{return _iservicebad;}
		}
        [Editable(false)]
		/// <summary>
        /// 物流好评总数量
		/// </summary>
		public long iLogisticGood
		{
			set{ _ilogisticgood=value;}
			get{return _ilogisticgood;}
		}
        [Editable(false)]
		/// <summary>
        /// 物流中评总数量
		/// </summary>
		public long iLogisticNormal
		{
			set{ _ilogisticnormal=value;}
			get{return _ilogisticnormal;}
		}
        [Editable(false)]
		/// <summary>
        /// 物流差评总数量
		/// </summary>
		public long iLogisticBad
		{
			set{ _ilogisticbad=value;}
			get{return _ilogisticbad;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sMemo
		{
			set{ _smemo=value;}
			get{return _smemo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iPoint
		{
			set{ _ipoint=value;}
			get{return _ipoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bPointOnly
		{
			set{ _bpointonly=value;}
			get{return _bpointonly;}
		}
        [Editable(false)]
        public string reason { get; set;}

        private long ishopid = 0;
        /// <summary>
        /// 店铺ID
        /// </summary>
        [Editable(false)]
        public long iShopId
        {
            get { return ishopid; }
            set { ishopid = value; }
        }
		#endregion Model
	}

    public partial class tbProductImages
    {
        public tbProductImages()
        {
            Product = new tbProduct();
            Images = new List<tbImage>();
        }
        /// <summary>
        /// 商品信息
        /// </summary>
        public tbProduct Product { get; set;}
        /// <summary>
        /// 图片列表
        /// </summary>
        public IEnumerable<tbImage> Images { get; set;} 
    }
}

