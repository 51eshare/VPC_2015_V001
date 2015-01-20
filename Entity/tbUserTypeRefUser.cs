using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbUserTypeRefUser。
	/// </summary>
	[Serializable]
	public partial class tbUserTypeRefUser
	{
		public tbUserTypeRefUser()
		{}
		#region Model
		private long _iusertyperefuserid;
		private long _iuserid;
		private long _iusertypeid;
		private long? _ivendorid;
		private bool _bvendormaster= false;
		private bool _bactive= false;
		private int _istatus;
		private long? _ishopid;
		/// <summary>
		/// 用户关系ID
		/// </summary>
		public long iUserTypeRefUserId
		{
			set{ _iusertyperefuserid=value;}
			get{return _iusertyperefuserid;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public long iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iUserTypeId
		{
			set{ _iusertypeid=value;}
			get{return _iusertypeid;}
		}
		/// <summary>
		/// 供应商ID
		/// </summary>
		public long? iVendorId
		{
			set{ _ivendorid=value;}
			get{return _ivendorid;}
		}
		/// <summary>
		/// 是否为供应商主关联帐号；0-非主帐号，1-主帐号
		/// </summary>
		public bool bVendorMaster
		{
			set{ _bvendormaster=value;}
			get{return _bvendormaster;}
		}
		/// <summary>
		/// 是否正常使用，0-不能使用，1-可以使用
		/// </summary>
		public bool bActive
		{
			set{ _bactive=value;}
			get{return _bactive;}
		}
		/// <summary>
		/// 审批状态
		/// </summary>
		public int iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
		}
		#endregion Model
	}
}

