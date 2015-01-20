using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbUserType。
	/// </summary>
	[Serializable]
	public partial class tbUserType
	{
		public tbUserType()
		{}
		#region Model
		private long _iusertypeid;
		private string _susertype;
		/// <summary>
		/// 用户类型ID
		/// </summary>
		public long iUserTypeId
		{
			set{ _iusertypeid=value;}
			get{return _iusertypeid;}
		}
		/// <summary>
		/// 用户类型
		/// </summary>
		public string sUserType
		{
			set{ _susertype=value;}
			get{return _susertype;}
		}
		#endregion Model
	}
}

