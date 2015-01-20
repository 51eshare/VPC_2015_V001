using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Entity
{
    /// <summary>
    /// 系统菜单表
    /// </summary>
    public class tbItem
    {
        [Key]
        /// <summary>
        /// 标识号
        /// </summary>
        public int ID { get; set;}

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string IName { get; set;}

        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set;}

        [Editable(false)]
        public string RPath {
            get {
                if (!string.IsNullOrWhiteSpace(Path))
                    return string.Concat(Path, ".aspx");
                else return string.Empty;
            }
        }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int UserType { get; set;}

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled { get; set;}

        /// <summary>
        /// 排序值
        /// </summary>
        public int IOrder { get; set;}

        /// <summary>
        /// 父ID
        /// </summary>
        public int IParent { get; set;}
    }
}
