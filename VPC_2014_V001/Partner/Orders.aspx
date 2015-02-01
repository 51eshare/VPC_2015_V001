<%@ Page Title="订单列表" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Orders" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="css" runat="server">
</asp:Content>
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
                <div class="row">
                    <label class="col-md-2 control-label">订单日期</label>
                    <div class="col-md-2">
                        <div class="input-append input-group dtpicker" id="startdatepicker">
                            <asp:TextBox class="form-control" ID="startdate" runat="server"></asp:TextBox>
                            <span class="input-group-addon add-on">
                                <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                            </span>
                        </div>
                    </div>
                    <div class="col-md-2 pull-left">
                        <div class="input-append input-group dtpicker" id="enddatepicker">
                            <asp:TextBox class="form-control" ID="enddate" runat="server" TextMode="Date"></asp:TextBox>
                            <span class="input-group-addon add-on">
                                <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row">
                    <label class="col-md-2 control-label">订单编号</label>
                    <div class="col-md-10">
                        <asp:TextBox class="form-control" ID="numberno" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row">
                    <label class="col-md-2 control-label">订单状态</label>
                    <div class="col-md-10">
                        <asp:DropDownList class="form-control" ID="state" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row text-center">
                    <asp:Button ID="search" CssClass="btn btn-primary" OnClick="btn_search_ServerClick" runat="server" Text="筛选" />
                </div>
            </div>
            <!--list-->
            <div class="container-fluid">
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>订单日期/订单编号</th>
                                    <th>商品</th>
                                    <th>数量/金额</th>
                                    <th>佣金</th>
                                    <th>订单状态</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="text-overflow"><%#Eval("dDate","{0:yyyy-MM-dd}")%>/<a href="Order.aspx?iOrderId=<%#Eval("iOrderId")%>"><%#Eval("iOrderId")%></a></td>
                            <td><%#Eval("sPdName")%></td>
                            <td><%#Eval("iOrderNum")%>/<%#Eval("fSaPriceSum")%></td>
                            <td><%#Eval("fCommissionSum")%></td>
                            <td class='<%#Eval("text_style")%> text-bold'><%#Eval("sStatus")%></td>
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
