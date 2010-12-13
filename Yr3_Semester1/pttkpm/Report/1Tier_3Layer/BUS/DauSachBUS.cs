using System.Collections.Generic;
using System.Data.SQLite;
using DTO;
using DAO;

namespace BUS
{
    public class DauSachBUS
    {
        // Insert book, return bookID
        public static int InsertBook(DauSachDTO sach) {
            int result = SachDAO.InsertBook(sach);
            return result;
        }

        // Kiem tra 1 cuon sach co ton tai trong db khong
        public static int CheckBook(string tenSach) {
            return SachDAO.BooksHave(tenSach);
        }
        // Trả về số lượng tồn của cuốn sách nếu 
        // lượng tồn của cuốn sách nhập vào là nhỏ hơn lượng tồn lớn nhất trong tham số
        // * Làm như thế này có thể lấy được lượng tồn để cập nhật lượng tồn mới
        public static int CheckLuongTonLN(string tenSach) {
            if (SachDAO.GetLuongTon(tenSach) < ThamSoDAO.SoLuongTonNN()) {
                return SachDAO.GetLuongTon(tenSach);
            }
            return -1;
        }
        // Cập nhật lượng tồn cho một cuốn sách
        public static void UpdateLuongTon(string tenSach, int luongTon) {
            SachDAO.UpdateLuongTon(tenSach,luongTon);
        }
        public static int GetLuongTon(string tenSach) {
            return SachDAO.GetLuongTon(tenSach);
        }
        // Trả về một mảng sáchID với tên tương ứng
        public static List<SachOutDTO> GetAllBooks() {
            var data = SachDAO.GetAllBooks();
            var result = new List<SachOutDTO>();
            while (data.Read()) {
                var sachOutDTO = new SachOutDTO() {MaSach = int.Parse(data[0].ToString()), TenSach = data[1].ToString(), LuongTon = int.Parse(data[2].ToString())};
                result.Add(sachOutDTO);
            }
            return result;
        }

    }
}
