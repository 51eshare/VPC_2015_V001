using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbLoginLog。
	/// </summary>
	[Serializable]
	public partial class tbLoginLog
	{
		public tbLoginLog()
		{}
		#region Model
		private long _tbloginid;
		private long? _iuserid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long tbLoginId
		{
			set{ _tbloginid=value;}
			get{return _tbloginid;}
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

