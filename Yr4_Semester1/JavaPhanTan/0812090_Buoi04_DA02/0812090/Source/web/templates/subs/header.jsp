<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>

<div id="masthead">
    <div class="topsec">
        <ul class="links">
            <li class="bold first">Default welcome msg!</li>
            <li><a href="account.html">My Account</a></li>
            <li><a href="cart">My Cart</a></li>

			<c:choose>
				<c:when test="${user == null}">
					<li><a href="login">Log In</a></li>
				</c:when>
				<c:otherwise>
					<li><a href="home?action=logout">Log out</a></li>
				</c:otherwise>
			</c:choose>

        </ul>
        <!-- <ul class="lang">
            <li>Language:</li>
            <li><a href="#"><img src="images/flag1.gif" alt="" /></a></li>
            <li><a href="#"><img src="images/flag2.gif" alt="" /></a></li>
        </ul> -->
    </div>
    <div class="logosec">
        <div class="logo">
            <a href="home"><img src="images/logo.png" alt="" /></a>
            <h5>World of Fragrance</h5>
        </div>
        <div class="cartsec cufontxt">
            <span class="items white">
			</span>${fn:length(sessionScope.cartItems)} items for a total of  <span class="itemsprice white">${sessionScope.totalPrice}</span>
        </div>
    </div>
    <div class="navigation">
        <div id="smoothmenu1" class="ddsmoothmenu">
            <ul>
                <li><a href="home" class="cufontxt upper">Home</a></li>
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
                <li><a href="cart" class="cufontxt upper">Cart</a></li>
            </ul>
            <div class="clear"></div>
        </div>
        <div class="search">
            <input type="text" value="Enter keyword to search" id="searchBox" name="s" onblur="if(this.value == '') {this.value = 'Enter keyword to search'; }" onfocus="if(this.value == 'Enter keyword to search') { this.value = ''; }" class="bar" />
            <a href='#' class="buttonone" id="RegisterButton">Search</a>
        </div>
    </div>
</div>