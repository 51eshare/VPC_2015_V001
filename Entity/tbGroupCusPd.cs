using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbGroupCusPd。
	/// </summary>
	[Serializable]
	public partial class tbGroupCusPd
	{
		public tbGroupCusPd()
		{}
		#region Model
		private long _igroupcuspdid;
		private long? _ipdid;
		private long? _ipdhistoryid;
		private int? _ipdclassid;
		private decimal? _fpurprice;
		private decimal? _fcommission;
		private decimal? _fsaprice;
		private decimal? _fbdprice;
		private DateTime? _dbegindate;
		private DateTime? _denddate;
		private int? _istatus;
		private long? _iuserid;
		private DateTime? _ddate;
		private long? _ibasequantity;
		private long? _iordernum;
		private long? _iratenum;
		/// <summary>
		/// 
		/// </summary>
		public long iGroupCusPdId
		{
			set{ _igroupcuspdid=value;}
			get{return _igroupcuspdid;}
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
		public int? iPdClassId
		{
			set{ _ipdclassid=value;}
			get{return _ipdclassid;}
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
		public DateTime? dBeginDate
		{
			set{ _dbegindate=value;}
			get{return _dbegindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dEndDate
		{
			set{ _denddate=value;}
			get{return _denddate;}
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
		public long? iBaseQuantity
		{
			set{ _ibasequantity=value;}
			get{return _ibasequantity;}
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
		public long? iRateNum
		{
			set{ _iratenum=value;}
			get{return _iratenum;}
		}
		#endregion Model
	}
}

