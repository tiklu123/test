<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Allstar Signs  : Login</title>
    <meta name="ROBOTS" content="NOINDEX, NOFOLLOW" />
    <link rel="stylesheet" href="login.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="login_logo">
       <a href="http://www.webcanny.com.au"><img src="login_img/login_logo.PNG" border="0" /></a></div>
    <div id="login_form">
        <div class="top_img">
            <span><strong><a href="default.aspx"><img src="login_img/home_btn.png" border="0" align="right" /></a><h1>Administrator Area</h1></strong></span>
        </div>
        <div class="login_body">
            <div class="left_panel">
                <label for="txtUserName">
                    User Name:
                </label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <label for="txtPwd">
                    Password:
                </label>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                <div class="btn clear">
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                        onclick="btnSubmit_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Reset" CausesValidation="false"
                        onclick="btnClear_Click" />                     
                </div>
            </div>
            <div class="right_panel">
                 <asp:LinkButton ID="lnkChangePwd" 
            runat="server" Text="Change Password" CausesValidation="false" 
                     onclick="lnkChangePwd_Click" ></asp:LinkButton>
                </div>
            <div class="clear">
            </div>
            <div class="highlite">
            <asp:Label ID="lblStatus" runat="server" Visible="false"></asp:Label>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="User Name is Required... ," ControlToValidate="txtUserName" 
                Display="Dynamic"></asp:RequiredFieldValidator>
               
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Password is Required..." ControlToValidate="txtPwd" 
                Display="Dynamic"></asp:RequiredFieldValidator> 
            
            </div>
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
