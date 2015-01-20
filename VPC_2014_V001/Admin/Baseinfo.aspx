<%@ Page Title="基本设置" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Baseinfo.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.Baseinfo" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="AddtbInfos" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">标题</span>
            <asp:TextBox class="form-control" ID="title" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="title_tip"></label>
        </div>
        <div class="data-space"></div>
       <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">描述</span>
            <asp:TextBox class="form-control" ID="description" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="description_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">关键字</span>
            <asp:TextBox class="form-control" ID="keywords" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="keywords_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">URL</span>
            <asp:TextBox class="form-control" ID="url" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="url_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">公司地址</span>
            <asp:TextBox class="form-control" ID="Address" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="Address_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系电话</span>
            <asp:TextBox class="form-control" ID="Phone" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="Phone_tip"></label>
        </div>
         <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">邮件</span>
            <asp:TextBox class="form-control" ID="Email" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="Email_tip"></label>
        </div>
         <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">版权</span>
            <asp:TextBox class="form-control" ID="Copyright" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="Copyright_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">水印</span>
            <asp:TextBox class="form-control" ID="Watermark" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="Watermark_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="col-lg-offset-2">
        <input type="submit" runat="server" id="Button1"  class="btn btn-primary" value="保 存" onserverclick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
</asp:Content>
