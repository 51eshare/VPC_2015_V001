using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbRecieveInfo。
	/// </summary>
	[Serializable]
	public partial class tbRecieveInfo
	{
		public tbRecieveInfo()
		{
            _idistrictid = 0;
        }
		#region Model
		private long _irecieveinfoid;
		private long _iuserid;
		private int _idistrictid;
		private string _srecievename;
		private string _saddress;
		private string _sphonenum;
		private string _spostcode;
		private bool _bdefault;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iRecieveInfoId
		{
			set{ _irecieveinfoid=value;}
			get{return _irecieveinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iDistrictId
		{
			set{ _idistrictid=value;}
			get{return _idistrictid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sRecieveName
		{
			set{ _srecievename=value;}
			get{return _srecievename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sAddress
		{
			set{ _saddress=value;}
			get{return _saddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sPhoneNum
		{
			set{ _sphonenum=value;}
			get{return _sphonenum;}
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
		public bool bDefault
		{
			set{ _bdefault=value;}
			get{return _bdefault;}
		}
		#endregion Model
	}
}

