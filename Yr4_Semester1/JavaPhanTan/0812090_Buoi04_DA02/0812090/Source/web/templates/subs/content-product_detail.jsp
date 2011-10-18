<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<%@page pageEncoding="UTF-8"%>

<div id="content_sec">
	<!-- Column 1 -->
	<div class="col1">
		<!-- My Cart -->
		<div class="mycart">
			<h5 class="small_head">My Cart</h5>
			<p class="txt">There are <a href="#" class="bold under"> items</a> in your cart.</p>
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
	</div>
	<!-- Column 2 -->
	<div class="col2">
		<!-- Product Detail -->
		<div class="prod_detail">
			<h2 class="heading colr">${ref.name}</h2>
			<!-- Product Gallery -->
			<div class="thumbgallery">
				<div id="slider2">

					<%-- Big images --%>
					<c:forEach items="${imageFiles}" var="file">
						<div class="contentdiv">
							<img src="images/product/${ref.name}/${file.name}" alt="" />
							<a rel="example_group" href="images/product/${ref.name}/${file.name}" title="${ref.name}" class="zoom">&nbsp;</a>
						</div>
					</c:forEach>

				</div>
				<a href="javascript:void(null)" class="prevbtn"><img src="images/back.gif" alt="" /></a>
				<div style="float:left; overflow:hidden;">
					<div class="anyClass" id="paginate-slider2">
						<ul>

							<%-- Small images --%>
							<c:forEach items="${imageSmallFiles}" var="file">
								<li><a href="#" class="toc"><img src="images/product/${ref.name}/small/${file.name}" alt="" /></a></li>
							</c:forEach>

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
						<li>Brand:  ${mf.name}</li>
						<li>Capacity: ${ref.capacity}</li>
						<li>Door style: ${ref.doorStyle}</li>
						<li>Number of doors: ${ref.doorCount}</li>
						<li>
							Features:
							<ul>
								<c:forEach items="${features}" var="feature">
									<li>${feature}</li>
								</c:forEach>
							</ul>
						</li>
						<li>
							Compositions:
							<ul>
								<c:forEach items="${compositions}" var="composition">
									<li>${composition}</li>
								</c:forEach>
							</ul>
						</li>
						<li>Power: ${ref.power}</li>
						<li>Size: ${ref.size}</li>
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
					</div>
				</div>
			</div>
		</div>
	</div>
</div>