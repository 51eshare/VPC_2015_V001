using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbPoint。
	/// </summary>
	[Serializable]
	public partial class tbPoint
	{
		public tbPoint()
		{}
		#region Model
		private long _ipointid;
        private long _iuserid;

        public long iUserId
        {
            get { return _iuserid; }
            set { _iuserid = value; }
        }
		private long _iponit;
		private DateTime _ddate;
		private long _iorderid;
		private string _smemo;
		/// <summary>
		/// 
		/// </summary>
		public long iPointId
		{
			set{ _ipointid=value;}
			get{return _ipointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iPonit
		{
			set{ _iponit=value;}
			get{return _iponit;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public DateTime dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iOrderId
		{
			set{ _iorderid=value;}
			get{return _iorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sMemo
		{
			set{ _smemo=value;}
			get{return _smemo;}
		}
		#endregion Model
	}
}

