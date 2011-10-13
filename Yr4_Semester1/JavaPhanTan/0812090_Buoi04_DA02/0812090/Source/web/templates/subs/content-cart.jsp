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
