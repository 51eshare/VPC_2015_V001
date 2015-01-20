<%@ Page Title="帐号管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Accounts.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.Accounts" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
         <div class="form-group form-group-min">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入会员名字">
            </div>
            <div class="ol-md-4">
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
                            <th>编码</th>
                            <th>用户名</th>
                            <th>昵称</th>
                            <th>邮箱</th>
                            <th>注册时间</th>
                            <th>积分</th>
                            <th>状态</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "iUserId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sLoginId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sNickName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sUserEmail") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "dDate") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "iPoint") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sStatus") %>
                        <input type="hidden" runat="server" id="input_iStatus" value='<%# DataBinder.Eval(Container.DataItem, "iStatus") %>' />
                    </td>
                    <td>
                        <a href='/Vendor/OperationManageHistory.aspx?iUserId=<%# DataBinder.Eval(Container.DataItem, "iUserId") %>&urlreferrer=<%=StringEncode("/Admin/Accounts")%>&operate=<%=StringEncode("edit")%>' class="btn btn-primary" role="button">编辑</a>
                        <asp:Button runat="server" OnClientClick="return check();" CommandName="op" Text="禁止" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iUserId") %>' ID="btn_del" CssClass="btn btn-danger" />
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
