<%@ Page Title="" Language="C#" MasterPageFile="~/FullSite.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="VPC_2014_V001.VPC.Vendor.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3">
        <div class="sidebar">
        <div class="sidebar-dropdown"><a href="#">Navigation</a></div>
        <!--- Sidebar navigation -->
        <!-- If the main navigation has sub navigation, then add the class "has_sub" to "li" of main navigation. -->
        <ul id="nav" style="">
          <!-- Main menu with font awesome icon -->
          <li class="open"><a href="index.html"><i class="fa fa-home"></i> Dashboard</a>
            <!-- Sub menu markup 
            <ul>
              <li><a href="#">Submenu #1</a></li>
              <li><a href="#">Submenu #2</a></li>
              <li><a href="#">Submenu #3</a></li>
            </ul>-->
          </li>
          <li class="has_sub">
			<a href="#"><i class="fa fa-list-alt"></i> Widgets  <span class="pull-right"><i class="fa fa-chevron-right"></i></span></a>
            <ul>
              <li><a href="widgets1.html">Widgets #1</a></li>
              <li><a href="widgets2.html">Widgets #2</a></li>
              <li><a href="widgets3.html">Widgets #3</a></li>
            </ul>
          </li>  
          <li class="has_sub">
			<a href="#"><i class="fa fa-file-o"></i> Pages #1  <span class="pull-right"><i class="fa fa-chevron-right"></i></span></a>
            <ul>
              <li><a href="post.html">Post</a></li>
              <li><a href="login.html">Login</a></li>
              <li><a href="register.html">Register</a></li>
              <li><a href="support.html">Support</a></li>
              <li><a href="invoice.html">Invoice</a></li>
              <li><a href="gallery.html">Gallery</a></li>
            </ul>
          </li> 
          <li class="has_sub">
			<a href="#"><i class="fa fa-file-o"></i> Pages #2  <span class="pull-right"><i class="fa fa-chevron-right"></i></span></a>
            <ul>
              <li><a href="media.html">Media</a></li>
              <li><a href="statement.html">Statement</a></li>
              <li><a href="error.html">Error</a></li>
              <li><a href="error-log.html">Error Log</a></li>
              <li><a href="calendar.html">Calendar</a></li>
              <li><a href="grid.html">Grid</a></li>
            </ul>
          </li>    
		  <li class="has_sub"><a href="#"><i class="fa fa-table"></i> Tables  <span class="pull-right"><i class="fa fa-chevron-right"></i></span></a>
            <ul>
              <li><a href="tables.html">Tables</a></li>
              <li><a href="dynamic-tables.html">Dynamic Tables</a></li>
            </ul>
          </li>		  
          <li><a href="charts.html"><i class="fa fa-bar-chart-o"></i> Charts</a></li> 
          <li><a href="forms.html"><i class="fa fa-tasks"></i> Forms</a></li>
          <li><a href="ui.html"><i class="fa fa-magic"></i> User Interface</a></li>
        </ul>
    </div>
        </div>
        <div class="col-md-9">
            111111
        </div>
    </div>
</asp:Content>
