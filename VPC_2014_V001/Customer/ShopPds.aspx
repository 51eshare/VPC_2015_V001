﻿<%@ Page Title="" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShopPds.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.ShopPds" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="ShopPds" role="form" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="row data-space" runat="server" id="shoplogo">
            <div class="col-md-2">
                <img class="img-rounded"  height="100" width="100" src="<%=tbshop.sImagePath%>"/>
            </div>
            <div class="col-md-10">
                <h2><%=tbshop.sShopName%></h2>
                <p><%=tbshop.sShopDesc%></p>
                <p class="hidden"><a class="btn btn-primary" role="button">收藏</a></p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入商品名称、描述">
            </div>
            <div class="col-md-6">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-8 col-md-3  data-space">
                <asp:DropDownList ID="sort_where" runat="server" OnSelectedIndexChanged="sort_where_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Value="" Selected="True">--请选择排序方式--</asp:ListItem>
                    <asp:ListItem Value="成交总数量 desc">销量优先</asp:ListItem>
                    <asp:ListItem Value="前台售价 desc">价格从高到底</asp:ListItem>
                    <asp:ListItem Value="前台售价 asc">价格从底到高</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div class="row  div_bottom div-display shop-margin">
                        <div class="col-xs-3">
                            <a href='shoppd?ipdid=<%# DataBinder.Eval(Container.DataItem, "P") %>&shareuid=<%=UserInfo==null?0:UserInfo.RealID%>&shopid=<%#DataBinder.Eval(Container.DataItem, "微店Id")%>'>
                                <img src='<%# DataBinder.Eval(Container.DataItem, "图片") %>' class="img-rounded imgouter" />
                            </a>
                        </div>
                        <div class="col-xs-6">
                            <div class="caption">
                                商品名称：<%# DataBinder.Eval(Container.DataItem, "商品名称") %><br />
                                前台售价：<%# DataBinder.Eval(Container.DataItem, "前台售价") %><br />
                                佣金：<%# DataBinder.Eval(Container.DataItem, "佣金") %><br />
                            </div>
                        </div>
                        <div class="col-xs-3">
                                <asp:Button ID="buy" runat="server" CommandName="buy" CssClass="btn btn-primary btn-lg" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "P") %>'  Text="购买" />  
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate></FooterTemplate>
            </asp:Repeater>
            <div class="row div-display shop-margin">
                <div class="col-lg-12 col-sm-12 col-xs-12 col-xxs-12">
                    <webdiyer:AspNetPager ID="aspnetpagerpaging" CssClass="aspnetpager" CurrentPageButtonClass="cpb"
                        OnPageChanged="paging_PageChanged" runat="server" FirstPageText="首页" PageSize="5"
                        LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" AlwaysShow="true" ShowPageIndexBox="Never" NumericButtonCount="10"
                        CurrentPageButtonPosition="End"
                        ShowFirstLast="false">
                    </webdiyer:AspNetPager>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
