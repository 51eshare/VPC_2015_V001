<%@ Page Title="帐号管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="picklist.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.picklist" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
        <div class="form-group form-group-min">
            <div class="col-xs-8 col-md-3">
                <input type="search" runat="server" id="where" class="form-control" placeholder="可输入供应商名字">
            </div>
            <div class="ol-md-4">
                <button class="btn btn-primary" runat="server" onserverclick="btn_search_ServerClick" id="btn_search" type="button">查找</button>
            </div>
        </div>
        <!-- Modal -->
        <div class="container-fluid">
            <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate>
                    <table class="table">
                        <thead>
                            <tr>
                                <th>编码</th>
                                <th>金额</th>
                                <th>申请日期</th>
                                <th>申请人</th>
                                <th>状态</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# DataBinder.Eval(Container.DataItem, "iCommissionId") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "nprice") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "dDate") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "sLoginId") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "sStatus") %>
                            <input type="hidden" runat="server" id="input_iStatus" value='<%# DataBinder.Eval(Container.DataItem, "iState") %>' />
                        </td>
                        <td>
                            <asp:Button runat="server" Visible="false" OnClientClick="return check();" CommandName="pay" Text="已付款" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iCommissionId") %>' ID="btn_pay" CssClass="btn btn-success" />
                            <asp:Button runat="server" Visible="false" OnClientClick="return check();" CommandName="del" Text="禁止" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iCommissionId") %>' ID="btn_del" CssClass="btn btn-danger" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
        </table>
                </FooterTemplate>
            </asp:Repeater>
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
                    <h4 class="modal-title" id="myModalLabel">供应商审核
                    </h4>
                </div>

                <div class="modal-body">
                    <input type="hidden" id="iUserId" value="0" />
                    <div class="row">
                        <label class="col-lg-2">审核结果:</label>
                        <div class="col-lg-10">
                            <label for="pass">通过</label>
                            <input type="radio" id="pass" checked="checked" value="1" name="checkresult" />
                            &#12288;
                   <label for="stop">不通过</label>
                            <input type="radio" id="stop" value="2" name="checkresult" />
                        </div>
                    </div>
                    <div class="row" checkresult_id="1">
                        <label class="col-lg-2">原因:</label>
                        <div class="col-lg-10">
                            <textarea class="form-control form-inline" id="sQuestionText"></textarea>
                        </div>
                    </div>
                    <div checkresult_id="2">
                        <div class="row form-inline">
                            <label class="col-lg-2">服务费金额:</label>
                            <div class="col-lg-5">
                                <input type="number" id="ServicePrice" class="form-control" />
                            </div>(元)
                        </div>
                        <div class="data-space"></div>
                        <div class="row">
                            <label class="col-lg-2">服务到期日:</label>
                            <div class="col-lg-5">
                                <input type="date" id="ServiceDate" class="form-control" />
                            </div>(如：2015-12-31)
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
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script type="text/javascript">
        $(function () {
            $("div[checkresult_id='1']").hide();
            $("#pass").prop("checked", "checked");
            $("input[name='checkresult']").change(function () {
                if ($(this).val() == "1") {
                    $("div[checkresult_id='2']").show();
                    $("div[checkresult_id='1']").hide();
                }
                else {
                    $("div[checkresult_id='2']").hide();
                    $("div[checkresult_id='1']").show();
                }
            });
            $("input[id='show_hand']").click(function () {
                $("#iUserId").val($(this).attr("iuserid"));
                $('#myModal').modal('show');
            });
            $("#btn_submit").click(function () {

                var _selectvalue = $("input[name='checkresult']:checked").val();
                if (_selectvalue == "2") {
                    if (!$("#sQuestionText").val()) {
                        alert("原因不能为空！");
                        $("#sQuestionText").focus();
                    }
                    else {
                        $.post("/Ajax/CheckStop.ajax", {
                            _iuserid: $("#iUserId").val(), squestiontext: $("#sQuestionText").val(),
                            servicedate: $("#ServiceDate").val(), serviceprice: $("#ServicePrice").val(),iclass:_selectvalue
                        }, function (result) {
                            if(result.data)
                            alert("提交成功！");
                        else
                            alert("提交失败！");
                        });
                    }
                }
                else {
                    if (!$("#ServicePrice").val()) {
                        alert("服务费金额不能为空！");
                        $("#ServicePrice").focus();
                    }
                    else if (!$("#ServiceDate").val()) {
                        alert("服务到期日不能为空！");
                        $("#ServiceDate").focus();
                    }
                    else {
                        $.post("/Ajax/CheckStop.ajax", {
                            _iuserid: $("#iUserId").val(), squestiontext: $("#sQuestionText").val(),
                            servicedate: $("#ServiceDate").val(), serviceprice: $("#ServicePrice").val(), iclass: _selectvalue
                        }, function (result) {
                            if (result.data)
                                alert("提交成功！");
                            else
                                alert("提交失败！");
                        });
                    }
                }
            });
            $('#myModal').on('hide.bs.modal', function () {
                window.location.reload();
            })
        });
        function check() {
            return confirm("确定要进行此操作吗？") ? true : false;
        }
    </script>
</asp:Content>
