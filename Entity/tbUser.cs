using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbUser。
	/// </summary>
	[Serializable]
	public partial class tbUser
	{
		public tbUser()
		{
            iParentID = 0;
            UserType = new List<long>();
            isweixin = false;
        }
		#region Model
		private long _iuserid=0;
		private string _sloginid;
		private string _snickname;
		private string _spassword;
		private string _swxopenid;
		private string _suseremail;
		private DateTime? _ddate;
		private int? _ilevel;
		private long? _ipoint;
        private long _iparentid =0;
        [Key]
		/// <summary>
		/// 用户ID
		/// </summary>
		public long iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string sLoginId
		{
			set{ _sloginid=value;}
			get{return _sloginid;}
		}
		/// <summary>
		/// 昵称
		/// </summary>
		public string sNickName
		{
			set{ _snickname=value;}
			get{return _snickname;}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string sPassword
		{
			set{ _spassword=value;}
			get{return _spassword;}
		}
        [Editable(false)]
		/// <summary>
		/// 微信ID
		/// </summary>
		public string sWxOpenId
		{
			set{ _swxopenid=value;}
			get{return _swxopenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sUserEmail
		{
			set{ _suseremail=value;}
			get{return _suseremail;}
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
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public int? iLevel
		{
			set{ _ilevel=value;}
			get{return _ilevel;}
		}
        [Editable(false)]
		/// <summary>
        /// 积分
		/// </summary>
		public long? iPoint
		{
			set{ _ipoint=value;}
			get{return _ipoint;}
		}
        /// <summary>
        /// 1000	用户
        /// 3000	个人小伙伴
        /// 3001	企业小伙伴
        /// 5000	供应商
        /// 9000	后台
        /// </summary>
        [Editable(false)]
        public IEnumerable<long> UserType
        { get; set; }
		/// <summary>
		/// 
		/// </summary>
        public long iParentID
		{
            set { _iparentid = value; }
            get { return _iparentid; }
		}
        [Editable(false)]
        /// <summary>
        /// 真实用户ID
        /// </summary>
        public long RealID
        {
            get {
                if (iParentID == 0)
                    return iUserId;
                else
                    return iParentID;
            }
        }

        [Editable(false)]
        public int iStatus { get; set;}
        [Editable(false)]
        /// <summary>
        /// 用户状态
        /// </summary>
        public string sStatus { get; set;}

        private long _blink = 0;
        /// <summary>
        /// 介绍会员ID
        /// </summary>
        public long bLink
        {
            get { return _blink; }
            set { _blink = value; }
        }
        /// <summary>
        /// 支付宝账号
        /// </summary>
        public string ilipay { get; set;}

        public string mobile { get; set;}

        public DateTime ilipaydate { get; set;}

        [Editable(false)]
        public bool ilipayvalid
        {
            get {
                if (ilipaydate.AddDays(90) < DateTime.Now)
                    return true;
                else
                    return false;
            }
        }

        #region 是否微信
        /// <summary>
        /// 是否微信
        /// true:是微信浏览器，false：不是微信浏览器
        /// </summary>
        [Editable(false)]
        public bool isweixin { get; set; }
        #endregion 

        #endregion Model
    }

    /// <summary>
    /// 店铺快速注册
    /// </summary>
    public class tbVendorRegist : tbUser
    {
        public tbVendorRegist()
        {

        }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string sShopName {get; set;}

        /// <summary>
        /// 店铺所在地
        /// </summary>
        public int iDistrict { get; set;}

        /// <summary>
        /// 分享者ID
        /// </summary>
        public long shareuid { get; set;}
    }
}

