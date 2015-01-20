<%@ Page Title="会员管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="OperationManageHistory.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.OperationManageHistory" %>
<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form runat="server" id="OperationManageform" class="form-horizontal">
        <div>
            <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
            </div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <div class="form-group">
                <label class="col-lg-2 control-label" for="sLoginId">用户名</label>
                <div class="col-lg-6">
                    <input type="text" placeholder="最长15位" runat="server" id="sLoginId" class="form-control" />
                </div>
                <label id="sLoginId_tip"></label>
            </div>
            <br />
            <div class="form-group">
                <label class="col-lg-2 control-label" for="sNickName">昵称</label>
                <div class="col-lg-6">
                    <input type="text" placeholder="昵称" id="sNickName" runat="server" name="sNickName" class="form-control" />
                </div>
                <label id="sNickName_tip"></label>
            </div>
            <br />
            <div class="form-group">
                <label class="col-lg-2 control-label" for="sUserEmail">邮箱</label>
                <div class="col-lg-6">
                    <input type="text" placeholder="邮箱" id="sUserEmail" runat="server" name="sUserEmail" class="form-control" />
                </div>
                <label id="sUserEmail_tip"></label>
            </div>
            <br />
            <div class="form-group">
                <label class="col-lg-2 control-label" for="sPassword">设置密码</label>
                <div class="col-lg-6">
                    <input type="password" placeholder="设置密码" id="sPassword" runat="server" name="sPassword" class="form-control" />
                </div>
                <label id="sPassword_tip"></label>
            </div>
            <br />
            <div class="form-group">
                <label class="col-lg-2 control-label" for="sPassword">确认密码</label>
                <div class="col-lg-6">
                    <input type="password" placeholder="确认密码" id="txtsPassword1" runat="server" name="txtsPassword1" class="form-control" />
                </div>
                <label id="txtsPassword1_tip"></label>
            </div>
            <br />
            <div class="form-group">
                <div class="col-lg-8 col-lg-offset-2">
                    <input type="button" id="btn_back" runat="server" value="返回" class="btn btn-default" onserverclick="btn_back_ServerClick" />
                    <input type="submit" id="btn_add" class="btn btn-primary" runat="server" onserverclick="btn_add_ServerClick" value="提交" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#OperationManageform").validate({
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
                        maxlength:50,
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
