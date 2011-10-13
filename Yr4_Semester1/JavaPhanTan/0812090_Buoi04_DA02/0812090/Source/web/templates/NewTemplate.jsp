<%@taglib prefix="template" uri="/WEB-INF/tlds/TemplateLibrary" %>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>
            <template:get name="title"/>
        </title>
        <%-- load stylesheets and js --%>
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
                <template:get name="header" />
            </div>
            <div class="clear"></div>
            <!-- Banner -->
            <template:get name="banner" />
            <!-- Content Section -->
            <div class="inner">
                <template:get name="content"/>
            </div>
            <div class="clear"></div>
            <!-- Footer -->
            <template:get name="footer" />
        </div>
        <template:get name="misc"/>
    </body>
</html>
