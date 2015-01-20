using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbGroupCusPdLog。
	/// </summary>
	[Serializable]
	public partial class tbGroupCusPdLog
	{
		public tbGroupCusPdLog()
		{}
		#region Model
		private long _igroupcuspdlogid;
		private long? _igroupcuspdid;
		private int? _istatus;
		private long? _iuserid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long iGroupCusPdLogId
		{
			set{ _igroupcuspdlogid=value;}
			get{return _igroupcuspdlogid;}
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

