using System;
using System.Data;
using Dapper;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类tbAdPd。
	/// </summary>
	[Serializable]
	public partial class tbAdPd
	{
		public tbAdPd()
		{}
		#region Model
		private long _iadpdid;
		private long _ipdid;
		private decimal _fpurprice;
		private decimal _fcommission;
		private decimal _fsaprice;
		private DateTime _dbegindate;
		private DateTime _denddate;
		private int _istatus=1;
		private long _iuserid;
		private DateTime _ddate;
		private long _iordernum;
		private long _iratenum;
		/// <summary>
		/// 
		/// </summary>
        [Key]
		public long iAdPdId
		{
			set{ _iadpdid=value;}
			get{return _iadpdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long iPdId
		{
			set{ _ipdid=value;}
			get{return _ipdid;}
		}
        [Editable(false)]
        public string sPdName { get; set;}
		/// <summary>
        /// 供应商结算价
		/// </summary>
		public decimal fPurPrice
		{
			set{ _fpurprice=value;}
			get{return _fpurprice;}
		}
		/// <summary>
        /// 佣金
		/// </summary>
        [Editable(false)]
		public decimal fCommission
		{
            get { return _fsaprice - _fpurprice; }
		}
		/// <summary>
        /// 零售价
		/// </summary>
		public decimal fSaPrice
		{
			set{ _fsaprice=value;}
			get{return _fsaprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dBeginDate
		{
			set{ _dbegindate=value;}
			get{return _dbegindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dEndDate
		{
			set{ _denddate=value;}
			get{return _denddate;}
		}
		/// <summary>
		/// 1：无效，1：有效
		/// </summary>
        [Editable(false)]
		public int iStatus
		{
			get{
                return _istatus;
            }
            set {
                _istatus = value;
            }
		}
        [Editable(false)]
        public string siStatus { get; set;}

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
        [Editable(false)]
		public DateTime dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public long iOrderNum
		{
			set{ _iordernum=value;}
			get{return _iordernum;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public long iRateNum
		{
			set{ _iratenum=value;}
			get{return _iratenum;}
		}
		#endregion Model
	}
}

