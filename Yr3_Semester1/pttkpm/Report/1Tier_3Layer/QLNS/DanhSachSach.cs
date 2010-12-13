using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLNS {
    public partial class DanhSachSach : Form {
        // Variables


        public DanhSachSach() {
            InitializeComponent();
        }

        private void DanhSachSach_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'qLNSDataSet.DAUSACH' table. You can move, or remove it, as needed.
            dAUSACHTableAdapter.Fill(qLNSDataSet.DAUSACH);
        }

        private void GroupBox1Enter(object sender, EventArgs e) {
        }

        private void Button1Click(object sender, EventArgs e) {
            Close();
        }

        // Xử lý sự kiện tìm kiếm khi text trong ô tìm kiếm thay đổi
        private void OnTextChange(object sender, EventArgs e) {
            var containText = new Regex(@"\D");
            try {
                dAUSACHBindingSource.Filter = txtSearch.Text;
                txtSearch.BackColor = SystemColors.Window;
            }
            catch (InvalidExpressionException) {
                if (containText.IsMatch(txtSearch.Text)) {
                    dAUSACHBindingSource.Filter =
                        string.Format("TenSach like '*{0}*' or TheLoai like '*{0}*' or TacGia  like '*{0}*'",
                                      EscapeSqlLike(txtSearch.Text));
                }
                else {
                    dAUSACHBindingSource.Filter =
                        string.Format("MaSach ={0} or TenSach like '*{0}*' or TheLoai like '*{0}*' or TacGia  like '*{0}*' or LuongTon ={0}",EscapeSqlLike(txtSearch.Text));
                }
            }
        }

        private static string EscapeSqlLike(string s_) {
            var s = new StringBuilder(s_);
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == '\'') {
                    s.Insert(i++, '\'');
                    continue;
                }
                if (s[i] == '[' || s[i] == '*' || s[i] == '?') {
                    s.Insert(i++, '[');
                    s.Insert(++i, ']');
                }
            }
            return s.ToString();
        }
    }
}