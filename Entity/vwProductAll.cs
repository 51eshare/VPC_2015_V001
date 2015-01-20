using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwProductAll。
	/// </summary>
	[Serializable]
	public partial class vwProductAll
	{
		public vwProductAll()
		{}
		#region Model
		private long _商品id;
		private long? _供应商id;
		private int? _产地id;
		private bool _是否赠品;
		private bool _是否促销;
		private string _商品名称;
		private string _商品品牌;
		private string _商品规格;
		private string _最小销售单位;
		private long? _最小销售数量;
		private string _包装;
		private int? _商品分类id;
		private string _产地名称;
		private string _食品有效期;
		private string _条码;
		private bool _是否进口;
		private int? _可售数量;
		private int? _安全库存;
		private decimal? _供应商结算价;
		private decimal? _小伙伴佣金;
		private decimal? _零售价;
		private decimal? _市场价;
		private DateTime? _价格有效期;
		private DateTime? _建档日期;
		private int? _状态id;
		private long? _成交总数量;
		private long? _评论总数量;
		private long? _点击总数量;
		private long? _商品好评总数量;
		private long? _商品中评总数量;
		private long? _商品差评总数量;
		private long? _服务好评总数量;
		private long? _服务中评总数量;
		private long? _服务差评总数量;
		private long? _物流好评总数量;
		private long? _物流中评总数量;
		private long? _物流差评总数量;
		private string _描述;
		private long? _积点数;
		private bool _是否积点兑换;
		private string _状态;
		private string _商品分类名称;
		private int? _扣点;
		/// <summary>
		/// 
		/// </summary>
		public long 商品Id
		{
			set{ _商品id=value;}
			get{return _商品id;}
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
		public int? 产地Id
		{
			set{ _产地id=value;}
			get{return _产地id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 是否赠品
		{
			set{ _是否赠品=value;}
			get{return _是否赠品;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 是否促销
		{
			set{ _是否促销=value;}
			get{return _是否促销;}
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
		public string 最小销售单位
		{
			set{ _最小销售单位=value;}
			get{return _最小销售单位;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 最小销售数量
		{
			set{ _最小销售数量=value;}
			get{return _最小销售数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 包装
		{
			set{ _包装=value;}
			get{return _包装;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 商品分类Id
		{
			set{ _商品分类id=value;}
			get{return _商品分类id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 产地名称
		{
			set{ _产地名称=value;}
			get{return _产地名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 食品有效期
		{
			set{ _食品有效期=value;}
			get{return _食品有效期;}
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
		public bool 是否进口
		{
			set{ _是否进口=value;}
			get{return _是否进口;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 可售数量
		{
			set{ _可售数量=value;}
			get{return _可售数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 安全库存
		{
			set{ _安全库存=value;}
			get{return _安全库存;}
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
		public decimal? 小伙伴佣金
		{
			set{ _小伙伴佣金=value;}
			get{return _小伙伴佣金;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 零售价
		{
			set{ _零售价=value;}
			get{return _零售价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 市场价
		{
			set{ _市场价=value;}
			get{return _市场价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 价格有效期
		{
			set{ _价格有效期=value;}
			get{return _价格有效期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 建档日期
		{
			set{ _建档日期=value;}
			get{return _建档日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 状态Id
		{
			set{ _状态id=value;}
			get{return _状态id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 成交总数量
		{
			set{ _成交总数量=value;}
			get{return _成交总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 评论总数量
		{
			set{ _评论总数量=value;}
			get{return _评论总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 点击总数量
		{
			set{ _点击总数量=value;}
			get{return _点击总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 商品好评总数量
		{
			set{ _商品好评总数量=value;}
			get{return _商品好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 商品中评总数量
		{
			set{ _商品中评总数量=value;}
			get{return _商品中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 商品差评总数量
		{
			set{ _商品差评总数量=value;}
			get{return _商品差评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 服务好评总数量
		{
			set{ _服务好评总数量=value;}
			get{return _服务好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 服务中评总数量
		{
			set{ _服务中评总数量=value;}
			get{return _服务中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 服务差评总数量
		{
			set{ _服务差评总数量=value;}
			get{return _服务差评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 物流好评总数量
		{
			set{ _物流好评总数量=value;}
			get{return _物流好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 物流中评总数量
		{
			set{ _物流中评总数量=value;}
			get{return _物流中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? 物流差评总数量
		{
			set{ _物流差评总数量=value;}
			get{return _物流差评总数量;}
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
		public long? 积点数
		{
			set{ _积点数=value;}
			get{return _积点数;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool 是否积点兑换
		{
			set{ _是否积点兑换=value;}
			get{return _是否积点兑换;}
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
		public string 商品分类名称
		{
			set{ _商品分类名称=value;}
			get{return _商品分类名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 扣点
		{
			set{ _扣点=value;}
			get{return _扣点;}
		}
		#endregion Model
	}
}

