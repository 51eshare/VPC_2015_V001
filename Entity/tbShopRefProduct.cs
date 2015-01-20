using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbShopRefProduct。
	/// </summary>
	[Serializable]
	public partial class tbShopRefProduct
	{
		public tbShopRefProduct()
		{}
		#region Model
		private long _ishoprefpdid;
		private long? _iuserid;
		private long? _ishopid;
		private long? _ipdid;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iShopRefPdId
		{
			set{ _ishoprefpdid=value;}
			get{return _ishoprefpdid;}
		}
        [Editable(false)]
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
		public long? iShopId
		{
			set{ _ishopid=value;}
			get{return _ishopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? iPdId
		{
			set{ _ipdid=value;}
			get{return _ipdid;}
		}
		
		#endregion Model
	}
}

