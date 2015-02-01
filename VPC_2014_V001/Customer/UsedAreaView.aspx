<%@ Page Title="店铺商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="UsedAreaView.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.UsedAreaView" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <div class="alert alert-danger hidden" role="alert" runat="server" id="TipMessage">
        该信息已删除，&#12288;<a href="/" class="alert-link">首页</a>&#12288;
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
                <img id="faceImg" runat="server" src="#" title="商品图片" class="productinfoimg img-thumbnail" />
                <div class="shop-margin">
                    <a class="btn btn-primary" href="/partner/vendorregist?shareuid=<%=RequestQuery("shareuid","0")%>"><i class="fa fa-home"></i>我要开店</a>&#12288;
                </div>
            </div>
            <div class="col-xs-12  col-md-8">
                <h4 class="title">
                    <asp:Label ID="UsedName" runat="server" Text=""></asp:Label>&nbsp;
                </h4>
                <p>
                    产地 :
                    <asp:Label ID="siDistrict" runat="server" Text=""></asp:Label>
                </p>
                <p>
                    品牌 :
                    <label runat="server" id="siPdClassId" />
                </p>
                 <p>
                    联系人 :
                    <label runat="server" id="siUserId" />
                </p>
                <p>
                    联系电话 :
                    <label runat="server" id="phone" />
                </p>
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
        </ul>
        <div class="tab-content">
            <!-- Description -->
            <div id="描述" class="tab-pane active" runat="server">
                 <label runat="server" id="description" />
                 
                 <div runat="server" id="imgs"></div>
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

