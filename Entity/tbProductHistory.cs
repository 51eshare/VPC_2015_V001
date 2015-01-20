using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbProductHistory。
	/// </summary>
	[Serializable]
	public partial class tbProductHistory
	{
		public tbProductHistory()
		{}
		#region Model
		private long _ipdhistoryid;
		private long? _ipdid;
		private long? _ivendorid;
		private long? _ivenhistoryid;
		private int? _idistrict;
		private string _sdistrict;
		private int? _ipdclassid;
		private bool _bgift;
		private bool _bpromotion;
		private string _spdname;
		private string _spdbrand;
		private string _spdstd;
		private string _spdcpu;
		private long? _ipdbasenum;
		private string _spdpackage;
		private string _squalityperiod;
		private string _sbarcode;
		private bool _bimport;
		private int? _iquantity;
		private decimal? _fpurprice;
		private decimal? _fcommission;
		private decimal? _fsaprice;
		private decimal? _fbdprice;
		private DateTime? _dvaliddate;
		private long? _iuserid;
		private DateTime? _ddate;
		private int? _istatus;
		private long? _iordernum;
		private long? _ireviewnum;
		private long? _iratenum;
		private long? _ipdgood;
		private long? _ipdnormal;
		private long? _ipdbad;
		private long? _iservicegood;
		private long? _iservicenormal;
		private long? _iservicebad;
		private long? _ilogisticgood;
		private long? _ilogisticnormal;
		private long? _ilogisticbad;
		private string _smemo;
		private long? _ipoint;
		private bool _bpointonly;
		/// <summary>
		/// 
		/// </summary>
		public long iPdHistoryId
		{
			set{ _ipdhistoryid=value;}
			get{return _ipdhistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdId
		{
			set{ _ipdid=value;}
			get{return _ipdid;}
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
		public long? iVenHistoryId
		{
			set{ _ivenhistoryid=value;}
			get{return _ivenhistoryid;}
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
		public string sDistrict
		{
			set{ _sdistrict=value;}
			get{return _sdistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iPdClassId
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
		public bool bPromotion
		{
			set{ _bpromotion=value;}
			get{return _bpromotion;}
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
		public string sPdCpu
		{
			set{ _spdcpu=value;}
			get{return _spdcpu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdBaseNum
		{
			set{ _ipdbasenum=value;}
			get{return _ipdbasenum;}
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
		public int? iQuantity
		{
			set{ _iquantity=value;}
			get{return _iquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fPurPrice
		{
			set{ _fpurprice=value;}
			get{return _fpurprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fCommission
		{
			set{ _fcommission=value;}
			get{return _fcommission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fSaPrice
		{
			set{ _fsaprice=value;}
			get{return _fsaprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fBdPrice
		{
			set{ _fbdprice=value;}
			get{return _fbdprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dValidDate
		{
			set{ _dvaliddate=value;}
			get{return _dvaliddate;}
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
		public int? iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iOrderNum
		{
			set{ _iordernum=value;}
			get{return _iordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iReviewNum
		{
			set{ _ireviewnum=value;}
			get{return _ireviewnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iRateNum
		{
			set{ _iratenum=value;}
			get{return _iratenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdGood
		{
			set{ _ipdgood=value;}
			get{return _ipdgood;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdNormal
		{
			set{ _ipdnormal=value;}
			get{return _ipdnormal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdBad
		{
			set{ _ipdbad=value;}
			get{return _ipdbad;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iServiceGood
		{
			set{ _iservicegood=value;}
			get{return _iservicegood;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iServiceNormal
		{
			set{ _iservicenormal=value;}
			get{return _iservicenormal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iServiceBad
		{
			set{ _iservicebad=value;}
			get{return _iservicebad;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iLogisticGood
		{
			set{ _ilogisticgood=value;}
			get{return _ilogisticgood;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iLogisticNormal
		{
			set{ _ilogisticnormal=value;}
			get{return _ilogisticnormal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iLogisticBad
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
		public long? iPoint
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
		#endregion Model
	}
}

