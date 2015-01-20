<%@ Page Title="小伙伴入驻" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.Regist" %>

<asp:Content ContentPlaceHolderID="css" runat="server" ClientIDMode="Static">
    <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="body" ClientIDMode="Static" runat="server">
    <div class="content">
        <div class="container">
            <div class="panel  panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">小伙伴注册
                    </h3>
                </div>
                <div class="panel-body">
                    <div class="alert alert-danger <%=tipclass%> text-center" role="alert">
                        <a class="close" data-dismiss="alert">×</a>
                        <p>
                            <asp:Label ID="message" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                    <form runat="server" id="RegistInfo" class="form-horizontal">
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sShopName">小伙伴店名</label>
                            <div class="col-lg-8">
                                <input type="text" maxlength="10" id="sShopName" runat="server" class="form-control" name="sShopName" placeholder="最长15位" />
                            </div>
                            <label id="sShopName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sLoginId">店铺所在地</label>
                            <input type="hidden" id="iDistrict" runat="server" name="iDistrict" />
                            <div class="col-lg-2">
                                <select class="form-control" runat="server" name="sDistrict" id="sDistrict"></select>
                            </div>
                            <div class="col-lg-2">
                                <select class="form-control" runat="server" name="sProvince" id="sProvince" />
                            </div>
                            <div class="col-lg-2">
                                <select class="form-control" runat="server" name="sCity" id="sCity" />
                            </div>
                            <label id="sDistrict_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="cOwnerName">小伙伴姓名</label>
                            <div class="col-lg-8">
                                <input type="text" maxlength="25" id="cOwnerName" runat="server" class="form-control" name="cOwnerName" placeholder="最长25位" />
                            </div>
                            <label id="cOwnerName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="cOwnerAccout">支付宝账号</label>
                            <div class="col-lg-8">
                                <input type="text" maxlength="25" id="cOwnerAccout" runat="server" class="form-control" name="cOwnerName" placeholder="最长25位" />
                            </div>
                            <label id="cOwnerAccout_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="cOwnerMP">手机号</label>
                            <div class="col-lg-8">
                                <input type="text" maxlength="25" id="cOwnerMP" runat="server" class="form-control" name="cOwnerMP" placeholder="最长25位" />
                            </div>
                            <label id="cOwnerMP_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sShopDesc">店铺介绍</label>
                            <div class="col-lg-8">
                                <textarea id="sShopDesc" maxlength="50" runat="server" class="form-control" name="sShopDesc" placeholder="最长25位" />
                            </div>
                            <label id="sShopDesc_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sShopDesc">店铺Logo</label>
                            <div class="col-lg-8">
                                <div class="col-lg-6">
                                    <input type="text" id="sImagePath" runat="server" class="form-control" name="sImagePath" value="" />
                                </div>
                                <div class="col-lg-2">
                                    <input type="button" id="btn_sImagePath" class="btn btn-danger btn-sm" value="选择图片" />
                                </div>
                            </div>
                        </div>
                        <div class="text-center">
                            <input type="submit" id="Btn_Regist" class="btn btn-primary btn-lg" value="注册" runat="server"  onserverclick="Btn_Regist_Click"/>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="js" runat="server">
    <script charset="utf-8" src="/kindeditor/kindeditor-min.js"></script>
    <script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script src="/Scripts/validate.expand.js"></script>
    <script>
        KindEditor.ready(function (K) {
            var editor = K.editor({
                uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                allowFileManager: false
            });
            K('#btn_sImagePath').click(function () {
                editor.loadPlugin('image', function () {
                    editor.plugin.imageDialog({
                        imageUrl: K('#sImagePath').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#sImagePath').val(url);
                            editor.hideDialog();
                        }
                    });
                });
            });
        });
        $(function () {
            $("#RegistInfo").validate({
                rules: {
                    <%=sShopName.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sDistrict.UniqueID%>: {
                        district: true,
                        min:1
                    },
                    <%=cOwnerName.UniqueID%>: {
                        required: true,
                        maxlength:10
                    },
                    <%=cOwnerAccout.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=cOwnerMP.UniqueID%>: {
                        required: true,
                        digits:true,
                        maxlength:20
                    },
                    <%=sShopDesc.UniqueID%>: {
                        required: true,
                        maxlength:50
                    }
                },
                messages:{
                    <%=sShopName.UniqueID%>: 
                             {
                                 required:"小伙伴店名不能为空",
                                 maxlength:"小伙伴店名不能超过{0}个字"
                             },
                    <%=cOwnerName.UniqueID%>: 
                             {
                                 required:"小伙伴姓名不能为空",
                                 maxlength:"小伙伴姓名不能超过{0}个字"
                             },
                    <%=cOwnerAccout.UniqueID%>: 
                             {
                                 required:"支付宝账号不能为空",
                                 maxlength:"支付宝账号不能超过{0}个字"
                             },
                    <%=cOwnerMP.UniqueID%>: 
                             {
                                 required:"手机号不能为空",
                                 digits:"手机号只能是整数",
                                 maxlength:"手机号不能超过{0}个字"
                             },
                    <%=sShopDesc.UniqueID%>: 
                             {
                                 required:"店铺介绍不能为空",
                                 maxlength:"店铺介绍不能超过{0}个字"
                             }
                },
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
            $("#sDistrict").change(function () {
                $("#iDistrict").val($(this).val());
                $.get("/Ajax/Districts.ajax", { idistrict: $(this).val() }, function (data) {
                    var _op = "<option value=''>--请选择--</option>";
                    for (var i in data) {
                        _op += "<option value='" + data[i].iDistrict + "'>" + data[i].sProvince + "</option>";
                    }
                    $("#sProvince,#sCity").empty();
                    $("#sProvince").append(_op);
                });
            });
            $("#sProvince").change(function () {
                $("#iDistrict").val($(this).val());
                $.get("/Ajax/Districts.ajax", { idistrict: $(this).val() }, function (data) {
                    var _op = "<option value=''>--请选择--</option>";
                    for (var i in data) {
                        _op += "<option value='" + data[i].iDistrict + "'>" + data[i].sCity + "</option>";
                    }
                    $("#sCity").empty().append(_op);
                });
            });
            $("#sCity").change(function () {
                $("#iDistrict").val($(this).val());
            });
        });
    </script>
</asp:Content>
