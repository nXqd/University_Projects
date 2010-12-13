using System;
using System.Windows.Forms;

namespace QLNS {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e) {
            var nhapSach = new PhieuNhapSach();
            nhapSach.Show();
        }

        private void ThôngTinToolStripMenuItemClick(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void ThoátToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            var banSach = new HoaDonBanSach();
            banSach.Show();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            var hoaDon = new PhieuThuTien();
            hoaDon.Show();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var danhSach = new DanhSachSach();
            danhSach.Show();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            var baoCaoTon = new BaoCaoTon();
            baoCaoTon.Show();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            var baoCaoNo = new BaoCaoCongNo();
            baoCaoNo.Show();
        }

        private void ỦngHộToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ungHo = new UngHo();
            ungHo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var thayDoi = new ThayDoiThamSo();
            thayDoi.Show();
        }
    }
}