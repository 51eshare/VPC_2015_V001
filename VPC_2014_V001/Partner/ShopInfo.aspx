<%@ Page Title="店铺信息" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShopInfo.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.ShopInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="ShopInfo">
    <br />
    <%: Page.Title %>
    <br />
            <dl class="dl-horizontal">

        <dt>小伙伴店铺ID</dt>
        <dd><asp:Label ID="LbiShopId" runat="server" Text="Label"></asp:Label></dd>
        <dt>小伙伴店铺名</dt>
        <dd><asp:Label ID="LbsShopName" runat="server" Text="Label"></asp:Label></dd>
        <dt>店铺描述</dt>
        <dd><asp:Label ID="LbsShopDesc" runat="server" Text="Label"></asp:Label></dd>
        <dt>小伙伴姓名</dt>
        <dd><asp:Label ID="LbcOwnerName" runat="server" Text="Label"></asp:Label></dd>
        <dt>邮箱</dt>
        <dd><asp:Label ID="LbcOwnerMail" runat="server" Text="Label"></asp:Label></dd>
        <dt>手机号</dt>
        <dd><asp:Label ID="LbcOwnerMP" runat="server" Text="Label"></asp:Label></dd>
        <dt>支付宝账号</dt>
        <dd><asp:Label ID="LbcOwnerAccout" runat="server" Text="Label"></asp:Label></dd>
        <dt>建店日期</dt>
        <dd><asp:Label ID="LbdDate" runat="server" Text="Label"></asp:Label></dd>
        <dt>店铺状态</dt>
        <dd><asp:Label ID="LbiStatus" runat="server" Text="Label"></asp:Label></dd>
        <dt>所在地区</dt>
        <dd><asp:Label ID="LbiDistrict" runat="server" Text="Label"></asp:Label></dd>
        <dt>店铺最大橱窗数量</dt>
        <dd><asp:Label ID="LbiProductNum" runat="server" Text="Label"></asp:Label></dd>
        <dt>总收藏量</dt>
        <dd><asp:Label ID="LbiCollection" runat="server" Text="Label"></asp:Label></dd>
        <dt>总点击量</dt>
        <dd><asp:Label ID="LbiClick" runat="server" Text="Label"></asp:Label></dd>
        <dt>总成交数量</dt>
        <dd><asp:Label ID="LbiVolumeNum" runat="server" Text="Label"></asp:Label></dd>
        <dt>总成交金额</dt>
        <dd><asp:Label ID="LbiVolumeSum" runat="server" Text="Label"></asp:Label></dd>
        <dt>当月成交数量</dt>
        <dd><asp:Label ID="LbiVolumeNumMonth1" runat="server" Text="Label"></asp:Label></dd>
        <dt>当月成交金额</dt>
        <dd><asp:Label ID="LbiVolumeSumMonth1" runat="server" Text="Label"></asp:Label></dd>
        <dt>近3个月成交数量</dt>
        <dd><asp:Label ID="LbiVolumeNumMonth3" runat="server" Text="Label"></asp:Label></dd>
        <dt>近3个月成交金额</dt>
        <dd><asp:Label ID="LbiVolumeSumMonth3" runat="server" Text="Label"></asp:Label></dd>

</dl >
        <asp:Button ID="Button1" runat="server" Text="修改" />
        </form>
</asp:Content>
