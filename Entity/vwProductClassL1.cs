using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwProductClassL1。
	/// </summary>
	[Serializable]
	public partial class vwProductClassL1
	{
		public vwProductClassL1()
		{}
		#region Model
		private int _ipdclassid;
		private string _cpdclass;
		/// <summary>
		/// 
		/// </summary>
		public int iPdClassId
		{
			set{ _ipdclassid=value;}
			get{return _ipdclassid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cPdClass
		{
			set{ _cpdclass=value;}
			get{return _cpdclass;}
		}
		#endregion Model
	}
}

