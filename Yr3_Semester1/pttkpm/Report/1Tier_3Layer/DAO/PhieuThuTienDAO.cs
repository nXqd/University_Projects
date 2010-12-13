using System;
using System.Data.SQLite;

using DTO;

namespace DAO
{
    public class PhieuThuTienDAO:Database
    {
        public static int Insert(PhieuThuTienDTO phieuThu) {
            var q = @"insert into PHIEUTHUTIEN (MaKH,NgayThuTien,SoTienThu) values ($Ma,@Ngay,@Tien);SELECT last_insert_rowid() AS MaPhieuThu";
            var sqlParas = new[] {
                                     new SQLiteParameter("@Ma", phieuThu.MaKH),
                                     new SQLiteParameter("@Ngay", phieuThu.Ngay),
                                     new SQLiteParameter("@Tien", phieuThu.TienThu)
                                 };
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
        // Get all Tien Thu of a KH in a month
        public static decimal GetTienTraOfKHInMonth(int maKH,string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@khachID", maKH),
                                     new SQLiteParameter("@date", date)
                                 };
            var q = @"SELECT ptt.MaKH,SUM(ptt.SoTienThu)
                        FROM PHIEUTHUTIEN ptt
                        GROUP BY ptt.MaKH
                        HAVING DATE(ptt.NgayThuTien,'start of month') = @date AND ptt.MaKH = @khachID";
            return Convert.ToDecimal(SqliteExecuteScalar(q, sqlParas));
        }
        // Get all Tien Thu of a KH in a month
        public static decimal GetTienTraOfKHBeforeMonth(int maKH, string date) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@khachID", maKH),
                                     new SQLiteParameter("@date", date)
                                 };
            var q = @"SELECT ptt.MaKH,SUM(ptt.SoTienThu)
                        FROM PHIEUTHUTIEN ptt
                        GROUP BY ptt.MaKH
                        HAVING DATE(ptt.NgayThuTien,'start of month') < @date AND ptt.MaKH = @khachID";
            return Convert.ToDecimal(SqliteExecuteScalar(q, sqlParas));
        }

    }
}
