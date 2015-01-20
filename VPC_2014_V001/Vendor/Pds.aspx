<%@ Page Title="供应商商品列表" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Pds.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Pds" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="ShopPds" role="form" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <%-- 增加筛选--%>
        <div class="form-group form-group-min">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入商品名称">
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <!-- /input-group -->
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div class="row div_bottom div-display shop-margin">
                        <div class="col-xs-3">
                            <a href="ShopPd?iPdId=<%# DataBinder.Eval(Container.DataItem, "iPdId") %>" target="_blank">
                            <img src='<%# DataBinder.Eval(Container.DataItem, "sImagePath") %>' height="100" width="100"></a>
                        </div>
                        <div class="col-xs-6">
                            <div class="caption">
                                商品名称:<%# DataBinder.Eval(Container.DataItem, "sPdName") %>
                                <br />
                                商品品牌:<%# DataBinder.Eval(Container.DataItem, "sPdBrand") %>
                                <br />
                                商品规格:<%# DataBinder.Eval(Container.DataItem, "sPdStd") %>
                                <br />
                                结算价:<%# DataBinder.Eval(Container.DataItem, "fPurPrice") %>
                                <br />
                                状态:<%# DataBinder.Eval(Container.DataItem, "sStatus") %>
                            </div>
                        </div>
                        <div class="col-xs-3">
                            <div class="btn-group">
                                <a class="btn btn-default" href='PdAdd?iPdId=<%# DataBinder.Eval(Container.DataItem, "iPdId") %>'>编辑</a>
                                <asp:Button ID="btn_check_up" CssClass="btn btn-primary" runat="server" Text="上架" CommandName="up" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iPdId") %>' />
                                <asp:Button ID="btn_check_down" CssClass="btn btn-danger" runat="server" Text="下架" CommandName="down" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iPdId") %>' />
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
