<%@ Page Title="编辑商品" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="PdEdit.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.PdEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server" id="PdEditInfo">
        <br />
        <%: Page.Title %>
        <br />
        <hr />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />

        <div class="row">
            <div class="col-md-6">
                商品基本资料
     <hr />
                        <div class="input-group">
                            <span class="input-group-addon">商品分类</span>
                            <asp:DropDownList class="form-control" ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged"></asp:DropDownList>
                            <asp:DropDownList class="form-control" ID="DropDownList8" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvDropDownList8" runat="server" ErrorMessage="  * 商品分类必须填写" Display="Dynamic" ControlToValidate="DropDownList8" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">商品名称</span>
                    <asp:TextBox class="form-control" ID="txtsPdName" runat="server" placeholder="（最多包含50个字）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsPdName" runat="server" ErrorMessage="  * 商品分类必须填写" Display="Dynamic" ControlToValidate="txtsPdName" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">品牌</span>
                    <asp:TextBox class="form-control" ID="txtsPdBrand" runat="server" placeholder="（中文/英文）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsPdBrand" runat="server" ErrorMessage="  * 品牌必须填写" Display="Dynamic" ControlToValidate="txtsPdBrand" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">规格</span>
                    <asp:TextBox class="form-control" ID="txtsPdStd" runat="server" placeholder="（例：1000ml/瓶、500g/包等）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsPdStd" runat="server" ErrorMessage="  * 规格必须填写" Display="Dynamic" ControlToValidate="txtsPdStd" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
                        <div class="input-group">
                            <span class="input-group-addon">产地</span>
                            <asp:DropDownList class="form-control" ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
                            <asp:DropDownList class="form-control" ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"></asp:DropDownList>
                            <asp:DropDownList class="form-control" ID="DropDownList6" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="  * 产地必须填写" Display="Dynamic" ControlToValidate="DropDownList4" ForeColor="Red"></asp:RequiredFieldValidator>

                        </div>

                <br />
                <div class="input-group">
                    <span class="input-group-addon">最小销售单位</span>
                    <asp:TextBox class="form-control" ID="txtsPdCpu" runat="server" placeholder="（例：瓶、盒、包等）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsPdCpu" runat="server" ErrorMessage="  * 最小销售单位必须填写" Display="Dynamic" ControlToValidate="txtsPdCpu" ForeColor="Red"></asp:RequiredFieldValidator>

                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">最小销售数量</span>
                    <asp:TextBox class="form-control" ID="txtiPdBaseNum" runat="server" placeholder="（单个起售填1，整箱起售填箱入数。）必填项">  </asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfviPdBaseNum" runat="server" ErrorMessage="  * 整数必须填写" Display="Dynamic" ControlToValidate="txtiPdBaseNum" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rfviPdBaseNum1" runat="server" ErrorMessage="  * 须填写整数" Display="Dynamic" ControlToValidate="txtiPdBaseNum" ForeColor="Red" ValidationExpression="^([1-9][0-9]*)$"></asp:RegularExpressionValidator>

                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">包装方式</span>
                    <asp:TextBox class="form-control" ID="txtsPdPackage" runat="server" placeholder="（例：盒装、瓶装等）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsPdPackage" runat="server" ErrorMessage="  * 包装方式必须填写" Display="Dynamic" ControlToValidate="txtsPdPackage" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">食品有效期</span>
                    <asp:TextBox class="form-control" ID="txtsQualityPeriod" runat="server" placeholder="（例：2年、10个月、15天）必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsQualityPeriod" runat="server" ErrorMessage="  * 食品有效期必须填写" Display="Dynamic" ControlToValidate="txtsQualityPeriod" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="input-group">
                    <span class="input-group-addon">条码</span>
                    <asp:TextBox class="form-control" ID="txtsbarCode" runat="server" placeholder="必填项"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvsbarCode" runat="server" ErrorMessage="  * 条码必须填写" Display="Dynamic" ControlToValidate="txtsbarCode" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
            </div>
            <div class="row">
                <div class="col-md-6">
                    供货资料
     <hr />
                    <div class="input-group">
                        <span class="input-group-addon">可售数量</span>
                        <asp:TextBox class="form-control" ID="intiQuantity" runat="server" TextMode="Number" placeholder="必填项"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfviQuantity" runat="server" ErrorMessage="  * 可售数量必须填写" Display="Dynamic" ControlToValidate="intiQuantity" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rfviQuantity1" runat="server" ErrorMessage="  * 须填写整数" Display="Dynamic" ControlToValidate="intiQuantity" ForeColor="Red" ValidationExpression="^([1-9][0-9]*)$"></asp:RegularExpressionValidator>
                    </div>
                    <br />
                    <div class="input-group">
                        <span class="input-group-addon">供应商供价（人民币元）</span>
                        <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
                        <asp:TextBox class="form-control" ID="numfPurPrice" runat="server" placeholder="必填项"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvnumfPurPrice" runat="server" ErrorMessage="  * 供应商供价必须填写" Display="Dynamic" ControlToValidate="numfPurPrice" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="numfPurPrice1" runat="server" ErrorMessage="  * 须填写两位小数" Display="Dynamic" ControlToValidate="numfPurPrice" ForeColor="Red" ValidationExpression="\d+(\.\d\d)?"></asp:RegularExpressionValidator>
                    </div>
                    <br />
                    <div class="input-group">
                        <span class="input-group-addon">前台售价（人民币元）</span>
                        <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
                        <asp:TextBox class="form-control" ID="numfSaPrice" runat="server" placeholder="必填项"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvfSaPrice" runat="server" ErrorMessage="  * 前台售价必须填写" Display="Dynamic" ControlToValidate="numfSaPrice" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rfvfSaPrice1" runat="server" ErrorMessage="  * 须填写两位小数" Display="Dynamic" ControlToValidate="numfSaPrice" ForeColor="Red" ValidationExpression="\d+(\.\d\d)?"></asp:RegularExpressionValidator>
                    </div>
                    <br />
                    <div class="input-group">
                        <span class="input-group-addon">市场价（人民币元）</span>
                        <span class="input-group-addon"><i class="fa fa-jpy"></i></span>
                        <asp:TextBox class="form-control" ID="numfBdPrice" runat="server" placeholder="必填项"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvfBdPrice" runat="server" ErrorMessage="  * 市场价必须填写" Display="Dynamic" ControlToValidate="numfBdPrice" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rfvfBdPrice1" runat="server" ErrorMessage="  * 须填写两位小数" Display="Dynamic" ControlToValidate="numfBdPrice" ForeColor="Red" ValidationExpression="\d+(\.\d\d)?"></asp:RegularExpressionValidator>
                    </div>
                    <br />
                    <div class="input-group input-append date">
                        <span class="input-group-addon">价格有效日期</span>
                        <asp:TextBox class="form-control" ID="datedValidDate" runat="server" TextMode="Date" Text="2099-12-31"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvdValidDate" runat="server" ErrorMessage="  * 价格有效日期必须填写" Display="Dynamic" ControlToValidate="datedValidDate" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <br />
                    <br />

                </div>
            </div>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />

        </div>
    </form>
</asp:Content>
