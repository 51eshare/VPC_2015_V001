using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbSystem。
	/// </summary>
	[Serializable]
	public partial class tbSystem
	{
		public tbSystem()
		{}
		#region Model
		private long _isysid;
		private string _ssystext;
		private string _svalue;
		private long? _ivalue;
		private decimal? _fvalue;
		private DateTime? _dvalue;
		private bool _bvalue;
		/// <summary>
		/// 
		/// </summary>
		public long iSysId
		{
			set{ _isysid=value;}
			get{return _isysid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sSystext
		{
			set{ _ssystext=value;}
			get{return _ssystext;}
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
		public DateTime? dValue
		{
			set{ _dvalue=value;}
			get{return _dvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bValue
		{
			set{ _bvalue=value;}
			get{return _bvalue;}
		}
		#endregion Model
	}
}

