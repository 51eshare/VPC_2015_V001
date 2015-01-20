using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbReview。
	/// </summary>
	[Serializable]
	public partial class tbReview
	{
		public tbReview()
		{}
		#region Model
		private long _ireviewid;
		private long? _iorderid;
		private long? _iuserid;
		private long? _ishopid;
		private long? _ishophistoryid;
		private long? _ipdid;
		private long? _ipdhistoryid;
		private long? _igroupcuspdid;
		private long? _ipromotionid;
		private long? _iadpdid;
		private DateTime? _ddate;
		private string _cmemo;
		private bool _bblock;
		private bool _bconfirm;
		/// <summary>
		/// 
		/// </summary>
		public long iReviewId
		{
			set{ _ireviewid=value;}
			get{return _ireviewid;}
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
		public DateTime? dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cMemo
		{
			set{ _cmemo=value;}
			get{return _cmemo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bBlock
		{
			set{ _bblock=value;}
			get{return _bblock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bConfirm
		{
			set{ _bconfirm=value;}
			get{return _bconfirm;}
		}
		#endregion Model
	}
}

