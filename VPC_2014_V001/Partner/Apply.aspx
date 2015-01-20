<%@ Page Title="" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Apply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%: Page.Title %>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
<h3>网站介绍</h3>
<div class="row">
  <div class="col-sm-12 col-md-12">
    <div class="thumbnail">
      <img data-src="" alt="...">
      <div class="caption">
        <p>...</p>
      </div>
    </div>
  </div>
<h3>小伙伴入驻流程</h3>
<div class="row">
  <div class="col-sm-12 col-md-12">
    <div class="thumbnail">
      <img data-src="" alt="...">
      <div class="caption">
        <p>...</p>
        <p><asp:Button ID="Button1" class="btn btn-default" runat="server" Text="立即申请" OnClick="Button1_Click" /> </p>
      </div>
    </div>
  </div>
</div>
    </div>
</asp:Content>