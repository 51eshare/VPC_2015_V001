using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwReceiveInfo。
	/// </summary>
	[Serializable]
	public partial class vwReceiveInfo
	{
		public vwReceiveInfo()
		{}
		#region Model
		private long? _用户id;
		private string _收货信息;
		private bool _是否默认;
		private long _收货信息id;
		/// <summary>
		/// 
		/// </summary>
		public long? 用户Id
		{
			set{ _用户id=value;}
			get{return _用户id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 收货信息
		{
			set{ _收货信息=value;}
			get{return _收货信息;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 是否默认
		{
			set{ _是否默认=value;}
			get{return _是否默认;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 收货信息Id
		{
			set{ _收货信息id=value;}
			get{return _收货信息id;}
		}
		#endregion Model
	}
}

