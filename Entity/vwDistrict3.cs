using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwDistrict3。
	/// </summary>
	[Serializable]
	public partial class vwDistrict3
	{
		public vwDistrict3()
		{}
		#region Model
		private int _idistrict;
		private string _scity;
		private int? _idistrictfatherid;
		private bool _bend;
		/// <summary>
		/// 
		/// </summary>
		public int iDistrict
		{
			set{ _idistrict=value;}
			get{return _idistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sCity
		{
			set{ _scity=value;}
			get{return _scity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iDistrictFatherId
		{
			set{ _idistrictfatherid=value;}
			get{return _idistrictfatherid;}
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

