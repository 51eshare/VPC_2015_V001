<%@ Page Title="订单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.Orders" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="css" runat="server">
 <link href="/Content/ui-dialog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script src="/Scripts/dialog-min.js"></script>
    <script src="/Scripts/dialog-plus-min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#startdatepicker,#enddatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
            $("input[id^='MainContent_Repeater1_pay_row_']").click(function () {
                $("#Alipay").prop("href", "/onpay/Alipay/default?attrsordernum=" + $(this).attr("AttrsOrderNum"));
                var elem = $('#info').html();
                dialog({
                    title: '在线支付',
                    okValue: '付款成功',
                    ok: function () {
                        this.title('提交中…');
                        return true;
                    },
                    cancelValue: '付款失败',
                    cancel: function () {},
                    content: elem,
                    padding: 6,
                    id: 'EF893L'
                }).show();
                return true;
            });
            $("input[id^='MainContent_Repeater1_payreturn_row_']").click(function () {
                return confirm("确定要退款吗？");
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="ShopPds" role="form" class="form-horizontal" runat="server">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <%-- 增加筛选--%>
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
            <!-- /input-group -->
            <div class="container-fluid">
                <table class="table table-striped table-bordered table-hover" id="datalist">
                    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                        <HeaderTemplate>
                            <headertemplate>
                        <thead>
                            <tr>
                                <th>订单编号</th>
                                <th>商品名称</th>
                                <th>价格</th>
                                <th>订单日期</th>
                                <th>状态</th>
                                <th>操作</th>
                            </tr>
                            <tbody>
                        </thead>
                    </headertemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#DataBinder.Eval(Container.DataItem,"iOrderId")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"sPdName")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"fSaPrice")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"dDate")%></td>
                                <td><%#Eval("sStatus")%></td>
                                <td>
                                    <input type="hidden" value='<%#Eval("iStatus")%>' />
                                    <asp:Button ID="pay_row" Visible="false" AttrsOrderNum='<%#DataBinder.Eval(Container.DataItem,"sOrderNum")%>'  CommandName="pay_row" Text="付款" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-success" runat="server" />
                                    <asp:Button ID="del_row" Visible="false" Text="取消" CommandName="del_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                                    <asp:Button ID="sign_row" Visible="false" Text="签收" CommandName="sign_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                                    <asp:Button ID="payreturn_row" Visible="false" Text="退款" CommandName="payreturn_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                                    <asp:Button ID="salesreturn_row" Visible="false" Text="退货退款" CommandName="salesreturn_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate></FooterTemplate>
                    </asp:Repeater>
                </table>
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
        </div>
        <div id="info" class="hidden">
            <input id="attrsordernum" type="hidden" name="attrsordernum" />
            <a href="/onpay/Alipay/default" id="Alipay" target="_blank">支付宝</a>
            <a href="/onpay/Alipay/default" target="_blank">财付通</a>
        </div>
    </form>
</asp:Content>
