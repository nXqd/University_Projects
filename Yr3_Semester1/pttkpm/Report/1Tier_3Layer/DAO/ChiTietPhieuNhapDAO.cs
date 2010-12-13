using System;
using System.Data.SQLite;
using DTO;

namespace DAO
{
    public class ChiTietPhieuNhapDAO:Database
    {
        // Insert ChiTietPhieuNhap
        public static int InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPN) {
            var sqlParas = new[] {
                                     new SQLiteParameter("@MaPhieu", chiTietPN.MaPhieuNhap),
                                     new SQLiteParameter("@MaSach", chiTietPN.MaSach),
                                     new SQLiteParameter("@SL", chiTietPN.LuongNhap)
                                 };
            string q = @"insert into CHITIETPHIEUNHAP (MaPhieuNhap,MaSach,SoLuong) values (@MaPhieu,@MaSach,@SL); 
                         SELECT last_insert_rowid() AS MaChiTietPhieuNhap;";
            return Convert.ToInt32(SqliteExecuteScalar(q, sqlParas));
        }
    }
}
