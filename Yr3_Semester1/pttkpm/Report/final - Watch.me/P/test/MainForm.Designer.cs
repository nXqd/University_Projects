namespace test
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter = new DevExpress.XtraEditors.SplitterControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.navAdminMembers = new DevExpress.XtraNavBar.NavBarItem();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.xtMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtWelcome = new DevExpress.XtraTab.XtraTabPage();
            this.xtWelcomeInside = new DevExpress.XtraTab.XtraTabControl();
            this.xtWelcomeLogin = new DevExpress.XtraTab.XtraTabPage();
            this.lFail = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bLogin = new DevExpress.XtraEditors.SimpleButton();
            this.tPass = new DevExpress.XtraEditors.TextEdit();
            this.tUser = new DevExpress.XtraEditors.TextEdit();
            this.xtWelcomeSign = new DevExpress.XtraTab.XtraTabPage();
            this.lc10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bRegister = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.xtMovies = new DevExpress.XtraTab.XtraTabPage();
            this.flowLogin = new System.Windows.Forms.FlowLayoutPanel();
            this.bLogout = new DevExpress.XtraEditors.SimpleButton();
            this.navUser = new DevExpress.XtraNavBar.NavBarGroup();
            this.navUserMedia = new DevExpress.XtraNavBar.NavBarItem();
            this.navUserPeople = new DevExpress.XtraNavBar.NavBarItem();
            this.navUserSchedule = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navAdminFilm = new DevExpress.XtraNavBar.NavBarItem();
            this.navAdminPeople = new DevExpress.XtraNavBar.NavBarItem();
            this.nav = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtMain)).BeginInit();
            this.xtMain.SuspendLayout();
            this.xtWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtWelcomeInside)).BeginInit();
            this.xtWelcomeInside.SuspendLayout();
            this.xtWelcomeLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUser.Properties)).BeginInit();
            this.xtWelcomeSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            this.flowLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(175, 0);
            this.splitter.LookAndFeel.SkinName = "Caramel";
            this.splitter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(6, 615);
            this.splitter.TabIndex = 6;
            this.splitter.TabStop = false;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(2, 22);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 591);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // navAdminMembers
            // 
            this.navAdminMembers.Caption = "Members";
            this.navAdminMembers.LargeImage = ((System.Drawing.Image)(resources.GetObject("navAdminMembers.LargeImage")));
            this.navAdminMembers.Name = "navAdminMembers";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.xtMain);
            this.panelMain.Controls.Add(this.splitterControl1);
            this.panelMain.Controls.Add(this.flowLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(175, 0);
            this.panelMain.LookAndFeel.SkinName = "Caramel";
            this.panelMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(610, 615);
            this.panelMain.TabIndex = 5;
            // 
            // xtMain
            // 
            this.xtMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtMain.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtMain.Location = new System.Drawing.Point(7, 22);
            this.xtMain.LookAndFeel.SkinName = "Caramel";
            this.xtMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtMain.Name = "xtMain";
            this.xtMain.SelectedTabPage = this.xtWelcome;
            this.xtMain.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.xtMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtMain.Size = new System.Drawing.Size(601, 591);
            this.xtMain.TabIndex = 5;
            this.xtMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtWelcome,
            this.xtMovies});
            // 
            // xtWelcome
            // 
            this.xtWelcome.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.xtWelcome.Appearance.PageClient.Options.UseBackColor = true;
            this.xtWelcome.Controls.Add(this.xtWelcomeInside);
            this.xtWelcome.Name = "xtWelcome";
            this.xtWelcome.Size = new System.Drawing.Size(594, 562);
            this.xtWelcome.Text = "xtWelcome";
            this.xtWelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.xtWelcome_Paint);
            // 
            // xtWelcomeInside
            // 
            this.xtWelcomeInside.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtWelcomeInside.Location = new System.Drawing.Point(167, 115);
            this.xtWelcomeInside.LookAndFeel.SkinName = "Caramel";
            this.xtWelcomeInside.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtWelcomeInside.Name = "xtWelcomeInside";
            this.xtWelcomeInside.SelectedTabPage = this.xtWelcomeLogin;
            this.xtWelcomeInside.Size = new System.Drawing.Size(300, 300);
            this.xtWelcomeInside.TabIndex = 0;
            this.xtWelcomeInside.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtWelcomeLogin,
            this.xtWelcomeSign});
            this.xtWelcomeInside.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabControl1_Paint);
            // 
            // xtWelcomeLogin
            // 
            this.xtWelcomeLogin.Controls.Add(this.lFail);
            this.xtWelcomeLogin.Controls.Add(this.checkEdit1);
            this.xtWelcomeLogin.Controls.Add(this.labelControl10);
            this.xtWelcomeLogin.Controls.Add(this.labelControl2);
            this.xtWelcomeLogin.Controls.Add(this.labelControl1);
            this.xtWelcomeLogin.Controls.Add(this.bLogin);
            this.xtWelcomeLogin.Controls.Add(this.tPass);
            this.xtWelcomeLogin.Controls.Add(this.tUser);
            this.xtWelcomeLogin.Name = "xtWelcomeLogin";
            this.xtWelcomeLogin.Size = new System.Drawing.Size(271, 293);
            this.xtWelcomeLogin.Text = "Login";
            // 
            // lFail
            // 
            this.lFail.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFail.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lFail.Location = new System.Drawing.Point(31, 192);
            this.lFail.Name = "lFail";
            this.lFail.Size = new System.Drawing.Size(225, 13);
            this.lFail.TabIndex = 7;
            this.lFail.Text = "Username and password are not match";
            this.lFail.Visible = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(238, 167);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(18, 19);
            this.checkEdit1.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(133, 170);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(98, 13);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "Forget password ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(22, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Password:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Username:";
            // 
            // bLogin
            // 
            this.bLogin.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Appearance.Options.UseFont = true;
            this.bLogin.Location = new System.Drawing.Point(120, 220);
            this.bLogin.LookAndFeel.SkinName = "Caramel";
            this.bLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(136, 29);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "GO!";
            this.bLogin.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(22, 136);
            this.tPass.Name = "tPass";
            this.tPass.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPass.Properties.Appearance.Options.UseFont = true;
            this.tPass.Properties.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(234, 25);
            this.tPass.TabIndex = 1;
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(22, 70);
            this.tUser.Name = "tUser";
            this.tUser.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.Properties.Appearance.Options.UseFont = true;
            this.tUser.Size = new System.Drawing.Size(234, 25);
            this.tUser.TabIndex = 0;
            // 
            // xtWelcomeSign
            // 
            this.xtWelcomeSign.Controls.Add(this.lc10);
            this.xtWelcomeSign.Controls.Add(this.labelControl9);
            this.xtWelcomeSign.Controls.Add(this.labelControl8);
            this.xtWelcomeSign.Controls.Add(this.labelControl7);
            this.xtWelcomeSign.Controls.Add(this.bRegister);
            this.xtWelcomeSign.Controls.Add(this.labelControl4);
            this.xtWelcomeSign.Controls.Add(this.textEdit5);
            this.xtWelcomeSign.Controls.Add(this.labelControl6);
            this.xtWelcomeSign.Controls.Add(this.textEdit6);
            this.xtWelcomeSign.Controls.Add(this.labelControl3);
            this.xtWelcomeSign.Controls.Add(this.labelControl5);
            this.xtWelcomeSign.Controls.Add(this.textEdit3);
            this.xtWelcomeSign.Controls.Add(this.textEdit4);
            this.xtWelcomeSign.Name = "xtWelcomeSign";
            this.xtWelcomeSign.Size = new System.Drawing.Size(271, 293);
            this.xtWelcomeSign.Text = "Sign up";
            // 
            // lc10
            // 
            this.lc10.Appearance.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc10.Location = new System.Drawing.Point(96, 158);
            this.lc10.Name = "lc10";
            this.lc10.Size = new System.Drawing.Size(0, 14);
            this.lc10.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(96, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 14);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "At least 6 characters";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(86, 11);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(102, 23);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Always free !";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(96, 209);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 14);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "At least 6 characters";
            // 
            // bRegister
            // 
            this.bRegister.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegister.Appearance.Options.UseFont = true;
            this.bRegister.Location = new System.Drawing.Point(62, 236);
            this.bRegister.LookAndFeel.SkinName = "Caramel";
            this.bRegister.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(167, 42);
            this.bRegister.TabIndex = 15;
            this.bRegister.Text = "GET STARTED !";
            this.bRegister.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.labelControl4.Location = new System.Drawing.Point(22, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 18);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Fullname";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(96, 50);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Size = new System.Drawing.Size(160, 25);
            this.textEdit5.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(22, 134);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Email";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(96, 130);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Size = new System.Drawing.Size(160, 25);
            this.textEdit6.TabIndex = 11;
            this.textEdit6.EditValueChanged += new System.EventHandler(this.TextEdit6EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(22, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Password";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(22, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Username";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(96, 178);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(160, 25);
            this.textEdit3.TabIndex = 6;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(96, 81);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Size = new System.Drawing.Size(160, 25);
            this.textEdit4.TabIndex = 5;
            this.textEdit4.EditValueChanged += new System.EventHandler(this.TextEdit4EditValueChanged);
            // 
            // xtMovies
            // 
            this.xtMovies.Name = "xtMovies";
            this.xtMovies.Size = new System.Drawing.Size(594, 562);
            this.xtMovies.Text = "xtMovies";
            // 
            // flowLogin
            // 
            this.flowLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLogin.Controls.Add(this.bLogout);
            this.flowLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLogin.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLogin.Location = new System.Drawing.Point(2, 2);
            this.flowLogin.Margin = new System.Windows.Forms.Padding(0);
            this.flowLogin.Name = "flowLogin";
            this.flowLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLogin.Size = new System.Drawing.Size(606, 20);
            this.flowLogin.TabIndex = 2;
            // 
            // bLogout
            // 
            this.bLogout.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.Appearance.Options.UseFont = true;
            this.bLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogout.Location = new System.Drawing.Point(527, 3);
            this.bLogout.LookAndFeel.SkinName = "Caramel";
            this.bLogout.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(76, 20);
            this.bLogout.TabIndex = 0;
            this.bLogout.Text = "Logout";
            this.bLogout.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // navUser
            // 
            this.navUser.Caption = "User";
            this.navUser.Expanded = true;
            this.navUser.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navUser.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navUser.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUserMedia),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUserPeople),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUserSchedule),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navUser.Name = "navUser";
            // 
            // navUserMedia
            // 
            this.navUserMedia.Caption = "Movies";
            this.navUserMedia.LargeImage = ((System.Drawing.Image)(resources.GetObject("navUserMedia.LargeImage")));
            this.navUserMedia.Name = "navUserMedia";
            this.navUserMedia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navUserMedia_LinkClicked);
            // 
            // navUserPeople
            // 
            this.navUserPeople.Caption = "People";
            this.navUserPeople.LargeImage = ((System.Drawing.Image)(resources.GetObject("navUserPeople.LargeImage")));
            this.navUserPeople.Name = "navUserPeople";
            // 
            // navUserSchedule
            // 
            this.navUserSchedule.Caption = "Schedule";
            this.navUserSchedule.LargeImage = ((System.Drawing.Image)(resources.GetObject("navUserSchedule.LargeImage")));
            this.navUserSchedule.Name = "navUserSchedule";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "OST";
            this.navBarItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.LargeImage")));
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navAdminFilm
            // 
            this.navAdminFilm.Caption = "Movies";
            this.navAdminFilm.LargeImage = ((System.Drawing.Image)(resources.GetObject("navAdminFilm.LargeImage")));
            this.navAdminFilm.Name = "navAdminFilm";
            // 
            // navAdminPeople
            // 
            this.navAdminPeople.Caption = "People";
            this.navAdminPeople.LargeImage = ((System.Drawing.Image)(resources.GetObject("navAdminPeople.LargeImage")));
            this.navAdminPeople.Name = "navAdminPeople";
            // 
            // nav
            // 
            this.nav.ActiveGroup = this.navUser;
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navUser,
            this.navBarGroup2});
            this.nav.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navUserMedia,
            this.navUserPeople,
            this.navUserSchedule,
            this.navAdminFilm,
            this.navAdminPeople,
            this.navAdminMembers,
            this.navBarItem1});
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.LookAndFeel.SkinName = "Caramel";
            this.nav.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nav.Name = "nav";
            this.nav.OptionsNavPane.ExpandedWidth = 140;
            this.nav.OptionsNavPane.ShowExpandButton = false;
            this.nav.Size = new System.Drawing.Size(175, 615);
            this.nav.TabIndex = 4;
            this.nav.Text = "navBarControl1";
            this.nav.Click += new System.EventHandler(this.nav_Click);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Administrator";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAdminFilm),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAdminPeople),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAdminMembers)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 615);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.nav);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtMain)).EndInit();
            this.xtMain.ResumeLayout(false);
            this.xtWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtWelcomeInside)).EndInit();
            this.xtWelcomeInside.ResumeLayout(false);
            this.xtWelcomeLogin.ResumeLayout(false);
            this.xtWelcomeLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUser.Properties)).EndInit();
            this.xtWelcomeSign.ResumeLayout(false);
            this.xtWelcomeSign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            this.flowLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitterControl splitter;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraNavBar.NavBarItem navAdminMembers;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraNavBar.NavBarGroup navUser;
        private DevExpress.XtraNavBar.NavBarItem navUserMedia;
        private DevExpress.XtraNavBar.NavBarItem navUserPeople;
        private DevExpress.XtraNavBar.NavBarItem navUserSchedule;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navAdminFilm;
        private DevExpress.XtraNavBar.NavBarItem navAdminPeople;
        private DevExpress.XtraNavBar.NavBarControl nav;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraTab.XtraTabControl xtMain;
        private DevExpress.XtraTab.XtraTabPage xtWelcome;
        private System.Windows.Forms.FlowLayoutPanel flowLogin;
        private DevExpress.XtraEditors.SimpleButton bLogout;
        private DevExpress.XtraTab.XtraTabPage xtMovies;
        private DevExpress.XtraTab.XtraTabControl xtWelcomeInside;
        private DevExpress.XtraTab.XtraTabPage xtWelcomeLogin;
        private DevExpress.XtraTab.XtraTabPage xtWelcomeSign;
        private DevExpress.XtraEditors.TextEdit tUser;
        private DevExpress.XtraEditors.TextEdit tPass;
        private DevExpress.XtraEditors.SimpleButton bLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.SimpleButton bRegister;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lc10;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lFail;
    }
}