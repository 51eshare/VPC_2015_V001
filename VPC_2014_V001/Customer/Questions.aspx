<%@ Page Title="咨询清单" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.Questions" %>
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
                <div class="row">
                    <label class="col-md-2 control-label">咨询时间</label>
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
                    <label class="col-md-2 control-label">主题</label>
                    <div class="col-md-10">
                        <asp:TextBox class="form-control" ID="numberno" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="data-space"></div>
                <div class="row">
                    <label class="col-md-2 control-label">咨询类别</label>
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
                                    <th>编号</th>
                                    <th>主题</th>
                                    <th>咨询人</th>
                                    <th>时间</th>
                                    <th>是否已经回复</th>
                                    <th>操作</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("iQuestionId")%></td>
                            <td><%#Eval("bTopic")%></td>
                            <td><%#Eval("sQuestionUserId")%></td>
                            <td class="text-overflow"><%#Eval("dDate","{0:yyyy-MM-dd}")%></td>
                            <td class='<%#Eval("bApply")%> text-bold'><%#Eval("sApply")%></td>
                            <td><a class="btn btn-danger" href='Reply?iQuestionId=<%#Eval("iQuestionId")%>'>回复</a>
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
