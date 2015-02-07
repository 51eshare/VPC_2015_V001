using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace Entity
{
	/// <summary>
	/// 类tbQuestion。
	/// </summary>
	[Serializable]
	public partial class tbQuestion
	{
		public tbQuestion()
		{
            ServicePrice = 0;
            ServiceDate = DateTime.Now;
            _iobjectid = 0;
        }
		#region Model
		private long _iquestionid;
		private long _iuserid;

        private long _iquestionuserid;
        private int _iquestiontype=1;
        private long _iobjectid;
		private string _squestiontext;
		private string _btopic;
		private DateTime _ddate;
		private bool _bapply;
        [Key]
		/// <summary>
		/// 
		/// </summary>
		public long iQuestionId
		{
			set{ _iquestionid=value;}
			get{return _iquestionid;}
		}
		/// <summary>
        /// 被咨询人ID
		/// </summary>
		public long iUserId
		{
			set{ _iuserid=value;}
			get{return _iuserid;}
		}
        [Editable(false)]
        public string sUserId { get; set;}
		/// <summary>
        /// 咨询人ID
		/// </summary>
        public long iQuestionUserId
		{
            set { _iquestionuserid = value; }
            get { return _iquestionuserid; }
		}
        [Editable(false)]
        public string sQuestionUserId { get; set;}
		/// <summary>
		/// 1:商品咨询
        /// 2:站内咨询
		/// </summary>
        public int iQuestionType
		{
            set { _iquestiontype = value; }
            get { return _iquestiontype; }
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
        public long iObjectId
		{
            set { _iobjectid = value; }
            get { return _iobjectid; }
		}
		/// <summary>
        /// 问题描述
		/// </summary>
		public string sQuestionText
		{
			set{ _squestiontext=value;}
			get{return _squestiontext;}
		}
		/// <summary>
        /// 问题主题
		/// </summary>
		public string bTopic
		{
			set{ _btopic=value;}
			get{return _btopic;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public DateTime dDate
		{
			set{ _ddate=value;}
			get{return _ddate;}
		}
        [Editable(false)]
		/// <summary>
		/// 
		/// </summary>
		public bool bApply
		{
			set{ _bapply=value;}
			get{return _bapply;}
		}
        [Editable(false)]
        public string sApply
        {
            get {
               return bApply ? "是" : "否";
            }
        }
        /// <summary>
        /// 回复内容
        /// </summary>
        [Editable(false)]
        public string ReplyText { get; set;}


        [Editable(false)]
        /// <summary>
        /// 回复人
        /// </summary>
        public string siReplyUserId { get; set;}

        [Editable(false)]
        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime ReplyDate { get; set; }

        /// <summary>
        /// 服务费用
        /// </summary>
        [Editable(false)]
        public long ServicePrice { get; set;}

        /// <summary>
        /// 到期时间
        /// </summary>
        [Editable(false)]
        public DateTime ServiceDate { get; set;}

        /// <summary>
        /// 审核类型
        /// 1：通过
        /// 2：不通过
        /// </summary>
        [Editable(false)]
        public int Class { get; set;}
		#endregion Model
	}
}

