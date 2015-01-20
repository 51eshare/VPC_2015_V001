using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbShopHistory。
	/// </summary>
	[Serializable]
	public partial class tbShopHistory
	{
		public tbShopHistory()
		{}
		#region Model
		private long _ishophistoryid;
		private long? _ishopid;
		private string _sshopname;
		private string _sshopdesc;
		private long? _iuserid;
		private DateTime? _ddate;
		private int? _istatus;
		private int? _ilevel;
		private int? _idistrict;
		private long? _icollection;
		private long? _iclick;
		private long? _ivolumenum;
		private decimal? _ivolumesum;
		private long? _ivolumenummonth1;
		private decimal? _ivolumesummonth1;
		private long? _ivolumenummonth3;
		private decimal? _ivolumesummonth3;
		private string _cownername;
		private string _cowneraccout;
		private string _cownermp;
		private string _cownermail;
		private long? _iproductnum;
		/// <summary>
		/// 
		/// </summary>
		public long iShopHistoryId
		{
			set{ _ishophistoryid=value;}
			get{return _ishophistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sShopName
		{
			set{ _sshopname=value;}
			get{return _sshopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sShopDesc
		{
			set{ _sshopdesc=value;}
			get{return _sshopdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iStatus
		{
			set{ _istatus=value;}
			get{return _istatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iDistrict
		{
			set{ _idistrict=value;}
			get{return _idistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iCollection
		{
			set{ _icollection=value;}
			get{return _icollection;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iClick
		{
			set{ _iclick=value;}
			get{return _iclick;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVolumeNum
		{
			set{ _ivolumenum=value;}
			get{return _ivolumenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? iVolumeSum
		{
			set{ _ivolumesum=value;}
			get{return _ivolumesum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVolumeNumMonth1
		{
			set{ _ivolumenummonth1=value;}
			get{return _ivolumenummonth1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? iVolumeSumMonth1
		{
			set{ _ivolumesummonth1=value;}
			get{return _ivolumesummonth1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iVolumeNumMonth3
		{
			set{ _ivolumenummonth3=value;}
			get{return _ivolumenummonth3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? iVolumeSumMonth3
		{
			set{ _ivolumesummonth3=value;}
			get{return _ivolumesummonth3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerName
		{
			set{ _cownername=value;}
			get{return _cownername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerAccout
		{
			set{ _cowneraccout=value;}
			get{return _cowneraccout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerMP
		{
			set{ _cownermp=value;}
			get{return _cownermp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cOwnerMail
		{
			set{ _cownermail=value;}
			get{return _cownermail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iProductNum
		{
			set{ _iproductnum=value;}
			get{return _iproductnum;}
		}
		#endregion Model

	}
}

