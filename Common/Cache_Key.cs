using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Cache_Key
    {
        /// <summary>
        /// 系统栏目
        /// </summary>
        public static string tbitems="tbitems";

        /// <summary>
        /// 区域
        /// </summary>
        public static string tbdistricts = "tbdistricts";

        /// <summary>
        /// 店铺
        /// </summary>
        public static string tbshops = "tbshops";

        /// <summary>
        /// 状态
        /// </summary>
        public static string tbstatus = "tbstatus";

        /// <summary>
        /// 商品类别
        /// </summary>
        public static string tbproductclass = "tbproductclass";

        /// <summary>
        /// 快递公司
        /// </summary>
        public static string tbexpress = "tbexpress";

        /// <summary>
        /// 平台首页基本信息
        /// </summary>
        public static string tbInfos = "tbInfos";

        /// <summary>
        /// 网站基本信息
        /// </summary>
        public static string siteinfo = "SiteInfo";

        /// <summary>
        /// 邮箱服务器配置
        /// </summary>
        public static string email = "email";

        /// <summary>
        /// 首页幻灯片
        /// </summary>
        public static string tbslideshow = "tbslideshow";


        /// <summary>
        /// 缓存时间
        /// </summary>
        public static TimeSpan Time = TimeSpan.FromDays(1);
    }

    public static class StateType
    {
        /// <summary>
        /// 一般状态
        /// </summary>
        public static int normastate=1;

        /// <summary>
        /// 订单状态
        /// </summary>
        public static int orderstate = 2;

        /// <summary>
        /// 咨询类型
        /// </summary>
        public static int questiontype = 3;

    }
}
