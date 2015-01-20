using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwDistrict1。
	/// </summary>
	[Serializable]
	public partial class vwDistrict1
	{
		public vwDistrict1()
		{}
		#region Model
		private int _idistrict;
		private string _sdistrict;
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
		public string sDistrict
		{
			set{ _sdistrict=value;}
			get{return _sdistrict;}
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

