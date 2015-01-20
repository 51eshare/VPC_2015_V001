using Common;
using Entity;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace VPC_2014_V001
{
    /// <summary>
    /// 页继承
    /// </summary>
    public class P_Base : Page_Base
    {

        public string UrlReferrer
        {
            get {
                if (ViewState["UrlReferrer"] != null)
                    return ViewState["UrlReferrer"].ToString();
                else
                    return string.Empty;
            }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    ViewState["UrlReferrer"] = value;
            }
        }

        public P_Base()
        {
            
        }
        public void IsLogin()
        {
                if (Session["UserInfo"] == null)
                    Response.Redirect("/Account/Login");
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
        }

        protected string GetParaStr(string para)
        {
            if (Request.QueryString[para] != null)
                return Request.QueryString[para];
            else
                return string.Empty;
        }
        protected int GetParaInt(string para)
        {
            if (Request.QueryString[para] != null)
                return int.Parse(Request.QueryString[para]);
            else
                return 0;
        }

        protected void BindOrderState(DropDownList ddl)
        {
            ddl.DataSource = b_Cache.GetStatus().Where(p => p.StateType == StateType.orderstate);
            ddl.DataTextField = "sStatus";
            ddl.DataValueField = "StateValue";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择订单状态--", ""));
            ddl.SelectedIndex = 0;
        }
        protected void BindOrderState(HtmlSelect ddl)
        {
            ddl.DataSource = b_Cache.GetStatus().Where(p => p.StateType == StateType.orderstate);
            ddl.DataTextField = "sStatus";
            ddl.DataValueField = "StateValue";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择订单状态--", ""));
            ddl.SelectedIndex = 0;
        }

        protected void BindtbExpress(HtmlSelect ddl)
        {
            ddl.DataSource = b_Cache.GetExpress().Where(p => p.enabled);
            ddl.DataTextField = "sName";
            ddl.DataValueField = "ID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择快递公司--", ""));
            ddl.SelectedIndex = 0;
        }
        protected void BindQuestionType(DropDownList ddl)
        {
            ddl.DataSource = b_Cache.GetStatus().Where(p => p.StateType == StateType.questiontype);
            ddl.DataTextField = "sStatus";
            ddl.DataValueField = "StateValue";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择咨询类型--", ""));
            ddl.SelectedIndex = 0;
        }
        protected void BindClass(DropDownList ddl, IEnumerable<tbStatus> data,string infotype="")
        {
            ddl.DataSource = data;
            ddl.DataTextField = "sStatus";
            ddl.DataValueField = "StateValue";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(infotype, ""));
            ddl.SelectedIndex = 0;
        }

        #region 产品类别
        /// <summary>
        /// 产品类别
        /// </summary>
        /// <param name="ddl"></param>
        protected void BindPdClass(DropDownList ddl,IEnumerable<tbProductClass> data)
        {
            ddl.DataSource = data;
            ddl.DataTextField = "cPdClass";
            ddl.DataValueField = "iPdClassId";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择商品类别--", ""));
            ddl.SelectedIndex = 0;
        }
        protected void BindPdClass(HtmlSelect ddl, IEnumerable<tbProductClass> data)
        {
            ddl.DataSource = data;
            ddl.DataTextField = "cPdClass";
            ddl.DataValueField = "iPdClassId";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--请选择商品类别--", ""));
            ddl.SelectedIndex = 0;
        }
        #endregion 

        #region 获取国家、省、市某一个ID
        /// <summary>
        /// 获取国家、省、市某一个ID
        /// </summary>
        /// <param name="sdistrict"></param>
        /// <param name="sprovince"></param>
        /// <param name="scity"></param>
        /// <returns></returns>
        protected int iDistrictId(HtmlSelect sdistrict, HtmlSelect sprovince, HtmlSelect scity)
        {
            if (!string.IsNullOrWhiteSpace(scity.Value))
                return Int32.Parse(scity.Value);
            else if (!string.IsNullOrWhiteSpace(sprovince.Value))
                return Int32.Parse(sprovince.Value);
            else
                return Int32.Parse(sdistrict.Value);
        }
        #endregion 
    }
}