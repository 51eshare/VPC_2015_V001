using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbOrderCancel。
	/// </summary>
	[Serializable]
	public partial class tbOrderCancel
	{
		public tbOrderCancel()
		{}
		#region Model
		private long _iordercancelid;
		private long? _iorderid;
		private bool _bchange;
		private decimal? _fpurprice;
		private decimal? _fcommission;
		private decimal? _fsaprice;
		private long? _iordernum;
		private decimal? _fpurpricesum;
		private decimal? _fcommissionsum;
		private decimal? _fsapricesum;
		private DateTime? _ddate;
		private int? _idistrictid;
		private string _srecievename;
		private string _saddress;
		private string _sphonenum;
		private string _spostcode;
		private bool _bbill;
		private int? _istatus;
		private DateTime? _drecieveconfirmdate;
		private bool _bautorecieveconfirm;
		private long? _ipoint;
		private long? _ishoprefpdid;
		private long? _ishoprefpdhistoryid;
		/// <summary>
		/// 
		/// </summary>
		public long iOrderCancelId
		{
			set{ _iordercancelid=value;}
			get{return _iordercancelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iOrderId
		{
			set{ _iorderid=value;}
			get{return _iorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bChange
		{
			set{ _bchange=value;}
			get{return _bchange;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fPurPrice
		{
			set{ _fpurprice=value;}
			get{return _fpurprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fCommission
		{
			set{ _fcommission=value;}
			get{return _fcommission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fSaPrice
		{
			set{ _fsaprice=value;}
			get{return _fsaprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iOrderNum
		{
			set{ _iordernum=value;}
			get{return _iordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fPurPriceSum
		{
			set{ _fpurpricesum=value;}
			get{return _fpurpricesum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fCommissionSum
		{
			set{ _fcommissionsum=value;}
			get{return _fcommissionsum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? fSaPriceSum
		{
			set{ _fsapricesum=value;}
			get{return _fsapricesum;}
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
		public int? iDistrictId
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
		public bool bBill
		{
			set{ _bbill=value;}
			get{return _bbill;}
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
		public DateTime? dRecieveConfirmDate
		{
			set{ _drecieveconfirmdate=value;}
			get{return _drecieveconfirmdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool bAutoRecieveConfirm
		{
			set{ _bautorecieveconfirm=value;}
			get{return _bautorecieveconfirm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPoint
		{
			set{ _ipoint=value;}
			get{return _ipoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopRefPdId
		{
			set{ _ishoprefpdid=value;}
			get{return _ishoprefpdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iShopRefPdHistoryId
		{
			set{ _ishoprefpdhistoryid=value;}
			get{return _ishoprefpdhistoryid;}
		}
		#endregion Model
	}
}

