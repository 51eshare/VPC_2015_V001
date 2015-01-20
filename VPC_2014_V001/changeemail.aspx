<%@ Page Title="修改邮箱" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="changeemail.aspx.cs" Inherits="VPC_2014_V001.changeemail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
<link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" ClientIDMode="Static" runat="server">
    <form runat="server" class="form-horizontal" id="RegistForm">
        <div class="container flex-main">
             <div class="alert alert-danger <%=tipclass%> text-center" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
             </div>
            <div class="form-group">
                <label for="oldemail" class="col-lg-2 control-label">原邮箱</label>
                <div class="col-md-3">
                    <asp:TextBox ID="oldemail" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="oldemail" class="col-lg-2 control-label">新邮箱</label>
                <div class="col-md-3">
                    <asp:TextBox ID="email" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label id="email_tip"></label>
            </div>
            <div class="form-group">
                <label for="oldemail" class="col-lg-2 control-label">确认新邮箱</label>
                <div class="col-md-3">
                    <asp:TextBox ID="confirm_email" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label id="confirm_email_tip"></label>
            </div>
            <div class="form-group">
                <div class="col-md-2 text-center col-md-offset-2">
                    <input type="submit" runat="server" id="btn_add" class="btn btn-primary" onserverclick="btn_add_ServerClick" value="提交" />
                </div>
            </div>
        </div>
        <input type="hidden" runat="server" id="uid" />
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#RegistForm").validate({
                rules: {
                    <%=confirm_email.UniqueID%>: {
                        required: true,
                        equalTo: "#email"
                    },
                    <%=email.UniqueID%>: {
                        required: true,
                        email:true
                    }
                },
                messages:{
                    <%=email.UniqueID%>: {
                        required:"设置密码不能为空",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=confirm_email.UniqueID%>: {
                        required:"确认密码必须填写",
                        equalTo: "确认密码与设置密码不一致"
                    }
                },
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</asp:Content>
