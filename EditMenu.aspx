<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditMenu.aspx.cs" Inherits="EditMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Allstar Signs   : Edit Menu</title>
    <link rel="stylesheet" href="login.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="login_logo">
        <a href="http://www.webcanny.com.au">
            <img src="login_img/login_logo.PNG" alt="" border="0" /></a></div>
    <div id="login_form">
        <div class="top_img">
            <span><strong class="menu_edit1">
                <div class="top_session edit_menus"> <h3>Edit Menu</h3></div>
                <div class="top_session1"><asp:LinkButton ID="lnklogout" runat="server" Text="" onclick="lnklogout_Click"  ></asp:LinkButton></div>
                <br clear="all" />
            </strong></span>
        </div>
        <div class="edit_menu_body">
                  <a href="edit.aspx?pid=p1&url=Default.aspx">SIGNS</a>
                 <a href="edit.aspx?pid=p2&url=printing.aspx">PRINTING</a>
                 <a href="edit.aspx?pid=p3&url=aboutus.aspx">ABOUT US</a>
                 <a href="edit.aspx?pid=p4&url=gallery.aspx">GALLERY</a>
                 <a href="edit.aspx?pid=p5&url=contactus.aspx">CONTACT US</a>
                 <a href="edit.aspx?pid=p0&url=Default.aspx">BANNER</a>
                <div class="clear"></div>
            <div id="login_footer">
                 CMS Tool Powered By WebCanny Pty Ltd 2013 &copy; All Rights Reserved</div>
        </div>
        <div class="bot_img">
            <span><strong></strong></span>
        </div>
    </div>
    </form>
</body>
</html>
