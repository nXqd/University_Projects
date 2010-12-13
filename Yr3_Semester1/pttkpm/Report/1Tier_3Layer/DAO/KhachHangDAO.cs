using System;
using System.Data.Common;
using System.Data.SQLite;


namespace DAO
{
    public class KhachHangDAO : Database
    {
        // Lấy nợ từ tên Khách Hàng 
        public static decimal GetNo(string tenKH)
        {
            var sqlParas = new[] {
                                     new SQLiteParameter("@tenKH", tenKH)
                                 };
            var obj = SqliteExecuteScalar(@"select NoKH from KHACHHANG where HoTenKH=@tenKH", sqlParas);
            return Convert.ToDecimal(obj);
        }
        // Kiểm tra tên Khách hàng nếu đã có 1 khách hàng
        public static int GetKhachHangID(string tenKH) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@tenKH", tenKH)
                                 };
            var obj = SqliteExecuteScalar(@"select MaKH from KHACHHANG where HoTenKH=@tenKH", sqlParas);
            return Convert.ToInt32(obj);
        }
        // Cập nhật nợ khách hàng theo khách hàng ID
        public static void UpdateNo(int maKH, decimal no) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@MaKH", maKH),
                                     new SQLiteParameter("@No", no)
                                 };
            SqliteExecuteNonQuery(@"UPDATE KHACHHANG SET NoKH=@No WHERE MaKH=@MaKH", sqlParas);
        }
        public static SQLiteDataReader GetAllKH() {
            return SqliteDataReader("Select MaKH,HotenKH,NoKH from KHACHHANG", null);
        }
        // Lấy email - phone - add với tên tương ứng
        public static SQLiteDataReader GetEmailPhoneAddByName(string name) {
            var sqlParas = new[]    {
                                     new SQLiteParameter("@name", name)
                                    };
            return SqliteDataReader("Select DiaChiKH,EmailKH,PhoneKH from KHACHHANG where HoTenKH=@name", sqlParas);
        }
    }
}
