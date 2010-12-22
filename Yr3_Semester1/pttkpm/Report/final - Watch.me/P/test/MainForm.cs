using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Utils;
using test.BUS_WS;
using System.Threading;

namespace test
{
    public partial class MainForm : Form
    {
        private Service1SoapClient _ws = new Service1SoapClient();
        private List<string> Users { get; set; }
        private MemberDTO mDTO { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // hide label
            xtMain.ShowTabHeader = DefaultBoolean.False;
            // disblae Logout button by default
            //bLogout.Enabled = false;
        }

        private void xtWelcome_Paint(object sender, PaintEventArgs e)
        {
            Users = _ws.GetMembers();
        }

        private void nav_Click(object sender, EventArgs e)
        {
        }

        private void navUserMedia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtMain.SelectedTabPage = xtMovies;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            xtMain.SelectedTabPage = xtWelcome;
            nav.Enabled = false;
        }

        private void xtraTabControl1_Paint(object sender, PaintEventArgs e)
        {
            // get list of users to check
            

        }

        #region Login-SignUp
        public static bool IsValidEmail(string inputEmail)
        {
            const string reg = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(reg);
            return re.IsMatch(inputEmail);
        }
        // Email check
        private void TextEdit6EditValueChanged(object sender, EventArgs e) {
            if (!IsValidEmail(textEdit6.Text)) {
                lc10.ForeColor = Color.Red;
                lc10.Text = "This email is not valid!";
            } else {
                lc10.Text = "It is valid!";
                lc10.ForeColor = Color.Green;
            }
        }
        // username check
        private void TextEdit4EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit4.Text.Count() >= 6)
            {
                if (Users.Contains(textEdit4.Text))
                {
                    labelControl9.Text = "This username is not available !";
                    labelControl9.ForeColor = Color.Red;
                } else {
                    labelControl9.Text = "This username is available !";
                    labelControl9.ForeColor = Color.Green;
                }
            } else {
                labelControl9.Text = "At least 6 characters !";
                labelControl9.ForeColor = Color.Red;
            }
        }
        // password
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit3.Text.Count() < 6) {
                labelControl7.Text = "At least 6 characters";
                labelControl7.ForeColor = Color.Red;
            } else {
                labelControl7.Text = "It is valid!";
                labelControl7.ForeColor = Color.Green;
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e) {
            mDTO = _ws.Login(tUser.Text, tPass.Text);
            if (mDTO != null)
            {
                lFail.Visible = false;
                // enable logout
                bLogout.Enabled = true;
                //TODO: switch screen
                
            } else {
                lFail.Visible = true;
            }

        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lc10.ForeColor == Color.Green && labelControl9.ForeColor == Color.Green && labelControl7.ForeColor == Color.Green) {
                bRegister.Text = "You're ready!";
                Thread.Sleep(50);
                xtWelcomeInside.SelectedTabPage = xtWelcomeLogin;
            }
        }

    }
}
