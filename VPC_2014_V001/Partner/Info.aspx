<%@ Page Title="小伙伴资料" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">店铺Logo</div>
        <div class="col-md-10 col-xs-6">
            <img runat="server" class="logo" id="sImagePath"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">小伙伴Id</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LBiShopId" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">小伙伴店名</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbsShopName" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">店铺介绍</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbsShopDesce" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">店铺所在地</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiDistrict" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">建立日期</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbdDate" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">店铺状态</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiStatus" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">商品橱窗数量</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiProductNum" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row hidden">
        <div class="col-md-2  col-xs-6 text-right text-bold">小伙伴姓名</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbcOwnerName" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row hidden">
        <div class="col-md-2  col-xs-6 text-right text-bold">邮箱</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbcOwnerMail" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row hidden">
        <div class="col-md-2  col-xs-6 text-right text-bold">支付宝账号</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbcOwnerAccout" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row hidden">
        <div class="col-md-2  col-xs-6 text-right text-bold">手机号</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbcOwnerMP" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">总收藏量</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiCollection" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">总成交数量</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeNum" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">总成交金额</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeSum" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">当月成交数量</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeNumMonth1" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">当月成交金额</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeSumMonth1" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">近3个月成交数量</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeNumMonth3" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2  col-xs-6 text-right text-bold">近3个月成交金额</div>
        <div class="col-md-10 col-xs-6">
            <asp:Label ID="LbiVolumeSumMonth3" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-offset-4 col-xs-offset-2">
            <button type="button" class="btn btn-primary div-display" onclick="location.href='InfoChange'">修改</button>
        </div>
    </div>
</asp:Content>
