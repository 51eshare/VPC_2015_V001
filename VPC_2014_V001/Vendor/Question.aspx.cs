using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace VPC_2014_V001.VPC.Vendor
{
    public partial class Question : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                IsLogin();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            long iUserId = 0;
            var _userinfo = new b_tbUser().GetList().SingleOrDefault(p => p.sLoginId == siUserId.Value.Trim());
            if (_userinfo != null)
                iUserId = _userinfo.iUserId;
            if (iUserId < 1)
            {
                Alert.Show("咨询人不存在！请核对",this);
            }
            else
            {
                tbQuestion _question = new tbQuestion();
                CommonMethod.Controls_to_Entity(_question, QuestionInfo);
                _question.iUserId = iUserId;
                _question.iQuestionUserId = UserInfo.iUserId;
                _question.iQuestionType = 2;
                if (new b_tbQuestion().Insert(_question) > 0)
                    Response.Redirect("/Vendor/Messages");
                else
                {
                    Alert.Show("咨询失败！请核对信息", this);
                }
            }
        }
    }
}