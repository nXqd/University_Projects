using System.Collections.Generic;

using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        // GetNo by Khach Hang Name
        public static decimal GetNo(string tenKH) {
            return KhachHangDAO.GetNo(tenKH);
        }
        // Lấy ID của một Khách hàng
        public static int GetKhachHangID(string tenKH) {
            return KhachHangDAO.GetKhachHangID(tenKH);
        }
        // Update Nợ
        public static void UpdateNo(int maKH,decimal no) {
            KhachHangDAO.UpdateNo(maKH,no);
        }
        // Lấy list khách hàng [MaKH,TenKH,NoKH]
        public static List<KhachHangOutDTO> GetAllKH() {
            var khachHangs = new List<KhachHangOutDTO>();
            var reader = KhachHangDAO.GetAllKH();
            while (reader.Read()) {
                khachHangs.Add(new KhachHangOutDTO {MaKH = int.Parse(reader[0].ToString()),NoKH=decimal.Parse(reader[2].ToString()),TenKH = reader[1].ToString()});
            }
            return khachHangs;
        }
        // Lấy email,phone,địachỉ của một khách hàng thông qua tên
        public static List<string> GetEmailPhoneAddByName(string name) {
            var results = new List<string>();
            var reader = KhachHangDAO.GetEmailPhoneAddByName(name);
            if (reader.Read()) {
                for (int i = 0; i < 3; ++i) 
                    results.Add(reader[i].ToString());
                return results;
            }
            return null;
        }
    }
}
