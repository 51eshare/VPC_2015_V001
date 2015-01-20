using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Entity
{
    #region 通用分页模型
    /// <summary>
    /// 通用分页模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class p_PageList<T>
    {
        public p_PageList()
        {
            OrderFields = string.Empty;
            GroupBy = string.Empty;
            PageIndex = 1;
        }
        public string Tables { get; set;}
        public string Fields { get; set;}
        public string OrderFields { get; set;}
        public string Where { get; set;}
        public int PageIndex { get; set;}
        private int _pagesize = 10;
        public int PageSize {
            get { return _pagesize; }
            set { _pagesize = value;}
        }
        public string GroupBy { get; set;}
        public int TotalCount { get; set;}
        public int PageCount
        {
            get { return (int)Math.Ceiling(TotalCount/(double)PageSize); }
        }
        public IEnumerable<T> DataList { get; set;}
    }
    #endregion 
}
