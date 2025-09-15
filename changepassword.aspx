<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="changepassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Allstar Signs  :  Change Password</title>
    <link rel="stylesheet" href="login.css" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="login_logo"><a href="http://www.webcanny.com.au"><img src="login_img/login_logo.PNG" alt="" border="0" /></a></div>
<div id="login_form">
	<div class="top_img"><span><strong><h2>Change Password</h2></strong></span> </div>
    
    <div class="password">
    
    	<div class="left_panel">
        	<label for="username">User Name: <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                    ControlToValidate="txtUserName" Display="Dynamic"></asp:RequiredFieldValidator></label> <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        	
            <label for="old_password">Old Password : <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                    ControlToValidate="txtOldPwd" Display="Dynamic"></asp:RequiredFieldValidator></label><asp:TextBox ID="txtOldPwd" runat="server" TextMode="Password"></asp:TextBox>
             
           
        </div>
        <div class="right_panel">
        	<label for="new_password">New Password : <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                    ControlToValidate="txtConfirmPwd" Display="Dynamic"></asp:RequiredFieldValidator></label> <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox>
            <label for="con_password">Confirm Password : <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                    ControlToValidate="txtOldPwd" Display="Dynamic"></asp:RequiredFieldValidator></label> <asp:TextBox ID="txtConfirmPwd" runat="server" TextMode="Password"></asp:TextBox>
        
        </div>
        <div class="clear"></div>
         <div class="btn">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            	<asp:Button ID="btnClear" runat="server" Text="Clear" CausesValidation="false" 
                    onclick="btnClear_Click"/>                
             <asp:Button ID="Button1" runat="server" Text="Back" CausesValidation="false" onclick="Button1_Click" />
            </div>
             <div class="highlite">
            <asp:Label ID="lblStatus" runat="server" Visible="false"></asp:Label>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords are Not match..."
                    ControlToCompare="txtNewPwd" ControlToValidate="txtConfirmPwd"></asp:CompareValidator>
            </div>
        <div id="login_footer"> CMS Tool Powered By WebCanny Pty Ltd 2013 &copy;  All Rights Reserved</div>
   	</div>
     
    <div class="bot_img"></div>
   
</div>
    </form>
</body>
</html>
