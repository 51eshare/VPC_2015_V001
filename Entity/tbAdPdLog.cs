using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbAdPdLog。
	/// </summary>
	[Serializable]
	public partial class tbAdPdLog
	{
		public tbAdPdLog()
		{}
		#region Model
		private long _iadpdlogid;
		private long? _iadpdid;
		private int? _istatus;
		private long? _iuserid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long iAdPdLogId
		{
			set{ _iadpdlogid=value;}
			get{return _iadpdlogid;}
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

