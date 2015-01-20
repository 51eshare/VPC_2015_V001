<%@ Page Title="小伙伴入驻" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="VendorRegist.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.VendorRegist" %>

<asp:Content ContentPlaceHolderID="css" runat="server" ClientIDMode="Static">
    <link rel="stylesheet" href="/Sample/kindeditor4110/themes/default/default.css" />
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
                            <label class="col-lg-2 control-label" for="sLoginId">用户名</label>
                            <div class="col-lg-8">
                                <input type="text" id="sLoginId" runat="server" class="form-control" name="sLoginId" placeholder="最长15位" />
                            </div>
                            <label id="sLoginId_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sUserEmail">邮箱</label>
                            <div class="col-lg-8">
                                <asp:TextBox class="form-control" TextMode="Email" ID="sUserEmail" runat="server" placeholder="最长15位"></asp:TextBox>
                            </div>
                            <label id="sUserEmail_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sPassword">密码</label>
                            <div class="col-lg-8">
                                <asp:TextBox class="form-control" ID="sPassword" TextMode="Password" runat="server" placeholder="最长15位"></asp:TextBox>
                            </div>
                            <label id="sPassword_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="txtsPassword1">确认密码</label>
                            <div class="col-lg-8">
                                <asp:TextBox class="form-control" ID="txtsPassword1" TextMode="Password" runat="server" placeholder="最长15位"></asp:TextBox>
                            </div>
                            <label id="txtsPassword1_tip"></label>
                        </div>
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
                        <div class="text-center">
                            <input type="submit" id="Btn_Regist" class="btn btn-primary btn-lg" value="注册" runat="server" onserverclick="Btn_Regist_Click" />
                        </div>
                        <input type="hidden" id="shareuid" value="0" runat="server" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script src="/Scripts/validate.expand.js"></script>
    <script>
        $(function () {
            $("#RegistInfo").validate({
                rules: {
                    <%=txtsPassword1.UniqueID%>: {
                        required: true,
                        equalTo: "#sPassword"
                    },
                    <%=sLoginId.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sUserEmail.UniqueID%>: {
                        required: true,
                        email:true
                    },
                    <%=sPassword.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=sShopName.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sDistrict.UniqueID%>: {
                        district: true,
                        min:1
                    }
                },
                messages:{
                    <%=sUserEmail.UniqueID%>: {
                        required:"设置密码不能为空",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sUserEmail.UniqueID%>: {
                        required:"邮箱不能为空",
                        maxlength:"邮箱格式不对"
                    },
                    <%=txtsPassword1.UniqueID%>: {
                        required:"确认密码必须填写",
                        equalTo: "确认密码与设置密码不一致"
                    },
                    <%=sLoginId.UniqueID%>: {
                        required:"用户名不能为空",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=sShopName.UniqueID%>: 
                             {
                                 required:"小伙伴店名不能为空",
                                 maxlength:"小伙伴店名不能超过{0}个字"
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
            $("#startdatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN',pickerPosition:"bottom-left"});
        });
    </script>
</asp:Content>
