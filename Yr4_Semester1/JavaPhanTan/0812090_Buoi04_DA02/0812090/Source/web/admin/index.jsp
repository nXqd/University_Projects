<%@page import="model.UserDTO"%>
<%@page import="data.UserDAO"%>
<%!	
private static UserDAO userDAO = new UserDAO();
%>

<%
	if (request.getParameter("type") != null) {
		UserDTO user = new UserDTO();
		user.setUsername(request.getParameter("user"));
		user.setPassword(request.getParameter("pass"));
		user = userDAO.login(user);
		if (user != null && user.getRoleId() == 2) {
			session = request.getSession(true);
			session.setAttribute("user", user.getUsername());
			session.setAttribute("type", "admin");
			RequestDispatcher rd = getServletContext().getRequestDispatcher("/admin/login.jsp");
			rd.forward(request, response);
			return;
		}
	}
%>
<!DOCTYPE html>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
		<title>Internet Dreams</title>
		<link rel="stylesheet" href="css/screen.css" type="text/css" media="screen" title="default" />
		<!--  jquery core -->
		<script src="js/jquery/jquery-1.4.1.min.js" type="text/javascript"></script>

		<!-- Custom jquery scripts -->
		<script src="js/jquery/custom_jquery.js" type="text/javascript"></script>

		<!-- MUST BE THE LAST SCRIPT IN <HEAD></HEAD></HEAD> png fix -->
		<script src="js/jquery/jquery.pngFix.pack.js" type="text/javascript"></script>
	</head>
	<body id="login-bg">

		<!-- Start: login-holder -->
		<div id="login-holder">

			<!-- start logo -->
			<div id="logo-login">

			</div>
			<!-- end logo -->

			<div class="clear"></div>

			<!--  start loginbox ................................................................................. -->
			<div id="loginbox">

				<!--  start login-inner -->
				<div id="login-inner">
					<table border="0" cellpadding="0" cellspacing="0">
						<tr>
							<th>Username</th>
							<td><input type="text"  class="login-inp" id="userLogin" /></td>
						</tr>
						<tr>
							<th>Password</th>
							<td><input type="password" value="************"  onfocus="this.value=''" class="login-inp" id="passLogin"/></td>
						</tr>
						<tr>
							<th></th>
							<td valign="top"><input type="checkbox" class="checkbox-size" id="login-check" /><label for="login-check">Remember me</label></td>
						</tr>
						<tr>
							<th></th>
							<td><input type="button" class="submit-login" id="loginButton" /></td>
						</tr>
					</table>
				</div>
				<!--  end login-inner -->
				<div class="clear"></div>
			</div>
			<!--  end loginbox -->

			<!--  start forgotbox ................................................................................... -->
			<div id="forgotbox">
				<div id="forgotbox-text">Please send us your email and we'll reset your password.</div>
				<!--  start forgot-inner -->
				<div id="forgot-inner">
					<table border="0" cellpadding="0" cellspacing="0">
						<tr>
							<th>Email address:</th>
							<td><input type="text" value="" class="login-inp" /></td>
						</tr>
						<tr>
							<th> </th>
							<td><input type="button" class="submit-login"  /></td>
						</tr>
					</table>
				</div>
				<!--  end forgot-inner -->
				<div class="clear"></div>
				<a href="" class="back-login">Back to login</a>
			</div>
			<!--  end forgotbox -->

		</div>
		<!-- End: login-holder -->
		<script type="text/javascript">
			$(document).pngFix( );
			// Login clicked
			$('#loginButton').click(function() {
				var user = $('#userLogin').val();
				var pass = $('#passLogin').val();
				if (user != null && pass != null)
					$.post("index.jsp", {type:"login", user:user, pass:pass} );
			});
		</script>
	</body>
</html>