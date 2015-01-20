<%@ Page Title="店铺商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="ShopPd.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.ShopPd" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <div class="alert alert-danger hidden" role="alert" runat="server" id="TipMessage">
        商品已经下架，请&#12288;<a href="shoppds?ishopid=<%=RequestQuery("shopid","0")%>" class="alert-link">查看</a>&#12288;该店铺其他商品。
    </div>
    <div runat="server" id="ShopPdInfo">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="row">
            <div class="col-xs-12 col-md-4">
                <img id="图片" runat="server" src="#" title="商品图片" class="productinfoimg img-thumbnail" />
                <div class="shop-margin">
                    <a class="btn btn-primary" href="/partner/vendorregist?shareuid=<%=RequestQuery("shareuid","0")%>"><i class="fa fa-home"></i>我要开店</a>&#12288;
                    <a class="btn btn-danger" href="shoppds?ishopid=<%=RequestQuery("shopid","0")%>"><i class="fa fa-eye"></i>进入店铺</a>
                </div>
            </div>
            <div class="col-xs-12  col-md-8">
                <h4 class="title">
                    <asp:Label ID="商品名称" runat="server" Text=""></asp:Label>&nbsp;
                </h4>
                <h5>售价 :
                    <asp:Label ID="前台售价" runat="server" Text=""></asp:Label></h5>
                <p>
                    产地名称 :
                    <asp:Label ID="产地名称" runat="server" Text=""></asp:Label>
                </p>
                <p>
                    商品品牌 :
                    <label runat="server" id="商品品牌" />
                </p>
                <p>
                    商品规格 :
                    <label runat="server" id="商品规格" />
                </p>
                <p>
                    包装 :
                    <label runat="server" id="包装" />
                </p>
                <p>
                    食品有效期 :
                    <label runat="server" id="食品有效期" />
                </p>
                <p>
                    条码 :
                    <label runat="server" id="条码" />
                </p>
                <p>
                    条码 :
                    <label runat="server" id="Label2" />
                </p>
                <form id="ShopPdInfoForm" role="form" class="form-horizontal" runat="server">
                    <div class="input-group">
                        <span class="input-group-addon" style="width: 100px;">购买数量</span>
                        <asp:TextBox class="form-control" ID="txtiOrderNum" runat="server" Style="width: 100px;" TextMode="Number" Text="">1</asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfviOrderNum" runat="server" ErrorMessage="  * 必填" Display="Dynamic" ControlToValidate="txtiOrderNum" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rfvtxtiRegistCapital1" runat="server" ErrorMessage="  * 请填写整数" Display="Dynamic" ControlToValidate="txtiOrderNum" ForeColor="Red" ValidationExpression="^([1-9][0-9]*)$"></asp:RegularExpressionValidator>
                    </div>
                </form>
            </div>
        </div>
        <div class="data-space"></div>
        <div class="text-center">
            <div class="btn-group">
                <button class="btn btn-primary btn-lg" id="ljgm" runat="server" data-toggle="modal" onserverclick="ljgm_ServerClick">
                    立即购买
                </button>
            </div>
            <div class="btn-group">
                <button class="btn btn-warning btn-lg" id="gwc" onserverclick="gwc_ServerClick" runat="server">
                    加入购物车
                </button>
            </div>
        </div>
        <div class="data-space"></div>
        <!-- JiaThis Button BEGIN -->
        <div class="jiathis_style_32x32 row" id="sharediv">
            <span class="jiathis_txt">分享到：</span>
            <a class="jiathis_button_tsina"></a>
            <a class="jiathis_button_tqq"></a>
            <a class="jiathis_button_cqq"></a>
        </div>
        <script type="text/javascript">
            var jiathis_config = {
                summary: "",
                shortUrl: true,
                hideMore: false
            }
        </script>
        <script type="text/javascript" src="http://v3.jiathis.com/code/jia.js" charset="utf-8"></script>
        <!-- JiaThis Button END -->
        <ul class="nav nav-tabs">
            <!-- Use uniqe name for "href" in below anchor tags -->
            <li class="active"><a data-toggle="tab" href="#描述">描述</a></li>
            <li class=""><a data-toggle="tab" href="#tab2">商品统计</a></li>
            <li class=""><a data-toggle="tab" href="#tab3">咨询</a></li>
        </ul>
        <div class="tab-content">
            <!-- Description -->
            <div id="描述" class="tab-pane active" runat="server">
            </div>
            <!-- Sepcs -->
            <div id="tab2" class="tab-pane">
                <table class="table table-striped tcart">
                    <tbody>
                        <tr>
                            <td><strong>成交总数</strong></td>
                            <td>
                                <label runat="server" id="成交总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>评论总数量</strong></td>
                            <td>
                                <label runat="server" id="评论总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>点击总数量</strong></td>
                            <td>
                                <label runat="server" id="点击总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>商品好评总数量</strong></td>
                            <td>
                                <label runat="server" id="商品好评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>商品中评总数量</strong></td>
                            <td>
                                <label runat="server" id="商品中评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>商品差评总数量</strong></td>
                            <td>
                                <label runat="server" id="商品差评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>服务好评总数量</strong></td>
                            <td>
                                <label runat="server" id="Label1"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>服务中评总数量</strong></td>
                            <td>
                                <label runat="server" id="服务中评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>服务差评总数量</strong></td>
                            <td>
                                <label runat="server" id="服务差评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>物流好评总数量</strong></td>
                            <td>
                                <label runat="server" id="物流好评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>物流中评总数量</strong></td>
                            <td>
                                <label runat="server" id="物流中评总数量"></label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>物流差评总数量</strong></td>
                            <td>
                                <label runat="server" id="物流差评总数量"></label>
                            </td>
                        </tr>
                    </tbody>
                </table>

            </div>
            <!-- Review -->
            <div id="tab3" class="tab-pane">
                <div class="form form-small">
                    <form class="form-horizontal" id="QuestionInfo">
                        <div class="data-space"></div>
                        <!-- Review form (not working)-->
                        <!-- Name -->
                        <div class="form-group">
                            <label for="name2" class="control-label col-md-2">标题</label>
                            <div class="col-md-6">
                                <input type="text" id="bTopic" name="bTopic" class="form-control">
                            </div>
                            <div id="bTopic_tip"></div>
                        </div>
                        <!-- Review -->
                        <div class="form-group">
                            <label for="name" class="control-label col-md-2">内容</label>
                            <div class="col-md-6">
                                <textarea class="form-control" name="sQuestionText" id="sQuestionText" rows="6"></textarea>
                            </div>
                            <div id="sQuestionText_tip"></div>
                        </div>
                        <!-- Buttons -->
                        <div class="form-group">
                            <!-- Buttons -->
                            <div class="col-md-6 col-md-offset-3">
                                <%if (UserInfo == null)
                                  {%>
                                <div class="alert-danger text-center bold"><a href="/Account/Login">如果需要咨询，请先登录</a></div>
                                <%}
                                  else
                                  {%>
                                <button class="btn btn-default" id="btn_sub" type="submit">提交</button>
                                <button class="btn btn-default" id="btn_reset" type="reset">重置</button>
                                <%}%>
                            </div>
                        </div>
                    </form>
                </div>

            </div>
        </div>
        <input type="hidden" id="iquestionuserid" runat="server" />
        <input type="hidden" id="iuserid" runat="server" />
        <input type="hidden" id="P" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            if (isWeiXin()) $("#sharediv").hide();
            $("#QuestionInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules: {
                    bTopic: {
                        required: true,
                        maxlength: 25
                    },
                    sQuestionText: {
                        required: true,
                        maxlength: 400
                    }
                },
                messages: {
                    bTopic: {
                        required: "标题不能为空",
                        maxlength: "最长不能超过{0}个字"
                    },
                    sQuestionText: {
                        required: "内容不能为空",
                        maxlength: "最长不能超过{0}个字"
                    }
                },
                submitHandler: function (form) {
                    $.get("/Ajax/AddQuestion.ajax", { bTopic: $("#bTopic").val(), sQuestionText: $("#sQuestionText").val(), iObjectId: $("#P").val(), iUserId: $("#iuserid").val(), iQuestionUserId: $("#iquestionuserid").val(), iQuestionType: 1 }, function (data) {
                        if (data.data > 0) {
                            alert("咨询提交成功！");
                            $("#btn_reset").click();
                        }
                        else {
                            alert("咨询提交失败，请核对信息后再提交！");
                        }
                    });
                    return false;
                }
            });
        });
    </script>

</asp:Content>

