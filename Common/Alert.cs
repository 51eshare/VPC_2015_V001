using System.Text;
using System.Web;
using System.Web.UI;

namespace Common
{
    /// <summary>
    ///     信息输出通用方法
    /// </summary>
    public class Alert
    {
        /// <summary>
        ///     一般输出
        /// </summary>
        /// <param name="str"></param>
        public static void Write(string str)
        {
            HttpContext.Current.Response.Write(str);
        }

        /// <summary>
        ///     显示一段自定义的输出代码
        /// </summary>
        /// <param name="MyPage"></param>
        /// <param name="strCode"></param>
        public static void ShowJS(Page MyPage, string strCode)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append(strCode.Trim());
            sb.Append("</script>");
            MyPage.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     页面重载
        /// </summary>
        public static void Location()
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("window.location.href=window.location.href;");
            sb.Append("</script>");
            HttpContext.Current.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     显示一个弹出窗口
        /// </summary>
        /// <param name="str"></param>
        public static void Show(string str, Page basepage)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("</script>");
            ClientScriptManager _csm = basepage.ClientScript;
            _csm.RegisterStartupScript(basepage.GetType(), "Show", sb.ToString(), false);
        }

        /// <summary>
        ///     显示一个弹出窗口，并关闭当前页
        /// </summary>
        /// <param name="str"></param>
        public static void ShowClose(string str)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\">\n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.close();\n");
            sb.Append("</script>\n");
            HttpContext.Current.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     显示一个弹出窗口，并转向当前页(刷新)
        /// </summary>
        /// <param name="str"></param>
        public static void ShowLocation(string str)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.location.href=window.location.href;\n");
            sb.Append("</script>");

            HttpContext.Current.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     显示一个弹出窗口，并转向目标页(导航)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        public static void ShowRedirect(string str, string url)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("window.location.href=\"" + url.Trim() + "\";\n");
            sb.Append("</script>");

            HttpContext.Current.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     显示一个弹出窗口，并转向上一页
        /// </summary>
        /// <param name="str"></param>
        public static void ShowPre(string str)
        {
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append("alert(\"" + str.Trim() + "\"); \n");
            sb.Append("var p=document.referrer; \n");
            sb.Append("window.location.href=p;\n");
            sb.Append("</script>");

            HttpContext.Current.Response.Write(sb.ToString());
        }

        /// <summary>
        ///     重定向
        /// </summary>
        /// <param name="url"></param>
        public static void RedirectPage(string url)
        {
            string path = "http://" + HttpContext.Current.Request.Url.Host + url;
            var sb = new StringBuilder();
            sb.Append("<script language=\"javascript\"> \n");
            sb.Append(string.Format("window.location.href='{0}';", @path));
            sb.Append("</script>");

            HttpContext.Current.Response.Write(sb.ToString());
        }
    }
}