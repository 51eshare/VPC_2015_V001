<%@ Page Title="咨询回复" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Question.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="QuestionInfo" runat="server" role="form" class="form-horizontal">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group">
            <label class="col-md-2 col-xs-4 control-label">咨询标题</label>
            <div class="col-md-6 col-xs-8">
                <input type="text" id="bTopic" runat="server" class="form-control" /></div>
            <label class="col-md-2 control-label" id="bTopic_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-md-2 col-xs-4 control-label">咨询人</label>
            <div class="col-md-6 col-xs-6">
                <input type="text" runat="server" id="siUserId" class="form-control" /></div>
             <label class="col-md-2 col-xs-12 pull-left red">咨询系统请填写：系统后台</label>   
            <label class="col-md-2 control-label" id="siUserId_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-md-2 col-xs-4 control-label">咨询内容</label>
            <div class="col-md-6 col-xs-8">
                <textarea class="form-control" runat="server" id="sQuestionText" rows="4"></textarea></div>
            <label class="col-md-2 control-label" id="sQuestionText_tip"></label>
        </div>
        <div class="form-group">
            <div class="col-md-6 text-center">
                <input type="submit" id="btn_add" runat="server" onserverclick="Button1_Click" class=" btn btn-success" value="添加咨询" />
                <a href="/Vendor/Messages" class=" btn btn-primary">返回</a>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="JS" runat="server" ContentPlaceHolderID="js">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#QuestionInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip_bak").html(error);
                },
                rules:{
                    <%=bTopic.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=siUserId.UniqueID%>: {
                        required: true
                    },
                    <%=sQuestionText.UniqueID%>: {
                        required: true
                    }
                },
                messages:{
                    <%=bTopic.UniqueID%>: {
                        required:"咨询标题不能为空",
                        maxlength: "最长不能超过{0}个字"
                    },
                    <%=siUserId.UniqueID%>: {
                        required: "咨询人不能为空"
                    },
                    <%=sQuestionText.UniqueID%>: {
                        required: "咨询内容不能为空"
                    }
                }
            });
        });
    </script>
</asp:Content>
