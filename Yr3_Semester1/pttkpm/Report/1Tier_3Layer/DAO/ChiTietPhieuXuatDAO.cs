using System;
using System.Data.SQLite;
using DTO;

namespace DAO
{
    public class ChiTietPhieuXuatDAO : Database
    {
        public static void Insert(ChiTietPhieuXuatDTO phieuXuat) {
            var sqliteParas = new[] {
                                        new SQLiteParameter("@MaPhieu",phieuXuat.MaPhieuXuat),
                                        new SQLiteParameter("@MaSach",phieuXuat.MaSach), 
                                        new SQLiteParameter("@SoLuong",phieuXuat.SoLuong), 
                                        new SQLiteParameter("@Gia",phieuXuat.DonGia) 
                                    };
            SqliteExecuteNonQuery("insert into CHITIETBAN(MaPhieuBan,MaSach,SoLuongBan,DonGia) values (@MaPhieu,@MaSach,@SoLuong,@Gia)", sqliteParas);
        }
    }
}
