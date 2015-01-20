using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VPC_2014_V001.VPC.Account;

namespace VPC_2014_V001.VPC.Partner
{
    public partial class Apply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////测试用
            //Session["U"] = "1";
            //Session["UL"] = "XAVIER";

            #region 判断iUserId存在
            if (Session["U"] == null)
            {
                Session["EPS"] = @"错误号100001<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iUserId不为空
            if (Session["U"] == null || string.IsNullOrEmpty(Session["U"].ToString().Trim()))
            {
                Session["EPS"] = @"错误号100002<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iUserId为整数
            Int64 iUserId = 0;
            if (!Int64.TryParse(Session["U"].ToString().Trim(), out iUserId))
            {
                Session["EPS"] = @"错误号100003<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iUserId为正整数
            if (iUserId < 1)
            {
                Session["EPS"] = @"错误号100004<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iLoginId存在
            if (Session["UL"] == null)
            {
                Session["EPS"] = @"错误号100005<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iLoginId不为空
            if (Session["UL"] == null || string.IsNullOrEmpty(Session["U"].ToString().Trim()))
            {
                Session["EPS"] = @"错误号100006<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }
            #endregion

            #region 判断iUserId与sLoginId是否匹配

            bool bError = false;
            string sError;

            DataSet ds = new DataSet();

            #region 数据库检索
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }

                try
                {
                    //存储过程名称
                    _clsVPCDB.CmdProc = "pcUserCheck_iUserId_iLoginId";

                    //存储过程参数
                    _clsVPCDB.AddParam("@iUserId", System.Data.SqlDbType.BigInt, Session["U"]);
                    _clsVPCDB.AddParam("@sLoginId", System.Data.SqlDbType.NVarChar, Session["UL"].ToString());

                    //执行存储过程,获取返回值
                    _clsVPCDB.ExecuteQuery(ref ds, "UI");


                    ////结束事务处理
                    //_clsVPCDB.CommitTrans();
                }
                catch (Exception ex) { bError = true; sError = ex.ToString(); }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }
            }
            #endregion

            if (bError)
            {
                Session["EPS"] = @"错误号900001<br/>获取数据时出错，请稍候再试";//显示的错误信息
                Session["EPSA"] = @".\Account\PasswordChange";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }

            if (ds.Tables["UI"].Rows.Count < 1)
            {
                Session["EPS"] = @"错误号100007<br/>无法获取登录的用户信息，请重新登录";//显示的错误信息
                Session["EPSA"] = @".\Account\Login";//待跳转的页面
                Response.Redirect(@"..\ErrorPage");//显示错误信息的页面
            }

            #endregion

            //获取角色
            Role _Role = new Role();
            if (!_Role.Checked(Session["U"].ToString()))
            {

                Response.Redirect(@"..\Account\Login");
            }

            //未经许可的小伙伴，跳转页面到小伙伴申请流程
            if (!_Role.bPartnerAllow)
            {
                Label1.Text = @"<div class=""alert alert-danger"" role=""alert"">未被授权成为小伙伴！</div>"; ;
                //Response.Redirect(@"Apply");
                return;
            }

            //已经填写小伙伴资料，跳转到小伙伴信息页面
            if (_Role.bIsPartner)
            {
                Response.Redirect(@"Info");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["S_Apply"] = "true";
            Response.Redirect(@"Regist");
        }
    }
}