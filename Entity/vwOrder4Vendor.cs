using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwOrder4Vendor。
	/// </summary>
	[Serializable]
	public partial class vwOrder4Vendor
	{
		public vwOrder4Vendor()
		{}
		#region Model
		private long _订单id;
		private decimal? _结算价;
		private long? _订单数量;
		private decimal? _结算金额;
		private DateTime? _订单日期;
		private string _收货人;
		private string _收货地址;
		private string _联系电话;
		private string _邮编;
		private bool _是否开票;
		private DateTime? _收货确认时间;
		private bool _自动确认收货;
		private int? _商品评价;
		private int? _服务评价;
		private int? _物流评价;
		private string _状态;
		private string _商品名称;
		private string _商品品牌;
		private string _商品规格;
		private string _条码;
		private long? _供应商id;
		private long _商品id;
		/// <summary>
		/// 
		/// </summary>
		public long 订单Id
		{
			set{ _订单id=value;}
			get{return _订单id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 结算价
		{
			set{ _结算价=value;}
			get{return _结算价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 订单数量
		{
			set{ _订单数量=value;}
			get{return _订单数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 结算金额
		{
			set{ _结算金额=value;}
			get{return _结算金额;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 订单日期
		{
			set{ _订单日期=value;}
			get{return _订单日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 收货人
		{
			set{ _收货人=value;}
			get{return _收货人;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 收货地址
		{
			set{ _收货地址=value;}
			get{return _收货地址;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 联系电话
		{
			set{ _联系电话=value;}
			get{return _联系电话;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 邮编
		{
			set{ _邮编=value;}
			get{return _邮编;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 是否开票
		{
			set{ _是否开票=value;}
			get{return _是否开票;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 收货确认时间
		{
			set{ _收货确认时间=value;}
			get{return _收货确认时间;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 自动确认收货
		{
			set{ _自动确认收货=value;}
			get{return _自动确认收货;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 商品评价
		{
			set{ _商品评价=value;}
			get{return _商品评价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 服务评价
		{
			set{ _服务评价=value;}
			get{return _服务评价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 物流评价
		{
			set{ _物流评价=value;}
			get{return _物流评价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 状态
		{
			set{ _状态=value;}
			get{return _状态;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 商品名称
		{
			set{ _商品名称=value;}
			get{return _商品名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 商品品牌
		{
			set{ _商品品牌=value;}
			get{return _商品品牌;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 商品规格
		{
			set{ _商品规格=value;}
			get{return _商品规格;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 条码
		{
			set{ _条码=value;}
			get{return _条码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 供应商Id
		{
			set{ _供应商id=value;}
			get{return _供应商id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 商品Id
		{
			set{ _商品id=value;}
			get{return _商品id;}
		}
		#endregion Model
	}
}

