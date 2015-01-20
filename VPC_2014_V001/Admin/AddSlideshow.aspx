<%@ Page Title="添加商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="AddSlideshow.aspx.cs" Inherits="VPC_2014_V001.VPC.Admin.AddSlideshow" ValidateRequest="false" %>

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
            <span class="input-group-addon" style="width: 150px;">标题</span>
            <asp:TextBox class="form-control" ID="TTitle" runat="server" Style="width: 300px;" placeholder="（最多包含25个字）必填项"></asp:TextBox>
            <label id="TTitle_tip"></label>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">链接地址</span>
            <asp:TextBox class="form-control" ID="URL" runat="server" Style="width: 300px;" placeholder="（链接地址）必填项"></asp:TextBox>
            <label id="URL_tip"></label>
        </div>
        <div class="data-space"></div>
        <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
        <script charset="utf-8" src="/kindeditor/kindeditor-min.js"></script>
        <script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
        <script>
            var editor;
            KindEditor.ready(function (K) {
                editor = K.create('#NContent', {
                    uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    allowFileManager: true,
                    afterBlur: function () {
                        document.getElementById("NContent").value = editor.html();
                       
                    }
                }
                );
                K('#btn_sImagePath').click(function () {
                    editor.loadPlugin('image', function () {
                        editor.plugin.imageDialog({
                            imageUrl: K('#Img').val(),
                            clickFn: function (url, title, width, height, border, align) {
                                K('#Img').val(url);
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
                <input type="text" id="Img" runat="server" class="form-control" name="Img" value=""/>
                <input type="button" id="btn_sImagePath" class="btn btn-danger btn-sm" value="选择图片" />
                <label id="Img_tip"></label>
            </div>
        </div>
        <div class="data-space"></div>
        <textarea name="_KindEditor" id="NContent" runat="server" style="height: 320px; width: 100%; visibility: hidden;"></textarea>
        <label id="NContent_tip"></label>
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
                    <%=TTitle.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=URL.UniqueID%>: {
                        required: true,
                        maxlength:25
                    },
                    <%=Img.UniqueID%>: {
                        required: true
                    }
                },
                messages:{
                    <%=TTitle.UniqueID%>: {
                        required: "请填写标题",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=URL.UniqueID%>: {
                        required: "请填写URL地址",
                        maxlength:"最长不能超过{0}个字"
                    },
                    <%=Img.UniqueID%>: {
                        required: "请选择图片"
                    }
                }
            });
        });
    </script>
</asp:Content>
