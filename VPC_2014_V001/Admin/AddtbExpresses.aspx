<%@ Page Title="添加快递公司" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="AddtbExpresses.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.AddtbExpresses" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="AddtbExpress" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">快递公司名称</span>
            <asp:TextBox class="form-control" ID="sName" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="sName_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系电话</span>
            <asp:TextBox class="form-control" ID="sPhone" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="sPhone_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">公司网站</span>
            <asp:TextBox class="form-control" ID="sURL" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="sURL_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系人</span>
            <asp:TextBox class="form-control" ID="sUser" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="sUser_tip"></label>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">是否启用</span>
            <asp:CheckBox ID="enabled" Checked="true" runat="server" CssClass="form-control" />
            <label id="enabled_tip"></label>
        </div>
        <div class="data-space"></div>
        <input type="submit" runat="server" id="Button1"  class="btn btn-primary" value="提交" onserverclick="Button1_Click"/>
        <input type="button" class="btn btn-danger" value="返回" runat="server" id="btn_back" onserverclick="btn_back_ServerClick"/>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#AddtbExpress").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules:{
                    <%=sName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sPhone.UniqueID%>: {
                        required: true,
                        maxlength:20
                    },
                    <%=sURL.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sUser.UniqueID%>: {
                        required: true,
                        maxlength:10
                    }
                },
                messages:{
                    <%=sName.UniqueID%>: {
                        required: "请填写快递公司名称",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sPhone.UniqueID%>: {
                        required: "请填写联系电话",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sURL.UniqueID%>: {
                        required: "请填写公司网站",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sUser.UniqueID%>: {
                        required: "请填写联系人",
                        maxlength:"最长不能超过{0}个字"
                    }
                }
            });
        });
    </script>
</asp:Content>
