using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Service
{
    public static class b_SiteInfo
    {
        /// <summary>
        /// 网站信息
        /// </summary>
        public static SiteInfo Site_Info = new SiteInfo();
        static b_SiteInfo()
        {
            Site_Info.description = ConfigurationManager.AppSettings["description"];
            Site_Info.title = ConfigurationManager.AppSettings["title"];
            Site_Info.keywords = ConfigurationManager.AppSettings["keywords"];
        }

    }
}
