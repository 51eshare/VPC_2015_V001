<%@ Page Title="供应商资料" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
    <dl class="dl-horizontal">
        供应商基本资料
        <hr class="data-space" />
        <dt>供应商名称</dt>
        <dd>
            <asp:Label ID="LbsVenName" runat="server"></asp:Label></dd>
        <dt>供应商性质</dt>
        <dd>
            <asp:Label ID="LbsVenType" runat="server"></asp:Label></dd>
        <dt>供应商所在地区</dt>
        <dd>
            <asp:Label ID="LbiDistrict" runat="server"></asp:Label></dd>
        <dt>联系人姓名</dt>
        <dd>
            <asp:Label ID="LbsContactName" runat="server"></asp:Label></dd>
        <dt>联系人电话</dt>
        <dd>
            <asp:Label ID="LbsContactPhoneNumber" runat="server"></asp:Label></dd>
        <dt>联系人手机</dt>
        <dd>
            <asp:Label ID="LbsContactMP" runat="server"></asp:Label></dd>
        <dt>联系人邮箱</dt>
        <dd>
            <asp:Label ID="LbsContactMail" runat="server"></asp:Label></dd>
        <hr class="data-space" />
        供应商资质
        <hr class="data-space" />
        <dt>注册资金（万元）</dt>
        <dd>
            <asp:Label ID="LbiRegistCapital" runat="server"></asp:Label></dd>
        <dt>供应商注册地址</dt>
        <dd>
            <asp:Label ID="LbsRegistAddress" runat="server"></asp:Label></dd>
        <dt>营业执照编号</dt>
        <dd>
            <asp:Label ID="LbsBussinessLicenceCode" runat="server"></asp:Label></dd>
        <dt>营业执照到期日</dt>
        <dd>
            <asp:Label ID="LbdBussinessLicenceExpDate" runat="server"></asp:Label></dd>
        <dt>组织机构代码</dt>
        <dd>
            <asp:Label ID="LbsOrganizationCode" runat="server"></asp:Label></dd>
        <hr class="data-space" />
        供应商财务资料
        <hr class="data-space" />
        <dt>开票类型</dt>
        <dd>
            <asp:Label ID="LbsTaxType" runat="server"></asp:Label></dd>
        <dt>税务登记号</dt>
        <dd>
            <asp:Label ID="LbsTaxCode" runat="server"></asp:Label></dd>
        <dt>开户银行（包含支行）</dt>
        <dd>
            <asp:Label ID="LbsBankName" runat="server"></asp:Label></dd>
        <dt>银行账号名称</dt>
        <dd>
            <asp:Label ID="LbsBankAccountName" runat="server"></asp:Label></dd>
        <dt>银行账号</dt>
        <dd>
            <asp:Label ID="LbsBankAccountCode" runat="server"></asp:Label></dd>
        <dt>开票电话</dt>
        <dd>
            <asp:Label ID="LbsBillAccountPhone" runat="server"></asp:Label></dd>
        <dt>开票抬头</dt>
        <dd>
            <asp:Label ID="LbsBillAccountName" runat="server"></asp:Label></dd>
        <dt>开票地址</dt>
        <dd>
            <asp:Label ID="LbsBillAccountAddress" runat="server"></asp:Label></dd>
        <dt>发票收件地址</dt>
        <dd>
            <asp:Label ID="LbsBillRecieveAddress" runat="server"></asp:Label></dd>
        <dt>发票收件人</dt>
        <dd>
            <asp:Label ID="LbsBillRecieveContactName" runat="server"></asp:Label></dd>
        <dt>联系电话</dt>
        <dd>
            <asp:Label ID="LbsBillRecievePhone" runat="server"></asp:Label></dd>
        <dt>邮编</dt>
        <dd>
            <asp:Label ID="LbsBillRecieveZip" runat="server"></asp:Label></dd>
        <dt>资质照片</dt>
        <dd>
            <asp:Label ID="sPhotos" runat="server"></asp:Label>
        </dd>
    </dl>
    <p class="col-sm-offset-1">
        <a href="InfoChange" runat="server" id="a_modify" visible="false" class="btn btn-primary">修改</a>
        <asp:Button CssClass="btn btn-danger"  runat="server" ID="btn_return" Visible="false" Text="返回" OnClick="btn_return_ServerClick"/>
    </p>
    </form>
</asp:Content>
