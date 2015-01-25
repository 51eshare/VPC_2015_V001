<%@ Page Title="帐号管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="picklist.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.picklist" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
            <div class="row div_bottom">
                <label class="col-md-1 control-label">账号</label>
                <div class="col-md-2">
                 <input type="text" id="sLoginId" runat="server" class="form-control" />
                </div>
                <label class="col-md-1 control-label">申请日期</label>
                <div class="col-md-2">
                    <div class="input-append input-group dtpicker" id="startdatepicker">
                        <asp:TextBox  CssClass="form-control" ID="startdate" runat="server"></asp:TextBox>
                        <span class="input-group-addon add-on">
                            <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                        </span>
                    </div>
                </div>
                <div class="col-md-2 pull-left">
                    <div class="input-append input-group dtpicker" id="enddatepicker">
                        <asp:TextBox CssClass="form-control" ID="enddate" runat="server" TextMode="Date"></asp:TextBox>
                        <span class="input-group-addon add-on">
                            <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                        </span>
                    </div>
                </div>
                <div class="col-md-2">
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
                                <td><input type="checkbox" id="check_all" runat="server"/></td>
                                <th>编码</th>
                                <th>金额</th>
                                <th>申请日期</th>
                                <th>申请人</th>
                                <th>账号</th>
                                <th>状态</th>
                                <th>操作 <asp:Button runat="server" OnClientClick="return pass_all();" CommandName="pass_all" Text="批量付款"  ID="btn_all" OnClick="btn_all_Click" CssClass="btn btn-danger" /></th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><input type="checkbox" check_all="1" runat="server" id="checkbox_p" value='<%# DataBinder.Eval(Container.DataItem, "iCommissionId") %>'/></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "iCommissionId") %></td>
                        <td><%# Math.Abs(decimal.Parse(DataBinder.Eval(Container.DataItem, "nprice").ToString())) %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "dDate") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "sLoginId") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "ilipay") %></td>
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
        <input type="hidden" id="check_all_value" runat="server" />
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script src="/Scripts/public.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#startdatepicker,#enddatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
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
                            servicedate: $("#ServiceDate").val(), serviceprice: $("#ServicePrice").val(), iclass: _selectvalue
                        }, function (result) {
                            if (result.data)
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
