<%@ Page Title="帐号管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.Orders" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
         <div class="form-group form-group-min">
            <div class="col-md-2">
                <select  runat="server" id="iStatus" class="form-control"></select>
            </div>
            <div class="col-md-2">
                <input type="search" runat="server" id="sVenName" class="form-control" placeholder="输入供应商名称">
            </div>
             <div class="col-md-2">
                <input type="search" runat="server" id="sShopName" class="form-control" placeholder="输入微店名称">
            </div>
            <div class="col-md-2">
                <input type="search" runat="server" id="dDate" class="form-control" placeholder="输入订单日期（2015-10-25）">
            </div>
            <div class="col-md-2">
                <input type="search" runat="server" id="sOrderNum" class="form-control" placeholder="输入订单标号">
            </div>
            <div class="ol-md-2">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <!-- Modal -->
        <div class="container-fluid">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>订单日期</th>
                            <th>订单编号</th>
                            <th>商品名称</th>
                            <th>供应商名称</th>
                            <th>微店名称</th>
                            <th>订单金额</th>
                            <th>订单状态</th>
                            <th>数据状态</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "dDate") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sOrderNum") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sPdName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sVenName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sShopName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "fSaPriceSum") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sStatus") %>
                        <input type="hidden" runat="server" id="input_iStatus" value='<%# DataBinder.Eval(Container.DataItem, "iStatus") %>' />
                    </td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sDatastatus") %></td>
                    <td>
                        <a href='Order?iOrderId=<%# DataBinder.Eval(Container.DataItem, "iOrderId") %>&urlreferrer=<%=StringEncode("/Admin/Orders")%>&operate=<%=StringEncode("view")%>' class="btn btn-primary" role="button">查看</a>
                        <asp:Button runat="server" OnClientClick="return check();" CommandName="op" Text="正常" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iOrderId") %>' ID="btn_del" CssClass="btn btn-danger" />
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
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script type="text/javascript">
        function check() {
            return confirm("确定要进行此操作吗？")?true:false;
            }
    </script>
</asp:Content>
