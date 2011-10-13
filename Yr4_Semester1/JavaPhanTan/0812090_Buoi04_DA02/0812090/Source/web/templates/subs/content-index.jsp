<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<div id="content_sec">
    <!-- Column 1 -->
    <div class="col1">
        <!-- Categories -->
        <div class="categories">
            <%-- <h5 class="small_head">Categories</h5>
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
				<%}%> --%>
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
                        <%-- featureds --%>
                        <c:forEach items="${featureds}" var="featured">
							<li>
								<a href="product_detail.jsp?getProduct=">
									<img src="images/product/${featured.name}/thumb.jpg" alt="" />
								</a>
							</li>
                        </c:forEach>
                        <%-- /featureds --%>
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
										<a href="product_detail.jsp?getProduct=${ref.id}" class="thumb"><img src="images/product/${ref.name}/thumb.jpg" alt="" /></a>
										<h6><a href="product_detail.jsp?getProduct=${ref.id}" class="colr">${ref.name}</a></h6>
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


