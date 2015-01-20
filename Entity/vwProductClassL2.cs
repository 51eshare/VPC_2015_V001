using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwProductClassL2。
	/// </summary>
	[Serializable]
	public partial class vwProductClassL2
	{
		public vwProductClassL2()
		{}
		#region Model
		private int _ipdclassid;
		private string _cpdclass;
		private long? _ipdfatherid;
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
		/// <summary>
		/// 
		/// </summary>
		public long? iPdFatherId
		{
			set{ _ipdfatherid=value;}
			get{return _ipdfatherid;}
		}
		#endregion Model
	}
}

