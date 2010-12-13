using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace DAO
{
    public abstract class Database
    {
        // Create, open and return sqlConnecion if ok, unless return null
        public static SQLiteConnection CreateConnection() {

            // check and create database
            // Tao db neu chua ton tai
            string dataPath = @"QLNS.db3";
            var _connString = @"Data Source=QLNS.db3";
            SQLiteConnection cnn = null;
            if (!File.Exists(dataPath))
            {
                // Create database
                SQLiteConnection.CreateFile(dataPath);

                cnn = new SQLiteConnection(_connString);
                cnn.Open();
                SQLiteCommand cmd = cnn.CreateCommand();
                cmd.CommandText = @"CREATE TABLE CHITIETBAN (MaPhieuBan char(10),MaSach char(10),DonGia decimal,SoLuongBan integer,MaChiTietBan integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE CHITIETPHIEUNHAP (MaChiTietPhieuNhap integer NOT NULL PRIMARY KEY AUTOINCREMENT,MaPhieuNhap integer,MaSach char(10),SoLuong integer)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE DAUSACH (MaSach integer NOT NULL PRIMARY KEY AUTOINCREMENT,TenSach char(20),TheLoai char(15),TacGia char(50),LuongTon integer)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE KHACHHANG (MaKH integer NOT NULL PRIMARY KEY AUTOINCREMENT,HoTenKH char(30),NoKH float,DiaChiKH char(30),EmailKH char(20),TienThuLN float,PhoneKH text)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE PHIEUBAN (MaPhieuBan integer NOT NULL PRIMARY KEY AUTOINCREMENT,MaKH char(10),NgayLapHD datetime,ThanhTien float)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE PHIEUNHAP (MaPhieuNhap integer NOT NULL PRIMARY KEY AUTOINCREMENT,NgayNhap datetime)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE PHIEUTHUTIEN (MaKH integer,NgayThuTien datetime,SoTienThu float,MaPhieuThu integer NOT NULL PRIMARY KEY AUTOINCREMENT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE THAMSO (ChoTraDu boolean,NoLN float,LuongNhapNN integer,LuongTonNN integer,LuongTonLN integer)";
                cmd.ExecuteNonQuery();

                cnn.Close();
            } else {
                cnn = new SQLiteConnection(_connString);
            }

            return cnn;
        }
        // SQliteExecuteScalar
        public static object SqliteExecuteScalar (string q,SQLiteParameter[] pColl) {
            // If there's no parameter, insert NULL
            Object obj;
            SQLiteConnection cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction()) {
                using (DbCommand cmd = cnn.CreateCommand()) {
                    cmd.CommandText = q;
                    if (pColl != null)
                        cmd.Parameters.AddRange(pColl);                   
                    obj = cmd.ExecuteScalar();

                    cmd.Dispose();
                }
                dbTrans.Commit();
                dbTrans.Dispose();
            }
            cnn.Close();
            cnn.Dispose();
            return obj;
        }
        // SQliteExecuteNonQuery
        public static object SqliteExecuteNonQuery(string q, SQLiteParameter[] pColl) {
            // If there's no parameter, insert NULL
            Object obj;
            SQLiteConnection cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction()) {
                using (DbCommand cmd = cnn.CreateCommand()) {
                    cmd.CommandText = q;
                    cmd.Parameters.AddRange(pColl);
                    obj = cmd.ExecuteNonQuery();

                    cmd.Dispose();
                }
                dbTrans.Commit();
                dbTrans.Dispose();
            }
            cnn.Close();
            cnn.Dispose();
            return obj;
        }
        // SQliteDataReader
        public static SQLiteDataReader SqliteDataReader(string q,SQLiteParameter[] sqLiteParameters) {
            // If there's no parameter, insert NULL
            SQLiteDataReader obj;
            SQLiteConnection cnn = CreateConnection();
            cnn.Open();
            using (DbTransaction dbTrans = cnn.BeginTransaction()) {
                using (DbCommand cmd = cnn.CreateCommand()) {
                    cmd.CommandText = q;
                    if (sqLiteParameters != null)
                        cmd.Parameters.AddRange(sqLiteParameters);
                    obj = (SQLiteDataReader)cmd.ExecuteReader();
                }
                dbTrans.Commit();
            }
            return obj;
        }
    }
}
