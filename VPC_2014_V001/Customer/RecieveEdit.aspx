<%@ Page Title="" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="RecieveEdit.aspx.cs" Inherits="VPC_2014_V001.VPC.Customer.RecieveEdit" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form runat="server" id="editform" class="form-horizontal">
        <div class="alert alert-danger <%=tipclass%>" role="alert">
            <a class="close" data-dismiss="alert">×</a>
            <p>
                <asp:Label ID="message" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">地区地区</label>
            <div class="col-sm-8">
                <input type="hidden" id="iDistrictId" runat="server" name="iDistrictId" />
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
        <div class="form-group">
            <label class="col-sm-2 control-label">收货人姓名</label>
            <div class="col-sm-8">
                <input placeholder="收货人姓名" id="sRecieveName" runat="server" class="form-control" required>
            </div>
            <div id="sRecieveName_tip"></div>
        </div>

        <div class="form-group">
            <label class="col-sm-2 control-label">收货地址</label>
            <div class="col-sm-8">
                <input placeholder="收货地址" runat="server" id="sAddress" class="form-control" required>
            </div>
            <div id="sAddress_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">联系电话</label>
            <div class="col-sm-8">
                <input placeholder="联系电话" id="sPhoneNum" runat="server" class="form-control" required>
            </div>
            <div id="sPhoneNum_tip"></div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">邮编</label>
            <div class="col-sm-8">
                <input placeholder="邮编" runat="server" id="sPostCode" class="form-control">
            </div>
        </div>

        <div class="form-group">
            <label class="col-sm-3 control-label" for="bDefault">
                <input type="checkbox" runat="server" value="1" name="bDefault" id="bDefault">是否默认</label>
        </div>
        <div class="form-group">
            <div class="col-xs-9 col-xs-offset-3">
                <input class="btn btn-sm btn-primary" runat="server" id="btn_add" onserverclick="btn_add_ServerClick" type="submit" value="提交" />
                <a class="btn btn-sm btn-warning" href="RecieveList" id="Re_back" runat="server">返回</a>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/validate.expand.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#sDistrict").change(function () {
                $("#iDistrictId").val($(this).val());
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
                $("#iDistrictId").val($(this).val());
                $.get("/Ajax/Districts.ajax", { idistrict: $(this).val() }, function (data) {
                    var _op = "<option value=''>--请选择--</option>";
                    for (var i in data) {
                        _op += "<option value='" + data[i].iDistrict + "'>" + data[i].sCity + "</option>";
                    }
                    $("#sCity").empty().append(_op);
                });
            });
            $("#sCity").change(function () {
                $("#iDistrictId").val($(this).val());
            });
            $("#editform").validate({
                rules: {
                    <%=sRecieveName.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=sDistrict.UniqueID%>: {
                        district: true,
                        min:1
                    },
                    <%=sAddress.UniqueID%>: {
                        required: true,
                        maxlength:100
                    },
                    <%=sPhoneNum.UniqueID%>: {
                        required: true,
                        maxlength:25
                    }
                },
                messages:{
                    <%=sRecieveName.UniqueID%>: 
                             {
                                 required:"收货人姓名不能为空",
                                 maxlength:"收货人姓名不能超过{0}个字"
                             },
                    <%=sAddress.UniqueID%>: 
                             {
                                 required:"收货地址不能为空",
                                 maxlength:"收货地址不能超过{0}个字"
                             },
                    <%=sPhoneNum.UniqueID%>: 
                             {
                                 required:"联系电话不能为空",
                                 maxlength:"联系电话不能超过{0}个字"
                             }
                },
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</asp:Content>
