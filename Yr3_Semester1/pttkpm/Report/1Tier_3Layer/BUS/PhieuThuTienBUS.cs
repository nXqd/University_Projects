using DAO;
using DTO;

namespace BUS
{
    public class PhieuThuTienBUS
    {
        // Insert a phieuThu and return its' ID
        public static int Insert(PhieuThuTienDTO phieuThu) {
            return PhieuThuTienDAO.Insert(phieuThu);
        }
        // Get all Tien Thu of a KH in a month
        public static decimal GetTienTraOfKHInMonth(int maKH, string date) {
            return PhieuThuTienDAO.GetTienTraOfKHInMonth(maKH, date);
        }
        // Get all Tien Thu of a KH in a month
        public static decimal GetTienTraOfKHBeforeMonth(int maKH, string date)
        {
            return PhieuThuTienDAO.GetTienTraOfKHBeforeMonth(maKH, date);
        }

    }
}
