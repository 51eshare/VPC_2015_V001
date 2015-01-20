using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbImage。
	/// </summary>
	[Serializable]
	public partial class tbImage
	{
		public tbImage()
		{}
		#region Model
		private long _iimgid;
		private string _simagename;
		private string _simagepath;
        private long _itype;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iImgId
		{
			set{ _iimgid=value;}
			get{return _iimgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sImageName
		{
			set{ _simagename=value;}
			get{return _simagename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sImagePath
		{
			set{ _simagepath=value;}
			get{return _simagepath;}
		}
		/// <summary>
        /// 图片类别 1:供应商证书
		/// </summary>
        public long iType
		{
            set { _itype = value; }
            get { return _itype; }
		}
        /// <summary>
        /// 图片本身类别
        /// </summary>
        public int iOType { get; set;}

        /// <summary>
        /// 图片本身排序
        /// </summary>
        public int iOrder { get; set;}
        /// <summary>
        /// 映射ID
        /// </summary>
        public long iMID { get; set; }
		#endregion Model
	}
}

