<%@ Page Title="添加广告" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Addad.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.Addad" ValidateRequest="false" %>

<asp:Content ID="Content3" ContentPlaceHolderID="css" runat="server">
    <link href="/Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="AddSlideshowInfo" runat="server" role="form" class="form-inline">
         <div class="alert alert-danger <%=tipclass%>" role="alert">
                <a class="close" data-dismiss="alert">×</a>
                <p>
                    <asp:Label ID="message" runat="server" Text=""></asp:Label>
                </p>
        </div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">商品编号</span>
            <asp:TextBox class="form-control" ID="iPdId" TextMode="Number" runat="server" Style="width: 300px;" Text="1"></asp:TextBox>
            <label id="iPdId_tip"></label>
        </div>
        <div class="data-space"></div>
         <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">供应商结算价</span>
            <asp:TextBox class="form-control" ID="fPurPrice" TextMode="Number" runat="server" Style="width: 300px;" Text="1"></asp:TextBox>
            <label id="fPurPrice_tip"></label>
        </div>
        <div class="data-space"></div>
         <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">零售价</span>
            <asp:TextBox class="form-control" ID="fSaPrice" TextMode="Number" runat="server" Style="width: 300px;" Text="1"></asp:TextBox>
            <label id="fSaPrice_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="row">
            <label class="col-md-1 control-label">有效日期</label>
            <div class="col-md-2">
                <div class="input-append input-group dtpicker" id="startdatepicker">
                    <asp:TextBox class="form-control" ID="dBeginDate" TextMode="Date" runat="server"></asp:TextBox>
                    <span class="input-group-addon add-on">
                        <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                    </span>
                </div>
            </div>
            <div class="col-md-2 pull-left">
                <div class="input-append input-group dtpicker" id="enddatepicker">
                    <asp:TextBox class="form-control" ID="dEndDate" runat="server" TextMode="Date"></asp:TextBox>
                    <span class="input-group-addon add-on">
                        <i data-date-icon="fa fa-calendar" data-time-icon="fa fa-times" class="fa fa-calendar"></i>
                    </span>
                </div>
            </div>
         </div>
        <div class="data-space"></div>
        <input type="submit" runat="server" id="Button1"  class="btn btn-primary" value="提交" onserverclick="Button1_Click"/>
        <input type="button" class="btn btn-danger" value="返回" runat="server" id="btn_back" onserverclick="btn_back_ServerClick"/>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="js" runat="server">
    <script src="/Scripts/jquery.validate.min.js"></script>
    <script src="/Scripts/JQuery.Validate.Messages_cn.js"></script>
    <script src="/Scripts/bootstrap-datetimepicker.zh-CN.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#AddSlideshowInfo").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                },
                rules:{
                    <%=iPdId.UniqueID%>: {
                        required: true
                    },
                    <%=fPurPrice.UniqueID%>: {
                        required: true,
                        min:1
                    },
                    <%=fSaPrice.UniqueID%>: {
                        required: true,
                        min:1
                    }
                },
                messages:{
                    <%=iPdId.UniqueID%>: {
                        required: "请填写商品编号"
                    },
                    <%=fPurPrice.UniqueID%>: {
                        required: "请填写供应商结算价",
                        min:"不能小于{0}"
                    },
                    <%=fSaPrice.UniqueID%>: {
                        required: "请填写零售价",
                        min:"不能小于{0}"
                    }
                }
            });
            $("#startdatepicker,#enddatepicker").datetimepicker({ pickTime: false, format: "yyyy-MM-dd", autoclose: true, language: 'zh-CN' });
        });
    </script>
</asp:Content>
