using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwShoppingCart。
	/// </summary>
	[Serializable]
	public partial class vwShoppingCart
	{
		public vwShoppingCart()
		{}
		#region Model
		private string _商品名称;
		private long? _订单数量;
		private decimal? _售价;
		private long _p;
		private long? _用户id;
		private string _图片;
		private long? _微店id;
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
		public long? 订单数量
		{
			set{ _订单数量=value;}
			get{return _订单数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 售价
		{
			set{ _售价=value;}
			get{return _售价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long P
		{
			set{ _p=value;}
			get{return _p;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 用户Id
		{
			set{ _用户id=value;}
			get{return _用户id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 图片
		{
			set{ _图片=value;}
			get{return _图片;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 微店Id
		{
			set{ _微店id=value;}
			get{return _微店id;}
		}
        public long iScId { get; set; }
		#endregion Model
	}
}

