using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbVendorClass。
	/// </summary>
	[Serializable]
	public partial class tbVendorClass
	{
		public tbVendorClass()
		{}
		#region Model
		private long _ivenclassid;
		private string _cvenclass;
		private long? _ivenfatherid;
		private int? _igrade;
		private bool _bend;
		/// <summary>
		/// 
		/// </summary>
		public long iVenClassId
		{
			set{ _ivenclassid=value;}
			get{return _ivenclassid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cVenClass
		{
			set{ _cvenclass=value;}
			get{return _cvenclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVenFatherId
		{
			set{ _ivenfatherid=value;}
			get{return _ivenfatherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iGrade
		{
			set{ _igrade=value;}
			get{return _igrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bEnd
		{
			set{ _bend=value;}
			get{return _bend;}
		}
		#endregion Model
	}
}

