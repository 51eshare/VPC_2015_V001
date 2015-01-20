<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VPC_2014_V001.index" %>

<%@ Import Namespace="Service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container flex-main">
        <div class="row">
            <div class="col-md-12">
                <div class="flex-image flexslider">
                    <ul class="slides">
                        <!-- Each slide should be enclosed inside li tag. -->
                        <% var _tbSlideshow = b_Cache.GettbSlideshows();%>
                        <% foreach (var item in _tbSlideshow)
                       {%>
                        <li style="float: left;margin-right: -100%;position: relative; display: list-item;">
                            <!-- Image -->
                            <img alt="" src="<%=item.Img%>">
                            <!-- Caption -->
                            <div class="flex-caption">
                                <!-- Title -->
                                <h3><%=item.TTitle %></h3>
                                <!-- Para -->
                                <p><%=item.NContent %></p>
                            </div>
                        </li>
                        <%} %>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <!-- Below slider starts -->

    <div class="sep"></div>
    <div class="slider-features">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6">
                    <div class="onethree">
                        <div class="onethree-left">
                            <!-- Font awesome icon -->
                            <div class="img"><i class="fa fa-cloud"></i></div>
                        </div>
                        <div class="onethree-right">
                            <!-- Title and meta -->
                            <% var Partner = b_Cache.GettbInfo().SingleOrDefault(p => p.InfoType == 1);%>
                            <h5><a href="javascript:void(0);"><%=Partner.TTitle%></a></h5>
                            <p class="meta"><%=Partner.CContent%></p>
                            <div class="button" runat="server" id="partner"><a href="/Partner/Regist">加入微店主</a></div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="col-md-6 col-sm-6">
                    <div class="onethree">
                        <div class="onethree-left">
                            <div class="img"><i class="fa fa-home"></i></div>
                        </div>
                        <div class="onethree-right">
                            <% var Vendor = b_Cache.GettbInfo().SingleOrDefault(p => p.InfoType == 4);%>
                            <h5><a href="javascript:void(0);"><%=Vendor.TTitle%></a></h5>
                            <p class="meta"><%=Vendor.CContent%></p>
                            <div class="button" runat="server" id="vendor"><a href="/Vendor/Regist">加入商家</a></div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Below slider ends -->

    <!-- Service style #2 starts -->
    <div class="container">
        <div class="service-two">
            <div class="row">
                <div class="col-md-12">
                    <h4 class="title">热卖商品</h4>
                </div>
                <%foreach (var item in HotProduct)
                  {%>
                <div class="col-md-3 col-sm-3 txtoverflow">
                    <h5><a href="/Customer/ShopPd?iPdid=<%=item.iShopRefPdId%>">
                        <img src="<%=item.sImagePath%>" class="img-thumbnail tproduct-logo" /></a></h5>
                    <p>商品名称：<a href="/Customer/ShopPd?iPdid=<%=item.iShopRefPdId%>"><%=item.sPdName%></a></p>
                    <p>价格：¥<%=item.fSaPrice%></p>
                    <p>商品品牌：<%=item.sPdBrand%></p>
                    <p>积点数：<%=item.iPoint%></p>
                </div>
                <%}%>
            </div>
        </div>
        <hr />
    </div>

    <!-- Service style #2 ends -->

    <!-- [Ends] Testimonial (flexslider), About & Twitter Slider (FlexSlider) -->
    <!-- Clients starts -->
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <!-- Clients images -->
                <div class="clients">
                    <img class="img-responsive" src="img/clients/1.png" alt="" />
                    <img class="img-responsive" src="img/clients/2.png" alt="" />
                    <img class="img-responsive" src="img/clients/3.png" alt="" />
                    <img class="img-responsive" src="img/clients/4.png" alt="" />
                    <img class="img-responsive" src="img/clients/5.png" alt="" />
                    <img class="img-responsive" src="img/clients/6.png" alt="" />
                </div>
            </div>
        </div>
    </div>
    <!-- Clients ends -->
</asp:Content>
