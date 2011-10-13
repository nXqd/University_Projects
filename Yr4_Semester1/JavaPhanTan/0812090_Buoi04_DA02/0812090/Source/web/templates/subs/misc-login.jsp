<script>
	// Login clicked
	$('#loginButton').click(function() {
		var user = $('#userLogin').val();
		var pass = $('#passLogin').val();
		var captchaChal = $('#recaptcha_challenge_field').val();
		var captchaRes = $('#recaptcha_response_field').val();
		if (user != null && pass != null && captchaRes != null)
		$.post("login.jsp", { type: "login", user: user, pass: pass, recaptcha_challenge_field: captchaChal, recaptcha_response_field : captchaRes } );
	});
	// Logout clicked
	$('#logoutButton').click(function() {
		$.post("index.jsp", {action:'logout'} );
	});

	// Register clicked
	$('#RegisterButton').click(function() {
		var user = $('#userRegister').val();
		var pass = $('#passRegister').val();
		var fullname = $('#fullnameRegister').val();
		var email = $('#emailRegister').val();
		var phone = $('#phoneRegister').val();
		var captchaChal = $('#recaptcha_challenge_field').val();
		var captchaRes = $('#recaptcha_response_field').val();
		if (user != null && pass != null && captchaRes != null)
		$.post("login.jsp", { type: "register", user: user, pass: pass, fullname: fullname, email: email, phone: phone,recaptcha_challenge_field: captchaChal, recaptcha_response_field : captchaRes  } );
	});
</script>