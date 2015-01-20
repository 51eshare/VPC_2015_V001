<%@ Page Title="添加商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="PdAdd.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.PdAdd" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="PdAddInfo" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">商品分类</span>
            <input id="iPdClassId" runat="server" value="0" name="iPdClassId" type="hidden"/>
            <asp:DropDownList class="form-control" ID="DropDownList7" runat="server"></asp:DropDownList>
            <asp:DropDownList class="form-control" ID="DropDownList8" runat="server"></asp:DropDownList>
            <label id="DropDownList7_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">商品名称</span>
            <asp:TextBox class="form-control" ID="sPdName" runat="server" Style="width: 300px;" placeholder="（最多包含50个字）必填项"></asp:TextBox>
            <label id="sPdName_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">品牌</span>
            <asp:TextBox class="form-control" ID="sPdBrand" runat="server" Style="width: 300px;" placeholder="（中文/英文）必填项"></asp:TextBox>
            <label id="sPdBrand_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">规格</span>
            <asp:TextBox class="form-control" ID="sPdStd" runat="server" Style="width: 300px;" placeholder="（例：1000ml/瓶、500g/包等）必填项"></asp:TextBox>
            <label id="sPdStd_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">产地</span>
            <input type="hidden" id="iDistrict" runat="server" name="iDistrict" />
            <select class="form-control" runat="server" name="sDistrict" id="sDistrict"></select>
            <select class="form-control" runat="server" name="sProvince" id="sProvince" />
            <select class="form-control" runat="server" name="sCity" id="sCity" />
            <label id="sDistrict_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">包装方式</span>
            <asp:TextBox class="form-control" ID="sPdPackage" runat="server" Style="width: 300px;" placeholder="（例：盒装、瓶装等）必填项"></asp:TextBox>
            <label id="sPdPackage_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">食品有效期</span>
            <asp:TextBox class="form-control" ID="sQualityPeriod" runat="server" Style="width: 300px;" placeholder="（例：2年、10个月、15天）必填项"></asp:TextBox>
            <label id="sQualityPeriod_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">条码</span>
            <asp:TextBox class="form-control" ID="sbarCode" runat="server" Style="width: 300px;" placeholder="必填项，无条码填0"></asp:TextBox>
            <label id="sbarCode_tip"></label>
        </div>
        <div class="data-space"></div>
        供货资料
     <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">可售数量</span>
            <asp:TextBox class="form-control" ID="iQuantity" runat="server" Style="width: 300px;" TextMode="Number" placeholder="必填项"></asp:TextBox>
            <label id="iQuantity_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 115px;">供应商供价</span>
            <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
            <asp:TextBox class="form-control" ID="fPurPrice" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="fPurPrice_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 115px;">前台售价</span>
            <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
            <asp:TextBox class="form-control" ID="fSaPrice" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="fSaPrice_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 115px;">市场价</span>
            <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
            <asp:TextBox class="form-control" ID="fBdPrice" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <label id="fBdPrice_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group dtpicker" id="startdatepicker">
            <span class="input-group-addon">价格有效日期</span>
            <asp:TextBox class="form-control input-width" ID="dValidDate" runat="server"  Text="2099-12-31" TextMode="Date"></asp:TextBox>
            <span class="input-group-addon add-on">
                <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
            </span>
        </div>
        <label id="dValidDate_tip"></label>
        <div class="data-space"></div>
        <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
        <script charset="utf-8" src="/kindeditor/kindeditor-min.js"></script>
        <script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
        <script>
            var editor;
            KindEditor.ready(function (K) {
                editor = K.create('#sMemo', {
                    uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    allowFileManager: true,
                    afterBlur: function () {
                        document.getElementById("sMemo").value = editor.html();
                       
                    }
                }
                );
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
        </script>
        <div class="row">
            <div class="col-md-4">
                <span style="width: 115px;">封面图片</span>
                <input type="text" id="sImagePath" runat="server" class="form-control" name="sImagePath" value=""/>
                <input type="button" id="btn_sImagePath" class="btn btn-danger btn-sm" value="选择图片" />
                <label id="sImagePath_tip"></label>
            </div>
        </div>
        <div class="data-space"></div>
        <textarea name="_KindEditor" id="sMemo" runat="server" style="height: 320px; width: 100%; visibility: hidden;"></textarea>
        <label id="sMemo_tip"></label>
        <div class="data-space"></div>
        <input type="submit" runat="server" id="Button1"  class="btn btn-primary" value="提交" onserverclick="Button1_Click"/>
        <input type="button" class="btn btn-primary" id="btn_return" runat="server" onserverclick="btn_return_ServerClick" value="返回" />
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            jQuery.validator.addMethod("isGtElement", function(value, element) { 
                value=parseInt(value);
                var _val=parseInt($("#fPurPrice").val());
                return this.optional(element) || value>=_val;       
            }, "前台售价需大于等于供价");
            $("#PdAddInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules:{
                    <%=DropDownList7.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=sPdName.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=sPdBrand.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=sPdStd.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=sDistrict.UniqueID%>: {
                        required: true
                    },
                    <%=sPdPackage.UniqueID%>: {
                        required: true,
                        maxlength:50
                    },
                    <%=sQualityPeriod.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=sbarCode.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=iQuantity.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=fPurPrice.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=fSaPrice.UniqueID%>: {
                        required: true,
                        min:1,
                        isGtElement:true
                    },
                    <%=fBdPrice.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=dValidDate.UniqueID%>: {
                        required: true,
                        date:true
                    },
                    <%=sImagePath.UniqueID%>: {
                        required: true
                    }
                },
                messages:{
                    <%=DropDownList7.UniqueID%>: {
                        required:"请选择商品分类",
                        min: "请选择商品分类"
                    },
                    <%=sPdName.UniqueID%>: {
                        required: "请填写商品名称",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sPdBrand.UniqueID%>: {
                        required: "请填写商品品牌",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sPdStd.UniqueID%>: {
                        required: "请填写商品规格",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sDistrict.UniqueID%>: {
                        required: "请选择商品产地"
                    },
                    <%=sPdPackage.UniqueID%>: {
                        required: "包装方式不能为空",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sQualityPeriod.UniqueID%>: {
                        required: "食品有效期不能为空",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sbarCode.UniqueID%>: {
                        required: "条码不能为空",
                        max:"最长不能超过{0}个字"
                    },
                    <%=sbarCode.UniqueID%>: {
                        required: "可售数量不能为空",
                        min:"不能小于{0}"
                    },
                    <%=fPurPrice.UniqueID%>: {
                        required: "供应商供价不能为空",
                        min:"不能小于{0}"
                    },
                    <%=fSaPrice.UniqueID%>: {
                        required: "前台售价不能为空",
                        min:"不能小于{0}"
                    },
                    <%=fBdPrice.UniqueID%>: {
                        required: "市场价不能为空",
                        min:"不能小于{0}"
                    },
                    <%=dValidDate.UniqueID%>: {
                        required: "价格有效日期不能为空",
                        date:"请输入合法的日期"
                    },
                    <%=sImagePath.UniqueID%>: {
                        required: "封面图片不能为空"
                    }
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
            $("#InfoChangeForm").validate({

            });
            $("#startdatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
        });
    </script>
</asp:Content>
