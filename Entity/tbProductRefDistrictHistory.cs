using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbProductRefDistrictHistory。
	/// </summary>
	[Serializable]
	public partial class tbProductRefDistrictHistory
	{
		public tbProductRefDistrictHistory()
		{}
		#region Model
		private long _ipdrefdistricthistoryid;
		private long? _ipdrefdistrictid;
		private long? _ipdhistoryid;
		private long? _ipdid;
		private int? _idistrict;
		private string _sdistrict;
		private bool _bsale;
		private long? _iuserid;
		private DateTime? _ddate;
		/// <summary>
		/// 
		/// </summary>
		public long iPdRefDistrictHistoryId
		{
			set{ _ipdrefdistricthistoryid=value;}
			get{return _ipdrefdistricthistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdRefDistrictId
		{
			set{ _ipdrefdistrictid=value;}
			get{return _ipdrefdistrictid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdHistoryId
		{
			set{ _ipdhistoryid=value;}
			get{return _ipdhistoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdId
		{
			set{ _ipdid=value;}
			get{return _ipdid;}
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
		public string sDistrict
		{
			set{ _sdistrict=value;}
			get{return _sdistrict;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bSale
		{
			set{ _bsale=value;}
			get{return _bsale;}
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
		#endregion Model
	}
}

