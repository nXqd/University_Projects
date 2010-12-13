using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class PhieuThuTien : Form {
        public PhieuThuTien() {
            InitializeComponent();
        }

        private void Label3Click(object sender, EventArgs e) {
        }

        private void Button2Click(object sender, EventArgs e) {
            Close();
        }

        // Khi nhấn nút lập phiếu > mọi thao tác kiểm tra, cập nhật diễn ra ở đây
        private void Button1Click(object sender, EventArgs e) {
            /* Quy định 4
             * GET tiền_nhập
             * READ nợ [ KHACHANG ]
             * IF tiền_nhập > nợ THEN
             *      DISPLAY "Không cho mài trả tiền"
             * ELSE 
             *      nợ -= tiền_nhập
             *      WRITE nợ to KHACHHANG
             *      WRITE hoáđơn to HOADON
             * ENDIF
             */
            decimal tienNhap = 0m;
            int khid;
            try {
                tienNhap = decimal.Parse(tienThu.ToString());
            }
            catch {
                MessageBox.Show(@"Đề nghị nhập số");
            }
            khid = KhachHangBUS.GetKhachHangID(tenKH.ToString());
            if (khid == 0) {
                MessageBox.Show(@"Khách hàng không tồn tại trong danh sách !");
            }
            else {
                decimal noKhach = KhachHangBUS.GetNo(tenKH.ToString());
                if (noKhach < tienNhap) {
                    MessageBox.Show(@"Số tiền quý khách đưa vượt quá số tiền nợ!");
                }
                else {
                    noKhach -= tienNhap;
                    KhachHangBUS.UpdateNo(khid, noKhach);

                    var phieuThu = new PhieuThuTienDTO {
                                                           MaKH = khid,
                                                           Ngay = ngayThu.Value.Date,
                                                           TienThu = tienNhap
                                                       };
                    PhieuThuTienBUS.Insert(phieuThu);
                }
            }
        }

        private void PhieuThuTien_Load(object sender, EventArgs e) {
            //Add customers name to ComboBox
            List<KhachHangOutDTO> khachHangs = KhachHangBUS.GetAllKH();
            foreach (KhachHangOutDTO khachHangOutDTO in khachHangs) {
                tenKH.Items.Add(khachHangOutDTO.TenKH);
            }
        }

        // Autofill email, phone, address
        private void HoTenChanged(object sender, EventArgs e) {
            var informations = KhachHangBUS.GetEmailPhoneAddByName(tenKH.Text); // DiaChi - Email - Phone
            
            if (informations == null) return;

            txtDiaChi.Text = informations[0];
            txtEmail.Text = informations[1];
            txtDienThoai.Text = informations[2];
        }

        private void TextBox4TextChanged(object sender, EventArgs e) {
        }
    }
}