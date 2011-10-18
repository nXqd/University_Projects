<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<div id="content_sec">
    <!-- Column 1 -->
    <div class="col1">
        <!-- Categories -->
        <div class="categories">
			<h5 class="small_head">Categories</h5>
			<div class="arrowlistmenu">

				<c:forEach items="${hashFeatureds}" var="featured">
					<a href="home?manu=${featured.key}" class="menuheader expandable">${featured.key} </a>
					<ul class="categoryitems">
						<li><a href="home?manu=${featured.key}">All</a></li>
						<c:forEach items="${featured.value}" var="item" >
							<li><a href="product?getProduct=${item.name}">${item.name}</a> </li>
						</c:forEach>
					</ul>
				</c:forEach>

			</div>
		</div>
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
						<c:forEach items="${featureds}" var="featured">
							<li>
								<a href="product?getProduct=${featured.id}">
									<img src="images/product/${featured.name}/thumb.jpg" alt="" />
								</a>
							</li>
						</c:forEach>
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

				<c:choose>
					<c:when test="${empty refrids}">
						<c:out value="There is no product"></c:out>
					</c:when>
					<c:otherwise>
						<c:forEach items="${refrids}" var="ref" varStatus="i">
							<c:choose>
								<c:when test="${(i.count + 1)%3 == 0}">
									<li class="last">
									</c:when>
									<c:otherwise>
									<li>
									</c:otherwise>
								</c:choose>

								<a href="product?getProduct=${ref.id}" class="thumb"><img src="images/product/${ref.name}/thumb.jpg" alt="" /></a>
								<h6><a href="product?getProduct=${ref.id}" class="colr">${ref.name}</a></h6>
								<a href="cart.jsp" class="addtocart">&nbsp;<span class="bubble">Add to cart</span></a>

							</li>
						</c:forEach>
					</c:otherwise>
				</c:choose>

			</ul>
			<!-- pager -->
			<div class="pagerSC">

				<c:choose>
					<c:when test="${page} > 1">
						<c:forEach items="${pageCount}" varStatus="i">
							<c:choose>
								<c:when test="${ i.count == page }">
									<span class="currentSC">${page}</span>
								</c:when>
								<c:otherwise>
									<a href="home?currentPage=${i.count}"</a>
								</c:otherwise>
							</c:choose>
						</c:forEach>
					</c:when>
				</c:choose>

			</div>
		</div>
	</div>