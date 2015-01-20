<%@ Page Title="供应商资料" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Reply.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Reply" %>
<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
<link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="ReplyInfo" runat="server" role="form">
    <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
    </div>
    <div class="row">
        <label class="col-md-2 control-label text-center">主题</label>
        <div class="col-md-10">
            <label id="bTopic" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row">
        <label class="col-md-2 control-label text-center">咨询人</label>
        <div class="col-md-10">
            <label id="sQuestionUserId" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row">
        <label class="col-md-2 control-label text-center">时间</label>
        <div class="col-md-10">
            <label id="dDate" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row">
       <label class="col-md-2 control-label text-center">是否已经回复</label>
        <div class="col-md-10">
            <label id="sApply" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row">
       <label class="col-md-2 control-label text-center">问题描述</label>
        <div class="col-md-10">
            <label id="sQuestionText" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row hidden"  runat="server" id="divReplyText">
       <label class="col-md-2 control-label text-center">问题描述</label>
        <div class="col-md-10">
            <label id="ReplyText" class="text-normal" runat="server"></label>
        </div>
    </div>
    <div class="row"  runat="server" id="divReply">
       <label class="col-md-2 control-label text-center">咨询回复</label>
        <div class="col-md-10">
            <textarea id="sReplyText" rows="12"  required runat="server" class="form-control data-space form-group-min"></textarea>
            <label id="sReplyText_tip"></label>
        </div>
    </div>
    <p class="col-sm-offset-4">
        <input type="submit" class="btn btn-danger" value="提交" onserverclick="InfoReply_ServerClick" id="InfoReply" runat="server" />
        <input type="button" class="btn btn-primary" runat="server" value="返回" id="btn_back" onserverclick="btn_back_ServerClick" />
    </p>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#ReplyInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</asp:Content>
