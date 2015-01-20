<%@ Page Title="店铺信息编辑" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShopInfoEdit.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.ShopInfoEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="ShopInfoEdit">
    <br />
    <%: Page.Title %>
    <br />
       <hr />
       <div class="input-group">
        <span class="input-group-addon">店铺名称</span>
        <asp:TextBox class="form-control" ID="txtsLoginId" runat="server" placeholder="最长10位"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvsLoginId" runat="server" ErrorMessage="  * 店铺名称必须填写" Display="Dynamic" ControlToValidate="txtsLoginId" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
     <div class="input-group">
        <span class="input-group-addon">店铺描述</span>
        <asp:TextBox class="form-control" ID="txtsNickname" runat="server" placeholder="最长25位"></asp:TextBox>
    </div>
    <br />
    <div class="input-group">
        <span class="input-group-addon">店铺所在地区</span>
        <asp:DropDownList class="form-control" ID="DropDownList4" runat="server"></asp:DropDownList>
        <asp:DropDownList class="form-control" ID="DropDownList5" runat="server"></asp:DropDownList>
        <asp:DropDownList class="form-control" ID="DropDownList6" runat="server"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="  * 店铺所在地区必须填写" Display="Dynamic" ControlToValidate="DropDownList6" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <asp:Button ID="Button1" runat="server" Text="保存" />
    </form>
</asp:Content>
