using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwDistrict2。
	/// </summary>
	[Serializable]
	public partial class vwDistrict2
	{
		public vwDistrict2()
		{}
		#region Model
		private int _idistrict;
		private string _sprovince;
		private bool _bend;
		private int? _idistrictfatherid;
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
		public string sProvince
		{
			set{ _sprovince=value;}
			get{return _sprovince;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bEnd
		{
			set{ _bend=value;}
			get{return _bend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iDistrictFatherId
		{
			set{ _idistrictfatherid=value;}
			get{return _idistrictfatherid;}
		}
		#endregion Model
	}
}

