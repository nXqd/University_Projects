using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class BaoCaoCongNo : Form {
        public BaoCaoCongNo() {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e) {
            try {
                // Clear all for new report
                grid.Rows.Clear();

                string sThang = txtThang.Text;
                string[] tmp = sThang.Split('/');
                int check = int.Parse(tmp[0]);
                if (check < 13 || check > 0) {
                    if (check < 10 && tmp[0].Count() < 2)
                        tmp[0] = "0" + tmp[0]; // month = "5" to "05"
                    sThang = tmp[1] + "-" + tmp[0] + "-" + "01"; // Get format YYYY-MM-DD

                    List<KhachHangOutDTO> khachs = KhachHangBUS.GetAllKH();
                    for (int i = 0; i < khachs.Count; i++) {
                        string khachName = khachs[i].TenKH;
                        decimal noDau;
                        decimal phatSinh;
                        decimal noCuoi;
                        // tinh phat Sinh trong thang
                        decimal mua = PhieuXuatBUS.GetNoKHByMonth(khachs[i].MaKH, sThang);
                        decimal tra = PhieuThuTienBUS.GetTienTraOfKHInMonth(khachs[i].MaKH, sThang);
                        phatSinh = mua - tra;

                        // noDau = phatSinh cac thang truoc
                        mua = PhieuXuatBUS.GetNoKHBeforeMonth(khachs[i].MaKH, sThang);
                        tra = PhieuThuTienBUS.GetTienTraOfKHBeforeMonth(khachs[i].MaKH, sThang);
                        noDau = mua - tra;

                        noCuoi = noDau + phatSinh;
                        // Insert to grid
                        var row = new[] {khachName, noDau.ToString(), phatSinh.ToString(), noCuoi.ToString()};
                        grid.Rows.Add(row);
                    }
                }
            }
            catch {
            }
        }

        private void Button2Click(object sender, EventArgs e) {
            Close();
        }
    }
}