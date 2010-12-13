using System;
using System.Data.SQLite;
using DTO;

namespace DAO
{
    public class SachDAO : Database
    {
        // Them dau sach moi
        public static int InsertBook(DauSachDTO sach)
        {
            var sqlParas = new[] {
                                     new SQLiteParameter("@TenSach", sach.TenSach),
                                     new SQLiteParameter("@TheLoai", sach.TheLoai),
                                     new SQLiteParameter("@TacGia", sach.TacGia),
                                     new SQLiteParameter("@LuongTon", sach.LuongTon),
                                 };
            string q =
                @"insert into DAUSACH (TenSach,TheLoai,TacGia,LuongTon) values(@TenSach,@TheLoai,@TacGia,@LuongTon);SELECT last_insert_rowid() AS MaSach;";
            return Convert.ToInt32(SqliteExecuteScalar(q,sqlParas));
        }

        // Kiem tra mot dau sach co ton tai trong database hay khong
        public static int BooksHave(string tenSach)
        {
            var sqlParas = new[] {
                                     new SQLiteParameter("@TenSach", tenSach)
                                 };
            return Convert.ToInt32(SqliteExecuteScalar(@"select * from DAUSACH where TenSach=@TenSach", sqlParas));
        }

        // Lấy lượng tồn của một cuốn sách thông qua tên sách
        public static int GetLuongTon(string tenSach)
        {
            var sqliteParas = new[] {
                                        new SQLiteParameter("@TenSach", tenSach),
                                    };
            return Convert.ToInt32(SqliteExecuteScalar(@"select LuongTon from DAUSACH where TenSach=@TenSach", sqliteParas));
        }

        // Cap nhat luong ton = luong ton cu + sach nhap vao
        public static void UpdateLuongTon(string tenSach, int luongTon)
        {
            var sqliteParas = new[] {
                                       new SQLiteParameter("@TenSach", tenSach),
                                       new SQLiteParameter("@LuongTon", luongTon)
                                    };
            SqliteExecuteScalar(@"update DAUSACH set LuongTon=@LuongTon where TenSach=@TenSach", sqliteParas);
        }
        // Trả về một đối tượng sqlDataReader để thao tác với Form
        public static SQLiteDataReader GetAllBooks() {
            return SqliteDataReader(@"SELECT MaSach,TenSach,LuongTon FROM DAUSACH",null);
        }

    }

}
