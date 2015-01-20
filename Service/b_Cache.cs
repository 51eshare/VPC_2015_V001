using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using XperiCode.SimpleCache;
using System.Runtime.Caching;
using Common;
using Newtonsoft.Json;

namespace Service
{
    public class b_Cache
    {
        public b_Cache()
        {

        }

        #region 所有栏目
        /// <summary>
        /// 所有栏目
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbItem> GetItems()
        {
            return MemoryCache.Default.Get(Cache_Key.tbitems,Cache_Key.Time,()=>new b_tbItem().GetList().OrderBy(p=>p.IOrder));
        }
        #endregion 

        /// <summary>
        /// 所有微店
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbShop> GetShops()
        {
            return MemoryCache.Default.Get(Cache_Key.tbshops, Cache_Key.Time, () => new b_tbShop().GetList());
        }

        #region 状态表
        /// <summary>
        /// 状态表
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbStatus> GetStatus()
        {
            return MemoryCache.Default.Get(Cache_Key.tbstatus, Cache_Key.Time, () => new b_tbStatus().GetList());
        }
        #endregion 

        #region 商品类别
        /// <summary>
        /// 商品类别
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbProductClass> GetProductClasses()
        {
            return MemoryCache.Default.Get(Cache_Key.tbproductclass, Cache_Key.Time, () => new b_tbProductClass().GetList());
        }
        #endregion 

        #region 平台首页基本信息
        public static IEnumerable<tbInfo> GettbInfo()
        {
            return MemoryCache.Default.Get(Cache_Key.tbInfos, Cache_Key.Time, () => new b_tbInfo().GetList());
        }
        #endregion 

        #region 网站基本信息
        public static SiteInfo GetSiteInfo()
        {
            return MemoryCache.Default.Get(Cache_Key.siteinfo, Cache_Key.Time, () => {
                var _info = new FileOperate().Read_Txt("Baseinfo");
                if (!string.IsNullOrWhiteSpace(_info))
                {
                    return JsonConvert.DeserializeObject<SiteInfo>(_info);
                }
                else
                    return null;
            });
        }
        #endregion 

        #region 网站基本信息
        public static Email GetEmail()
        {
            return MemoryCache.Default.Get(Cache_Key.email, Cache_Key.Time, () =>
            {
                var _info = new FileOperate().Read_Txt("Email");
                if (!string.IsNullOrWhiteSpace(_info))
                {
                    return JsonConvert.DeserializeObject<Email>(_info);
                }
                else
                    return null;
            });
        }
        #endregion

        #region 首页幻灯片
        public static IEnumerable<tbSlideshow> GettbSlideshows()
        {
            return MemoryCache.Default.Get(Cache_Key.tbslideshow, Cache_Key.Time, () =>new b_tbSlideshow().GetList());
        }
        #endregion 

        /// <summary>
        /// 快递公司列表
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbExpress> GetExpress()
        {
            return MemoryCache.Default.Get(Cache_Key.tbexpress, Cache_Key.Time, () => new b_tbExpress().GetList());
        }

        #region 移除数据
        public static void RemoveData(string cache_key)
        {
            if (MemoryCache.Default.Contains(cache_key))
            {
                MemoryCache.Default.Remove(cache_key);
            }
        }
        #endregion

        #region 区域
        /// <summary>
        /// 区域
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<tbDistrict> GettbDistricts()
        {
            return MemoryCache.Default.Get(Cache_Key.tbdistricts, Cache_Key.Time, () => new b_tbDistrict().GetList("select * from tbDistrict order by sDistrict asc"));
        }
        #endregion 
    }
}
