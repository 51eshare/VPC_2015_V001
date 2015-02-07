<%@ Page Title="店铺列表" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShopList.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.ShopList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="css" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/jquery.dataTables.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="js" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.dataTables.min.js"></script>

</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="shoplist" role="form" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group form-group-min hidden">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入店铺名称、描述">
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <div class="form-group hidden">
            <div class="col-xs-8 col-md-3  data-space">
                <asp:DropDownList ID="sort_where" runat="server" OnSelectedIndexChanged="btn_search_ServerClick" CssClass="form-control" AutoPostBack="true">
                    <asp:ListItem Value="" Selected="True">--请选择排序方式--</asp:ListItem>
                    <asp:ListItem Value="a.总销量 desc">销量优先</asp:ListItem>
                    <asp:ListItem Value="a.总关注量 desc">关注优先</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <!-- /input-group -->
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <div class="row div_bottom div-display shop-margin">
                        <div class="col-md-3 col-sm-2">
                            <a href='ShopPds.aspx?iShopId=<%# DataBinder.Eval(Container.DataItem, "店铺Id") %>' class="btn btn-default" target="_self">
                                <img src='<%# DataBinder.Eval(Container.DataItem, "图片") %>' class="img-rounded imgouter" /></a>
                        </div>
                        <div class="col-md-6  col-sm-8">
                            <div class="caption">
                                店铺名称：<%# DataBinder.Eval(Container.DataItem, "店铺名称") %><br />
                                店铺描述：<%# DataBinder.Eval(Container.DataItem, "店铺描述") %><br />
                                总销量：<%# DataBinder.Eval(Container.DataItem, "总销量") %>&#12288;关注度：<%# DataBinder.Eval(Container.DataItem, "总关注量") %><br />
                            </div>
                        </div>
                        <div class="col-md-3  col-sm-2">
                            <a href='ShopPds.aspx?iShopId=<%# DataBinder.Eval(Container.DataItem, "店铺Id") %>' class="btn btn-default hidden" target="_self">查看</a>
                            <asp:Button ID="Collect" runat="server" CssClass="btn btn-success" Text="收藏" CommandName='<%# DataBinder.Eval(Container.DataItem, "iCollectId") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "店铺Id") %>' />
                        </div>
                    </div>

                </ItemTemplate>

                <FooterTemplate>
                </FooterTemplate>
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
        <!-- /.navbar-collapse -->
    </form>
</asp:Content>
