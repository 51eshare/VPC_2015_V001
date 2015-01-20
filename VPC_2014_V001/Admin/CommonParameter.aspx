<%@ Page Title="管理公共参数" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="CommonParameter.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.CommonParameter" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="AddCommonParameter" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 200px;">自动确认收货时间</span>
            <asp:TextBox class="form-control" ID="AutoConfirm" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="AutoConfirm_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 200px;">供应商服务到期前提示时间</span>
            <asp:TextBox class="form-control" ID="AutoPrompt" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="AutoPrompt_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 200px;">积分和销售额对应比率</span>
            <asp:TextBox class="form-control" ID="Rate" runat="server" Text="5" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="Rate_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 200px;">分享奖励积分</span>
            <asp:TextBox class="form-control" ID="SharePoint" runat="server" Text="100" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="SharePoint_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="col-lg-offset-2">
        <input type="submit" runat="server" id="Button1"  class="btn btn-primary" value="提交" onserverclick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#AddCommonParameter").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules:{
                    <%=AutoConfirm.UniqueID%>: {
                        required: true,
                        min:0
                    },
                    <%=AutoPrompt.UniqueID%>: {
                        required: true,
                        min:0
                    },
                    <%=Rate.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=SharePoint.UniqueID%>: {
                        required: true,
                        min:1
                    }
                },
                messages:{
                    <%=AutoConfirm.UniqueID%>: {
                        required: "请填写自动确认收货时间",
                        min:"自动确认收货时间至少大于0"
                    },
                    <%=AutoPrompt.UniqueID%>: {
                        required: "请填写供应商服务到期前提示时间",
                        min:"供应商服务到期前提示时间至少大于0"
                    },
                    <%=Rate.UniqueID%>: {
                        required: "请填写积分和销售额对应比率",
                        min:"积分和销售额对应比率至少大于0"
                    },
                    <%=SharePoint.UniqueID%>: {
                        required: "请填写分享奖励积分",
                        min:"分享奖励积分至少大于0"
                    }
                }
            });
        });
    </script>
</asp:Content>
