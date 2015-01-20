<%@ Page Title="网页错误" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="VPC_2014_V001.VPC.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <br />
    <%: Page.Title %>--%>
    <br />
    <br />

    <div class="alert alert-danger" role="alert">
        <p>
            <asp:Label ID="Label1" runat="server" Text="遇到错误了"></asp:Label>
        </p>
        <br />
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary" OnClick="LinkButton1_Click">点击此处继续</asp:LinkButton>
        </p>
    </div>
    <br />

</asp:Content>
