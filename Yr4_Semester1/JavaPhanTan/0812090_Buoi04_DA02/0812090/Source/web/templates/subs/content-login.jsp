<div id="content_sec">
	<!-- Column 3 -->
	<div class="col3">
		<div class="login">
			<h3 class="heading colr">Login</h3>
			<div class="signin">
				<h5 class="colr">Please Sign In</h5>
				<p>If you have an account with us, please log in.</p>
				<ul>
					<li class="txt bold">Username *</li>
					<li class="field"><input name="username" type="text" id="userLogin"/></li>
				</ul>
				<ul>
					<li class="txt bold">Password *</li>
					<li class="field"><input name="username" type="password" id="passLogin"/></li>
				</ul>
				<ul>
				</ul>
				<ul>
					<li class="txt bold">&nbsp;</li>
					<li class="field"><p class="right">* Required Fields</p></li>
				</ul>
				<ul>
					<li class="txt bold">&nbsp;</li>
					<li class="field">
						<a href="login.jsp" class="buttonone right" id="loginButton">Login</a>
						<a href="#" class="forget under">Forgot Your Password?</a>
					</li>
				</ul>
			</div>
			<div class="newcus signin">
				<h5 class="colr">New Customer</h5>
				<p>If you have an account with us, please log in.</p>
				<ul>
					<li class="txt bold">Username *</li>
					<li class="field"><input name="user" type="text" id="userRegister" /></li>
				</ul>
				<ul>
					<li class="txt bold">Password *</li>
					<li class="field"><input name="pass" type="password" id="passRegister" /></li>
				</ul>
				<ul>
					<li class="txt bold">Fullname</li>
					<li class="field"><input name="fullname" type="text" id="fullnameRegister" /></li>
				</ul>
				<ul>
					<li class="txt bold">Email</li>
					<li class="field"><input name="email" type="text" id="emailRegister" /></li>
				</ul>
				<ul>
					<li class="txt bold">Phone</li>
					<li class="field"><input name="phone" type="text" id="phoneRegister" /></li>
				</ul>
				<ul>
					<li class="txt bold">&nbsp;</li>
					<li class="field"><a href="#" class="buttonone right" id="RegisterButton">Create User</a> </li>
				</ul>
			</div>
		</div>
	</div>
	<div id="recaptcha">
		${recaptchaHTML}
	</div>
</div>