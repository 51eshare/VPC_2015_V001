<%@ Page Title="添加小伙伴级别" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="AddPartnerLevel.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.AddPartnerLevel" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="AddPartnerLevelInfo" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">微店积分</span>
            <asp:TextBox class="form-control" ID="price" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="price_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">微店等级</span>
            <asp:TextBox class="form-control" ID="llevel" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="llevel_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">橱窗数</span>
            <asp:TextBox class="form-control" TextMode="Number" ID="windows" runat="server" Text="5" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="windows_tip"></label>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">是否可以修改前台售价</span>
            <asp:CheckBox ID="ismodify" runat="server" CssClass="form-control" />
            <label id="ismodify_tip"></label>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">佣金比率</span>
            <asp:TextBox class="form-control" ID="Rate" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="Rate_tip"></label>
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
            $("#AddPartnerLevelInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules:{
                    <%=price.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=llevel.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=windows.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=Rate.UniqueID%>: {
                        required: true,
                        min:1
                    }
                },
                messages:{
                    <%=price.UniqueID%>: {
                        required: "请填微店积分",
                        min:"销售金额至少大于1"
                    },
                    <%=llevel.UniqueID%>: {
                        required: "请填写微店等级",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=windows.UniqueID%>: {
                        required: "请填写橱窗数",
                        min:"橱窗数至少大于1"
                    },
                    <%=Rate.UniqueID%>: {
                        required: "请填写佣金比率",
                        min:"橱窗数至少大于1"
                    }
                }
            });
        });
    </script>
</asp:Content>
