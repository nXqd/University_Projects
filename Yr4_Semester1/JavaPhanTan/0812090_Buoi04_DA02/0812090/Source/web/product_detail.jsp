<%--
Document   : product_detail
Created on : Sep 26, 2011, 8:42:22 PM
Author     : Administrator
--%>

<%@page import="java.io.File"%>
<%@page import="org.apache.jasper.tagplugins.jstl.core.ForEach"%>
<%@page import="data.ManufacturorDAO"%>
<%@page import="model.ManufacturorDTO"%>
<%@page import="model.ManufacturorDTO"%>
<%@page import="java.util.logging.*"%>
<%@page import="java.sql.SQLException"%>
<%@page import="model.RefridgeratorDTO"%>
<%@page import="data.RefridgeratorDAO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%-- Declaration --%>
<%!
private static RefridgeratorDAO dao = new RefridgeratorDAO();
private static RefridgeratorDTO ref;
private static ManufacturorDTO mf;
private static String user;
%>

<%-- Check for get and post --%>
<%
	if (request.getParameter("getProduct") != null) {
		String productId = request.getParameter("getProduct");

		// Login
		try {
			ref = new RefridgeratorDTO();
			ref.setId(Integer.parseInt(productId));
			ref = dao.get(ref);

			// get Manufacutor name
			ManufacturorDAO mfDAO = new ManufacturorDAO();
			mf = new ManufacturorDTO();
			mf.setId(ref.getId());
			mf = mfDAO.getNameById(mf);

		} catch (SQLException ex) {
			Logger.getLogger(RefridgeratorDTO.class.getName()).log(Level.SEVERE, null, ex);
		} catch (ClassNotFoundException ex) {
			Logger.getLogger(RefridgeratorDTO.class.getName()).log(Level.SEVERE, null, ex);
		} catch (InstantiationException ex) {
			Logger.getLogger(RefridgeratorDTO.class.getName()).log(Level.SEVERE, null, ex);
		} catch (IllegalAccessException ex) {
			Logger.getLogger(RefridgeratorDTO.class.getName()).log(Level.SEVERE, null, ex);
		}
		// Register
	}
	/*if (request.getParameter("quantity") != null) {
		// make a request to add to cart
		request.setAttribute("quantity", request.getParameter("quantity"));
		request.setAttribute("id", ref.getId());
		RequestDispatcher dispatcher = request.getRequestDispatcher("/cart.jsp");
		if (dispatcher != null)
   			dispatcher.forward(request, response);
	}*/

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
		<!-- <script type="text/javascript" src="js/tabs.js"></script> -->
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
					<!-- Column 1 -->
					<div class="col1">
						<!-- My Cart -->
						<div class="mycart">
							<h5 class="small_head">My Cart</h5>
							<p class="txt">There are <a href="#" class="bold under">3 items</a> in your cart.</p>
							<p class="txt">Cart Subtotal: <span class="bold">$899.97</span></p>
							<a href="#" class="buttonone checkout">Checkout</a>
							<div class="clear"></div>
							<ul>
								<li>
									<a href="#" class="title">Open Perfume</a>
									<a href="#" class="cross">&nbsp;</a>
									<div class="clear"></div>
									<p class="qty">QTY: 2</p>
									<p class="price">Price: <span class="bold">$200</span></p>
								</li>
								<li class="withbg">
									<a href="#" class="title">Open Perfume</a>
									<a href="#" class="cross">&nbsp;</a>
									<div class="clear"></div>
									<p class="qty">QTY: 2</p>
									<p class="price">Price: <span class="bold">$200</span></p>
								</li>
								<li>
									<a href="#" class="title">Open Perfume</a>
									<a href="#" class="cross">&nbsp;</a>
									<div class="clear"></div>
									<p class="qty">QTY: 2</p>
									<p class="price">Price: <span class="bold">$200</span></p>
								</li>
								<li class="withbg">
									<a href="#" class="title">Open Perfume</a>
									<a href="#" class="cross">&nbsp;</a>
									<div class="clear"></div>
									<p class="qty">QTY: 2</p>
									<p class="price">Price: <span class="bold">$200</span></p>
								</li>
							</ul>
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
						<!-- Product Detail -->
						<div class="prod_detail">
							<h2 class="heading colr"><%= ref.getName()%></h2>
							<!-- Product Gallery -->
							<div class="thumbgallery">
								<div id="slider2">
									<%
										File folder = new File(config.getServletContext().getRealPath("/") + "images/product/" + ref.getName() + "/");
										File[] listOfFiles = folder.listFiles();
										for (int i = 0; i < listOfFiles.length; i++) {
											if (listOfFiles[i].isFile() && listOfFiles[i].getName() != "thumb.jpg") {
									%>

									<div class="contentdiv">
										<img src="images/product/<%= ref.getName()%>/<%= listOfFiles[i].getName()%>" alt="" />
										<a rel="example_group" href="images/product/<%= ref.getName()%>/<%= listOfFiles[i].getName()%>" title="<%= ref.getName()%>" class="zoom">&nbsp;</a>
									</div>
									<% }%>
									<% }%>
								</div>
								<a href="javascript:void(null)" class="prevbtn"><img src="images/back.gif" alt="" /></a>
								<div style="float:left; overflow:hidden;">
									<div class="anyClass" id="paginate-slider2">
										<ul>
											<%
												folder = new File(config.getServletContext().getRealPath("/") + "images/product/" + ref.getName() + "/small/");
												listOfFiles = folder.listFiles();
												for (int i = 0; i < listOfFiles.length; i++) {
													if (listOfFiles[i].isFile()) {
											%>
											<li><a href="#" class="toc"><img src="images/product/<%= ref.getName()%>/small/<%= listOfFiles[i].getName()%>" alt="" /></a></li>
													<% }%>
													<% }%>
										</ul>
									</div>
								</div>
								<a href="javascript:void(null)" class="nextbtn"><img src="images/forward.gif" alt="" /></a>
								<script type="text/javascript" src="js/gallery.js"></script>
							</div>
							<!-- Product Description -->
							<div class="desc">
								<div class="prodlinks">
									<a href="#" class="emailfriend">Email to a friend</a>
									<div class="clear"></div>
									<a href="#" class="writereview">Be the first to review this product</a>
								</div>
								<div class="stock">
									<a href="#"><img src="images/instock.gif" alt="" /></a>
								</div>
								<div class="quickreview">
									<h6 class="colr">Quick Overview</h6>
									<ul class="features">
										<li>Hãng sản xuất:  <%= mf.getName()%></li>
										<li>Tổng dung tích: <%= ref.getCapacity()%></li>
										<li>Kiểu cửa: <%= ref.getDoorStyle()%></li>
										<li>Số cửa: <%= ref.getDoorCount()%></li>
										<li>
											Tính năng:
											<ul>
												<%
							String features[] = ref.getFeature().split("\\|");
							for (String feature : features) {%>
												<li><%= feature%></li>
												<%}%>
											</ul>
										</li>
										<li>
											Cấu tạo:
											<ul>
												<%
							String compositions[] = ref.getComposition().split("\\|");
							for (String composition : compositions) {%>
												<li><%= composition%></li>
												<%}%>
											</ul>

										</li>
										<li>Công suất: <%= ref.getPower()%></li>
										<li>Kích thước: <%= ref.getSize()%></li>
									</ul>
								</div>
								<div class="clear"></div>
								<div class="prod_options">
									<div class="moreoption">
										<p class="price bold">Price: <span class="overline">$200.99</span> to $199.5</p>
										<p class="txt">To Buy, Select Size and Color</p>
										<ul>
											<li class="txt bold">Quantity</li>
											<li class="optons"><input name="quantity" type="text" /></li>
											<li class="cartbtn"><a href="#" class="addtocartbtn">Add to Cart</a></li>
										</ul>
										<div class="clear"></div>
										<a href="#" class="addtowishlist">Add to Wishlist</a>
										<a href="#" class="addtowishlist">Add to Compare</a>
									</div>
								</div>
							</div>
						</div>
						<!-- Product Listing -->
						<!--<div class="prlisting">-->
						<!--<h2 class="heading colr">New Products for March 2010</h2>-->
						<!--<ul class="listing">-->
						<!--<li>-->
						<!--<a href="prod_detail.html" class="thumb"><img src="images/prod1.gif" alt="" /></a>-->
						<!--<h6><a href="prod_detail.html" class="colr">Vibrant Perfume for Men</a></h6>-->
						<!--<a href="#" class="addwish">Add to Wishlist</a>-->
						<!--<a href="#" class="addcomp">Add to Compare</a>-->
						<!--<p class="price">Price: <span class="black overline">$200.99</span> to <span class="black">$150.99</span></p>-->
						<!--<a href="cart.html" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>-->
						<!--</li>-->
						<!--<li>-->
						<!--<a href="prod_detail.html" class="thumb"><img src="images/prod2.gif" alt="" /></a>-->
						<!--<h6><a href="prod_detail.html" class="colr">Vibrant Perfume for Men</a></h6>-->
						<!--<a href="#" class="addwish">Add to Wishlist</a>-->
						<!--<a href="#" class="addcomp">Add to Compare</a>-->
						<!--<p class="price">Price: <span class="black overline">$200.99</span> to <span class="black">$150.99</span></p>-->
						<!--<a href="cart.html" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>-->
						<!--</li>-->
						<!--<li class="last">-->
						<!--<a href="prod_detail.html" class="thumb"><img src="images/prod3.gif" alt="" /></a>-->
						<!--<h6><a href="prod_detail.html" class="colr">Vibrant Perfume for Men</a></h6>-->
						<!--<a href="#" class="addwish">Add to Wishlist</a>-->
						<!--<a href="#" class="addcomp">Add to Compare</a>-->
						<!--<p class="price">Price: <span class="black overline">$200.99</span> to <span class="black">$150.99</span></p>-->
						<!--<a href="cart.html" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>-->
						<!--</li>-->
						<!--</ul>-->
						<!--<div class="clear"></div>-->
						<!--</div>-->
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
			$('.addtocartbtn').click(function() {
				var quantity = $('input[name=quantity]').val();
				if (quantity)
					window.location.href = 'cart.jsp?quantity=' + quantity + '&id=' + <%= ref.getId() %> ;
					//$.post('product_detail.jsp', { quantity: quantity});
			});
		</script>
	</body>
</html>
