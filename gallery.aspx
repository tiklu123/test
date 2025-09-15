<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<%--<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.2//EN" "http://www.openmobilealliance.org/tech/DTD/xhtml-mobile12.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">--%>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
     <title>ALLSTAR SIGNS : Gallery</title>
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
     
     <!-- LIGHTBOX begins -->
    <link rel="stylesheet" href="css/lightbox.css" type="text/css" media="screen" />
	<script src="js/prototype.js" type="text/javascript"></script>
	<script src="js/scriptaculous.js?load=effects,builder" type="text/javascript"></script>
	<script src="js/lightbox.js" type="text/javascript"></script>
     <!-- LIGHTBOX ends -->
     
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
<body id="page4">
    <form id="form1" runat="server">
    <!-- header -->
    <%--<header>
  </header>--%>
  <!-- slider -->
  <section>
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
  </section>
  <div id="menubar">
        <a href="Default.aspx">Signs</a> <a href="printing.aspx">Printing &amp; Design</a> <a href="aboutus.aspx">About Us</a> <a href="gallery.aspx" class="active">Gallery</a> <a href="contactus.aspx">Contact Us</a>
  </div>
  <!-- content -->
  <section>
  	<div class="container_24">
    	<div class="wrapper">
    	    <div class="content_area">
    	        <h2 id="p1" runat="server"></h2>
    	        <p id="p2" runat="server"></p>
    	        <p id="p3" runat="server"></p>
    	        <div class="clearfix">
    	            <ul id="p4" runat="server" class="client_list auto-margin maxheight">
    	                
    	            </ul> 
    	            <ul id="p5" runat="server" class="client_list auto-margin maxheight">
                        
    	            </ul>
    	            <ul id="p6" runat="server" class="client_list auto-margin maxheight">
    	                
    	            </ul>
    	            <ul id="p7" runat="server" class="client_list auto-margin maxheight">
    	                
    	            </ul>  
    	        </div>
    	        <div>&nbsp;</div>
    	        <div class="hor_split"></div>
    	        <div>&nbsp;</div>
    	        <div class="full_row clearfix">
    	           <ul class="gallery_image">
    	            <li>
    	                <%--<a id="a1" runat="server" href="" rel="lightbox">--%><img id="img1" runat="server" src="" width="194" height="128" alt="Lock &amp; Key Border" title="Lock &amp; Key Border" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a2" runat="server" href="" rel="lightbox">--%><img id="img2" runat="server" src="" width="194" height="128" alt="Coastal Paint Van" title="Coastal Paint Van" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a3" runat="server" href="" rel="lightbox">--%><img id="img3" runat="server" src="" width="194" height="128" alt="A.J.C. Fabrication" title="A.J.C. Fabrication" class="img_border" /><%--</a>--%>
    	            </li>
    	           
    	            <li>
    	                <%--<a id="a4" runat="server" href="" rel="lightbox">--%><img id="img4" runat="server" src="" width="194" height="128" alt="Dwelling B &amp; B Chalets" title="Dwelling B &amp; B Chalets" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a5" runat="server" href="" rel="lightbox">--%><img id="img5" runat="server" src="" width="194" height="128" alt="A1 Salvage and Hardware" title="A1 Salvage and Hardware" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a6" runat="server" href="" rel="lightbox">--%><img id="img6" runat="server" src="" width="194" height="128" alt="Barbeques Galore" title="Barbeques Galore" class="img_border" /><%--</a>--%>
    	            </li>
    	           
    	            <li>
    	                <%--<a id="a7" runat="server" href="" rel="lightbox">--%><img id="img7" runat="server" src="" width="194" height="128" alt="Peel Bearins Tools and Filters" title="Peel Bearins Tools and Filters" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a8" runat="server" href="" rel="lightbox">--%><img id="img8" runat="server" src="" width="194" height="128" alt="Rugs &amp; Soft Furnishings" title="Rugs &amp; Soft Furnishings" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a9" runat="server" href="" rel="lightbox">--%><img id="img9" runat="server" src="" width="194" height="128" alt="Fridge City Building" title="Fridge City Building" class="img_border" /><%--</a>--%>
    	            </li>
    	           
    	            <li>
    	                <%--<a id="a10" runat="server" href="" rel="lightbox">--%><img id="img10" runat="server" src="" width="194" height="128" alt="Hang Loose Building" title="Hang Loose Building" class="img_border" /><%--</a>--%>
    	            </li>
    	            <li>
    	                <%--<a id="a11" runat="server" href="" rel="lightbox">--%><img id="img11" runat="server" src="" width="194" height="128" alt="Mike Sprintcar" title="Mike Sprintcar" class="img_border" /><%--</a>--%>
    	            </li>
    	          
    	           </ul>
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
    	        <p><a href="Default.aspx">Signs</a> | <a href="printing.aspx">Printing &amp; Design</a> | <a href="aboutus.aspx">About Us</a> | <a href="gallery.aspx" class="active">Gallery</a> | <a href="contactus.aspx">Contact Us</a></p>
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
