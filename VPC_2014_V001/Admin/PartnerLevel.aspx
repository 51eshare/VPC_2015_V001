<%@ Page Title="小伙伴级别管理" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="PartnerLevel.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.PartnerLevel" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="OperationManageForm" runat="server" class="form-horizontal">
        <!-- Button trigger modal -->
         <div class="form-group form-group-min">
            <div class="ol-md-4">
                <a href="AddPartnerLevel?urlreferrer=<%=StringEncode("/Admin/PartnerLevel")%>&operate=<%=StringEncode("add")%>" class="btn btn-danger">添加</a>
            </div>
        </div>
        <!-- Modal -->
        <div class="container-fluid">
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>编码</th>
                            <th>微店积分</th>
                            <th>微店等级</th>
                            <th>橱窗数</th>
                            <th>是否可以修改前台售价</th>
                            <th>佣金比率</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "ID") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "price") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "llevel") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "windows") %></td>
                    <td>
                       <%# bool.Parse(DataBinder.Eval(Container.DataItem, "ismodify").ToString())?"是":"否"%>
                    </td>
                     <td><%# DataBinder.Eval(Container.DataItem, "Rate") %>%</td>
                    <td>
                        <a href='/Admin/AddPartnerLevel?PartnerLevelID=<%# DataBinder.Eval(Container.DataItem, "ID") %>&urlreferrer=<%=StringEncode("/Admin/PartnerLevel")%>&operate=<%=StringEncode("view")%>' class="btn btn-primary" role="button">修改</a>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script type="text/javascript">
        function check() {
            return confirm("确定要进行此操作吗？")?true:false;
            }
    </script>
</asp:Content>
