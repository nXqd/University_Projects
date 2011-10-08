<%--
Document   : index
Created on : Sep 17, 2011, 2:38:06 PM
Author     : nXqd
--%>
<%@page import="java.util.logging.*"%>
<%@page import="model.UserDTO"%>
<%@page import="java.sql.SQLException"%>
<%@page import="data.UserDAO"%>
<%@page import="java.io.PrintWriter"%>
<%@ page import="net.tanesha.recaptcha.*" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%-- Declaration --%>
<jsp:useBean id="sessionUser" scope="session" class="model.UserDTO"></jsp:useBean>
<%!
private static UserDAO userDAO = new UserDAO();
%>

<%-- GET and POST --%>
<%

session = request.getSession(true);

// Check if captcha is right
if (request.getParameter("type") != null) {
String remoteAddr = request.getRemoteAddr();
ReCaptchaImpl reCaptcha = new ReCaptchaImpl();
reCaptcha.setPrivateKey("6LcPesgSAAAAAEVDo4xq4RiQQY__dVfCCiHPRiKT");

String challenge = request.getParameter("recaptcha_challenge_field");
String uresponse = request.getParameter("recaptcha_response_field");
ReCaptchaResponse reCaptchaResponse = reCaptcha.checkAnswer(remoteAddr, challenge, uresponse);

// end captcha
if (reCaptchaResponse.isValid()) {
String type = request.getParameter("type");
UserDTO userDTO;

// Login
if ("login".equals(type)) {
try {
userDTO = new UserDTO();
userDTO.setUsername(request.getParameter("user"));
userDTO.setPassword(request.getParameter("pass"));

if (userDAO.login(userDTO) != null) {
	sessionUser = userDTO;
}


} catch (SQLException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (ClassNotFoundException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (InstantiationException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (IllegalAccessException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
}
// Register
} else if ("register".equals(type)) {
userDTO = new UserDTO();
userDTO.setUsername(request.getParameter("user"));
userDTO.setPassword(request.getParameter("pass"));
userDTO.setFullname(request.getParameter("fullname"));
userDTO.setEmail(request.getParameter("email"));
userDTO.setPhone(request.getParameter("phone"));
try {
userDAO.insert(userDTO);

} catch (SQLException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (ClassNotFoundException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (InstantiationException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
} catch (IllegalAccessException ex) {
Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
}
} else {
out.print("Answer is wrong");
}
}
}
%>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Estore 23</title>
        <!-- // Stylesheet // -->
        <link href="css/style.css" rel="stylesheet" type="text/css" />
        <link href="css/ddsmoothmenu.css" rel="stylesheet" type="text/css" />
        <link rel="stylesheet" type="text/css" href="css/jquery.fancybox-1.3.1.css" media="screen" />
        <!-- // Javascript // -->
        <script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="js/ddsmoothmenu.js"></script>
        <script type="text/javascript" src="js/menu.js"></script>
        <script type="text/javascript" src="js/bannercontentslider.js"></script>
        <script type="text/javascript" src="js/ddaccordion.js"></script>
        <script type="text/javascript" src="js/acordin.js"></script>
        <script type="text/javascript" src="js/jquery.easing.1.1.js"></script>
        <script type="text/javascript" src="js/scroll.js"></script>
        <script type="text/javascript" src="js/cufon-yui.js"></script>
        <script type="text/javascript" src="js/Tahoma_400-Tahoma_700.font.js"></script>
        <script type="text/javascript">Cufon.replace('h1, h2, h3, h4, h5, h6, .cufontxt');</script>
        <script type="text/javascript" src="js/jquery.fancybox-1.3.1.js"></script>
        <script type="text/javascript" src="js/lightbox.js"></script>
        <script type="text/javascript" src="js/prodscroller.js"></script>
        <script type="text/javascript" src="js/tabs.js"></script>
    </head>
    <body>
        <div id="wrapper_sec">
            <div class="inner">
                <!-- Header -->
                <div id="masthead">
                    <div class="topsec">
                        <ul class="links">
                            <li class="bold first">Default welcome msg!</li>
                            <li><a href="account.html">My Account</a></li>
                            <!--                            <li><a href="#">My Wishlist</a></li>-->
                            <li><a href="cart.html">My Cart</a></li>
                            <!--                            <li><a href="#">Checkout</a></li>-->
                            <% if (sessionUser.getUsername() == null) {%>
                            <li><a href="login.jsp">Log In</a></li>
                            <%} else {%>
                            <li><a href="index.jsp?action=logout">Log out</a></li>
                            <% }%>
                        </ul>
                        <ul class="lang">
                            <li>Language:</li>
                            <li><a href="#"><img src="images/flag1.gif" alt="" /></a></li>
                            <li><a href="#"><img src="images/flag2.gif" alt="" /></a></li>
                        </ul>
                    </div>
                    <div class="logosec">
                        <div class="logo">
                            <a href="index.jsp"><img src="images/logo.png" alt="" /></a>
                            <h5>World of Fragrance</h5>
                        </div>
                        <div class="cartsec cufontxt">
                            <span class="items white">00</span> items for a total of <span class="itemsprice white">$0.00</span>
                        </div>
                    </div>
                    <div class="navigation">
                        <div id="smoothmenu1" class="ddsmoothmenu">
                            <ul>
                                <li><a href="index.jsp" class="cufontxt upper">Home</a></li>
                                <li><a href="categories.html" class="cufontxt upper">Men's</a></li>
                                <li><a href="categories.html" class="cufontxt upper">Women's</a>
                                <ul>
                                    <li><a href="#">Who we are</a>
                                    <ul>
                                        <li><a href="listing.html">Introduction</a></li>
                                        <li><a href="listing.html">Who we are</a></li>
                                        <li><a href="listing.html">Where we work</a></li>
                                        <li><a href="listing.html">Our Team</a></li>
                                        <li><a href="listing.html">Careers</a></li>
                                    </ul>
                                    </li>
                                    <li><a href="listing.html">Introduction</a></li>
                                    <li><a href="listing.html">Where we work</a></li>
                                    <li><a href="listing.html">Our Team</a></li>
                                    <li><a href="listing.html">Careers</a></li>
                                </ul>
                                </li>
                                <li><a href="cart.html" class="cufontxt upper">Cart</a></li>
                                <li><a href="#" class="cufontxt upper">Pages</a>
                                <ul>
                                    <li><a href="index.jsp">Home</a></li>
                                    <li><a href="categories.html">Categories</a></li>
                                    <li><a href="listing.html">Listing</a></li>
                                    <li><a href="prod_detail.html">Product Detail</a></li>
                                    <li><a href="cart.html">Shopping Cart</a></li>
                                    <li><a href="login.html">Login</a></li>
                                    <li><a href="account.html">Customer Account</a></li>
                                    <li><a href="static.html">Static</a></li>
                                </ul>
                                </li>
                                <li><a href="#" class="cufontxt upper">Themes</a>
                                <ul>
                                    <li><a href="index.jsp">Grey</a></li>
                                    <li><a href="http://chimpstudio.co.uk/themeforest/estore23/cyan/index.html">Cyan</a></li>
                                    <li><a href="http://chimpstudio.co.uk/themeforest/estore23/brown/index.html">Brown</a></li>
                                    <li><a href="http://chimpstudio.co.uk/themeforest/estore23/green/index.html">Green</a></li>
                                </ul>
                                </li>
                            </ul>
                            <div class="clear"></div>
                        </div>
                        <div class="search">
                            <input type="text" value="Enter keyword to search" id="searchBox" name="s" onblur="if(this.value == '') { this.value = 'Enter keyword to search'; }" onfocus="if(this.value == 'Enter keyword to search') { this.value = ''; }" class="bar" />
                            <a href="#" class="buttonone">Search</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <!-- Bread Crumb -->
            <div class="inner">
                <div id="crumb">
                    <ul>
                        <li class="txt">You are here</li>
                        <li><a href="index.jsp">Home</a></li>
                        <li><a href="static.html">About Us</a></li>
                        <li><a href="#" class="last">Introduction</a></li>
                    </ul>
                </div>
            </div>
            <!-- Content Section -->
            <div class="inner">
                <div id="content_sec">
                    <!-- Column 3 -->
                    <div class="col3">
                        <div class="login">
                            <h3 class="heading colr">Login</h3>
                            <div class="signin">
                                <h5 class="colr">Please Sign In</h5>
                                <p>If you have an account with us, please log in.</p>
                                <ul>
                                    <li class="txt bold">Username *</li>
                                    <li class="field"><input name="username" type="text" id="userLogin"/></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">Password *</li>
                                    <li class="field"><input name="username" type="password" id="passLogin"/></li>
                                </ul>
                                <ul>
                                </ul>
                                <ul>
                                    <li class="txt bold">&nbsp;</li>
                                    <li class="field"><p class="right">* Required Fields</p></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">&nbsp;</li>
                                    <li class="field">
                                    <a href="login.jsp" class="buttonone right" id="loginButton">Login</a>
                                    <a href="#" class="forget under">Forgot Your Password?</a>
                                    </li>
                                </ul>
                            </div>
                            <div class="newcus signin">
                                <h5 class="colr">New Customer</h5>
                                <p>If you have an account with us, please log in.</p>
                                <ul>
                                    <li class="txt bold">Username *</li>
                                    <li class="field"><input name="user" type="text" id="userRegister" /></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">Password *</li>
                                    <li class="field"><input name="pass" type="password" id="passRegister" /></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">Fullname</li>
                                    <li class="field"><input name="fullname" type="text" id="fullnameRegister" /></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">Email</li>
                                    <li class="field"><input name="email" type="text" id="emailRegister" /></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">Phone</li>
                                    <li class="field"><input name="phone" type="text" id="phoneRegister" /></li>
                                </ul>
                                <ul>
                                    <li class="txt bold">&nbsp;</li>
                                    <li class="field"><a href="#" class="buttonone right" id="RegisterButton">Create User</a> </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div id="recaptcha">
                        <%
                        ReCaptcha c = ReCaptchaFactory.newReCaptcha("6LcPesgSAAAAAIjbb3M3M-h8HRk5i2skREBLbxTG ", "6LcPesgSAAAAAEVDo4xq4RiQQY__dVfCCiHPRiKT", false);
                        out.print(c.createRecaptchaHtml(null, null));
                        %>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <!-- Footer -->
            <!--<div id="footer">-->
                <!--<div class="inner">-->
                    <!--[> Footer Top Section <]-->
                    <!--<div class="footer_top">-->
                        <!--[> Newsletter Submission <]-->
                        <!--<div class="newsletter">-->
                            <!--<h4>Newsletter Signup</h4>-->
                            <!--<ul>-->
                                <!--<li>-->
                                <!--<input type="text" value="Signup for Newsletter" id="newsBox" name="s" onblur="if(this.value == '') { this.value = 'Signup for Newsletter'; }" onfocus="if(this.value == 'Signup for Newsletter') { this.value = ''; }" class="bar" />-->
                                <!--</li>-->
                                <!--<li class="right"><a href="#" class="searchbtn buttonone">Signup</a></li>-->
                                <!--</ul>-->
                            <!--</div>-->
                        <!--[> Credit Cards <]-->
                        <!--<div class="creditcards">-->
                            <!--<h4>We Accept</h4>-->
                            <!--<ul>-->
                                <!--<li><a href="#"><img src="images/creditcard1.gif" alt="" /></a></li>-->
                                <!--<li><a href="#"><img src="images/creditcard2.gif" alt="" /></a></li>-->
                                <!--<li><a href="#"><img src="images/creditcard3.gif" alt="" /></a></li>-->
                                <!--<li><a href="#"><img src="images/creditcard4.gif" alt="" /></a></li>-->
                                <!--<li><a href="#"><img src="images/creditcard5.gif" alt="" /></a></li>-->
                                <!--</ul>-->
                            <!--</div>-->
                        <!--</div>-->
                    <!--<div class="clear"></div>-->
                    <!--<div class="footer_sec">-->
                        <!--<div class="company">-->
                            <!--<h4>Company</h4>-->
                            <!--<ul>-->
                                <!--<li><a href="static.html">About Us</a></li>-->
                                <!--<li><a href="static.html">Customer Service</a></li>-->
                                <!--<li><a href="static.html">Terms &amp; Conditions</a></li>-->
                                <!--<li><a href="static.html">Privacy Policy</a></li>-->
                                <!--</ul>-->
                            <!--</div>-->
                        <!--<div class="customcare">-->
                            <!--<h4>Customer Care</h4>-->
                            <!--<ul>-->
                                <!--<li><a href="static.html">Refund Policy</a></li>-->
                                <!--<li><a href="static.html">Delivery Info</a></li>-->
                                <!--<li><a href="static.html">Shipping Charges</a></li>-->
                                <!--<li><a href="static.html">Store Locator</a></li>-->
                                <!--</ul>-->
                            <!--</div>-->
                        <!--<div class="community">-->
                            <!--<h4>Community</h4>-->
                            <!--<ul>-->
                                <!--<li><a href="#"><img src="images/foot_icon1.gif" alt="" /> YouTube</a></li>-->
                                <!--<li><a href="#"><img src="images/foot_icon2.gif" alt="" /> Facebook</a></li>-->
                                <!--<li><a href="#"><img src="images/foot_icon3.gif" alt="" /> RSS Feeds</a></li>-->
                                <!--<li><a href="#"><img src="images/foot_icon4.gif" alt="" /> From the Blog</a></li>-->
                                <!--</ul>-->
                            <!--</div>-->
                        <!--<div class="footlogo">-->
                            <!--<a href="index.jsp" class="small_logo"><img src="images/logo.png" alt="" /></a>-->
                            <!--<h6>World of Fragrance</h6>-->
                            <!--</div>-->
                        <!--<div class="clear"></div>-->
                        <!--<div class="copyrights">-->
                            <!--<p>Copyright © 2010-2011 <a href="http://adf.ly/13ptF" target="_blank">RT Production</a> | All Rights Reserved</p>-->
                            <!--<a href="#" class="top">Top</a>-->
                            <!--</div>-->
                        <!--</div>-->
                    <!--<div class="clear"></div>-->
                    <!--</div>-->
                <!--</div>-->
        </div>
        <script>
            // Login clicked
            $('#loginButton').click(function() {
                var user = $('#userLogin').val();
                var pass = $('#passLogin').val();
                var captchaChal = $('#recaptcha_challenge_field').val();
                var captchaRes = $('#recaptcha_response_field').val();
                if (user != null && pass != null && captchaRes != null)
                $.post("login.jsp", { type: "login", user: user, pass: pass, recaptcha_challenge_field: captchaChal, recaptcha_response_field : captchaRes } );
            });
            // Logout clicked
            $('#logoutButton').click(function() {
                $.post("index.jsp", {action:'logout'} );
            });

            // Register clicked
            $('#RegisterButton').click(function() {
                var user = $('#userRegister').val();
                var pass = $('#passRegister').val();
                var fullname = $('#fullnameRegister').val();
                var email = $('#emailRegister').val();
                var phone = $('#phoneRegister').val();
                var captchaChal = $('#recaptcha_challenge_field').val();
                var captchaRes = $('#recaptcha_response_field').val();
                if (user != null && pass != null && captchaRes != null)
                $.post("login.jsp", { type: "register", user: user, pass: pass, fullname: fullname, email: email, phone: phone,recaptcha_challenge_field: captchaChal, recaptcha_response_field : captchaRes  } );
            });
        </script>
    </body>
</html>
