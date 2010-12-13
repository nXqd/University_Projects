using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml;
using System.Xml.XPath;
using QLNV.Business;
using QLNV.DTO;
/* Du lieu dc luu tru dang xml trong phan CSDL
 * xmlThuocTinhRieng
 * nhanVienVanPhong:    
 *      soNgayCong
 *      donGiaNgayCong
 * nhanVienSanXuat
 *      soSanPham
 *      donGiaSanPham
 */
namespace QLNV.Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNhanVienClick(object sender, RoutedEventArgs e)
        {
            // Kiểm tra tính hợp lệ của các giá trị nhập vào
            if (txtMSNV == null || txtDiaChi == null || txtDonGia == null || txtHoTen == null || txtSo == null ||
                txtMSNV.Foreground == Brushes.Red || txtSo.Foreground == Brushes.Red ||
                txtDonGia.Foreground == Brushes.Red || dNgaySinh.Text == "")
            {
            }
            else
            {
                string nhanVienType = cbNhanVien.Text == @"Nhân viên văn phòng" ? "nvvp" : "nvsx";
                var dtoNhanVien = new dtoNhanVien();
                dtoNhanVien.DiaChi = txtDiaChi.Text;
                dtoNhanVien.HoTen = txtHoTen.Text;
                dtoNhanVien.Msnv = int.Parse(txtMSNV.Text);
                dtoNhanVien.NgaySinh = DateTime.Parse(dNgaySinh.Text);
                dtoNhanVien.NgheNghiep = nhanVienType;
                dtoNhanVien.TienLuong = int.Parse(txtSo.Text) * int.Parse(txtDonGia.Text);
                dtoNhanVien.XmlThuocTinhRieng = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>";
                if (nhanVienType == "nvvp")
                {
                    dtoNhanVien.XmlThuocTinhRieng = "<nhanVien>" +
                                                    "\n<soNgayCong>" + txtSo.Text + "</soNgayCong>" +
                                                    "\n<donGiaNgayCong>" + txtDonGia.Text + "</donGiaNgayCong>" +
                                                    "\n</nhanVien>";
                }
                else
                {
                    dtoNhanVien.XmlThuocTinhRieng = "<soSanPham>" + txtSo.Text + "</soSanPham>" +
                                                    "<donSanPham>" + txtDonGia.Text + "</donGiaSanPham>";
                }
                // Add                                   
                if (bNhanVien.Add(dtoNhanVien) == 1)
                {
                    MessageBox.Show("Nhập thành công", "Thành công", MessageBoxButton.OK);
                }
                else if (bNhanVien.Add(dtoNhanVien) == 2)
                {
                    MessageBox.Show("Mã số nhân viên này đã tồn tại!", "Trùng mã số", MessageBoxButton.OK);
                }
            }
        }

        private void ComboBox1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
                            * Thiết lập giá trị của 2 label cuối tương ứng với giá trị trong combobox
                            */
            var selectedItem = (ComboBoxItem)cbNhanVien.SelectedItem;
            if (selectedItem.Content != null)
            {
                if (selectedItem.Content.ToString() == "Nhân viên văn phòng")
                {
                    lSo.Content = "Số ngày công";
                    lDonGia.Content = "Đơn giá mỗi ngày công";
                }
                else
                {
                    lSo.Content = "Số sản phẩm";
                    lDonGia.Content = "Đơn giá mỗi sản phẩm";
                }
            }
        }

        private void IsFocusedTabTimKiem(object sender, RoutedEventArgs e)
        {
            txtTimKiem.Text = "Mã số nhân viên";
        }

        private void MsnvChanged(object sender, TextChangedEventArgs e)
        {
            int result;
            var txtBox = (TextBox)sender;
            txtBox.Foreground = int.TryParse(txtBox.Text, out result) ? Brushes.Green : Brushes.Red;
        }

        private void TxtDonGiaNgayCongTang(object sender, TextChangedEventArgs e)
        {
            float result;
            var txtBox = (TextBox)sender;
            txtBox.Foreground = float.TryParse(txtBox.Text, out result) ? Brushes.Green : Brushes.Red;
        }

        private void MsnvSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // reset giá trị các label
            label2.Content = "";
            label3.Content = "";
            label4.Content = "";
            label5.Content = "";
            label6.Content = "";
            label7.Content = "";

            int result;
            var txtBox = (TextBox)sender;
            txtBox.Foreground = int.TryParse(txtBox.Text, out result) ? Brushes.Green : Brushes.Red;
            if (txtBox.Foreground == Brushes.Green)
            {
                var dtoNhanVienOut = bNhanVien.Search(result);
                if (dtoNhanVienOut != null)
                {
                    // Đổi giá trị khai báo trước + đồng thời lấy 2 giá trị cuối bằng cách đọc xml


                    if (dtoNhanVienOut.XmlThuocTinhRieng != "")
                    {
                        var xmlDoc = new XmlDocument();
                        // Encode the XML string in a UTF-8 byte array
                        byte[] encodedString = Encoding.UTF8.GetBytes(dtoNhanVienOut.XmlThuocTinhRieng);

                        // Put the byte array into a stream and rewind it to the beginning
                        MemoryStream ms = new MemoryStream(encodedString);
                        ms.Flush();
                        ms.Position = 0;
                        xmlDoc.Load(ms);
                        if (!string.IsNullOrEmpty(dtoNhanVienOut.NgheNghiep = "nvvp"))
                        {

                            XmlNodeList xmlNodelist = xmlDoc.SelectNodes(@"/nhanVien/soNgayCong");
                            if (xmlNodelist != null) label5.Content = xmlNodelist[0].InnerText;

                            xmlNodelist = xmlDoc.SelectNodes(@"/nhanVien/donGiaNgayCong");
                            if (xmlNodelist != null) label7.Content = xmlNodelist[0].InnerText;

                            l_TimKiemSo.Content = "Số ngày công";
                            l_TimKiemDonGia.Content = "Đơn giá mỗi ngày công";

                        }
                        else
                        {
                            XmlNodeList xmlNodelist = xmlDoc.SelectNodes(@"/nhanVien/soSanPham");
                            if (xmlNodelist != null) label5.Content = xmlNodelist[0].InnerText;

                            xmlNodelist = xmlDoc.SelectNodes(@"/nhanVien/donGiaSanPham");
                            if (xmlNodelist != null) label7.Content = xmlNodelist[0].InnerText;

                            l_TimKiemSo.Content = "Số sản phẩm";
                            l_TimKiemDonGia.Content = "Đơn giá mỗi sản phẩm";
                        }
                    }
                    // Điền các giá trị vào label tương ứng
                    label2.Content = dtoNhanVienOut.HoTen;
                    label3.Content = dtoNhanVienOut.NgaySinh;
                    label4.Content = dtoNhanVienOut.DiaChi;
                    label6.Content = dtoNhanVienOut.TienLuong;
                }
            }
        }

        private void MouseClickMaSoNhanVienTextBox(object sender, MouseButtonEventArgs e)
        {
            txtTimKiem.Text = "";
        }
/*        private void DropImage(object sender, DragEventArgs e) {
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                listBox1.Items.Add(file);
            }
        }
*/

        private void image1_DragEnter(object sender, DragEventArgs e)
        {
            // check if drag file is an image
            if (!e.Data.GetDataPresent("Image"))
            {
                e.Effects = DragDropEffects.None;
                e.Handled = true;
            }
            else
            {
                e.Effects = DragDropEffects.Move;
            }
        }

    }
}
