using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class PhieuNhapSach : Form {
        public PhieuNhapSach() {
            InitializeComponent();
            PhieuNhapGrid.Rows.Clear(); // Clear all first
        }

        // Neu click bo thi don gian dong form
        private void BtnBoClick(object sender, EventArgs e) {
            Close();
        }

        private void BtnThemClick(object sender, EventArgs e) {
            try {
                // Variables
                int rowCount = PhieuNhapGrid.Rows.Count;
                bool hasPhieuNhap = false; // Đảm bảo Phiếu Nhập Sách chỉ được tạo một lần
                string msg = ""; // Biến toàn cục string để thông báo tổng hợp các trường hợp nhập vào không hợp lệ


                for (int i = 0; i < rowCount-1; ++i) {
                    // 1.  Kiểm tra có dữ liệu nhập vào hay không 
                    var sachNhap = new SachNhapDTO();
                    DataGridViewCellCollection cell = PhieuNhapGrid.Rows[i].Cells;
                    bool data = true; // Kiểm tra coi dữ liệu một row đã được nhập đủ chưa
                    if (cell[1].Value == null || cell[4].Value == null) {
                        msg += @"Bạn đã chưa nhập Tên Sách hoặc Số lượng ở dòng " + (i+1) + "\n";
                        data = false;
                        }
                    if (data) {
                        sachNhap.STT = cell[0].Value != null ? Int32.Parse(cell[0].Value.ToString()) : 0;
                        sachNhap.TenSach = cell[1].Value.ToString(); // Ten sach
                        sachNhap.TacGia = cell[3].Value != null ? cell[3].Value.ToString() : "";
                        sachNhap.TheLoai = cell[2].Value != null ? cell[2].Value.ToString() : "";
                        sachNhap.SoLuong = Int32.Parse(cell[4].Value.ToString()); // SoLuong Nhap

                        // 2.Kiểm tra số lượng sách nhập có thoả quy định không
                        if (ThamSoBUS.CheckSoLuongNhapNN(sachNhap.SoLuong)) {
                            var phieuNhap = new PhieuNhapDTO {NgayNhap = dtNgayNhap.Value};

                            // We use another hasPhieuNhap bool to make sure
                            // we only check phieuNhap in database one time
                            int phieuNhapID = PhieuNhapBUS.HasPhieuNhap(phieuNhap.NgayNhap);
                            if (!hasPhieuNhap)
                                if (phieuNhapID != 0)
                                    hasPhieuNhap = true;
                                else {
                                    phieuNhapID = PhieuNhapBUS.Insert(phieuNhap.NgayNhap);
                                }
                            // 3.Kiểm tra coi sách có tồn tại trong CSDL không
                            int maSach = DauSachBUS.CheckBook(sachNhap.TenSach);
                            if (maSach != 0) {
                                //Sách tồn tại > kiểm tra lượng tồn và update
                                int luongTon = DauSachBUS.CheckLuongTonLN(sachNhap.TenSach);
                                if (luongTon != -1) {
                                    DauSachBUS.UpdateLuongTon(sachNhap.TenSach, luongTon + sachNhap.SoLuong);
                                }
                                var chiTietPN = new ChiTietPhieuNhapDTO {
                                                                            MaPhieuNhap = phieuNhapID,
                                                                            MaSach = maSach,
                                                                            LuongNhap = sachNhap.SoLuong
                                                                        };
                                ChiTietPhieuNhapBUS.Insert(chiTietPN);
                                msg += @"Thành công!";
                            }
                                // 3. Nếu sách không tồn tại thì ta insert một sách mới 
                            else {
                                var sachDTO = new DauSachDTO();
                                sachDTO.TacGia = sachNhap.TacGia;
                                sachDTO.TenSach = sachNhap.TenSach;
                                sachDTO.TheLoai = sachNhap.TheLoai;
                                sachDTO.LuongTon = sachNhap.SoLuong;

                                int sachID = DauSachBUS.InsertBook(sachDTO);
                                var chiTietPN = new ChiTietPhieuNhapDTO {
                                                                            MaPhieuNhap = phieuNhapID,
                                                                            MaSach = sachID,
                                                                            LuongNhap = sachNhap.SoLuong
                                                                        };
                                ChiTietPhieuNhapBUS.Insert(chiTietPN);
                                msg += @"Thành công!";
                            }
                        } else {
                            msg += @"Bạn đã nhập dưới số lượng tối thiểu cho cuốn sách" + sachNhap.TenSach + "\n";
                        }
                        
                    }
                }
                MessageBox.Show(msg, @"Thông báo", MessageBoxButtons.OK);
            }
            catch {
            }
        }

        private void PhieuNhapGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }
    }
}