using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbShopRefProductHistory。
	/// </summary>
	[Serializable]
	public partial class tbShopRefProductHistory
	{
		public tbShopRefProductHistory()
		{}
		#region Model
		private long _ishoprefpdhistoryid;
		private long? _ishoprefpdid;
		private long? _iuserid;
		private long? _ishopid;
		private long? _ishophistoryid;
		private long? _ipdid;
		private long? _ipdhistoryid;
		private long? _igroupcuspdid;
		private long? _ipromotionid;
		private long? _iadpdid;
		private decimal? _fpurprice;
		private decimal? _fcommission;
		private decimal? _fsaprice;
		private decimal? _fbdprice;
		private bool _bactive;
		private DateTime? _ddate;
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
		private long? _ipoint;
		private bool _bpointonly;
		private int? _istatus;
		/// <summary>
		/// 
		/// </summary>
		public long iShopRefPdHistoryId
		{
			set{ _ishoprefpdhistoryid=value;}
			get{return _ishoprefpdhistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopRefPdId
		{
			set{ _ishoprefpdid=value;}
			get{return _ishoprefpdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iUserid
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopHistoryId
		{
			set{ _ishophistoryid=value;}
			get{return _ishophistoryid;}
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
		public long? iPdHistoryId
		{
			set{ _ipdhistoryid=value;}
			get{return _ipdhistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iGroupCusPdId
		{
			set{ _igroupcuspdid=value;}
			get{return _igroupcuspdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPromotionId
		{
			set{ _ipromotionid=value;}
			get{return _ipromotionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iAdPdId
		{
			set{ _iadpdid=value;}
			get{return _iadpdid;}
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
		public bool bActive
		{
			set{ _bactive=value;}
			get{return _bactive;}
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
		/// <summary>
		/// 
		/// </summary>
		public int? istatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		#endregion Model
	}
}

