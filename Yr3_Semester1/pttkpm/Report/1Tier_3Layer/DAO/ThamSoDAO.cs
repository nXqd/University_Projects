using System;
using System.Data.SQLite;
using DTO;

namespace DAO
{
    public class ThamSoDAO : Database {
        public static int GetSoLuongNhapNN() {
            return Convert.ToInt32(SqliteExecuteScalar(@"SELECT LuongNhapNN FROM THAMSO",null));
        }
        // Trả về lượng tồn tối đa khi nhập sách vào
        public static int SoLuongTonNN() {
            return Convert.ToInt32(SqliteExecuteScalar(@"SELECT LuongTonNN FROM THAMSO",null));
        }
        public static decimal GetNoLN() {
            return Convert.ToDecimal(SqliteExecuteScalar(@"SELECT NoLN FROM THAMSO",null));
        }
        public static ThamSoDTO GetAll() {
            var thamSos = new ThamSoDTO();
            var obj = SqliteDataReader(@"SELECT * FROM THAMSO", null);
            if (obj.Read()) {
                thamSos.SoLuongNhapNN = int.Parse(obj[0].ToString());
                thamSos.LuongTonLN = int.Parse(obj[1].ToString());
                thamSos.LuongTonNN = int.Parse(obj[2].ToString());
                thamSos.NoLN = int.Parse(obj[3].ToString());
                thamSos.ChoTraDu = bool.Parse(obj[4].ToString());
            }
            return thamSos;
        }
        public static void UpdateAll(ThamSoDTO thamSos) {

            var q = @"UPDATE THAMSO SET LuongNhapNN=@nhapNN,LuongTonLN=@tonLN,LuongTonNN=@tonNN,NoLN=@noLN,ChoTraDu=@traDu";
            var sqlParas = new[] {
                                     new SQLiteParameter("@nhapNN", thamSos.SoLuongNhapNN),
                                     new SQLiteParameter("@tonLN", thamSos.LuongTonLN),
                                     new SQLiteParameter("@tonNN", thamSos.LuongTonNN),
                                     new SQLiteParameter("@noLN", thamSos.NoLN),
                                     new SQLiteParameter("@traDu", thamSos.ChoTraDu),
                                 };
            SqliteExecuteNonQuery(q,sqlParas);
        }
    }

}
