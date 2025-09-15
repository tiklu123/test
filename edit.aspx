<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Allstar Signs  : Edit</title>
    <link rel="stylesheet" href="login.css" type="text/css" />
<meta http-equiv="X-UA-Compatible" content="IE=9" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="login_logo_edit"><a href="http://www.webcanny.com.au"><img src="login_img/login_logo.PNG" border="0" /></a></div>
<div id="edit_page">
	<div class="top_img">
    	<span>
        	<strong>
            	<div class="top_session">
                	<asp:Button ID="btnUndo" runat="server"  Text="" onclick="btnUndo_Click" />
                </div>
                <div class="top_session2">
                    <a href="editmenu.aspx"><img src="login_img/back_home.png" /></a>
                </div>
                <div class="top_session1">
                <asp:LinkButton ID="lnklogout" runat="server" Text="" onclick="lnklogout_Click"  ></asp:LinkButton>
                </div>
                <div class="clear"></div>
           	</strong>
        </span> 
  	</div>
    
    <div class="edit_body">
    	<div class="left_panel" >
    	     <div id="div_iframe" runat="server">
        </div>
        </div>
        <div class="right_panel">
             <asp:Panel ID="panel1" runat="server" ></asp:Panel>
        </div>
        <div class="clear"></div>
        <div id="login_footer"> CMS Tool Powered By WebCanny Pty Ltd 2013  &copy;  All Rights Reserved</div>
   	</div>
     
    <div class="bot_img"><span><strong></strong></span> </div>
   
</div>
    </form>
</body>
</html>
