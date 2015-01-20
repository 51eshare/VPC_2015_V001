using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
        public static class DataState
        {
            public static int nocheck = 1;
            public static int passcheck = 2;
            public static int ban = 3;
        }
        public static class Operate
        {
            public static string view = "view";
            public static string edit = "edit";
        }
        public static class URL
        {
            /// <summary>
            /// 
            /// </summary>
            public static string urlreferrer = "urlreferrer";

            /// <summary>
            /// 分享标识号
            /// </summary>
            public static string shareuid = "shareuid";
        }
}
