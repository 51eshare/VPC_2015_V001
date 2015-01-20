<%@ Page Title="" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="RecieveList.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.RecieveList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="alert alert-danger <%=tipclass%>"  role="alert">
        <a class="close" data-dismiss="alert">×</a>
        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
     </div>
    <div class="row">
        <div class="col-md-12">
            <form runat="server">
            <table class="table table-striped table-bordered table-hover" id="datalist">
                <asp:Repeater ID="DataList1" OnItemCommand="DataList1_ItemCommand" runat="server">
                    <HeaderTemplate>
                        <thead>
                            <tr>
                                <th>序号</th>
                                <th>收货人姓名</th>
                                <th>收货地址</th>
                                <th>联系电话</th>
                                <th>编辑 <a class="btn btn-sm btn-primary" href="RecieveEdit"><i class="fa fa-fw fa-plus"></i>添加</a></th>
                            </tr>
                            <tbody>
                        </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#DataBinder.Eval(Container.DataItem,"iRecieveInfoId")%></td>
                            <td><%#DataBinder.Eval(Container.DataItem,"sRecieveName")%></td>
                            <td><%#DataBinder.Eval(Container.DataItem,"sAddress")%></td>
                            <td><%#Eval("sPhoneNum")%></td>
                            <td>
                                <asp:Button ID="edit_row" CommandName="edit_row" Text="编辑" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iRecieveInfoId")%>' CssClass="btn btn-sm btn-success" runat="server" />
                                <asp:Button ID="del_row" Text="删除" CommandName="del_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iRecieveInfoId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    </FooterTemplate>
                </asp:Repeater>
            </table>
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="js" ID="js" runat="server">
<script type="text/javascript">
    $(function () {
        $("input[id*='del_row']", $("#datalist")).click(function () {
            return confirm("确定要删除吗？");
        });
    });
</script>
</asp:Content>
