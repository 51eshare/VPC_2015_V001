using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbOrder。
	/// </summary>
	[Serializable]
	public partial class tbOrder
	{
		public tbOrder()
		{}
		#region Model
		private long _iorderid;
		private long? _iuserid;
        private long? _ishoprefpdid;
		private decimal? _fpurprice;
		private decimal? _fcommission;
		private decimal? _fsaprice;
		private long? _iordernum;
		private decimal? _fpurpricesum;
		private decimal? _fcommissionsum;
		private decimal? _fsapricesum;
		private DateTime? _ddate;
		private int? _idistrictid;
		private bool _bbill;
        public string sBill
        {
            get {
                return _bbill ? "是" : "否";
            }
        }
		private int? _istatus=1;
        public string sStatus { get; set; }

		private DateTime? _drecieveconfirmdate;
		private bool _bautorecieveconfirm;
		private long? _ipoint;
		private string _smemo;
        private int iselltype=1;

        public string sPdName { get; set;}
        private string _sordernum = Guid.NewGuid().ToString();

        /// <summary>
        /// 购物车ID
        /// </summary>
        public long iScId { get; set;}

        /// <summary>
        /// 订单标号
        /// </summary>
        public string sOrderNum
        {
            get { return _sordernum; }
            set { _sordernum = value; }
        }
        /// <summary>
        /// 商品销售方式，
        /// 1:正常销售、2：团购、3：促销、4：广告
        /// </summary>
        public int iSellType
        {
            get { return iselltype; }
            set { iselltype = value; }
        }
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iOrderId
		{
			set{ _iorderid=value;}
			get{return _iorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iUserid
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}

        [Editable(false)]
        public string sLoginId { get; set;}
		/// <summary>
		/// 
		/// </summary>
        public long? iShopRefPdId
		{
            set { _ishoprefpdid = value; }
            get { return _ishoprefpdid; }
		}
        public string sShopName { get; set; }
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
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public decimal? fPurPriceSum
		{
			set{ _fpurpricesum=value;}
			get{return _fpurpricesum;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public decimal? fCommissionSum
		{
			set{ _fcommissionsum=value;}
			get{return _fcommissionsum;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public decimal? fSaPriceSum
		{
			set{ _fsapricesum=value;}
			get{return _fsapricesum;}
		}
        [Editable(false)]
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
		public bool bBill
		{
			set{ _bbill=value;}
			get{return _bbill;}
		}
        [Editable(false)]
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
		public string sMemo
		{
			set{ _smemo=value;}
			get{return _smemo;}
		}
        [Editable(false)]
        public Dictionary<int, string> styleDict
        {
            get
            {
                return new Dictionary<int, string>() { { 1, "text-warning" }, { 2, "text-warning" }, { 3, "text-warning" }, { 4, "text-warning" }, { 5, "text-success" }, { 6, "text-warning" }, { 7, "text-warning" }, { 8, "text-warning" }, { 9, "text-warning" }, { 10, "text-warning" } };
            }
        }
        [Editable(false)]
        public string text_style
        {
            get
            {
                return styleDict[iStatus.Value];
            }
        }

        [Editable(false)]
        /// <summary>
        /// 异常数据
        /// 1：正常数据，2：异常数据
        /// </summary>
        public int iException { get; set;}
        public string sException { get; set;}
        [Editable(false)]
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string sVenName { get; set;}

        [Editable(false)]
        /// <summary>
        /// 数据状态
        /// </summary>
        public bool Datastatus { get; set;}

        [Editable(false)]
        public string sDatastatus
        {
            get {
                return Datastatus ? "是" : "否";
            }
        }
        [Editable(false)]
        /// <summary>
        /// 支付形式
        ///1：支付宝
        ///2：财付通
        /// </summary>
        public int iStyle { get; set; }

        [Editable(false)]
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime dPay { get; set;}

        [Editable(false)]
        /// <summary>
        /// 快递公司ID
        /// </summary>
        public int ExpressID { get; set;}

        [Editable(false)]
        /// <summary>
        /// 快递公司
        /// </summary>
        public string sExpressID { get; set; }

        [Editable(false)]
        /// <summary>
        /// 快递单号
        /// </summary>
        public string ExpressNum { get; set;}

        [Editable(false)]
        public DataTable Data { get; set;}

        [Editable(false)]
        public int BillType { get; set;}
        [Editable(false)]
        public string Comhead { get; set;}
        [Editable(false)]
        public string Remark { get; set;}
        #endregion Model
	}

    public partial class tbOrderDetail : tbOrder
    {
        public tbOrderDetail()
        {
            sStyle = string.Empty;
            sExpressID = string.Empty;
            No = string.Empty;
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string sPdStd { get; set;}
        public string sRecieveName { get; set;}
        public string sAddress { get; set;}
        public string sPhoneNum { get; set;}
        public string sStyle { get;set;}
        public DateTime Shippingdate { get; set;}
        public string sExpressID { get; set;}
        public string No { get; set;}
        public int ReceivingStyle { get; set;}
        public string sReceivingStyle { get {
            return ReceivingStyle == 1 ? "手动" : "自动";
        } }
        public DateTime ReceivingDate { get; set;}

        /// <summary>
        /// 发票类型
        /// 1：个人，2：公司
        /// </summary>
        public int BillType { get; set;}
        /// <summary>
        /// 公司抬头
        /// </summary>
        public string Comhead { get; set;}


    }
}

