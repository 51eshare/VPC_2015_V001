using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类vwProduct4Partner。
	/// </summary>
	[Serializable]
	public partial class vwProduct4Partner
	{
		public vwProduct4Partner()
		{}
		#region Model
		private long _p;
		private int _产地id;
		private string _产地名称;
		private string _商品名称;
		private string _商品品牌;
		private string _商品规格;
		private string _最小销售单位;
		private long _最小销售数量;
		private string _包装;
		private string _食品有效期;
		private string _条码;
		private decimal _供应商结算价;
		private decimal _佣金;
		private decimal _前台售价;
		private decimal _零售价;
		private DateTime _价格有效期;
		private DateTime _建档日期;
		private int _状态id;
		private long _成交总数量;
		private long _评论总数量;
		private long _点击总数量;
		private long _商品好评总数量;
		private long _商品中评总数量;
		private long _商品差评总数量;
		private long _服务好评总数量;
		private long _服务中评总数量;
		private long _服务差评总数量;
		private long _物流好评总数量;
		private long _物流中评总数量;
		private long _物流差评总数量;
		private string _描述;
		private string _状态名称;
		private string _商品分类名称;
		private long _微店id;
		private string _图片;
        /// <summary>
        /// 供应商ID
        /// </summary>
        public long iUserId { get; set;}
        [Key]
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
		public int 产地Id
		{
			set{ _产地id=value;}
			get{return _产地id;}
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
		public long 最小销售数量
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
		public decimal 供应商结算价
		{
			set{ _供应商结算价=value;}
			get{return _供应商结算价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal 佣金
		{
			set{ _佣金=value;}
			get{return _佣金;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal 前台售价
		{
			set{ _前台售价=value;}
			get{return _前台售价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal 零售价
		{
			set{ _零售价=value;}
			get{return _零售价;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime 价格有效期
		{
			set{ _价格有效期=value;}
			get{return _价格有效期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime 建档日期
		{
			set{ _建档日期=value;}
			get{return _建档日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 状态Id
		{
			set{ _状态id=value;}
			get{return _状态id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 成交总数量
		{
			set{ _成交总数量=value;}
			get{return _成交总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 评论总数量
		{
			set{ _评论总数量=value;}
			get{return _评论总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 点击总数量
		{
			set{ _点击总数量=value;}
			get{return _点击总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 商品好评总数量
		{
			set{ _商品好评总数量=value;}
			get{return _商品好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 商品中评总数量
		{
			set{ _商品中评总数量=value;}
			get{return _商品中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 商品差评总数量
		{
			set{ _商品差评总数量=value;}
			get{return _商品差评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 服务好评总数量
		{
			set{ _服务好评总数量=value;}
			get{return _服务好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 服务中评总数量
		{
			set{ _服务中评总数量=value;}
			get{return _服务中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 服务差评总数量
		{
			set{ _服务差评总数量=value;}
			get{return _服务差评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 物流好评总数量
		{
			set{ _物流好评总数量=value;}
			get{return _物流好评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 物流中评总数量
		{
			set{ _物流中评总数量=value;}
			get{return _物流中评总数量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 物流差评总数量
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
		public string 状态名称
		{
			set{ _状态名称=value;}
			get{return _状态名称;}
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
		public long 微店Id
		{
			set{ _微店id=value;}
			get{return _微店id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 图片
		{
			set{ _图片=value;}
			get{return _图片;}
		}
        private int _istatus = 1;

        /// <summary>
        /// 商品状态
        /// 
        /// 
        /// </summary>
        public int iStatus
        {
            get { return _istatus; }
            set { _istatus = value; }
        }

		#endregion Model
	}
}

