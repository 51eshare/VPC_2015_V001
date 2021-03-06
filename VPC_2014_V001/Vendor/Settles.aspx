﻿<%@ Page Title="未结算清单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Settles.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Settles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%: Page.Title %>
    <br />
           <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">订单列表</div>
        <div class="panel-body">
            <p>
            </p>
        </div> 
        <table class="table">
            <thead>
                <tr>
                   
                    <th>订单日期<br />订单编号</th>
                    <th>商品</th>
                    <th>规格</th>
                    <th>编码<br />条码</th>
                    <th>数量<br />金额</th>
                    <th>订单状态</th>
                    <th>操作</th>

                </tr>
            </thead>

            <tbody>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate></HeaderTemplate>

        <ItemTemplate>
                <tr >
                  
                    <td><%# DataBinder.Eval(Container.DataItem, "订单日期") %><br /><%# DataBinder.Eval(Container.DataItem, "订单Id") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "商品名称") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "商品规格") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "商品Id") %><br /><%# DataBinder.Eval(Container.DataItem, "条码") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "订单数量") %><br /><%# DataBinder.Eval(Container.DataItem, "结算金额") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "状态") %></td>
                    <td><asp:Button ID="Button2" runat="server"  Text="查看" /><br /><asp:Button ID="Button3" runat="server" Text="发货" /></td>

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
</asp:Content>
