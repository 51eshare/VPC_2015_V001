<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VPC_2014_V001._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><i class="fa fa-sitemap"></i>&nbsp;&nbsp;网站地图</h1>

        <div class="row">
            <div class="col-md-3">
                <a target="_blank" href="http://sighttp.qq.com/authd?IDKEY=90f2faa44b489a8fbe21e7e50cfbd6f31c732fbe1d456f8f">
                    <img border="0" src="http://wpa.qq.com/imgd?IDKEY=90f2faa44b489a8fbe21e7e50cfbd6f31c732fbe1d456f8f&pic=51" alt="点击这里给我发消息" title="点击这里给我发消息"></a>
            <p>Xavier</p>
            </div>
            <div class="col-md-3">
                <a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=799264679&site=qq&menu=yes">
                    <img border="0" src="http://wpa.qq.com/pa?p=2:799264679:51" alt="点击这里给我发消息" title="点击这里给我发消息" /></a>
            <p>mj</p>
            </div>
        </div>

    </div>

    <div class="row">
        <div class="col-md-3">
            <h2><i class="fa fa-user"></i>&nbsp;&nbsp;帐户</h2>
            <ul>
                <li><a href="VPC/Account/Regist">用户注册</a></li>
                <li><a href="VPC/Account/Login">用户登录</a></li>
                <li><a href="VPC/Account/PasswordFind">找回密码</a></li>
                <li><a href="VPC/Account/PasswordChange">更改密码</a></li>
            </ul>
            <br />
            <br />
            <h2><i class="fa fa-pencil-square-o"></i>&nbsp;&nbsp;资源</h2>
            <ul>
                <li><a href="VPC/Sample/ControlSample">控件示例 By Xavier</a></li>
            </ul>

        </div>
        <div class="col-md-3">
            <h2><i class="fa fa-truck"></i>&nbsp;&nbsp;供应商</h2>
            <ul>
                <li><a href="VPC/Vendor/Apply">供应商申请</a></li>
                <li><a href="VPC/Vendor/Regist">供应商入驻</a></li>
                <li><a href="VPC/Vendor/Info">供应商资料</a></li>
                <li><a href="VPC/Vendor/InfoChange">供应商资料变更</a></li>
                <li><a href="VPC/Vendor/InfoHistory">供应商资料变更历史</a></li>
                <li><a href="VPC/Vendor/OperationManage">帐号管理</a></li>
                <li><a href="VPC/Vendor/OperationManageHistory">帐号管理历史</a></li>
                <li><a href="VPC/Vendor/Pds">商品列表</a></li>
                <li><a href="VPC/Vendor/Pd">商品详情</a></li>
                <li><a href="VPC/Vendor/PdAdd">增加产品</a></li>
                <li><a href="VPC/Vendor/PdEdit">编辑商品</a></li>
                <li><a href="VPC/Vendor/PdHistory">商品编辑历史</a></li>
                <li><a href="VPC/Vendor/StockEdit">库存更新</a></li>
                <li><a href="VPC/Vendor/Orders">订单列表</a></li>
                <li><a href="VPC/Vendor/Order">订单详情</a></li>
                <li><a href="VPC/Vendor/Dispatchs">未发货清单</a></li>
                <li><a href="VPC/Vendor/Recieves">未签收清单</a></li>
                <li><a href="VPC/Vendor/Settles">未结算清单</a></li>
                <li><a href="VPC/Vendor/Reconciliation">对帐单</a></li>
                <li><a href="VPC/Vendor/Finishs">已完成订单</a></li>
                <li><a href="VPC/Vendor/Abnormals">异常订单</a></li>
                <li><a href="VPC/Vendor/Questions">咨询清单</a></li>
                <li><a href="VPC/Vendor/Question">咨询回复</a></li>
            </ul>
        </div>
        <div class="col-md-3">
            <h2><i class="fa fa-share-square-o"></i>&nbsp;&nbsp;小伙伴</h2>
            <ul>
                <li><a href="VPC/Partner/Regist">小伙伴入驻</a></li>
                <li><a href="VPC/Partner/Info">小伙伴资料</a></li>
                <li><a href="VPC/Partner/InfoChange">小伙伴资料变更</a></li>
                <li><a href="VPC/Partner/ShopInfo">店铺信息</a></li>
                <li><a href="VPC/Partner/ShopInfoEdit">店铺主页</a></li>
                <li><a href="VPC/Partner/ShopPds">店铺商品表</a></li>
                <li><a href="VPC/Partner/Pd">商品详情</a></li>
                <li><a href="VPC/Partner/Pds">可售商品</a></li>
                <li><a href="VPC/Partner/Orders">订单列表</a></li>
                <li><a href="VPC/Partner/Order">订单详情</a></li>
                <li><a href="VPC/Partner/Dispatchs">未发货清单</a></li>
                <li><a href="VPC/Partner/Recieves">未签收清单</a></li>
                <li><a href="VPC/Partner/Settles">未结算清单</a></li>
                <li><a href="VPC/Partner/Reconciliation">对帐单</a></li>
                <li><a href="VPC/Partner/Finishs">已完成订单</a></li>
                <li><a href="VPC/Partner/Abnormals">异常订单</a></li>
            </ul>
        </div>
        <div class="col-md-3">
            <h2><i class="fa fa-shopping-cart"></i>&nbsp;&nbsp;用户</h2>
            <ul>
                <li><a href="VPC/Customer/Default">客户首页</a></li>
                <li><a href="VPC/Customer/Orders">客户订单</a></li>
                <li><a href="VPC/Customer/ShopList">店铺收藏</a></li>
                <li><a href="VPC/Customer/ShoppingCart">购物车</a></li>
                <li><a href="VPC/Customer/ShopPd">店铺商品</a></li>
                <li><a href="VPC/Customer/ShopPds">店铺商品列表</a></li>

            </ul>
        </div>
    </div>

</asp:Content>
