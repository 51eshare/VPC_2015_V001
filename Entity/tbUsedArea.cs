using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 二手区
    /// </summary>
    public class tbUsedArea
    {
        public tbUsedArea()
        {
            photolist = new List<string>();
        }
        [Key]
        public long ID { get; set;}
        /// <summary>
        /// 商品名字
        /// </summary>
        public string UsedName { get; set;}

        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int iPdClassId { get; set; }

        [Editable(false)]
        /// <summary>
        /// 商品分类名称
        /// </summary>
        public string siPdClassId { get; set;}

        /// <summary>
        /// 地区ID
        /// </summary>
        public int iDistrict { get; set;}

        [Editable(false)]
        /// <summary>
        /// 地区名称
        /// </summary>
        public int siDistrict { get; set;}

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set;}

        /// <summary>
        /// 联系方式
        /// </summary>
        public string phone { get; set;}

        /// <summary>
        /// 照片
        /// </summary>
        private string _photos = string.Empty;
        public string photos {
            get 
            {
                if (!string.IsNullOrWhiteSpace(_photos))
                    return _photos;
                else
                {
                    StringBuilder _sb = new StringBuilder();
                    if (_photolist.Count > 0)
                    {
                        foreach (var item in _photolist)
                        {
                            _sb.Append(_sb.Length > 0 ? string.Concat(",", item) : item);
                        }
                    }
                    return _sb.ToString();
                }
            }
            set {
                _photos = value;
            }
        }

        private List<string> _photolist = new List<string>();
        [Editable(false)]
        public List<string> photolist{
            get {
                if (!string.IsNullOrWhiteSpace(photos))
                    return photos.Split(',').ToList();
                else
                    return new List<string>();
            }
            set {
                _photolist = value;
            }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long iUserId { get; set;}

        /// <summary>
        /// 用户名称
        /// </summary>
        [Editable(false)]
        public string siUserId { get; set;}

        /// <summary>
        /// 添加时间
        /// </summary>
        [Editable(false)]
        public DateTime Dates{get;set;}

        /// <summary>
        /// 封面图片
        /// </summary>
        public string faceImg { get; set;}
    }
}
