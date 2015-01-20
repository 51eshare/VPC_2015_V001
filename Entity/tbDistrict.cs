using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbDistrict。
	/// </summary>
	[Serializable]
	public partial class tbDistrict
	{
		public tbDistrict()
		{}
		#region Model
		private int _idistrict;
		private string _sdistrict;
		private string _sprovince;
		private string _scity;
		private int _idistrictfatherid;
		private string _spostcode;
		private int _igrade;
		private bool _bend;
        [Key]
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
		public string sDistrict
		{
			set{ _sdistrict=value;}
			get{return _sdistrict;}
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
		public string sCity
		{
			set{ _scity=value;}
			get{return _scity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iDistrictFatherId
		{
			set{ _idistrictfatherid=value;}
			get{return _idistrictfatherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPostCode
		{
			set{ _spostcode=value;}
			get{return _spostcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iGrade
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

