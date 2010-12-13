using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class BaoCaoTon : Form {
        public BaoCaoTon() {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e) {
            try {
                // Clear all first
                grid.Rows.Clear();

                string sThang = txtThang.Text;
                string[] tmp = sThang.Split('/');
                int check = int.Parse(tmp[0]);
                if (check < 13 || check > 0) {
                    if (check < 10 && tmp[0].Count() < 2)
                        tmp[0] = "0" + tmp[0]; // month = "5" to "05"
                    sThang = tmp[1] + "-" + tmp[0] + "-" + "01"; // Get format YYYY-MM-DD

                    List<SachOutDTO> sachs = DauSachBUS.GetAllBooks();
                    for (int i = 0; i < sachs.Count; i++) {
                        string sachName = sachs[i].TenSach;
                        int tonDau;
                        int phatSinh;
                        int tonCuoi = sachs[i].LuongTon;
                        // phatSinh = nhapTrongThang - xuatTrongThang
                        int nhap = PhieuNhapBUS.GetLuongNhapOfBookByMonth(sachs[i].MaSach, sThang);
                        int xuat = PhieuXuatBUS.GetLuongBanOfBookByMonth(sachs[i].MaSach, sThang);
                        phatSinh = nhap - xuat;
                        // tonDau = nhapTruocThang - xuatTruocThang
                        nhap = PhieuNhapBUS.GetLuongBanOfBookBeforeMonth(sachs[i].MaSach, sThang);
                        xuat = PhieuXuatBUS.GetLuongBanOfBookBeforeMonth(sachs[i].MaSach, sThang);
                        tonDau = nhap - xuat;
                        tonCuoi = tonDau + phatSinh;

                        // Insert to Grid
                        var row = new[] {sachName, tonDau.ToString(), phatSinh.ToString(), tonCuoi.ToString()};
                        grid.Rows.Add(row);
                    }
                }
            }
            catch {
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}