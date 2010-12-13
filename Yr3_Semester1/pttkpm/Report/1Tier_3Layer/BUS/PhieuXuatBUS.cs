using System;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuXuatBUS
    {
        public static int Insert(PhieuXuatDTO phieuXuat) {
            return PhieuXuatDAO.Insert(phieuXuat);
        }
        public static void UpdateThanhTien(int phieuXuatID, decimal tien) {
            PhieuXuatDAO.UpdateThanhTien(phieuXuatID,tien);
        }
        // Check PhieuXuat and return phieuXuatID if available
        public static int CheckPhieuXuat(int maKH,DateTime time) {
            return PhieuXuatDAO.CheckPhieuXuat(maKH, time);
        }
        // Get sum(luongban) of a book in a month
        public static int GetLuongBanOfBookByMonth(int sachID, string date) {
            return PhieuXuatDAO.GetLuongBanOfBookByMonth(sachID, date);
        }
        // Get sum(luongban) of a book before a month
        public static int GetLuongBanOfBookBeforeMonth(int sachID,string date) {
            return PhieuXuatDAO.GetLuongBanOfBookBeforeMonth(sachID, date);
        }
        // Get SUM(No) of a KH in a month
        public static decimal GetNoKHByMonth(int khachID, string date) {
            return PhieuXuatDAO.GetNoKHByMonth(khachID, date);
        }
        // Get Sum(no) of a KH before a month
        public static decimal GetNoKHBeforeMonth(int khachID, string date) {
            return PhieuXuatDAO.GetNoKHBeforeMonth(khachID, date);
        }
    }
}
