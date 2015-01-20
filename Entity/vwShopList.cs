using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Entity
{
	/// <summary>
	/// 类vwShopList。
	/// </summary>
	[Serializable]
	public partial class vwShopList
	{
		public vwShopList()
		{}
		#region Model
		private string _店铺名称;
		private long _店铺id;
		private string _店铺描述;
		private DateTime _建档日期;
		private long _总关注量;
		private long _总销量;
		private long _总点击量;
		private long _当月销量;
		private long _前3个月销量;
		private long _商品数;
		private string _图片;
        private long _icollectid = 0;
        public long iCollectId
        {
            get { return _icollectid;}
            set { _icollectid = value;}
        }
		/// <summary>
		/// 
		/// </summary>
		public string 店铺名称
		{
			set{ _店铺名称=value;}
			get{return _店铺名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 店铺Id
		{
			set{ _店铺id=value;}
			get{return _店铺id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 店铺描述
		{
			set{ _店铺描述=value;}
			get{return _店铺描述;}
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
		public long 总关注量
		{
			set{ _总关注量=value;}
			get{return _总关注量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 总销量
		{
			set{ _总销量=value;}
			get{return _总销量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 总点击量
		{
			set{ _总点击量=value;}
			get{return _总点击量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 当月销量
		{
			set{ _当月销量=value;}
			get{return _当月销量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 前3个月销量
		{
			set{ _前3个月销量=value;}
			get{return _前3个月销量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long 商品数
		{
			set{ _商品数=value;}
			get{return _商品数;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 图片
		{
			set{ _图片=value;}
			get{return _图片;}
		}
		#endregion Model
	}
}

