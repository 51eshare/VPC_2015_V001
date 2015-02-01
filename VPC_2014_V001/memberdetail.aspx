<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="memberdetail.aspx.cs" Inherits="VPC_2014_V001.memberdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="css" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container flex-main" id="info" runat="server">
        <div class="row">
            <div class="col-md-12 title text-center">
               <label id="TTitle" class="h2" runat="server"></label>&#12288;( <label runat="server" id="SDate"></label> )
            </div>
            <div class="col-md-12">
               <label id="CContent" runat="server"></label>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="js" runat="server">
</asp:Content>
