using System;
using System.Data.SQLite;
using System.IO;
using QLNV.DTO;
/*
 * Cach du lieu luu trong database
 */
namespace QLNV.Data
{
    public static class dNhanVien
    {
        private static string _connString = "";
        static dNhanVien()
        {
            // Tao db neu chua ton tai
            string dataPath = @"data\db.db3";
            if (!File.Exists(dataPath))
            {
                if (!Directory.Exists(@"data"))
                {
                    Directory.CreateDirectory(@"data");
                }

                // Create database
                SQLiteConnection.CreateFile(@"data\db.db3");
                _connString = @"Data Source=.\data\db.db3";

                var cnn = new SQLiteConnection((_connString));
                cnn.Open();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "CREATE TABLE NhanVien(ID integer primary key , hoTen varchar (20), ngaySinh datetime, diaChi varchar (20) , tienLuong float,ngheNghiep varchar(10), thuocTinhKhac text)";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static bool Add(dtoNhanVien nvsx)
        {
            var cnn = new SQLiteConnection(_connString);
            cnn.Open();
            using (var cmd = cnn.CreateCommand())
            {
                cmd.CommandText = "insert into NhanVien (ID,hoTen,ngaySinh,diaChi,tienLuong,ngheNghiep,thuocTinhKhac) values(@ID,@hoTen,@ngaySinh,@diaChi,@tienLuong,@ngheNghiep,@thuocTinhKhac)";
                //Parameters
                cmd.Parameters.Add(new SQLiteParameter("@ID"));
                cmd.Parameters.Add(new SQLiteParameter("@hoTen"));
                cmd.Parameters.Add(new SQLiteParameter("@ngaySinh"));
                cmd.Parameters.Add(new SQLiteParameter("@diaChi"));
                cmd.Parameters.Add(new SQLiteParameter("@tienLuong"));
                cmd.Parameters.Add(new SQLiteParameter("@ngheNghiep"));
                cmd.Parameters.Add(new SQLiteParameter("@imagePath"));
                cmd.Parameters.Add(new SQLiteParameter("@thuocTinhKhac"));

                cmd.Parameters["@ID"].Value = nvsx.Msnv;
                cmd.Parameters["@hoTen"].Value = nvsx.HoTen;
                cmd.Parameters["@ngaySinh"].Value = nvsx.NgaySinh;
                cmd.Parameters["@diaChi"].Value = nvsx.DiaChi;
                cmd.Parameters["@tienLuong"].Value = nvsx.TienLuong;
                cmd.Parameters["@ngheNghiep"].Value = nvsx.NgheNghiep;
                cmd.Parameters["@imagePath"].Value = nvsx.NgheNghiep;
                cmd.Parameters["@thuocTinhKhac"].Value = nvsx.XmlThuocTinhRieng;
                //Excute
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public static dtoNhanVien Search(int msnv)
        {
            var cnn = new SQLiteConnection(_connString);
            cnn.Open();

            var cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from NhanVien where ID = @ID";
            // Parameters
            cmd.Parameters.Add(new SQLiteParameter("@ID"));
            cmd.Parameters["@ID"].Value = msnv;

            var reader = cmd.ExecuteReader();
            dtoNhanVien dtoNhanVien = null;
            if (reader.Read())
            {
                dtoNhanVien = new dtoNhanVien();
                dtoNhanVien.Msnv = int.Parse(reader[0].ToString());
                dtoNhanVien.HoTen = reader[1].ToString();
                dtoNhanVien.NgaySinh = (DateTime)reader[2];
                dtoNhanVien.DiaChi = reader[3].ToString();
                dtoNhanVien.TienLuong = float.Parse(reader[4].ToString());
                dtoNhanVien.NgheNghiep = reader[5].ToString();
                //dtoNhanVien.ImagePath = reader[6].ToString();
                dtoNhanVien.XmlThuocTinhRieng = reader[6].ToString();
            }
            cnn.Close();
            return dtoNhanVien;
        }
    }
}