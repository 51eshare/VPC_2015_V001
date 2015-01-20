<%@ Page Title="资金清单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Commissionlist.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.Commissionlist" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="css" runat="server">
 <link href="/Content/ui-dialog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script type="text/javascript">
        function check_price()
        {
            if (!$("#nprice").val())
            {
                alert("请填写提现金额");
                return false;
            }
            else if ($("#nprice").val() > $("#allnprice").html()) {
                alert("提现金额应小于总金额");
                return false;
            }
            else {
                return true;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
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
                <div class="row hidden">
                    <label class="col-md-2 control-label">总金额</label>
                    <div class="col-md-2">
                        <label class=" text-bold text-success" id="allnprice" runat="server"></label>&nbsp;元
                    </div>
                    <label class="col-md-2 control-label">提现金额</label>
                    <div class="col-md-1">
                        <asp:TextBox ID="nprice" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row hidden">
                    <label class="col-md-2 control-label">姓名</label>
                    <div class="col-md-2">
                        <asp:TextBox class="form-control" ReadOnly="true" ID="Sname" runat="server"></asp:TextBox>
                    </div>
                     <label class="col-md-2 control-label">支付宝账户</label>
                    <div class="col-md-2">
                        <asp:TextBox class="form-control" ReadOnly="true" ID="ilipay" runat="server"></asp:TextBox>
                    </div>  
                    <label class="col-md-2 control-label">手机号</label>
                    <div class="col-md-2">
                        <asp:TextBox class="form-control" ReadOnly="true" ID="mobile" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row text-center">
                    <asp:Button ID="search" CssClass="btn btn-primary hidden" OnClientClick="return check_price();" OnClick="btn_search_ServerClick" runat="server" Text="提现" />
                    <a href="pickCommission" class="btn btn-primary">提现</a>
                </div>
            </div>
            <!-- /input-group -->
            <div class="container-fluid">
                <table class="table table-striped table-bordered table-hover" id="datalist">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <headertemplate>
                        <thead>
                            <tr>
                                <th>资金编号</th>
                                <th>金额</th>
                                <th>日期</th>
                                <th>说明</th>
                            </tr>
                            <tbody>
                        </thead>
                    </headertemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#DataBinder.Eval(Container.DataItem,"iCommissionId")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"nprice")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"dDate")%></td>
                                <td><%#DataBinder.Eval(Container.DataItem,"remark")%></td>
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
    </form>
</asp:Content>
