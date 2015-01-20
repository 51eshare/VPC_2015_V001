<%@ Page Title="个人信息" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="VPC_2014_V001.VPC.Account.UserInfo" %>
<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
<link href="/Content/Site.css" rel="stylesheet" />
<link href="/Content/admin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
        <div class="content">
        <div class="container">
            <div class="panel panel-default">
               <div class="panel-heading">
                  <h3 class="panel-title">
                     用户注册 
                  </h3>
               </div>
                <div class="panel-body">
            <div class="alert alert-danger <%=tipclass%> text-center" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
             </div>
            <form id="RegistForm" runat="server" class="form-horizontal">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="sLoginId">用户名</label>
                    <div class="col-lg-8">
                        <input type="text" id="sLoginId" runat="server" class="form-control" name="sLoginId" placeholder="最长15位" />
                    </div>
                    <label id="sLoginId_tip"></label>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="sNickName">昵称</label>
                    <div class="col-lg-8">
                        <asp:TextBox class="form-control" ID="sNickName" runat="server" placeholder="最长15位"></asp:TextBox>
                    </div>
                    <label id="sNickName_tip"></label>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="sUserEmail">邮箱</label>
                    <div class="col-lg-2">
                        <asp:TextBox class="form-control" TextMode="Email" ID="sUserEmail" runat="server" placeholder="最长15位"></asp:TextBox>
                    </div>
                    <div class="col-lg-1">
                        <input type="button" runat="server" id="btn_sUserEmail" onserverclick="btn_sUserEmail_Click" value="修改" class="btn btn-primary" />
                    </div>
                    <label id="sUserEmail_tip"></label>
                    <div class="col-lg-4 text-success">修改邮箱需要原邮箱验证</div>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="ilipay">支付宝账号</label>
                    <div class="col-lg-2">
                        <asp:TextBox class="form-control" ID="ilipay" runat="server" placeholder="最长25位"></asp:TextBox>
                    </div>
                    <div class="col-lg-1">
                        <input type="button" id="btn_ilipay" onclick="return on_btn_ilipay()" runat="server" value="修改" class="btn btn-primary" />
                    </div>
                     <label id="ilipay_tip"></label>
                    <div class="col-lg-4 text-success">修改支付宝账户，需要冻结提现功能90天</div>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="mobile">手机号</label>
                    <div class="col-lg-8">
                        <asp:TextBox class="form-control" ID="mobile" runat="server" placeholder="最长25位"></asp:TextBox>
                    </div>
                    <label id="mobile_tip"></label>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="sPassword">密码</label>
                    <div class="col-lg-8">
                        <asp:TextBox class="form-control" ID="sPassword" TextMode="Password" runat="server" placeholder="最长15位"></asp:TextBox>
                    </div>
                    <label id="sPassword_tip"></label>
                </div>
                <div class="form-group">
                    <label class="col-lg-2 control-label" for="txtsPassword1">确认密码</label>
                    <div class="col-lg-8">
                        <asp:TextBox class="form-control" ID="txtsPassword1" TextMode="Password" runat="server" placeholder="最长15位"></asp:TextBox>
                    </div>
                    <label id="txtsPassword1_tip"></label>
                </div>
                <div class="text-center">
                <input type="submit" runat="server" id="btn_add" class="btn btn-primary" onserverclick="btn_add_ServerClick" value="提交" />
                </div>
                <input runat="server" id="iUserId" type="hidden" />
            </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" ClientIDMode="Static" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script type="text/javascript">
        function on_btn_ilipay()
        {
            if(confirm("为保证您的账户安全，修改支付宝账户将冻结提现功能90天，\n若在此期间原账户无任何异议，90天后提现功能自动激活"))
            {
                $.post("/Ajax/changeilipay.ajax", {
                    iUserId: $("#iUserId").val(), ilipay:$("#ilipay").val()}, function (result) {
                        if (result.data)
                            alert("修改成功！");
                        else
                            alert("修改失败！");
                    });        
            }
        };
        $(function () {
            $("#RegistForm").validate({
                rules: {
                    <%=txtsPassword1.UniqueID%>: {
                        required: true,
                        equalTo: "#sPassword"
                    },
                    <%=sLoginId.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sNickName.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sUserEmail.UniqueID%>: {
                        required: true,
                        email:true
                    },
                    <%=sPassword.UniqueID%>: {
                        required: true,
                        maxlength:50
                    }
                },
                messages:{
                    <%=sUserEmail.UniqueID%>: {
                        required:"设置密码不能为空",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sUserEmail.UniqueID%>: {
                        required:"邮箱不能为空",
                        maxlength:"邮箱格式不对"
                    },
                    <%=sNickName.UniqueID%>: {
                        required:"昵称不能为空",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=txtsPassword1.UniqueID%>: {
                        required:"确认密码必须填写",
                        equalTo: "确认密码与设置密码不一致"
                     },
                    <%=sLoginId.UniqueID%>: {
                        required:"用户名不能为空",
                        maxlength:"最长不能超过{0}个字"
                    }
                },
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</asp:Content>
