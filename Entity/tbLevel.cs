using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbLevel。
	/// </summary>
	[Serializable]
	public partial class tbLevel
	{
		public tbLevel()
		{}
		#region Model
		private int _ilevel;
		private string _sobject;
		private string _slevel;
		/// <summary>
		/// 
		/// </summary>
		public int iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sObject
		{
			set{ _sobject=value;}
			get{return _sobject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sLevel
		{
			set{ _slevel=value;}
			get{return _slevel;}
		}
		#endregion Model
	}
}

