<%@ Page Title="订单列表" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Orders" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#startdatepicker,#enddatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
            $("input[id='show_hand']").click(function () {
                $("#iUserId").val($(this).attr("iuserid"));
                $('#myModal').modal('show');
            });
            $("#btn_submit").click(function () {
                if (!$("#ExpressID").val()) {
                    alert("请选择快递公司！");
                    $("#ExpressID").focus();
                }
                else if (!$("#No").val())
                {
                    alert("请填写快递单号！");
                    $("#No").focus();
                }
                else {
                    $.post("/Ajax/CheckExpress.ajax", {
                        iOrderId: $("#iUserId").val(), ExpressID: $("#ExpressID").val(), No: $("#No").val()
                    }, function (result) {
                        if (result.data) {
                            alert("提交成功！");
                            $('#myModal').modal('hide');
                        }
                        else
                            alert("提交失败！");
                    });
                }
            });
            $('#myModal').on('hide.bs.modal', function () {
                window.location.href = window.location.href;
            })
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
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>订单日期/订单编号</th>
                                    <th>商品</th>
                                    <th>数量/金额</th>
                                    <th>订单状态</th>
                                    <th>操作</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="text-overflow"><%#Eval("dDate","{0:yyyy-MM-dd}")%>/<a href="Order.aspx?iOrderId=<%#Eval("iOrderId")%>"><%#Eval("iOrderId")%></a></td>
                            <td><%#Eval("sPdName")%></td>
                            <td><%#Eval("iOrderNum")%>/<%#Eval("fSaPrice")%></td>
                            <td class='<%#Eval("text_style")%> text-bold'><%#Eval("sStatus")%></td>
                            <td>
                                <input type="button" runat="server" visible='<%#Eval("iStatus").ToString().Equals("2")%>' iuserid='<%# DataBinder.Eval(Container.DataItem, "iOrderId") %>' class="btn btn-danger" value="发货" id="show_hand" />
                                <asp:Button ID="payreturn_row" Visible="false" Text="确认退款" CommandName="payreturn_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                                <asp:Button ID="salesreturn_row" Visible="false" Text="确认退货退款" CommandName="salesreturn_row" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"iOrderId")%>' CssClass="btn btn-sm btn-danger" runat="server" />
                            </td>
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
    <!-- 模态框（Modal） -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog"
        aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"
                        aria-hidden="true">
                        ×
                    </button>
                    <h4 class="modal-title" id="myModalLabel">发货确认
                    </h4>
                </div>

                <div class="modal-body">
                    <input type="hidden" id="iUserId" value="0" />
                    <div class="row">
                        <label class="col-lg-2">快递公司:</label>
                        <div class="col-lg-6">
                            <select id="ExpressID" runat="server" class="form-control"></select>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-lg-2">快递单号:</label>
                        <div class="col-lg-6">
                            <input type="text" id="No" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btn_submit" class="btn btn-primary">
                        提交
                    </button>
                    <button type="button" class="btn btn-default"
                        data-dismiss="modal">
                        关闭
                    </button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
</asp:Content>
