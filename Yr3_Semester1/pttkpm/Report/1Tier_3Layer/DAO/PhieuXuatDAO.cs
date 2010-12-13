using System;
using System.Data.SQLite;
using DTO;

namespace DAO
{
    public class PhieuXuatDAO:Database
    {
        public static void UpdateThanhTien(int phieuXuatID,decimal tien) {
            var sqlParas = new[]    {
                                                        new SQLiteParameter("@phieuID",phieuXuatID),  
                                                        new SQLiteParameter("@tien",tien)
                                    };
            SqliteExecuteNonQuery(@"UPDATE PHIEUBAN SET ThanhTien=@tien WHERE MaPhieuBan=@phieuID", sqlParas);
        }
        public static int Insert(PhieuXuatDTO phieuXuat) {
            var sqlParas = new[]    {
                                                        new SQLiteParameter("@MaKH",phieuXuat.MaKH),  
                                                        new SQLiteParameter("@time",phieuXuat.NgayXuat.Date)
                                    };
            return Convert.ToInt32(SqliteExecuteScalar(@"insert into PHIEUBAN(MaKH,NgayLapHD) values(@MaKH,@time);SELECT last_insert_rowid() AS MaPhieuBan;", sqlParas));
        }
        // Check if a phieuXuat is available
        public static int CheckPhieuXuat(int maKH,DateTime time) {
            var sqlParas = new[]                    {
                                                        new SQLiteParameter("@MaKH",maKH),  
                                                        new SQLiteParameter("@time",time)
                                                    };
            return Convert.ToInt32(SqliteExecuteScalar(@"select * from PHIEUBAN where MaKH=@MaKH and NgayLapHD=@time",sqlParas));
        }
        // Get SUM(SoLuong) of a book in a month
        public static int GetLuongBanOfBookByMonth(int sachID,string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@sachID", sachID),
                                     new SQLiteParameter("@date", date)
                                 };
            string q =  @"SELECT SUM(ctb.SoLuongBan)
                        FROM PHIEUBAN pb INNER JOIN CHITIETBAN ctb ON pb.MaPhieuBan = ctb.MaPhieuBan
                        GROUP BY ctb.MaSach
                        HAVING DATE(pb.NgayLapHD,'start of month') = @date AND ctb.MaSach = @sachID";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Get SUM(SoLuong) of a book before a month
        public static int GetLuongBanOfBookBeforeMonth(int sachID, string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@sachID", sachID),
                                     new SQLiteParameter("@date", date)
                                 };
            string q = @"SELECT SUM(ctb.SoLuongBan)
                        FROM PHIEUBAN pb INNER JOIN CHITIETBAN ctb ON pb.MaPhieuBan = ctb.MaPhieuBan
                        GROUP BY ctb.MaSach
                        HAVING DATE(pb.NgayLapHD,'start of month') < @date AND ctb.MaSach = @sachID";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Get SUM(No) of a KH in a month
        public static decimal GetNoKHByMonth(int khachID, string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@khachID", khachID),
                                     new SQLiteParameter("@date", date)
                                 };
            var q =     @"SELECT SUM(pb.ThanhTien)
                        FROM PHIEUBAN pb
                        GROUP BY pb.MaKH
                        HAVING DATE(pb.NgayLapHD,'start of month') = @date AND pb.MaKH = @khachID";
            return Convert.ToDecimal(SqliteExecuteScalar(q, sqlParas));
        }
        // Get Sum(no) of a KH before a month
        public static decimal GetNoKHBeforeMonth(int khachID, string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@khachID", khachID),
                                     new SQLiteParameter("@date", date)
                                 };
            var q =     @"SELECT SUM(pb.ThanhTien)
                        FROM PHIEUBAN pb
                        GROUP BY pb.MaKH
                        HAVING DATE(pb.NgayLapHD,'start of month') < @date AND pb.MaKH = @khachID";
            return Convert.ToDecimal(SqliteExecuteScalar(q, sqlParas));
        }
    }
}
