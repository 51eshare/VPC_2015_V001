using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbProductClass。
	/// </summary>
	[Serializable]
	public partial class tbProductClass
	{
		public tbProductClass()
		{}
		#region Model
		private int _ipdclassid;
		private string _cpdclass;
		private long _ipdfatherid;
		private int _igrade;
		private bool _bend;
		private int _idiscount;
        [Key]
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
		public long iPdFatherId
		{
			set{ _ipdfatherid=value;}
			get{return _ipdfatherid;}
		}
		/// <summary>
        /// 级次
		/// </summary>
		public int iGrade
		{
			set{ _igrade=value;}
			get{return _igrade;}
		}
		/// <summary>
        /// 是否末级
		/// </summary>
		public bool bEnd
		{
			set{ _bend=value;}
			get{return _bend;}
		}
		/// <summary>
        /// 扣率
		/// </summary>
		public int iDiscount
		{
			set{ _idiscount=value;}
			get{return _idiscount;}
		}
		#endregion Model
	}
}

