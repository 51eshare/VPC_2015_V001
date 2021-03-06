﻿<%@ Page Title="可售商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Pds.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Pds" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="ShopPds" role="form" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group form-group-min">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入商品名称">
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <!-- /input-group -->
        <div class="form-group">
            <div class="col-xs-8 col-md-3  data-space">
                <asp:DropDownList ID="sort_where" runat="server" OnSelectedIndexChanged="sort_where_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Value="" Selected="True">--请选择排序方式--</asp:ListItem>
                    <asp:ListItem Value="a.iOrderNum desc">销量优先</asp:ListItem>
                    <asp:ListItem Value="a.fSaPrice desc">价格从高到底</asp:ListItem>
                    <asp:ListItem Value="a.fSaPrice asc">价格从底到高</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate></HeaderTemplate>

                <ItemTemplate>

                    <div class="row   div_bottom div-display shop-margin">
                        <div class="col-md-3">
                             <a href='/customer/shoppd?ipdid=<%# DataBinder.Eval(Container.DataItem, "iShopRefPdId") %>&shareuid=<%=UserInfo.RealID%>&shopid=<%#DataBinder.Eval(Container.DataItem, "iShopId")%>' target="_top"><img src='<%# DataBinder.Eval(Container.DataItem, "sImagePath") %>' class="img-rounded imgouter"></a>
                        </div>
                        <div class="col-md-6">
                            <div class="caption">
                                商品名称：<%# DataBinder.Eval(Container.DataItem, "sPdName") %><br />
                                前台售价：<%# DataBinder.Eval(Container.DataItem, "fSaPrice") %><br />
                                佣金：<%# DataBinder.Eval(Container.DataItem, "fCommission") %><br />
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="btn-group">
                                <asp:Button ID="sj" runat="server" Text="下架" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iShopRefPdId") %>' CssClass="btn btn-primary" />
                            </div>
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

