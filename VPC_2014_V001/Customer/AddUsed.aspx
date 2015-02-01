<%@ Page Title="添加二手资料" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="AddUsed.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.AddUsed" %>

<asp:Content ID="Content2" ContentPlaceHolderID="css" runat="server">
    <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="InfoChangeForm" role="form" runat="server" class="form-horizontal">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">商品名称</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="UsedName" runat="server" placeholder="最长25位" required />
            </div>
            <div id="UsedName_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">商品分类</label>
            <div class="col-sm-8">
                <input id="iPdClassId" runat="server" value="0" name="iPdClassId" type="hidden" />
                <asp:DropDownList class="form-control input-width-20" ID="DropDownList7" runat="server"></asp:DropDownList>
                <asp:DropDownList class="form-control input-width-20" ID="DropDownList8" runat="server"></asp:DropDownList>
            </div>
            <label id="DropDownList7_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">商品所在地</label>
            <div class="col-sm-8">
                <input type="hidden" id="iDistrict" runat="server" name="iDistrict" />
                <select class="form-control input-width-20" runat="server" name="sDistrict" id="sDistrict">
                </select>
                &#12288;
            <select class="form-control input-width-20" runat="server" name="sProvince" id="sProvince">
            </select>&#12288;
            <select class="form-control input-width-20" runat="server" name="sCity" id="sCity">
            </select>
            </div>
            <div id="sDistrict_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">手机号</label>
            <div class="col-sm-8">
                <input type="text" class="form-control" id="phone" runat="server" placeholder="最长25位" />
            </div>
            <div id="phone_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">介绍</label>
            <div class="col-sm-8">
                <textarea type="text" class="form-control" id="description" runat="server" placeholder="最长1000位" />
            </div>
            <div id="description_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="faceImg">封面图片</label>
            <div class="col-lg-8">
                <div class="col-lg-6">
                    <input type="text" id="faceImg" runat="server" class="form-control" name="faceImg" value="" />
                </div>
                <div class="col-lg-2">
                    <input type="button" id="faceImg_btn" class="btn btn-danger btn-sm" value="选择图片" />
                </div>
            </div>
            <label id="faceImg_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="sShopDesc">商品图片1</label>
            <div class="col-lg-8">
                <div class="col-lg-6">
                    <input type="text" id="sImagePath_1" runat="server" class="form-control" name="sImagePath" value="" />
                </div>
                <div class="col-lg-2">
                    <input type="button" id="btn_sImagePath_1" class="btn btn-danger btn-sm" value="选择图片" />
                </div>
            </div>
            <label id="sImagePath_1_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="sShopDesc">商品图片2</label>
            <div class="col-lg-8">
                <div class="col-lg-6">
                    <input type="text" id="sImagePath_2" runat="server" class="form-control" name="sImagePath" value="" />
                </div>
                <div class="col-lg-2">
                    <input type="button" id="btn_sImagePath_2" class="btn btn-danger btn-sm" value="选择图片" />
                </div>
            </div>
            <label id="sImagePath_2_tip"></label>
        </div>
        <div class="form-group">
            <label class="col-lg-2 control-label" for="sShopDesc">商品图片3</label>
            <div class="col-lg-8">
                <div class="col-lg-6">
                    <input type="text" id="sImagePath_3" runat="server" class="form-control" name="sImagePath" value="" />
                </div>
                <div class="col-lg-2">
                    <input type="button" id="btn_sImagePath_3" class="btn btn-danger btn-sm" value="选择图片" />
                </div>
            </div>
            <label id="sImagePath_3_tip"></label>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-4">
                <input class="btn btn-primary btn-lg" runat="server" id="btn_add" onserverclick="btn_add_ServerClick" type="submit" value="提交" />
                &#12288;<a href="UsedArea" class="btn btn-primary btn-lg">返回</a>
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
            var faceimgeditor = K.editor({
                uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>&width=200',
                fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                allowFileManager: false
            });
            K('#faceImg_btn').click(function () {
                faceimgeditor.loadPlugin('image', function () {
                    faceimgeditor.plugin.imageDialog({
                        imageUrl: K('#faceImg').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#faceImg').val(url);
                            faceimgeditor.hideDialog();
                        }
                    });
                });
            });
            K('#btn_sImagePath_1').click(function () {
                editor.loadPlugin('image', function () {
                    editor.plugin.imageDialog({
                        imageUrl: K('#sImagePath_1').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#sImagePath_1').val(url);
                            editor.hideDialog();
                        }
                    });
                });
            });
            K('#btn_sImagePath_2').click(function () {
                editor.loadPlugin('image', function () {
                    editor.plugin.imageDialog({
                        imageUrl: K('#sImagePath_2').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#sImagePath_2').val(url);
                            editor.hideDialog();
                        }
                    });
                });
            });
            K('#btn_sImagePath_3').click(function () {
                editor.loadPlugin('image', function () {
                    editor.plugin.imageDialog({
                        imageUrl: K('#sImagePath_3').val(),
                        clickFn: function (url, title, width, height, border, align) {
                            K('#sImagePath_3').val(url);
                            editor.hideDialog();
                        }
                    });
                });
            });
        });
        $(function () {
            $("#InfoChangeForm").validate({
                rules: {
                    <%=UsedName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sDistrict.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=description.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=faceImg.UniqueID%>: {
                        required: true
                    }
                },
                messages:{
                    <%=UsedName.UniqueID%>: 
                            {
                                required:"商品名称不能为空",
                                maxlength:"商品名称不能超过{0}个字"
                            },
                    <%=sDistrict.UniqueID%>: 
                             {
                                 required:"商品所在地没有选择",
                                 min:"商品所在地没有选择"
                             },
                    <%=description.UniqueID%>: 
                             {
                                 required:"商品介绍不能为空",
                                 maxlength:"商品介绍不能超过{0}个字"
                             },
                    <%=faceImg.UniqueID%>: 
                             {
                                 required:"封面图片不能为空"
                             }
                }, errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "*tip").html(error);
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
            $("#DropDownList7").change(function () {
                $("#iPdClassId").val($(this).val());
                $.get("/Ajax/ProductClasses.ajax", { ipdfatherid: $(this).val() }, function (data) {
                    var _op = "<option value=''>--请选择--</option>";
                    for (var i in data) {
                        _op += "<option value='" + data[i].iPdClassId + "'>" + data[i].cPdClass + "</option>";
                    }
                    $("#DropDownList8").empty().append(_op);
                });
            });
            $("#DropDownList8").change(function () {
                $("#iPdClassId").val($(this).val());
            });
        });
    </script>
</asp:Content>
