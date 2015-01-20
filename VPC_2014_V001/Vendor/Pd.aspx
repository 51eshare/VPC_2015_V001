<%@ Page Title="商品详情" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Pd.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Pd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form runat="server" id="PdInfo">
        <div class="row" id="info" runat="server">
            <div class="col-md-6">
                商品基本资料
    <dl class="dl-horizontal">
        <dt>封面主图</dt>
        <dd><img runat="server" id="sImagePath" class="img-thumbnail img-rounded productinfoimg" />
            </dd>
        <dt>商品编码</dt>
        <dd>
            <asp:Label ID="iPdId" runat="server" Text=""></asp:Label></dd>
        <dt>商品名称</dt>
        <dd>
            <asp:Label ID="sPdName" runat="server" Text=""></asp:Label></dd>
        <dt>品牌</dt>
        <dd>
            <asp:Label ID="sPdBrand" runat="server" Text=""></asp:Label></dd>
        <dt>规格</dt>
        <dd>
            <asp:Label ID="sPdStd" runat="server" Text=""></asp:Label></dd>
        <dt>产地</dt>
        <dd>
            <asp:Label ID="sDistrict" runat="server" Text=""></asp:Label></dd>
        <dt>最小销售单位</dt>
        <dd>
            <asp:Label ID="sPdCpu" runat="server" Text=""></asp:Label></dd>
        <dt>最小销售数量</dt>
        <dd>
            <asp:Label ID="iPdBaseNum" runat="server" Text=""></asp:Label></dd>
        <dt>包装方式</dt>
        <dd>
            <asp:Label ID="sPdPackage" runat="server" Text=""></asp:Label></dd>
        <dt>食品有效期</dt>
        <dd>
            <asp:Label ID="sQualityPeriod" runat="server" Text=""></asp:Label></dd>
        <dt>条码</dt>
        <dd>
            <asp:Label ID="sbarCode" runat="server" Text=""></asp:Label></dd>
    </dl>
            </div>
            <div class="col-md-6">
                供货资料
    <dl class="dl-horizontal">
        <dt>可售数量</dt>
        <dd>
            <asp:Label ID="iQuantity" runat="server" Text=""></asp:Label></dd>
        <dt>供应商供价（人民币元）</dt>
        <dd>
            <asp:Label ID="fPurPrice" runat="server" Text=""></asp:Label></dd>
        <dt>前台售价（人民币元）</dt>
        <dd>
            <asp:Label ID="fSaPrice" runat="server" Text=""></asp:Label></dd>
        <dt>市场价（人民币元）</dt>
        <dd>
            <asp:Label ID="fBdPrice" runat="server" Text=""></asp:Label></dd>
        <dt>价格有效日期至</dt>
        <dd>
            <asp:Label ID="dValidDate" runat="server" Text=""></asp:Label></dd>
        <dt>建档日期</dt>
        <dd>
            <asp:Label ID="dDate" runat="server" Text=""></asp:Label></dd>
    </dl>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                商品交易数据
    <dl class="dl-horizontal">
        <dt>商品状态</dt>
        <dd>
            <asp:Label ID="iStatus" runat="server" Text=""></asp:Label></dd>
        <dt>成交总数量</dt>
        <dd>
            <asp:Label ID="iOrderNum" runat="server" Text=""></asp:Label></dd>
        <dt>评论总数量</dt>
        <dd>
            <asp:Label ID="iReviewNum" runat="server" Text=""></asp:Label></dd>
        <dt>点击总数量</dt>
        <dd>
            <asp:Label ID="iRateNum" runat="server" Text=""></asp:Label></dd>
        <dt>商品好评总数量</dt>
        <dd>
            <asp:Label ID="iPdGood" runat="server" Text=""></asp:Label></dd>
        <dt>商品中评总数量</dt>
        <dd>
            <asp:Label ID="iPdNormal" runat="server" Text=""></asp:Label></dd>
        <dt>商品差评总数量</dt>
        <dd>
            <asp:Label ID="iPdBad" runat="server" Text=""></asp:Label></dd>
        <dt>服务好评总数量</dt>
        <dd>
            <asp:Label ID="iServiceGood" runat="server" Text=""></asp:Label></dd>
        <dt>服务中评总数量</dt>
        <dd>
            <asp:Label ID="iServiceNormal" runat="server" Text=""></asp:Label></dd>
        <dt>服务差评总数量</dt>
        <dd>
            <asp:Label ID="iServiceBad" runat="server" Text=""></asp:Label></dd>
        <dt>物流好评总数量</dt>
        <dd>
            <asp:Label ID="iLogisticGood" runat="server" Text=""></asp:Label></dd>
        <dt>物流中评总数量</dt>
        <dd>
            <asp:Label ID="iLogisticNormal" runat="server" Text=""></asp:Label></dd>
        <dt>物流差评总数量</dt>
        <dd>
            <asp:Label ID="iLogisticBad" runat="server" Text=""></asp:Label></dd>
    </dl>
            </div>
            <div class="col-md-6">
                <div></div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <label>描述</label>
            </div>
            <div class="col-md-11">
                <asp:Label ID="sMemo" runat="server" Text=""></asp:Label></div>
        </div>
        <div class="row">
            <div class="col-md-12 text-center">
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="修改" OnClick="Button1_Click" />
                <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="返回" OnClick="Button2_Click" />
            </div>
        </div>
    </form>
</asp:Content>
