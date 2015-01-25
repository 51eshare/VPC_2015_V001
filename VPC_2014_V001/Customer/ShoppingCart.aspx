<%@ Page Title="购物车" EnableEventValidation="false" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form runat="server" id="ShoppingCart">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="row" data="data_<%# DataBinder.Eval(Container.DataItem, "iScId") %>" iScId="<%# DataBinder.Eval(Container.DataItem, "iScId") %>">
                    <div class="col-xs-2">
                        <img src='<%# DataBinder.Eval(Container.DataItem, "图片") %>' height="50" width="50">
                    </div>
                    <div class="col-xs-7 text-overflow">
                        <h5><strong><%# DataBinder.Eval(Container.DataItem, "商品名称") %></strong>
                            <div class="empty"></div>
                            <strong>￥<%# DataBinder.Eval(Container.DataItem, "售价") %>*<input type="hidden" name="price_<%# DataBinder.Eval(Container.DataItem, "iScId") %>" value="<%# DataBinder.Eval(Container.DataItem, "售价") %>" id="price_<%# DataBinder.Eval(Container.DataItem, "iScId") %>" /> <input type="number" data_id="<%# DataBinder.Eval(Container.DataItem, "iScId") %>" name="number_<%# DataBinder.Eval(Container.DataItem, "iScId") %>" id="number_<%# DataBinder.Eval(Container.DataItem, "iScId") %>" min="1" class="form-control text-width-80" value="<%# DataBinder.Eval(Container.DataItem, "订单数量") %>" />件</strong></h5>
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
            <input type="hidden" runat="server" id="iDistrictId" />
        </div>
        <label>
            <input type="checkbox" name="bBill" id="bBill" runat="server">
            是否开票
        </label>
        <div class="row" id="div_billtype">
            <div class="col-xs-2">
                <label>
                    <input type="radio" id="p" checked="checked" name="billtype" value="1" />个人</label>&#12288;<label><input type="radio" name="billtype" id="c" value="2" />单位</label>
            </div>
        </div>
        <div class="row" id="div_comhead">
            <div class=" col-md-1">
                单位抬头
            </div>
            <div class="col-xs-2">
                <input type="text" id="comhead" runat="server" class="form-control" />
            </div>
        </div>
        <div class="empty"></div>
        <div class="row">
            <div class="col-md-1">
                备注
            </div>
            <div class="col-xs-10">
                <textarea id="Remark" runat="server" class="form-control" />
            </div>
        </div>
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
            $("#div_billtype,#div_comhead").hide();
            $("input[name='optionsRadios']").on("click", function () {
                $("#iDistrictId").val($(this).val());
            });
            $("#bBill").change(function () {
                if ($("#bBill").prop("checked")) {
                    $("#div_billtype").show();
                }
                else {
                    $("#div_billtype,#div_comhead").hide();
                }
            });
            $("input[name='billtype']").change(function () {
                if ($(this).val() == "2") {
                    $("#div_comhead").show();
                }
                else {
                    $("#div_comhead").hide();
                }
            });
            $("input[name^='number_']").change(function () {
                var _allprice = 0.00;
                var _id = "";
                var _price = 0;
                var _num = 0;
                $("div[class='row'][data^='data_']").each(function () {
                    _id=$(this).attr("iScId");
                    _price=$("#price_" + _id).val();
                    _num = $("#number_" + _id).val();
                    _allprice += _price * _num;
                });
                $("#price").html(_allprice.toString()+".00");
            });
        })
    </script>
</asp:Content>
