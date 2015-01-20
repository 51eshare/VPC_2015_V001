using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbPromotionLog。
	/// </summary>
	[Serializable]
	public partial class tbPromotionLog
	{
		public tbPromotionLog()
		{}
		#region Model
		private long _ipromotionlogid;
		private long? _ipromotionid;
		private int? _istatus;
		private long? _iuserid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long iPromotionLogId
		{
			set{ _ipromotionlogid=value;}
			get{return _ipromotionlogid;}
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
		#endregion Model
	}
}

