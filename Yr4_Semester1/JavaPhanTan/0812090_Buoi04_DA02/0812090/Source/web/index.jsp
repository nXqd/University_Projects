<%--
Document   : index
Created on : Sep 17, 2011, 2:38:06 PM
Author     : nXqd
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page import="java.text.DecimalFormat"%>
<%@page import="model.*"%>
<%@page import="data.ManufacturorDAO"%>
<%@page import="java.util.List"%>
<%@page import="data.RefridgeratorDAO"%>

<%!
private static RefridgeratorDAO refDAO = new RefridgeratorDAO();
private static List<RefridgeratorDTO> refs;
private static List<RefridgeratorDTO> featureds;
private static List<ManufacturorDTO> mfs;
private static ManufacturorDAO mfDAO = new ManufacturorDAO();
private static int pageCount;
private static int currentPage;
private static int productPerPage = 9;
private static String user;
%>

<%
// check for search POST method
	mfs = mfDAO.get();

// check logout redirected
	if (request.getParameter("action") != null) {
		String abc = request.getParameter("action");
		session.setAttribute("user", null);
		session.setAttribute("type", null);
	}

// check if we search something
	if (request.getParameter("searchStr") != null) {
		String searchStr = request.getParameter("searchStr");
		refs = refDAO.search(searchStr);
	} else {
		refs = refDAO.getAll();
		if (request.getParameter("currentPage") != null) {
			currentPage = Integer.parseInt(request.getParameter("currentPage"));
		} else {
			currentPage = 1;
		}
	}

// check if we want search product by category
	if (request.getParameter("manu") != null) {
		int manuId = Integer.parseInt(request.getParameter("manu"));
		refs = refDAO.searchByManufacturor(manuId);
	}

// get featured products
	featureds = refDAO.getFeatureds();
	pageCount = refs.size() / 9 + 1;

// Check if there is a user logined
	if (session.getAttribute("user") != null) {
		user = (String) session.getAttribute("user");
	} else {
		user = null;
	}
%>

<!DOCTYPE html>
<html>

	<head>
		<%@page contentType="text/html" pageEncoding="UTF-8"%>
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
							<li><a href="cart.html">My Cart</a></li>

							<% if (user == null) {%>
							<li><a href="login.jsp">Log In</a></li>
							<%} else {%>
							<li><a href="index.jsp?action=logout">Log out</a></li>
							<% }%>

						</ul>
						<!-- <ul class="lang">
						<li>Language:</li>
						<li><a href="#"><img src="images/flag1.gif" alt="" /></a></li>
						<li><a href="#"><img src="images/flag2.gif" alt="" /></a></li>
						</ul> -->
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
								<!-- <li><a href="categories.html" class="cufontxt upper">Men's</a></li>
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
								</li> -->
								<li><a href="cart.html" class="cufontxt upper">Cart</a></li>
							</ul>
							<div class="clear"></div>
						</div>
						<div class="search">
							<input type="text" value="Enter keyword to search" id="searchBox" name="s" onblur="if(this.value == '') { this.value = 'Enter keyword to search'; }" onfocus="if(this.value == 'Enter keyword to search') { this.value = ''; }" class="bar" />
							<a href='#' class="buttonone" id="RegisterButton">Search</a>
						</div>
					</div>
				</div>
			</div>
			<div class="clear"></div>
			<!-- Banner -->
			<div id="banner">
				<div class="inner">
					<div id="slider2" style="overflow:hidden; height:313px;">
						<div class="contentdiv"><a href="prod_detail.html"><img src="images/banner1.jpg" alt="" /></a></div>
						<div class="contentdiv"><a href="prod_detail.html"><img src="images/banner1.jpg" alt="" /></a></div>
						<div class="contentdiv"><a href="prod_detail.html"><img src="images/banner1.jpg" alt="" /></a></div>
					</div>
					<div id="paginate-slider2">
						<a href="#" class="prev">&nbsp;</a>
						<a href="#" class="next">&nbsp;</a>
					</div>
					<script type="text/javascript" src="js/banner.js"></script>
				</div>
			</div>
			<!-- Content Section -->
			<div class="inner">
				<div id="content_sec">
					<!-- Column 1 -->
					<div class="col1">
						<!-- Categories -->
						<div class="categories">
							<h5 class="small_head">Categories</h5>
							<div class="arrowlistmenu">
								<%
									for (ManufacturorDTO dto : mfs) {
										List<RefridgeratorDTO> listRefrid = refDAO.getByManufacturor(dto);
								%>
								<a href="index.jsp?manu=<%= dto.getId()%>" class="menuheader expandable"><%= dto.getName()%> </a>

								<ul class="categoryitems">
									<li><a href="index.jsp?manu=<%= dto.getId()%>">All</a></li>
									<% for (RefridgeratorDTO refridDTO : listRefrid) {

									%>
									<li><a href="product_detail.jsp?getProduct=<%= refridDTO.getId()%>"><%= refridDTO.getName()%></a> </li>
									<%}%>
								</ul>
								<%}%>
							</div>
						</div>
						<!-- Compare Products -->
						<!-- <div class="compare">
						<h5 class="small_head">Compare Products</h5>
						<ul>
						<li>
						<a href="prod_detail.html" class="title">Lorem ipsum dolor sit amet</a>
						<a href="#" class="cross">&nbsp;</a>
						</li>
						<li>
						<a href="prod_detail.html" class="title">Lorem ipsum dolor sit amet</a>
						<a href="#" class="cross">&nbsp;</a>
						</li>
						<li>
						<a href="prod_detail.html" class="title">Lorem ipsum dolor sit amet</a>
						<a href="#" class="cross">&nbsp;</a>
						</li>
						<li>
						<a href="prod_detail.html" class="title">Lorem ipsum dolor sit amet</a>
						<a href="#" class="cross">&nbsp;</a>
						</li>
						</ul>
						<a href="#" class="buttonone right">Compare</a>
						</div> -->
						<!-- Community Poll -->
						<!-- <div class="com_pol">
						<h5 class="small_head">Community Poll</h5>
						<p class="wht">What is your favorite feature?</p>
						<ul>
						<li><input type="radio" value="" /> Layered Navigation</li>
						<li><input type="radio" value="" /> Price Rules</li>
						<li><input type="radio" value="" /> Category Management</li>
						<li><input type="radio" value="" /> Compare Products</li>
						</ul>
						<a href="#" class="buttonone left">Vote</a>
						</div> -->
					</div>
					<!-- Column 2 -->
					<div class="col2">
						<!-- Featured Products -->
						<div class="featuredslider">
							<h2 class="heading colr">Featured Products</h2>
							<div class="innerslider">
								<a href="#" class="prevbtn">&nbsp;</a>
								<div class="anyClass scroll">
									<ul>
										<%
										for (RefridgeratorDTO ftRefrid : featureds) {
										%>
										<li>
											<a href="product_detail.jsp?getProduct=<%= ftRefrid.getId()%>">
												<img src="images/product/<%= ftRefrid.getName() %>/thumb.jpg" alt="" />
												<%= ftRefrid.getName()%>
											</a>
										</li>
										<%}%>
									</ul>
								</div>
								<a href="#" class="nextbtn">&nbsp;</a>
							</div>
						</div>
						<div class="clear"></div>
						<!-- Product Listing -->
						<div class="prlisting">
							<h2 class="heading colr">New Products</h2>
							<ul class="listing">
								<%
									if (refs.size() == 0)
										out.println("No products!");
									else {
										int max = refs.size() < currentPage * productPerPage ? refs.size() : currentPage * productPerPage;
										for (int i = (currentPage - 1) * productPerPage; i < max; i++) {
											RefridgeratorDTO refDTO = refs.get(i);
											if ((i + 1) % 3 == 0) {
								%>
								<li class="last">
									<%} else {%>
								<li>
									<%}%>
									<a href="product_detail.jsp?getProduct=<%= refDTO.getId()%>" class="thumb"><img src="images/product/<%= refDTO.getName() %>/thumb.jpg" alt="" /></a>
									<h6><a href="product_detail.jsp?getProduct=<%= refDTO.getId()%>" class="colr"><%= refDTO.getName()%></a></h6>
									<!--<a href="#" class="addwish">Add to Wishlist</a>-->
									<!--<a href="#" class="addcomp">Add to Compare</a>-->
									<p class="price">Price: <span class="black"><%= new DecimalFormat("#").format(refDTO.getPrice())%> VND</span></p>
									<a href="cart.html" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>
								</li>

								<%}%>
								<%}%>
							</ul>
							<!-- pager -->
							<% if (pageCount > 1) {%>
							<div class="pagerSC">
								<%
									for (int i = 1; i <= pageCount; i++) {
										if (i == currentPage) {
								%>
								<span class="currentSC"><%= currentPage%></span>
								<% } else {%>
								<a href="index.jsp?currentPage=<%= i%>" title="Go to page <%= i%>"><%= i%></a>
								<% }%>
								<% }%>
								<div style="clear: left;"></div>
                                                        </div>

                                                        <% }%>
						</div>
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
			$("#RegisterButton").click(function() {
				var searchStr = $('#searchBox').val();
				window.location.href = "index.jsp?searchStr=" + searchStr;
			});

		</script>
	</body>
</html>
