<%@ Page Title="快递公司管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="tbExpresses.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.tbExpresses" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="tbExpressesForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
         <div class="form-group form-group-min">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入快速公司名字">
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
                <a href="AddtbExpresses?urlreferrer=<%=StringEncode("/Admin/tbExpresses")%>&operate=<%=StringEncode("add")%>" class="btn btn-danger">添加</a>
            </div>
        </div>
        <!-- Modal -->
        <div class="container-fluid">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>编码</th>
                            <th>名称</th>
                            <th>联系电话</th>
                            <th>联系人</th>
                            <th>公司网址</th>
                            <th>状态</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "ID") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sPhone") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sUser") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sURL") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "senabled") %>
                        <input type="hidden" runat="server" id="input_iStatus" value='<%# DataBinder.Eval(Container.DataItem, "enabled") %>' />
                    </td>
                    <td>
                        <a href='AddtbExpresses.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>&urlreferrer=<%=StringEncode("/Admin/tbExpresses")%>&operate=<%=StringEncode("edit")%>' class="btn btn-primary" role="button">编辑</a>
                        <asp:Button runat="server" OnClientClick="return check();" CommandName="op" Text="禁止" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>' ID="btn_del" CssClass="btn btn-danger" />
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
