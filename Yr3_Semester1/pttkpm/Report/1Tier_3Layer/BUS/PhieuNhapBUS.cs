using DAO;
using System;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static int HasPhieuNhap(DateTime ngayNhap) {
            return PhieuNhapDAO.HasPhieuNhap(ngayNhap);
        }
        public static int Insert(DateTime ngayNhap) {
            return PhieuNhapDAO.InsertPhieuNhap(ngayNhap);
        }
        // Get luongNhap of a Book in a Month
        public static int GetLuongNhapOfBookByMonth(int sachID, string date) {
            return PhieuNhapDAO.GetLuongNhapOfBookByMonth(sachID, date);
        }
        // Get sum(luongban) of a book before a month
        public static int GetLuongBanOfBookBeforeMonth(int sachID, string date) {
            return PhieuNhapDAO.GetLuongBanOfBookBeforeMonth(sachID, date);
        }
    }
}
