<%@ Page Title="咨询回复" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Question.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="QuestionInfo" runat="server" role="form" class="form-horizontal">
       <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group">
            <label class="col-md-2 control-label">咨询标题</label>
            <div class="col-md-6"><input type="text" class="form-control" /></div>
        </div>
        <div class="form-group">
            <label class="col-md-2 control-label">咨询人</label>
            <div class="col-md-6"><input type="text" class="form-control" /></div>
        </div>
        <div class="form-group">
            <label class="col-md-2 control-label">咨询内容</label>
            <div class="col-md-6"><textarea class="form-control" rows="4"></textarea></div>
        </div>
         <div class="form-group">
            <div class="col-md-6 text-center"><input type="button" id="btn_add" runat="server" class=" btn btn-success"  value="添加咨询"/></div>
        </div>
    </form>
</asp:Content>
