using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class HoaDonBanSach : Form {
        public HoaDonBanSach() {
            InitializeComponent();
        }

        private void Label2Click(object sender, EventArgs e) {
        }

        private void DateTimePicker1ValueChanged(object sender, EventArgs e) {
        }

        private void Button1Click(object sender, EventArgs e) {
            var tenKH = cbHoTen.Text;
            var msg = "";
            var phieuXuatID = 0;
            var khachHangID = KhachHangBUS.GetKhachHangID(tenKH);
            if (khachHangID != 0) {
                if (ThamSoBUS.CheckNoLN(tenKH)) {
                    int rowCount = PhieuNhapGrid.Rows.Count;
                    bool hasPhieuXuat = false;
                    decimal sum = 0; // Tổng tiền mua của khách hàng, để cập nhật vào nợ
                    for (int i = 0; i < rowCount-1; ++i) {
                        var sachNhap = new SachNhapDTO();
                        DataGridViewCellCollection cell = PhieuNhapGrid.Rows[i].Cells;
                        var data = true; // Kiểm tra coi dữ liệu một row đã được nhập đủ chưa
                        if (cell[1].Value == null || cell[2].Value == null || cell[5].Value == null) {
                            msg += @"Bạn phải nhập Tên sách, Số lượng và Đơn giá " + (i+1) + "\n";
                            data = false;
                        }
                        if (data) {
                            sachNhap.STT = cell[0].Value != null ? Int32.Parse(cell[0].Value.ToString()) : 0;
                            sachNhap.TenSach = cell[1].Value.ToString(); 
                            sachNhap.DonGia = decimal.Parse(cell[2].Value.ToString());
                            sachNhap.TheLoai = cell[3].Value != null ? cell[2].Value.ToString() : "";
                            sachNhap.TacGia = cell[4].Value != null ? cell[4].Value.ToString() : "";
                            sachNhap.SoLuong = Int32.Parse(cell[5].Value.ToString()); 

                            // Kiểm tra lượng sách tồn sau khi nhập có đúng như quy định không)
                            int sachID = DauSachBUS.CheckBook(sachNhap.TenSach);
                            if (sachID == 0)
                                msg += "Sách " + sachNhap.TenSach + " không tồn tại trong kho hàng \n";
                            else 
                                if (ThamSoBUS.CheckLTNN(sachNhap.TenSach, sachNhap.SoLuong)) {

                                var phieuXuat = new PhieuXuatDTO {
                                                                     NgayXuat = ngayLap.Value.Date,
                                                                     MaKH = khachHangID,
                                                                 };

                                // We use another hasPhieuNhap bool to make sure
                                // we only check phieuNhap in database one time
                                phieuXuatID = PhieuXuatBUS.CheckPhieuXuat(khachHangID, ngayLap.Value.Date);
                                if (!hasPhieuXuat)
                                    if (phieuXuatID != 0)
                                        hasPhieuXuat = true;
                                    else {
                                        phieuXuatID = PhieuXuatBUS.Insert(phieuXuat);
                                    }

                                // Lập phiếu chi tiết nhập sách
                                var chiTietPhieuXuat = new ChiTietPhieuXuatDTO
                                {
                                    DonGia = sachNhap.DonGia,
                                    MaSach = sachID,
                                    SoLuong = sachNhap.SoLuong,
                                    MaPhieuXuat = phieuXuatID
                                };

                                ChiTietPhieuXuatBUS.Insert(chiTietPhieuXuat);
                                // + tiền
                                sum += sachNhap.DonGia * sachNhap.SoLuong;
                                // Update lại lượng tồn
                                int luongTon = DauSachBUS.GetLuongTon(sachNhap.TenSach);
                                DauSachBUS.UpdateLuongTon(sachNhap.TenSach, luongTon - sachNhap.SoLuong);
                                msg += @"Thành công!";
                            } else {
                            msg += @"Bạn mua quá nhiều sách "+ sachNhap.TenSach + @" , hãy giảm lại!";
                        } 
                        }
                    }
                    // Cập nhật nợ + cập nhật thành tiền
                    KhachHangBUS.UpdateNo(khachHangID, sum);
                    PhieuXuatBUS.UpdateThanhTien(phieuXuatID,sum);
                } else msg += @"Khách hàng này nợ quá nhiều !";
            }
            else msg += @"Khách hàng này không tồn tại";
            MessageBox.Show(msg, @"Thông báo!", MessageBoxButtons.OK);
        }

        private void Button3Click(object sender, EventArgs e) {
            PhieuNhapGrid.Rows.Clear();
        }

        private void Button2Click(object sender, EventArgs e) {
            Close();
        }

        private void GroupBox1Enter(object sender, EventArgs e)
        {

        }

        private void HoaDonBanSach_Load(object sender, EventArgs e) {
            //Add customers name to ComboBox
            List<KhachHangOutDTO> khachHangs = KhachHangBUS.GetAllKH();
            foreach (KhachHangOutDTO khachHangOutDTO in khachHangs) {
                cbHoTen.Items.Add(khachHangOutDTO.TenKH);
            }
        }
    }
}