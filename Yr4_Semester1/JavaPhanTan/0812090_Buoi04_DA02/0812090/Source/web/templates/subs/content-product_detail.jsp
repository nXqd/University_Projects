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
						<li>Hãng s?n xu?t:  <%= mf.getName()%></li>
						<li>T?ng dung tích: <%= ref.getCapacity()%></li>
						<li>Ki?u c?a: <%= ref.getDoorStyle()%></li>
						<li>S? c?a: <%= ref.getDoorCount()%></li>
						<li>
							Tính n?ng:
							<ul>
								<%
			String features[] = ref.getFeature().split("\\|");
			for (String feature : features) {%>
								<li><%= feature%></li>
								<%}%>
							</ul>
						</li>
						<li>
							C?u t?o:
							<ul>
								<%
			String compositions[] = ref.getComposition().split("\\|");
			for (String composition : compositions) {%>
								<li><%= composition%></li>
								<%}%>
							</ul>
							
						</li>
						<li>Công su?t: <%= ref.getPower()%></li>
						<li>Kích th??c: <%= ref.getSize()%></li>
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