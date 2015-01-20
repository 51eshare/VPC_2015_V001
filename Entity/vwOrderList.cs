using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwOrderList。
	/// </summary>
	[Serializable]
	public partial class vwOrderList
	{
		public vwOrderList()
		{}
		#region Model
		private long _订单id;
		private long? _商品id;
		private decimal? _结算价;
		private decimal? _结算金额;
		private DateTime? _订单日期;
		private string _状态;
		private string _商品名称;
		private string _商品规格;
		private string _条码;
		private long? _订单数量;
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
		public long? 商品Id
		{
			set{ _商品id=value;}
			get{return _商品id;}
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
		public long? 订单数量
		{
			set{ _订单数量=value;}
			get{return _订单数量;}
		}
		#endregion Model
	}
}

