﻿<%@ Page Title="订单详情" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <form id="OrderDetail" runat="server">
    <dl class="dl-horizontal">
        <dt>订单日期</dt>
        <dd><asp:Label ID="dDate" runat="server" Text="Label"></asp:Label></dd>
        <dt>订单编号</dt>
        <dd><asp:Label ID="sOrderNum" runat="server" Text="Label"></asp:Label></dd>
        <dt>商品名称</dt>
        <dd><asp:Label ID="sPdName" runat="server" Text="Label"></asp:Label></dd>
        <dt>规格</dt>
        <dd><asp:Label ID="sPdStd" runat="server" Text="Label"></asp:Label></dd>
        <dt>数量</dt>
        <dd><asp:Label ID="iOrderNum" runat="server" Text="Label"></asp:Label></dd>
        <dt>单价</dt>
        <dd><asp:Label ID="fSaPrice" runat="server" Text="Label"></asp:Label></dd>
        <dt>金额</dt>
        <dd><asp:Label ID="fSaPriceSum" runat="server" Text="Label"></asp:Label></dd>
        <dt>收货人</dt>
        <dd><asp:Label ID="sRecieveName" runat="server" Text="Label"></asp:Label></dd>
        <dt>收货地址</dt>
        <dd><asp:Label ID="sAddress" runat="server" Text="Label"></asp:Label></dd>
        <dt>联系电话</dt>
        <dd><asp:Label ID="sPhoneNum" runat="server" Text="Label"></asp:Label></dd>
        <dt>是否开票</dt>
        <dd><asp:Label ID="sBill" runat="server" Text="Label"></asp:Label></dd>
        <dt>订单状态</dt>
        <dd><asp:Label ID="sStatus" runat="server" Text="Label"></asp:Label></dd>
        <dt>付款时间</dt>
        <dd><asp:Label ID="dPay" runat="server" Text="Label"></asp:Label></dd>
        <dt>支付形式</dt>
        <dd><asp:Label ID="sStyle" runat="server" Text="Label"></asp:Label></dd>
        <dt>发货时间</dt>
        <dd><asp:Label ID="Shippingdate" runat="server" Text="Label"></asp:Label></dd>
        <dt>物流公司</dt>
        <dd><asp:Label ID="sExpressID" runat="server" Text="Label"></asp:Label></dd>
        <dt>物流号</dt>
        <dd><asp:Label ID="No" runat="server" Text="Label"></asp:Label></dd>
        <dt>确认方式</dt>
        <dd><asp:Label ID="sReceivingStyle" runat="server" Text="Label"></asp:Label></dd>
        <dt>确认时间</dt>
        <dd><asp:Label ID="ReceivingDate" runat="server" Text="Label"></asp:Label></dd>
      </dl>
       <dl>
           <dt><a class="btn btn-primary col-md-offset-2" href="Orders.aspx">返回</a></dt>
       </dl>
    </form>
</asp:Content>
