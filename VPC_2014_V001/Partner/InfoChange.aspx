<%@ Page Title="小伙伴资料变更" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="InfoChange.aspx.cs" Inherits="VPC_2014_V001.VPC.Partner.InfoChange" %>
<asp:Content ID="Content2" ContentPlaceHolderID="css" runat="server">
<link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
<link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="InfoChangeForm" role="form" runat="server" class="form-horizontal">
         <div class="alert alert-danger <%=tipclass%>"  role="alert">
        <a class="close" data-dismiss="alert">×</a>
        <p>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </p>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">小伙伴店名</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="sShopName" runat="server" placeholder="最长20位" required />
            </div>
            <div id="sShopName_tip"></div>
        </div>
        <div class="data-space"></div>
        <div class="form-group">
            <label class="col-sm-2 control-label">店铺所在地</label>
            <div class="col-sm-8">
                <input type="hidden" id="iDistrict" runat="server" name="iDistrict" />
                <select class="form-control input-width-20" runat="server" name="sDistrict" id="sDistrict" required>
                </select>
                &#12288;
            <select class="form-control input-width-20" runat="server" name="sProvince" id="sProvince">
            </select>&#12288;
            <select class="form-control input-width-20" runat="server" name="sCity" id="sCity">
            </select>
            </div>
            <div id="sDistrict_tip"></div>
        </div>
        <div class="data-space"></div>
        <div class="form-group">
            <label class="col-sm-2 control-label">邮箱</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="cOwnerMail" runat="server" placeholder="必填项" required/>
            </div>
            <div id="cOwnerMail_tip"></div>
        </div>
        <div class="data-space"></div>
         <div class="form-group">
            <label class="col-sm-2 control-label">小伙伴姓名</label>
            <div class="col-sm-8">
                 <input type="text" class="form-control" id="cOwnerName" runat="server" placeholder="最长25位" required/>
            </div>
            <div id="cOwnerName_tip"></div>
        </div>
        <div class="data-space"></div>
        <div class="form-group">
            <label class="col-sm-2 control-label">支付宝账号</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="cOwnerAccout" runat="server" placeholder="必填项" required/>
            </div>
            <div id="cOwnerAccout_tip"></div>
        </div>
        <div class="data-space"></div>
        <div class="form-group">
            <label class="col-sm-2 control-label">手机号</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="cOwnerMP" runat="server" placeholder="必填项" required/>
            </div>
            <div id="cOwnerMP_tip"></div>
        </div>
        <div class="data-space"></div>
        <div class="form-group">
            <label class="col-sm-2 control-label">店铺介绍</label>
            <div class="col-sm-8">
                 <input type="text" class="form-control" id="sShopDesc" runat="server" placeholder="最长25位" required/>
            </div>
            <div id="sShopDesc_tip"></div>
        </div>
        <div class="data-space"></div>
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
            <label id="sImagePath_tip"></label>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-4">
                <input class="btn btn-primary btn-lg" runat="server" id="btn_add" onserverclick="btn_add_ServerClick" type="submit" value="提交"/>
            </div>
        </div>
        <input type="hidden" id="iShopId" runat="server" value="0" />
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script charset="utf-8" src="/kindeditor/kindeditor-min.js"></script>
    <script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script type="text/javascript">
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
            $("#InfoChangeForm").validate({
                rules: {
                    <%=sShopName.UniqueID%>: {
                        required: true,
                        maxlength:15
                    },
                    <%=sDistrict.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=cOwnerMail.UniqueID%>: {
                        required: true,
                        email:true,
                        maxlength:25
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
                    },
                    <%=sImagePath.UniqueID%>: {
                        required: true
                    }
                },
                messages:{
                    <%=sShopName.UniqueID%>: 
                            {
                                required:"小伙伴店名不能为空",
                                maxlength:"小伙伴店名不能超过{0}个字"
                            },
                    <%=sDistrict.UniqueID%>: 
                             {
                                 required:"店铺所在地没有选择",
                                 min:"店铺所在地没有选择"
                             },
                    <%=cOwnerMail.UniqueID%>: 
                             {
                                 required:"邮箱不能为空",
                                 email:"邮箱格式不对",
                                 maxlength:"邮箱不能超过{0}个字"
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
                             },
                    <%=sImagePath.UniqueID%>: 
                             {
                                 required:"店铺Logo没有选择"
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
            $("#InfoChangeForm").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</asp:Content>
