<%@ Page Title="帐号管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="OperationManage.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.OperationManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <h4 class="text-warning text-bold">子帐号:&#12288;您可以建立5个子帐号</h4>
        <!-- Button trigger modal -->
        <a class="btn btn-primary" id="a_btn" runat="server" href="OperationManageHistory.aspx">增加子帐号</a>
        <!-- Modal -->
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>帐号编码</th>
                            <th>用户名</th>
                            <th>用户邮箱</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "iUserId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sLoginId") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "sUserEmail") %></td>
                    <td>
                        <a href='OperationManageHistory.aspx?iUserId=<%# DataBinder.Eval(Container.DataItem, "iUserId") %>' class="btn btn-primary" role="button">编辑</a>
                        <asp:Button runat="server" OnClientClick="return check();" Text="删除" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iUserId") %>' ID="btn_del" CssClass="btn btn-danger" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
        </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script type="text/javascript">
        function check() {
            return confirm("确定要删除吗？")?true:false;
            }
    </script>
</asp:Content>
