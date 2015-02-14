<%@ Page Title="广告列表" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="adlist.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.adlist" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="StockEditInfo" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <%-- 增加筛选--%>
        <div class="form-group form-group-min">
            <div class="col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入商品名称">
            </div>
            <div class="col-xs-8 col-md-3">
                <select id="iStatus" runat="server" class="form-control"></select>
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
                <a href="/Admin/Addad?urlreferrer=<%=StringEncode("/Vendor/adlist")%>&operate=<%=StringEncode("add")%>" class="btn btn-danger">添加</a>
            </div>
        </div>
        <!-- /input-group -->
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound">
                <HeaderTemplate>
                    <table class="table">
                        <thead class="text-center">
                            <tr>
                                <th>编码</th>
                                <th>商品名称</th>
                                <th>广告时间</th>
                                <th>当前状态</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <td><%# DataBinder.Eval(Container.DataItem, "iAdPdId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sPdName") %></td>
                    <td>
                        <%# DataBinder.Eval(Container.DataItem, "dBeginDate") %>~<%# DataBinder.Eval(Container.DataItem, "dEndDate") %>
                    </td>
                    <td><%# DataBinder.Eval(Container.DataItem, "siStatus") %></td>
                    <td>
                        <a href='/Admin/Addad?iadpdid=<%# DataBinder.Eval(Container.DataItem, "iAdPdId") %>&urlreferrer=<%=StringEncode("/Vendor/adlist")%>&operate=<%=StringEncode("view")%>' class="<%# DataBinder.Eval(Container.DataItem, "iStatus").ToString().Equals("1")?"btn btn-primary":"hidden"%>" role="button">编辑</a>
                        <asp:Button ID="Button2" Visible="false" CssClass="btn btn-danger" runat="server" Text="删除" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iAdPdId") %>' />
                    </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
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
    </form>
</asp:Content>
