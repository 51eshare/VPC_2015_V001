<%@ Page Title="供应商资料变更" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="InfoChange.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.InfoChange" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" ClientIDMode="Static" runat="server">
    <form id="InfoChangeform" runat="server">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">供应商名称</span>
            <asp:TextBox class="form-control" ID="txtsVenName" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">供应商所在地区</span>
            <asp:DropDownList class="form-control" ID="DropDownList4" runat="server" Style="width: 180px;" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList class="form-control" ID="DropDownList5" runat="server" Style="width: 180px;" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList class="form-control" ID="DropDownList6" runat="server" Style="width: 180px;"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="  * 供应商所在地区必须填写" Display="Dynamic" ControlToValidate="DropDownList4" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系人姓名</span>
            <asp:TextBox class="form-control" ID="txtsContactName" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsContactName" runat="server" ErrorMessage="  * 联系人姓名必须填写" Display="Dynamic" ControlToValidate="txtsContactName" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系人电话</span>
            <asp:TextBox class="form-control" ID="txtsContactPhoneNumber" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rvfsContactPhoneNumber" runat="server" ErrorMessage="  * 联系人电话必须填写" Display="Dynamic" ControlToValidate="txtsContactPhoneNumber" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系人手机</span>
            <asp:TextBox class="form-control" ID="txtsContactMP" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsContactMP" runat="server" ErrorMessage="  * 联系人手机必须填写" Display="Dynamic" ControlToValidate="txtsContactMP" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系人邮箱</span>
            <asp:TextBox class="form-control" ID="txtsContactMail" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsContactMail" runat="server" ErrorMessage="  * 联系人邮箱必须填写" Display="Dynamic" ControlToValidate="txtsContactMail" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="rfvsContactMail1" runat="server" ErrorMessage="  * 须填写正确的邮箱地址" Display="Dynamic" ControlToValidate="txtsContactMail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div class="data-space"></div>
        <h4>资质</h4>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">注册资金（万元）</span>
            <asp:TextBox class="form-control" ID="txiRegistCapital" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">供应商注册地址</span>
            <asp:TextBox class="form-control" ID="txsRegistAddress" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">业执照编号</span>
            <asp:TextBox class="form-control" ID="txsBussinessLicenceCode" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">营业执照到期日</span>
            <asp:TextBox class="form-control" ID="txdBussinessLicenceExpDate" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">组织机构代码</span>
            <asp:TextBox class="form-control" ID="txsOrganizationCode" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <h4>财务资料</h4>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">开票类型</span>
            <asp:DropDownList class="form-control" ID="ddlsTaxType" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvsTaxType" runat="server" ErrorMessage="  * 开票类型必须填写" Display="Dynamic" ControlToValidate="ddlsTaxType" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">开户银行(含支行)</span>
            <asp:TextBox class="form-control" ID="txsBankName" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">开票抬头</span>
            <asp:TextBox class="form-control" ID="txsBillAccountName" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">税务登记号</span>
            <asp:TextBox class="form-control" ID="txsTaxCode" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">银行账号名称</span>
            <asp:TextBox class="form-control" ID="txsBankAccountName" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group ">
            <span class="input-group-addon" style="width: 150px;">银行账号</span>
            <asp:TextBox class="form-control" ID="txsBankAccountCode" runat="server" Style="width: 300px;" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">开票电话</span>
            <asp:TextBox class="form-control" ID="txtsBillAccountPhone" runat="server" Style="width: 300px;" placeholder="（开票资料上的电话）必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillAccountPhone" runat="server" ErrorMessage="  * 开票电话必须填写" Display="Dynamic" ControlToValidate="txtsBillAccountPhone" ForeColor="Red"></asp:RequiredFieldValidator>

        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">开票地址</span>
            <asp:TextBox class="form-control" ID="txtsBillAccountAddress" runat="server" Style="width: 300px;" placeholder="（开票资料上的地址）必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillAccountAddress" runat="server" ErrorMessage="  * 开票地址必须填写" Display="Dynamic" ControlToValidate="txtsBillAccountAddress" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">发票收件地址</span>
            <asp:TextBox class="form-control" ID="txtsBillRecieveAddress" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillRecieveAddress" runat="server" ErrorMessage="  * 发票收件地址必须填写" Display="Dynamic" ControlToValidate="txtsBillRecieveAddress" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">发票收件人</span>
            <asp:TextBox class="form-control" ID="txtsBillRecieveContactName" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillRecieveContactName" runat="server" ErrorMessage="  * 发票收件地址必须填写" Display="Dynamic" ControlToValidate="txtsBillRecieveContactName" ForeColor="Red"></asp:RequiredFieldValidator>

        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">联系电话</span>
            <asp:TextBox class="form-control" ID="txtsBillRecievePhone" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillRecievePhone" runat="server" ErrorMessage="  * 联系电话必须填写" Display="Dynamic" ControlToValidate="txtsBillRecievePhone" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">邮编</span>
            <asp:TextBox class="form-control" ID="txtsBillRecieveZip" runat="server" Style="width: 300px;" placeholder="必填项"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvsBillRecieveZip" runat="server" ErrorMessage="  * 联系电话必须填写" Display="Dynamic" ControlToValidate="txtsBillRecieveZip" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="data-space"></div>
        <div class="input-group">
            <span class="input-group-addon" style="width: 150px;">资质照片</span>
            <textarea name="_KindEditor" id="sPhotos" runat="server" style="height: 320px; width: 100%; visibility: hidden;"></textarea>
        </div>
        <div class="data-space"></div>
        <p class="col-sm-offset-2">
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="保存" OnClick="Button1_Click" /></p>
    </form>
</asp:Content>
<asp:Content ContentPlaceHolderID="js" runat="server">
    <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
    <script charset="utf-8" src="/kindeditor/kindeditor-min.js"></script>
    <script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
    <script>
        var editor;
        KindEditor.ready(function (K) {
            editor = K.create('#sPhotos', {
                uploadJson: '/kindeditor/asp.net/upload_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx?iVendorId=<%=UserInfo.RealID%>',
                    allowFileManager: true,
                    afterBlur: function () {
                        document.getElementById("sPhotos").value = editor.html();

                    }
                }
                );
            });
    </script>
</asp:Content>
