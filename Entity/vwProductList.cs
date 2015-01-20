using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwProductList。
	/// </summary>
	[Serializable]
	public partial class vwProductList
	{
		public vwProductList()
		{}
		#region Model
		private long _p;
		private string _商品名称;
		private string _商品品牌;
		private string _商品规格;
		private decimal? _供应商结算价;
		private string _状态;
		private decimal? _佣金;
		private string _描述;
		private decimal? _前台售价;
		private string _图片;
		private long? _供应商id;
		private string _scollect;
		private string _sonsale;
		private string _bcollectenable;
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
		public decimal? 供应商结算价
		{
			set{ _供应商结算价=value;}
			get{return _供应商结算价;}
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
		public decimal? 佣金
		{
			set{ _佣金=value;}
			get{return _佣金;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 描述
		{
			set{ _描述=value;}
			get{return _描述;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 前台售价
		{
			set{ _前台售价=value;}
			get{return _前台售价;}
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
		public long? 供应商Id
		{
			set{ _供应商id=value;}
			get{return _供应商id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sCollect
		{
			set{ _scollect=value;}
			get{return _scollect;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sOnSale
		{
			set{ _sonsale=value;}
			get{return _sonsale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bCollectEnable
		{
			set{ _bcollectenable=value;}
			get{return _bcollectenable;}
		}
		#endregion Model
	}
}

