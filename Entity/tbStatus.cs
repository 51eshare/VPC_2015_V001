using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbStatus。
	/// </summary>
	[Serializable]
	public partial class tbStatus
	{
		public tbStatus()
		{}
		#region Model
		private int _istatus;
		private string _sobject;
		private string _sstatus;
        /// <summary>
        /// 状态类型
        /// </summary>
        public int StateType { get; set;}
        
        [Key]
		/// <summary>
		///状态ID 
		/// </summary>
		public int iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 状态类别描述
		/// </summary>
		public string sObject
		{
			set{ _sobject=value;}
			get{return _sobject;}
		}
		/// <summary>
		/// 状态值描述
		/// </summary>
		public string sStatus
		{
			set{ _sstatus=value;}
			get{return _sstatus;}
		}
        /// <summary>
        /// 状态值
        /// </summary>
        public int StateValue { get; set;}
		#endregion Model
	}
}

