<%@ Page Title="对帐单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Reconciliation.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Reconciliation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="Reconciliation">
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
                        <th>结算数量<br />
                            结算金额</th>
                        <th>订单状态</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>

                        <td></td>
                        <td></td>
                        <td>100<br />
                            30000.00</td>
                        <td></td>
                    </tr>
                    <hr />

                    <tr>

                        <td>2014-01-01<br />
                            20140800001</td>
                        <td>澳洲澳大利亚进口Lemontree Dairy柠檬树牧场全脂牛奶1L*12盒</td>
                        <td>1<br />
                            300.00</td>
                        <td>待结算</td>
                    </tr>

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
    </form>
</asp:Content>
