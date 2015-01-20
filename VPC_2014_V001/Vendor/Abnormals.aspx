<%@ Page Title="异常订单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Abnormals.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Abnormals" %>

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
                    <th>货号<br />条码</th>
                    <th>数量<br />金额</th>
                    <th>订单状态</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                  
                    <td>2014-01-01<br />20140800001</td>
                    <td>澳洲澳大利亚进口Lemontree Dairy柠檬树牧场全脂牛奶1L*12盒</td>
                    <td>1L*12盒</td>
                    <td>12345678<br />9369999042592</td>
                    <td>1<br />300.00</td>
                    <td>异常</td>
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

</asp:Content>
