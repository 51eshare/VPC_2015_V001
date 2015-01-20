<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VPC_2014_V001.VPC.Account.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <!-- Title and other stuffs -->
    <title>会员登录-<%:SiteInfo.title%></title>
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
                            <i class="fa fa-user fa-2x"></i>&nbsp;会员登录 
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
                                        <label class="control-label col-lg-3" for="txtsLoginId">用户名</label>
                                        <div class="col-lg-5">
                                            <input type="text" class="form-control input col-lg-4" runat="server" id="txtsLoginId" placeholder="用户名" required>
                                        </div>
                                        <div id="txtsLoginId_tip"></div>
                                    </div>
                                    <!-- Password -->
                                    <div class="form-group">
                                        <label class="control-label col-lg-3" for="txtsPassword">密码</label>
                                        <div class="col-lg-5">
                                            <input type="password" class="form-control" runat="server" id="txtsPassword" placeholder="密码" required>
                                        </div>
                                        <div id="txtsPassword_tip"></div>
                                    </div>
                                    <div class="col-lg-9 col-lg-offset-3">
                                        <input type="submit" runat="server" id="Button3" onserverclick="Button3_Click" class="btn btn-info btn-sm" value="登录">
                                        <a  href="PasswordFind">&#12288;忘记密码</a>
                                        <a  href="Regist">&#12288;注册</a>
                                        <a  href="/">&#12288;首页</a>
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
