<%@ Page Title="二手区" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="UsedArea.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.UsedArea" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#startdatepicker,#enddatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="Orders" role="form" class="form-horizontal" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="panel panel-default">
            <!-- Default panel contents -->
            <div class="panel-body">
                <div class="data-space"></div>
                <div class="row">
                    <label class="col-md-2 control-label">商品名称</label>
                    <div class="col-md-4">
                        <asp:TextBox class="form-control" ID="UsedName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row text-center">
                    <asp:Button ID="search" CssClass="btn btn-primary" OnClick="btn_search_ServerClick" runat="server" Text="筛选" />
                    <a href="AddUsed" class="btn btn-success">添加商品</a>
                </div>
            </div>
            <!--list-->
            <div class="container-fluid">
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>编号</th>
                                    <th>名称</th>
                                    <th>分类</th>
                                    <th>时间</th>
                                    <th>操作</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ID")%></td>
                            <td><a href="AddUsed?ID=<%#Eval("ID")%>"><%#Eval("UsedName")%></a></td>
                            <td><%#Eval("siPdClassId")%></td>
                            <td class="text-overflow"><%#Eval("Dates","{0:yyyy-MM-dd hh:mm}")%></td>
                            <td><asp:Button Text="删除" runat="server" CssClass="btn btn-primary" CommandArgument='<%#Eval("ID")%>' /> </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
            </table>
                    </FooterTemplate>
                </asp:Repeater>
                <div class="row div-display shop-margin text-center">
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
        </div>
    </form>
</asp:Content>
