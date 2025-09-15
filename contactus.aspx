<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="contactus" %>

<!DOCTYPE html>
<html lang="en">
<%--<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.2//EN" "http://www.openmobilealliance.org/tech/DTD/xhtml-mobile12.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">--%>
<head runat="server">
    <title>ALLSTAR SIGNS : Contact Us</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="css/reset.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/grid.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <script type="text/javascript" src="js/flashobject.js"></script>
    <script src="js/cufon-yui.js" type="text/javascript"></script>
    <script src="js/cufon-replace.js" type="text/javascript"></script>
    <script src="js/Cicle_300.font.js" type="text/javascript"></script>
    <script src="js/Trebuchet_MS_400-Trebuchet_MS_700-Trebuchet_MS_italic_400-Trebuchet_MS_italic_700.font.js" type="text/javascript"></script>
     
     <!-- Start WOWSlider.com HEAD section -->
     <link rel="stylesheet" type="text/css" href="engine1/banner.css" />
     <!-- End WOWSlider.com HEAD section -->
    <!-- MAXHEIGHT begins -->
    <script src="js/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/maxheight.js" type="text/javascript"></script>
    <script src="js/jquery.equalheights.js" type="text/javascript"></script>
    <!-- MAXHEIGHT ends -->
    <!--[if lt IE 7]>
        <script type="text/javascript" src="http://info.template-help.com/files/ie6_warning/ie6_script_other.js"></script>
      <![endif]-->
    <!--[if lt IE 9]>
        <script type="text/javascript" src="js/html5.js"></script>
      <![endif]-->
    <!--[if lt IE 8]>
        <script src="js/cufon-yui.js" type="text/javascript"></script>
        <script src="js/cufon-replace.js" type="text/javascript"></script>
        <script src="js/Cicle_300.font.js" type="text/javascript"></script>
      <![endif]-->
      
      <script type="text/javascript">
<!--
          function validation() {
              if (document.getElementById("txtname").value == "- your name -") {
                  alert('Please Enter your Name.');
                  document.getElementById("txtname").focus();
                  return false;
              }
              var v1 = document.getElementById("txtname");
              var v2 = v1.value.trim().length;
              if (v2 == 0) {
                  alert('Name should not be blank.');
                  document.getElementById("txtname").focus();
                  return false;
              }
              if (document.getElementById("txtphone").value == "- phone -") {
                  alert("Please Enter Your Phone Number")
                  document.getElementById("txtphone").focus();
                  return false;
              }
              if (document.getElementById("txtmobile").value == "- mobile -") {
                  alert("Please Enter Your Mobile Number")
                  document.getElementById("txtmobile").focus();
                  return false;
              }
              if (document.getElementById("txtemail").value == "- email -") {
                  alert("Please Enter Your Email!");
                  document.getElementById("txtemail").focus();
                  return false;
              }
              var emailPat = /(^[0-9][0-9a-z_\.]*)|(^[a-z]([a-z0-9_\.]*)@([a-z0-9][a-z0-9-_\.]*)([.][a-z]{3})$)|(^[a-z]([a-z0-9_\.]*)@([a-z0-9][a-z0-9-_\.]*)(\.[a-z]{2,4})(\.[a-z]{2})*$)/i;
              var emailid = document.getElementById("txtemail").value;
              var matchArray = emailid.match(emailPat);
              if (matchArray == null) {
                  alert("Your email address seems incorrect. Please try again.");
                  document.getElementById("txtemail").focus();
                  return false;
              }
              if (document.getElementById("txtmessage").value == "- comments -") {
                  alert('Please Enter your Comments.');
                  document.getElementById("txtmessage").focus();
                  return false;
              }
              var v3 = document.getElementById("txtmessage");
              var v4 = v3.value.trim().length;
              if (v4 == 0) {
                  alert('Comments should not be blank.');
                  document.getElementById("txtmessage").focus();
                  return false;
              }
          }

          function isNumeric(keyCode) {

              if (keyCode == 16)
                  isShift = true;

              return ((keyCode >= 48 && keyCode <= 57 || keyCode == 8 ||
                         keyCode == 9 || keyCode == 37 || keyCode == 46 ||
                         keyCode == 39 || keyCode == 35 || keyCode == 36 ||
                        (keyCode >= 96 && keyCode <= 105)) && isShift == false);
          }
          var isShift = false;
          function keyUP(keyCode) {

              if (keyCode == 16)

                  isShift = false;
          }
       -->
    </script>
<script type="text/javascript">

  var _gaq = _gaq || [];
  _gaq.push(['_setAccount', 'UA-30555318-1']);
  _gaq.push(['_trackPageview']);

  (function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
  })();

</script>
</head>
<body id="page5">
    <form id="form1" runat="server">
    <!-- header -->
    <%--<header>
    </header>--%>
    <!-- slider -->
    <section id="slider" class="paddtop_6">
  	    <div class="container_24">
          <div class="wrapper">
            <div id="logo">
                <a href="Default.aspx"><img src="images/allstars_logo.png" width="300" height="52" alt="ALLSTAR SIGNS" title="ALLSTAR SIGNS"/></a>
            </div>
            <div id="banner">
                <!-- Start WOWSlider.com BODY section -->
                <div id="wowslider-container1">
                  <div class="ws_images">
                     <ul>
                  <li><img id="bimg1" runat="server" src="" alt="Allstar Signs" /></li>
                  <li><img id="bimg2" runat="server" src="" alt="Allstar Signs" /></li>
                  <li><img id="bimg3" runat="server" src="" alt="Allstar Signs" /></li>
                  <li><img id="bimg4" runat="server" src="" alt="Allstar Signs" /></li>
                  <li><img id="bimg5" runat="server" src="" alt="Allstar Signs" /></li>
                </ul>
                  </div>
                  <div class="ws_bullets">
                    <div>
    	                <a href="#">1</a>
                        <a href="#">2</a>
                        <a href="#">3</a>
                        <a href="#">4</a>
                        <a href="#">5</a>
                    </div>
                  </div>
                </div>
                <script type="text/javascript" src="engine1/wowslider.js"></script>
                <script type="text/javascript" src="engine1/script.js"></script>
                <!-- End WOWSlider.com BODY section -->
            </div>
          </div>
        </div>
        <div id="menubar">
            <a href="Default.aspx">Signs</a> <a href="printing.aspx">Printing &amp; Design</a> <a href="aboutus.aspx">About Us</a> <a href="gallery.aspx">Gallery</a> <a href="contactus.aspx" class="active">Contact Us</a>
        </div>
    </section>
    <!-- content -->
    <section id="content">
  	    <div class="container_24">
    	    <div class="wrapper">
    	        <div class="content_area">
    	            <h2 id="p1" runat="server"></h2>
    	            <div id="p2" runat="server" class="full_row margin_bottom_5">
        	            
    	            </div>
    	            <div class="hor_split"></div>
    	            <div class="full_row">
    	                <div id="contacts-form">
    	                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    	                <asp:Panel ID="Panel1" runat="server">
    	                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    	                <ContentTemplate>
    	                    <h4>Contact Form</h4>
    	                    <input type="text" name="txtName" id="txtname" runat="server" value="- your name -" onblur="if(this.value=='') this.value='- your name -'" onfocus="if(this.value=='- your name -') this.value=''" maxlength="25" />
    	                    <input type="text" name="txtPhone" id="txtphone" runat="server" value="- phone -" onblur="if(this.value=='') this.value='- phone -'" onfocus="if(this.value=='- phone -') this.value=''"  onkeyup="keyUP(event.keyCode)" onkeydown="return isNumeric(event.keyCode)" maxlength="12" />
    	                    <input type="text" name="txtMobile" id="txtmobile" runat="server" value="- mobile -" onblur="if(this.value=='') this.value='- mobile -'" onfocus="if(this.value=='- mobile -') this.value=''"  onkeyup="keyUP(event.keyCode)" onkeydown="return isNumeric(event.keyCode)"  maxlength="12" />
    	                    <input type="text" name="txtEmail" id="txtemail" runat="server" value="- email -" onblur="if(this.value=='') this.value='- email -'" onfocus="if(this.value=='- email -') this.value=''" />
    	                    <textarea name="txtComments" id="txtmessage" runat="server" rows="10" cols="10" onblur="if(this.value=='') this.value='- comments -'" onfocus="if(this.value=='- comments -') this.value=''" >- comments -</textarea>
    	                    <div class="field_row clearfix">
    	                        <input id="Reset1" type="reset" value="Clear" class="btn" />
    	                        <asp:Button ID="Button1" runat="server" Text="Send" CssClass="btn" OnClick="Button1_Click" OnClientClick="return validation()"></asp:Button>
    	                    </div>
    	                    </ContentTemplate>
    	                </asp:UpdatePanel>
    	                </asp:Panel>
    	                </div>
    	            </div>
    	            <div class="hor_split"></div>
    	            <div class="full_row">
    	                <h4>Google Map</h4>
    	                <iframe width="290" height="360" src="http://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=+&amp;q=ALL+STAR+SIGNS,+Unit+3,+8+Delmont+Place+Mandurah+Western+Australia+6210&amp;ie=UTF8&amp;hq=ALL+STAR+SIGNS,+Unit+3,+8+Delmont+Place&amp;hnear=Mandurah+Western+Australia,+Australia&amp;t=m&amp;ll=-32.513525,115.751438&amp;spn=0.052112,0.049782&amp;z=13&amp;iwloc=A&amp;output=embed" class="map"></iframe><br /><small><a href="http://maps.google.co.in/maps?f=q&amp;source=embed&amp;hl=en&amp;geocode=+&amp;q=ALL+STAR+SIGNS,+Unit+3,+8+Delmont+Place+Mandurah+Western+Australia+6210&amp;ie=UTF8&amp;hq=ALL+STAR+SIGNS,+Unit+3,+8+Delmont+Place&amp;hnear=Mandurah+Western+Australia,+Australia&amp;t=m&amp;ll=-32.513525,115.751438&amp;spn=0.052112,0.049782&amp;z=13&amp;iwloc=A" style="color:#029ae4;text-align:left">View Larger Map</a></small>
    	            </div>
    	        </div>
    	    </div>
        </div>
    </section>
    <!-- footer -->
    <footer>
        <div class="container_24">
    	    <div class="clearfix footer_lrpadding">
    	        <div class="full_row aligncenter">
    	            <p><a href="Default.aspx">Signs</a> | <a href="printing.aspx">Printing &amp; Design</a> | <a href="aboutus.aspx">About Us</a> | <a href="gallery.aspx">Gallery</a> | <a href="contactus.aspx" class="active">Contact Us</a></p>
    	        </div>
    	    <div class="full_row">
      	        &copy; Allstar Signs 2013 | <a id="editlogin" runat="server" href="login.aspx">Edit</a> |
               <%--<a target="_blank"  href="http://webcanny.com.au/web-design">Website Design</a> by <a target="_blank"  href="http://webcanny.com.au">WebCanny</a>--%>
            </div>
          </div>
        </div>
    </footer>
    </form>
</body>
</html>
