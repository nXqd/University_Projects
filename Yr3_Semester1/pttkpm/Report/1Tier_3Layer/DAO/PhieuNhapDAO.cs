using System;
using System.Data.SQLite;

namespace DAO
{
    public class PhieuNhapDAO: Database
    {
        // Insert Phieu Nhap
        public static int InsertPhieuNhap(DateTime ngayNhap) {
            var sqlParas = new[] {
                                     new SQLiteParameter("$NgayNhap", ngayNhap.Date)
                                 };
            var q = @"insert into PHIEUNHAP (NgayNhap) values ($NgayNhap);SELECT last_insert_rowid() AS MaPhieuNhap";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Check if there's already a PhieuNhap
        public static int HasPhieuNhap(DateTime ngayNhap) {
            var sqlParas = new[] {
                                     new SQLiteParameter("$NgayNhap", ngayNhap.Date)
                                 };
            var q = @"select * from PhieuNhap where NgayNhap=$NgayNhap";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Get luongNhap of a Book in a Month
        public static int GetLuongNhapOfBookByMonth(int sachID,string date) {
            var sqlParas = new[] {
                                   new SQLiteParameter("@date", date),
                                   new SQLiteParameter("@sachID", sachID)
                               };
            var q =
                @"SELECT SUM(ctpn.SoLuong)
                    FROM PHIEUNHAP pn INNER JOIN CHITIETPHIEUNHAP ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap
                    GROUP BY ctpn.MaSach,DATE(pn.NgayNhap,'start of month')
                    HAVING DATE(pn.NgayNhap,'start of month') = @date AND ctpn.MaSach = @sachID";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Get sum(luongban) of a book before a month
        public static int GetLuongBanOfBookBeforeMonth(int sachID, string date) {
            var sqlParas = new[] {
                                   new SQLiteParameter("@date", date),
                                   new SQLiteParameter("@sachID", sachID)
                               };
            var q =
                @"SELECT SUM(ctpn.SoLuong)
                    FROM PHIEUNHAP pn INNER JOIN CHITIETPHIEUNHAP ctpn ON pn.MaPhieuNhap = ctpn.MaPhieuNhap
                    GROUP BY ctpn.MaSach,DATE(pn.NgayNhap,'start of month')
                    HAVING DATE(pn.NgayNhap,'start of month') < @date AND ctpn.MaSach = @sachID";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
    }
}
