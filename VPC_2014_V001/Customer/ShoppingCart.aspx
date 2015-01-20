<%@ Page Title="购物车" enableEventValidation="false" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form runat="server" id="ShoppingCart">
        <div class="alert alert-danger <%=tipclass%>"  role="alert">
        <a class="close" data-dismiss="alert">×</a>
        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
        </div>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-xs-2">
                    <img src='<%# DataBinder.Eval(Container.DataItem, "图片") %>' height="50" width="50">
                </div>
                <div class="col-xs-7 text-overflow">
                    <h5><strong><%# DataBinder.Eval(Container.DataItem, "商品名称") %></strong>
                        <div class="empty"></div>
                        <strong>￥<%# DataBinder.Eval(Container.DataItem, "售价") %>*<%# DataBinder.Eval(Container.DataItem, "订单数量") %>件</strong></h5>
                    <div class="empty"></div>
                </div>
                <div class="col-xs-3">
                    <asp:HiddenField ID="iOrderNum" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "订单数量")%>' />
                    <asp:HiddenField ID="iUserid" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "用户Id")%>' />
                    <asp:HiddenField ID="iShopRefPdId" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "P")%>' />
                    <asp:HiddenField ID="iScId" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "iScId")%>' />
                    <asp:Button runat="server" CssClass="btn btn-danger" CommandName="btn_del" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "iScId") %>' Text="删除" />
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate></FooterTemplate>
    </asp:Repeater>
    <div class="row">
        <div class="col-xs-2">
        </div>
        <div class="col-xs-5">
        </div>
        <div class="col-xs-5">
            <h4><strong>合计：￥<label id="price" runat="server"></label></strong></h4>
        </div>
    </div>
    <div class="radio">
        <h4><strong>收货信息</strong>&nbsp;<a class="btn btn-info btn-xs" href="RecieveEdit.aspx?urlreferrer=<%=StringEncode("ShoppingCart")%>&operate=<%=StringEncode("add")%>">增加常用地址</a></h4>
        <asp:Repeater ID="Repeater2" runat="server">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <label>
                    <input type="radio" <%#bool.Parse((DataBinder.Eval(Container.DataItem, "是否默认").ToString()))?"checked":string.Empty %> name="optionsRadios" id="optionsRadios1" value="<%# DataBinder.Eval(Container.DataItem, "收货信息Id") %>">
                    <h5><%# DataBinder.Eval(Container.DataItem, "收货信息") %></h5>
                </label>
            </ItemTemplate>
            <FooterTemplate></FooterTemplate>
        </asp:Repeater>
        <input type="hidden" runat="server" id="iDistrictId"/>
    </div>
    <label>
        <input type="checkbox" name="bBill" id="bBill" runat="server">
        是否开票
    </label>
    <div class="empty"></div>
    <div class="btn-group btn-group-justified">
        <div class="btn-group">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="btn btn-primary btn-lg" Text="提交" />
        </div>
    </div>
</form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script>
        $(function () {
            $("input[name='optionsRadios']").on("click", function () {
                $("#iDistrictId").val($(this).val());
            });
        })
    </script>
</asp:Content>
