<%@ Page Title="对帐单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Reconciliation.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Reconciliation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%: Page.Title %>
    <br />


    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">订单列表</div>
        <div class="panel-body">
            <p>
                <div class="input-group input-append date">
                    <span class="input-group-addon">订单日期</span>
                    <asp:TextBox class="form-control" ID="datedDate" runat="server" TextMode="Date"></asp:TextBox>-
        <asp:TextBox class="form-control" ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">订单状态</span>
                    <asp:DropDownList class="form-control" ID="DropDownList4" runat="server"></asp:DropDownList>
                </div>
                <br />
                <asp:Button ID="Button1" runat="server" Text="筛选" />
            </p>
        </div>

        <table class="table">
            <thead>
                <tr>

                    <th>订单日期<br />
                        订单编号</th>
                    <th>商品</th>
                    <th>规格</th>
                    <th>编码<br />
                        条码</th>
                    <th>数量<br />
                        金额</th>
                    <th>订单状态</th>
                    <th>操作</th>

                </tr>
            </thead>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate></HeaderTemplate>

                    <ItemTemplate>
                        <tr>

                            <td><%# DataBinder.Eval(Container.DataItem, "订单日期") %><br />
                                <%# DataBinder.Eval(Container.DataItem, "订单Id") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "商品名称") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "商品规格") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "商品Id") %><br />
                                <%# DataBinder.Eval(Container.DataItem, "条码") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "结算价") %><br />
                                <%# DataBinder.Eval(Container.DataItem, "结算金额") %></td>
                            <td><%# DataBinder.Eval(Container.DataItem, "状态") %></td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="查看" /><br />
                                <asp:Button ID="Button3" runat="server" Text="发货" /></td>

                        </tr>
                    </ItemTemplate>

                    <FooterTemplate></FooterTemplate>

                </asp:Repeater>

            </tbody>
        </table>
    </div>


    <ul class="pagination">
        <li><a href="#">&laquo;</a></li>
        <li><a href="#">1</a></li>
        <li><a href="#">2</a></li>
        <li><a href="#">3</a></li>
        <li><a href="#">4</a></li>
        <li><a href="#">5</a></li>
        <li><a href="#">&raquo;</a></li>
    </ul>
    <br />
    <asp:Button ID="Button2" runat="server" Text="全部确认" />


</asp:Content>
