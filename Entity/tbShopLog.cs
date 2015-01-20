using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbShopLog。
	/// </summary>
	[Serializable]
	public partial class tbShopLog
	{
		public tbShopLog()
		{}
		#region Model
		private long _ishoplogid;
		private long? _iuserid;
		private long? _ishopid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long iShopLogId
		{
			set{ _ishoplogid=value;}
			get{return _ishoplogid;}
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
		public long? iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
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

