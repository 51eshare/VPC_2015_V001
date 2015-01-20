<%@ Page Title="邮箱服务器基本设置" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="EmailServer.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.EmailServer" ValidateRequest="false" %>

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
            <span class="input-group-addon" style="width: 150px;">服务器名称</span>
            <asp:TextBox CssClass="form-control" ID="HostIP" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="HostIP_tip"></label>
        </div>
        <div class="data-space"></div>
       <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">端口</span>
            <asp:TextBox CssClass="form-control" ID="port" Text="80" TextMode="Number" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="port_tip"></label>
        </div>
        <div class="data-space"></div>
       <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">是否使用SSL</span>
            <asp:CheckBox runat="server" ID="ssl" Checked="false" />
            <label id="ssl_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">用户名</span>
            <asp:TextBox CssClass="form-control" ID="username" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="username_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">密码</span>
            <asp:TextBox CssClass="form-control" ID="password" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="password_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">发件名称</span>
            <asp:TextBox CssClass="form-control" ID="mailFrom" runat="server" Style="width: 300px;"></asp:TextBox>
            <label id="mailFrom_tip"></label>
        </div>
         <div class="data-space"></div>
        <div class="col-lg-offset-2">
        <input type="submit" runat="server" id="btn_save"  class="btn btn-primary" value="保 存" onserverclick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
</asp:Content>
