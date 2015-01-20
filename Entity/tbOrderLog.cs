using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbOrderLog。
	/// </summary>
	[Serializable]
	public partial class tbOrderLog
	{
		public tbOrderLog()
		{}
		#region Model
		private long _iorderlogid;
		private long? _iorderid;
		private long? _iordercancelid;
		private long? _ishopid;
		private long? _ishophistoryid;
		private long? _ipdid;
		private long? _ipdhistoryid;
		private long? _ivendorid;
		private long? _ivenhistoryid;
		private int? _istatus;
		private string _sstatus;
		private string _sname;
		private string _svalue;
		private DateTime? _dvalue;
		private long? _ivalue;
		private decimal? _fvalue;
		private bool _bvalue;
		private int? _istatusnext;
		private string _sstatusnext;
		private bool _bend;
		private DateTime? _ddate;
		private long? _iuserid;
		/// <summary>
		/// 
		/// </summary>
		public long iOrderLogId
		{
			set{ _iorderlogid=value;}
			get{return _iorderlogid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iOrderId
		{
			set{ _iorderid=value;}
			get{return _iorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iOrderCancelId
		{
			set{ _iordercancelid=value;}
			get{return _iordercancelid;}
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
		public int? iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sStatus
		{
			set{ _sstatus=value;}
			get{return _sstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sName
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sValue
		{
			set{ _svalue=value;}
			get{return _svalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dValue
		{
			set{ _dvalue=value;}
			get{return _dvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iValue
		{
			set{ _ivalue=value;}
			get{return _ivalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fValue
		{
			set{ _fvalue=value;}
			get{return _fvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bValue
		{
			set{ _bvalue=value;}
			get{return _bvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iStatusNext
		{
			set{ _istatusnext=value;}
			get{return _istatusnext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sStatusNext
		{
			set{ _sstatusnext=value;}
			get{return _sstatusnext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bEnd
		{
			set{ _bend=value;}
			get{return _bend;}
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
		public long? iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		#endregion Model
	}
}

