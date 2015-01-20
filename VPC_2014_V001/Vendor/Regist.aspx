<%@ Page Title="供应商入驻" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Regist" %>

<asp:Content ContentPlaceHolderID="css" runat="server" ClientIDMode="Static">
    <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="body" ClientIDMode="Static" runat="server">
    <div class="content">
        <div class="container">
            <div class="panel  panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">供应商入驻注册
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
                            <label class="col-lg-2 control-label" for="sVenName">供应商名称</label>
                            <div class="col-lg-8">
                                <input type="text" maxlength="10" id="sVenName" runat="server" class="form-control" name="sVenName" placeholder="最长15位" />
                            </div>
                            <label id="sVenName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sLoginId">供应商所属地区</label>
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
                            <label class="col-lg-2 control-label" for="sContactName">联系人姓名</label>
                            <div class="col-lg-8">
                                <input type="text" id="sContactName" runat="server" class="form-control" name="sContactName" placeholder="" />
                            </div>
                            <label id="sContactName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sContactPhoneNumber">联系人电话</label>
                            <div class="col-lg-8">
                                <input type="text" id="sContactPhoneNumber" runat="server" class="form-control" name="sContactPhoneNumber" placeholder="" />
                            </div>
                            <label id="sContactPhoneNumber_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sContactMP">联系人手机</label>
                            <div class="col-lg-8">
                                <input type="text" id="sContactMP" runat="server" class="form-control" name="sContactMP" placeholder="" />
                            </div>
                            <label id="sContactMP_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sContactMail">邮箱</label>
                            <div class="col-lg-8">
                                <input type="text" id="sContactMail" runat="server" class="form-control" name="sContactMail" placeholder="" />
                            </div>
                            <label id="sContactMail_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="iRegistCapital">注册资金</label>
                            <div class="col-lg-6">
                                <input type="text" id="iRegistCapital" runat="server" class="form-control max-width-90" name="iRegistCapital" placeholder="" />（万元）
                            </div>
                            <label id="iRegistCapital_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sRegistAddress">供应商注册地址</label>
                            <div class="col-lg-6">
                                <input type="text" id="sRegistAddress" runat="server" class="form-control" name="sRegistAddress" placeholder="" />
                            </div>
                            <label id="sRegistAddress_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBussinessLicenceCode">营业执照编号</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBussinessLicenceCode" runat="server" class="form-control" name="sBussinessLicenceCode" placeholder="" />
                            </div>
                            <label id="sBussinessLicenceCode_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="dBussinessLicenceExpDate">营业执照到期日</label>
                            <div class="col-lg-3">
                                <div id="startdatepicker" class="input-append input-group dtpicker">
                                    <input type="text" class="form-control" id="dBussinessLicenceExpDate" runat="server" name="dBussinessLicenceExpDate">
                                    <span class="input-group-addon add-on">
                                        <i class="fa fa-calendar" data-time-icon="fa fa-times" data-date-icon="fa fa-calendar"></i>
                                    </span>
                                </div>
                            </div>
                            <label id="dBussinessLicenceExpDate_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sOrganizationCode">组织机构代码</label>
                            <div class="col-lg-8">
                                <input type="text" id="sOrganizationCode" runat="server" class="form-control" name="sOrganizationCode" placeholder="" />
                            </div>
                            <label id="sOrganizationCode_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sTaxCode">税号</label>
                            <div class="col-lg-8">
                                <input type="text" id="sTaxCode" runat="server" class="form-control" name="sTaxCode" placeholder="" />
                            </div>
                            <label id="sTaxCode_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBankName">开户银行（包含支行）</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBankName" runat="server" class="form-control" name="sBankName" placeholder="" />
                            </div>
                            <label id="sBankName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBankAccountCode">银行帐号</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBankAccountCode" runat="server" class="form-control" name="sBankAccountCode" placeholder="" />
                            </div>
                            <label id="sBankAccountCode_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBankAccountName">帐号名称</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBankAccountName" runat="server" class="form-control" name="sBankAccountName" placeholder="" />
                            </div>
                            <label id="sBankAccountName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sTaxType">开票类型</label>
                            <div class="col-lg-8 form-inline">
                                <label class="form-control"><input type="radio" checked="checked" id="sTaxType_1" name="sTaxType" value="1" />普通发票</label>
                                <label class="form-control"><input type="radio" id="sTaxType_2" name="sTaxType" value="2" />增值税专用发票</label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillAccountName">开票抬头</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillAccountName" runat="server" class="form-control" name="sBillAccountName" placeholder="" />
                            </div>
                            <label id="sBillAccountName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillAccountPhone">开票电话</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillAccountPhone" runat="server" class="form-control" name="sBillAccountPhone" placeholder="" />
                            </div>
                            <label id="sBillAccountPhone_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillAccountAddress">开票地址</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillAccountAddress" runat="server" class="form-control" name="sBillAccountAddress" placeholder="" />
                            </div>
                            <label id="sBillAccountAddress_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillRecieveAddress">发票收件地址</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillRecieveAddress" runat="server" class="form-control" name="sBillRecieveAddress" placeholder="" />
                            </div>
                            <label id="sBillRecieveAddress_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillRecieveZip">发票收件邮编</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillRecieveZip" runat="server" class="form-control" name="sBillRecieveZip" placeholder="" />
                            </div>
                            <label id="sBillRecieveZip_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillRecieveContactName">发票收件人</label>
                            <div class="col-lg-8">
                                <input type="text" id="sBillRecieveContactName" runat="server" class="form-control" name="sBillRecieveContactName" placeholder="" />
                            </div>
                            <label id="sBillRecieveContactName_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sBillRecievePhone">发票收件人联系电话</label>
                            <div class="col-lg-6">
                                <input id="sBillRecievePhone" runat="server" class="form-control" name="sBillRecievePhone" placeholder="" />
                            </div>
                            <label id="sBillRecievePhone_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sShopDesc">售后服务电话</label>
                            <div class="col-lg-8">
                                <input id="sCustomerServicePhone" runat="server" class="form-control" name="sCustomerServicePhone" placeholder="" />
                            </div>
                            <label id="sCustomerServicePhone_tip"></label>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label" for="sShopDesc">资质照片</label>
                            <div class="col-lg-8">
                                <textarea name="_KindEditor" id="sPhotos" runat="server" style="height: 320px; width: 100%; visibility: hidden;"></textarea>
                            </div>
                            <label id="sShopDesc_tip"></label>
                        </div>
                        <div class="text-center">
                            <input type="submit" id="Btn_Regist" class="btn btn-primary btn-lg" value="注册" runat="server" onserverclick="Btn_Regist_Click" />
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
            var editor = K.create("#sPhotos",{
                uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                allowFileManager: true,
                afterBlur: function () {
                    document.getElementById("sPhotos").value = editor.html();
                }
            });
        });
        $(function () {
            $("#RegistInfo").validate({
                rules: {
                    <%=sVenName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sDistrict.UniqueID%>: {
                        district: true,
                        min:1
                    },
                    <%=sContactMail.UniqueID%>: {
                        required: true,
                        email:true,
                        maxlength:25
                    },
                    <%=sContactName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sContactPhoneNumber.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sContactMP.UniqueID%>: {
                        required: true,
                        digits:true,
                        maxlength:20
                    },
                    <%=sCustomerServicePhone.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sPhotos.UniqueID%>: {
                        required: true
                    },
                    <%=iRegistCapital.UniqueID%>: {
                        required: true,
                        digits:true
                    },
                    <%=sRegistAddress.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=sBussinessLicenceCode.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=dBussinessLicenceExpDate.UniqueID%>: {
                        required: true,
                        date:true
                    },
                    <%=sOrganizationCode.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sTaxCode.UniqueID%>: {
                        required: true,
                        maxlength:20
                    },
                    <%=sBankName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBankAccountCode.UniqueID%>: {
                        required: true,
                        maxlength:20
                    },
                    <%=sBankAccountName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBillAccountName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBillAccountPhone.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBillAccountAddress.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=sBillRecieveAddress.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=sBillRecieveZip.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBillRecieveContactName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sBillRecievePhone.UniqueID%>: {
                        required: true,
                        maxlength:25
                    }
                },
                messages:{
                    <%=sVenName.UniqueID%>: 
                             {
                                 required:"供应商名称不能为空",
                                 maxlength:"供应商名称不能超过{0}个字"
                             },
                    <%=sContactMail.UniqueID%>: 
                             {
                                 required:"邮箱不能为空",
                                 email:"邮箱格式不对",
                                 maxlength:"邮箱不能超过{0}个字"
                             },
                    <%=sContactName.UniqueID%>: 
                             {
                                 required:"联系人姓名不能为空",
                                 maxlength:"联系人姓名不能超过{0}个字"
                             },
                    <%=sContactPhoneNumber.UniqueID%>: 
                             {
                                 required:"联系人电话不能为空",
                                 maxlength:"联系人电话不能超过{0}个字"
                             },
                    <%=sContactMP.UniqueID%>: 
                             {
                                 required:"联系人手机不能为空",
                                 digits:"联系人手机格式不正确",
                                 maxlength:"联系人手机不能超过{0}个字"
                             },
                    <%=sCustomerServicePhone.UniqueID%>: 
                             {
                                 required:"售后服务电话不能为空",
                                 maxlength:"售后服务电话不能超过{0}个字"
                             },
                    <%=sPhotos.UniqueID%>: 
                             {
                                 required:"资质照片不能为空"
                             },
                    <%=iRegistCapital.UniqueID%>: 
                             {
                                 required:"注册资金不能为空",
                                 digits:"注册资金只能是整数"
                             },
                    <%=sRegistAddress.UniqueID%>: 
                             {
                                 required:"供应商注册地址不能为空",
                                 maxlength:"供应商注册地址不能超过{0}个字"
                             },
                    <%=sBussinessLicenceCode.UniqueID%>: 
                             {
                                 required:"营业执照编号不能为空",
                                 maxlength:"营业执照编号不能超过{0}个字"
                             },
                    <%=dBussinessLicenceExpDate.UniqueID%>: 
                             {
                                 required:"营业执照到期日不能为空",
                                 date:"营业执照到期日格式不对"
                             },
                    <%=sOrganizationCode.UniqueID%>: 
                             {
                                 required:"组织机构代码不能为空",
                                 maxlength:"组织机构代码不能超过{0}个字"
                             },
                    <%=sTaxCode.UniqueID%>: 
                             {
                                 required:"税号不能为空",
                                 maxlength:"税号不能超过{0}个字"
                             },
                    <%=sBankName.UniqueID%>: 
                             {
                                 required:"开户银行不能为空",
                                 maxlength:"开户银行不能超过{0}个字"
                             },
                    <%=sBankAccountCode.UniqueID%>: 
                             {
                                 required:"银行帐号不能为空",
                                 maxlength:"银行帐号不能超过{0}个字"
                             },
                    <%=sBankAccountName.UniqueID%>: 
                             {
                                 required:"帐号名称不能为空",
                                 maxlength:"帐号名称不能超过{0}个字"
                             },
                    <%=sBillAccountName.UniqueID%>: 
                             {
                                 required:"开票抬头不能为空",
                                 maxlength:"开票抬头不能超过{0}个字"
                             },
                    <%=sBillAccountPhone.UniqueID%>: 
                             {
                                 required:"开票电话不能为空",
                                 maxlength:"开票电话不能超过{0}个字"
                             },
                    <%=sBillAccountAddress.UniqueID%>: 
                             {
                                 required:"开票地址不能为空",
                                 maxlength:"开票地址不能超过{0}个字"
                             },
                    <%=sBillRecieveAddress.UniqueID%>: 
                             {
                                 required:"发票收件地址不能为空",
                                 maxlength:"发票收件地址不能超过{0}个字"
                             },
                    <%=sBillRecieveZip.UniqueID%>: 
                             {
                                 required:"发票收件邮编不能为空",
                                 maxlength:"发票收件邮编不能超过{0}个字"
                             },
                    <%=sBillRecieveContactName.UniqueID%>: 
                             {
                                 required:"发票收件人不能为空",
                                 maxlength:"发票收件人不能超过{0}个字"
                             },
                    <%=sBillRecievePhone.UniqueID%>: 
                             {
                                 required:"发票收件人联系电话不能为空",
                                 maxlength:"发票收件人联系电话不能超过{0}个字"
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
