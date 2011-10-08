<%@page import="java.text.DecimalFormat"%>
<%@page import="java.util.Date"%>
<%@page import="model.OrderDTO"%>
<%@page import="data.OrderDetailDAO"%>
<%@page import="model.OrderDetailDTO"%>
<%@page import="data.OrderDAO"%>

<%@page import="model.RefridgeratorDTO"%>
<%@page import="data.RefridgeratorDAO"%>
<%@page import="java.util.ArrayList"%>
<%@page import="java.util.ArrayList"%>
<%@page import="com.sun.org.apache.bcel.internal.generic.AALOAD"%>
<%@page import="java.util.List"%>
<%! 
private class Item {
	public int id;
	public int quantity;
}
private static List<Item> items = new ArrayList<Item>();
private static float totalPrice = 0;
private static RefridgeratorDAO dao = new RefridgeratorDAO();
%>

<%
totalPrice = 0;
session = request.getSession(true);

// process checking out 
if (request.getParameter("checkout") != null && items.size() > 0) {
	try {
	OrderDAO orderDAO = new OrderDAO();
	OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
	
	OrderDTO orderDTO = new OrderDTO();
	// check session for user id 
	orderDTO.setUserId(1); // just for testing

	orderDTO.setTime(new Date());
	// set to accepted at the moment
	orderDTO.setOrderStatusId(1);

	// set OrderDetailids 
	String orderDetailIds = new String();
	for ( Item itemTmp : items) {
		OrderDetailDTO dto = new OrderDetailDTO();
		dto.setCount(itemTmp.quantity);
		dto.setRefridgeratorId(itemTmp.id);
		// insert order detail to database
		orderDetailDAO.insert(dto);
		orderDetailIds += dto.getId() + ",";
	}
	orderDTO.setOrderDetailIds(orderDetailIds);

	// insert orderDTO to database
	orderDAO.insert(orderDTO); }
	catch ( Exception ex ) {
	}
}

// add to cart
if (request.getParameter("quantity") != null && request.getParameter("id") != null) {
	Item item = new Item();
	item.id = Integer.parseInt(request.getParameter("id"));
	item.quantity = Integer.parseInt(request.getParameter("quantity"));
	if (session.getAttribute("carts_items") == null) {
		session.setAttribute("carts_items", items);
	} else {
		items = (List<Item>)session.getAttribute("carts_items");
	}
	// check if this product id is alread in cart list
	boolean hasItem = false;
	for(Item itemTmp : items) {
		if ( itemTmp.id == item.id ) {
			itemTmp.quantity += item.quantity;
			hasItem = true;
			break;
		}
	}
	if (!hasItem) items.add(item);

	// set new items to session
	session.setAttribute("carts_items", items);

	// get total price
	for(Item itemTmp : items) {
		RefridgeratorDTO dto = new RefridgeratorDTO();
		dto.setId(itemTmp.id);
		dto = dao.get(dto);
		totalPrice += dto.getPrice() * itemTmp.quantity;
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
                            <li><a href="cart.jsp">My Cart</a></li>
                            <li><a href="login.html">Log In</a></li>
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
                                <li><a href="cart.jsp" class="cufontxt upper">Cart</a></li>
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
                        <div class="shoppingcart">
                            <h2 class="heading colr">Shopping Cart</h2>
                            <ul class="buttons">
                                <li><a href="index.jsp" class="buttonone">Continue Shopping</a></li>
                                <li><a href="cart.jsp?checkout=true" class="buttonone">Proceed to Checkout</a></li>
                            </ul>
                            <div class="cartitems">
                                <ul class="carthead">
                                    <li class="image">Image</li>
                                    <li class="name">Product Name</li>
                                    <li class="delete">Delete</li>
                                    <li class="qty">Qty</li>
                                    <li class="unitprice">Unit Price</li>
                                    <li class="subtotal">Subtotal</li>
                                </ul>
				<% 
				for(Item itemTmp : items) {
					RefridgeratorDTO dto = new RefridgeratorDTO();
					dto.setId(itemTmp.id);
					dto = dao.get(dto);					
				%>
                                <ul class="cartlist">
                                    <li class="image"><a href="prod_detail.html"><img src="images/cart1.gif" alt="" /></a></li>
                                    <li class="name"><a href="prod_detail.html"><%= dto.getName() %></a></li>
                                    <li class="delete"><a href="#"><img src="images/delete.gif" alt="" /></a></li>
                                    <li class="qty"><input name="a" type="text" value="<%= itemTmp.quantity %>" /></li>
                                    <li class="unitprice"><%= new DecimalFormat("#.##").format(dto.getPrice()) %></li>
                                    <li class="subtotal"><%= new DecimalFormat("#.##").format(dto.getPrice() * itemTmp.quantity) %></li>
                                </ul>
				<%}%>
                            </div>
                            <div class="clear"></div>
                            <!-- Cart Left Section -->
                            <div class="cartleft">
                                <!-- Discount Coupon -->
                                <div class="clear"></div>
                                <!-- Products -->
                                <!--<div class="relatedproducts">-->
                                    <!--<h6 class="colr relhead">Based on your selection, you may be interested in the following items:</h6>-->
                                    <!--<a href="#" class="arrows_left">&nbsp;</a>-->
                                    <!--<div class="product">-->
                                        <!--<a href="prod_detail.html" class="thumb"><img src="images/prod1.gif" alt="" /></a>-->
                                        <!--<h6><a href="prod_detail.html" class="colr">Vibrant Perfume for Men</a></h6>-->
                                        <!--<a href="#" class="addwish">Add to Wishlist</a>-->
                                        <!--<a href="#" class="addcomp">Add to Compare</a>-->
                                        <!--<p class="price">Price: <span class="black overline">$200.99</span> to <span class="black">$150.99</span></p>-->
                                        <!--<a href="cart.jsp" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>-->
                                        <!--</div>-->
                                    <!--<div class="product">-->
                                        <!--<a href="prod_detail.html" class="thumb"><img src="images/prod1.gif" alt="" /></a>-->
                                        <!--<h6><a href="prod_detail.html" class="colr">Vibrant Perfume for Men</a></h6>-->
                                        <!--<a href="#" class="addwish">Add to Wishlist</a>-->
                                        <!--<a href="#" class="addcomp">Add to Compare</a>-->
                                        <!--<p class="price">Price: <span class="black overline">$200.99</span> to <span class="black">$150.99</span></p>-->
                                        <!--<a href="cart.jsp" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>-->
                                        <!--</div>-->
                                    <!--<a href="#" class="arrows_right">&nbsp;</a>-->
                                    <!--</div>-->
                            </div>
                            <!-- Cart Right Section -->
                            <div class="cartright">
                                <!-- Totals -->
                                <div class="totals">
                                    <!--<ul>-->
                                        <!--<li class="tot_head">Sub Total</li>-->
                                        <!--<li class="tot_price">$349.99</li>-->
                                        <!--</ul>-->
                                    <ul>
                                        <li class="tot_head">Grand total</li>
                                        <li class="tot_price"><%= new DecimalFormat("#.##").format(totalPrice) %></li>
                                    </ul>
                                </div>
                                <div class="clear"></div>
                                <!-- Estimate Shipping and Tax -->
                                <!--<div class="est_tax">-->
                                    <!--<h5 class="colr">Estimate Shipping and Tax</h5>-->
                                    <!--<p>Enter your destination to get a shipping estimate.</p>-->
                                    <!--<ul>-->
                                        <!--<li class="txt">Country</li>-->
                                        <!--<li class="inputf">-->
                                        <!--<select name="jumpMenu" id="jumpMenu" onchange="MM_jumpMenu('parent',this,0)">-->
                                            <!--<option>United Estates</option>-->
                                            <!--<option>United Kingdom</option>-->
                                            <!--<option>Canada</option>-->
                                            <!--</select>-->
                                        <!--</li>-->
                                        <!--<li class="txt">State/Province</li>-->
                                        <!--<li class="inputf">-->
                                        <!--<select name="jumpMenu" id="jumpMenu1" onchange="MM_jumpMenu('parent',this,0)">-->
                                            <!--<option>Alabama</option>-->
                                            <!--<option>Florida</option>-->
                                            <!--<option>New York</option>-->
                                            <!--</select>-->
                                        <!--</li>-->
                                        <!--<li class="txt">Zip code</li>-->
                                        <!--<li class="inputf">-->
                                        <!--<input name="a" type="text" />-->
                                        <!--</li>-->
                                        <!--<li class="txt"><a href="#" class="buttonone">Apply Coupon</a></li>-->
                                        <!--</ul>-->
                                    <!--</div>-->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <!-- Footer -->
        </div>
    </body>

</html>