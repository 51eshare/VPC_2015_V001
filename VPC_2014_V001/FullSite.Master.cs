using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using Entity;

namespace VPC_2014_V001
{
    public partial class FullSite : M_Base
    {
        /// <summary>
        /// 选择的用户类型
        /// </summary>
        private string _a="<a href=\"javascript:void(0);\">{0} <b class=\"caret\"></b></a>";
        private string _li = "<li><a href=\"{0}\">{1}</a></li>";
        public StringBuilder sb = new StringBuilder("<ul class=\"nav nav-pill pull-left\">"), _temp;
        protected void Page_Load(object sender, EventArgs e)
        {
                if (UserInfo != null)
                {
                    var _list = b_Cache.GetItems();
                    var _p = _list.Where(p => p.Path == null && UserInfo.UserType.Contains(p.UserType) && p.Enabled);
                    foreach (var item in _p)
                    {
                        _temp =new StringBuilder("<li class=\"dropdown\">");
                        _temp.AppendFormat(_a, item.IName).Append("<ul class=\"subnav\">");
                        var _templist = _list.Where(p => p.UserType == item.UserType && !string.IsNullOrWhiteSpace(p.Path) && p.Enabled && item.ID==p.IParent);
                        foreach (var itemli in _templist)
                        {
                            _temp.AppendFormat(_li, itemli.Path, itemli.IName);
                        }
                        _temp.Append("</ul></li>");
                        sb.Append(_temp.ToString());
                    }
                    sb.Append("</ul>");
                    sb.Append("<ul class=\"nav nav-pill pull-left\">&#12288;");
                    sb.AppendFormat(_li, "/customer/usedarealist", "二手区");
                    //sb.AppendFormat(_li, "/Account/UserInfo", string.Concat("<i class=\"fa fa-user\">&nbsp;</i>", UserInfo.sLoginId));
                    sb.AppendFormat(_li, "/", "首页");
                    sb.AppendFormat(_li, "/Account/Login", "退出");
                    sb.Append("</ul>");
                }
                else
                {
                    sb.AppendFormat(_li, "/Account/Login", "登录").AppendFormat(_li, "/Account/Regist", "注册");
                }
                
        }
    }
}