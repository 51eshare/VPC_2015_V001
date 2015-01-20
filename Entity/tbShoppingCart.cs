using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbShoppingCart。
	/// </summary>
	[Serializable]
	public partial class tbShoppingCart
	{
		public tbShoppingCart()
		{}
		#region Model
        private long? _iuserid;
		private long _iscid;
        private long? _ishoprefpdid;
        private long? _iordernum;
		private DateTime? _ddate;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iScId
		{
			set{ _iscid=value;}
			get{return _iscid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iUserid
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
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
		public long? iOrderNum
		{
			set{ _iordernum=value;}
			get{return _iordernum;}
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
		#endregion Model
	}
}

