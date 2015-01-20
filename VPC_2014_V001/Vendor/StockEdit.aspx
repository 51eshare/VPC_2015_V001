<%@ Page Title="库存更新" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="StockEdit.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.StockEdit" %>

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
                <HeaderTemplate>
                    <table class="table">
                        <thead class="text-center">
                            <tr>
                                <th>商品编码</th>
                                <th>商品名称</th>
                                <th>当前库存</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <td><%# DataBinder.Eval(Container.DataItem, "iPdId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sPdName") %></td>
                    <td>
                        <div class="input-group">
                            <asp:TextBox class="form-control" ID="intiQuantity" runat="server" Style="width: 100px;" TextMode="Number" placeholder="必填" Text='<%# DataBinder.Eval(Container.DataItem, "iQuantity") %>'></asp:TextBox>
                        </div>

                    </td>
                    <td>
                        <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="更新" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iPdId") %>' />
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
