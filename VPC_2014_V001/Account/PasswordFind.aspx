<%@ Page Title="寻回密码" Language="C#" AutoEventWireup="true" CodeBehind="PasswordFind.aspx.cs" Inherits="VPC_2014_V001.VPC.Account.PasswordFind" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <!-- Title and other stuffs -->
    <title>找回密码-<%:SiteInfo.title%></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="<%:SiteInfo.description%>">
    <meta name="keywords" content="<%:SiteInfo.keywords%>">
    <meta name="author" content="">
    <!-- Stylesheets -->
    <link href="/Content/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="/Content/font-awesome.min.css">
    <link href="../../Content/Site.css" rel="stylesheet" />
    <link href="/Content/admin.css" rel="stylesheet">
    <script src="../../Scripts/jquery-1.10.2.min.js"></script>
    <script src="/Scripts/respond.min.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <script src="../../Scripts/JQuery.Validate.Messages_cn.js"></script>
    <!--[if lt IE 9]>
    <script src="/Scripts/html5shiv.js"></script>
    <![endif]-->
    <!-- Favicon -->
    <link rel="shortcut icon" href="img/favicon/favicon.png">
    <script>
        $(function () {
            $("#login_form").validate({
                errorPlacement: function (error, element) {
                    $("#" + $(element).attr("id") + "_tip").html(error);
                }
            });
        });
    </script>
</head>

<body>

    <!-- Form area -->
    <div class="admin-form">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- Widget starts -->
                    <div class="widget worange">
                        <!-- Widget head -->
                        <div class="widget-head">
                            <i class="fa fa-key fa-2x"></i>&nbsp;找回密码 
                        </div>

                        <div class="widget-content">
                            <div class="padd">
                                <!-- Login form -->
                                <form class="form-horizontal" id="login_form" runat="server">
                                    <div class="form-group">
                                        <div class="col-lg-12">
                                           <asp:Label ID="Label1" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                    <!-- Email -->
                                    <div class="form-group">
                                        <label class="control-label col-lg-3" for="txtsLoginId">邮箱</label>
                                        <div class="col-lg-5">
                                            <input type="email" class="form-control input col-lg-4" runat="server" id="txtsLoginId" placeholder="Email" required>
                                        </div>
                                        <div id="txtsLoginId_tip"></div>
                                    </div>
                                    <div class="col-lg-9 col-lg-offset-3">
                                        <input type="submit" runat="server" id="Button3" onserverclick="Button3_ServerClick" class="btn btn-info btn-sm" value="发送">
                                        <a  href="Login">&#12288;登录</a>
                                    </div>
                                    <br />
                                </form>

                            </div>
                        </div>
                        <div class="widget-foot text-center">
                            <%:SiteInfo.title %>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- JS -->
    <script src="/Scripts/bootstrap.min.js"></script>
</body>
</html>