using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        // Insert a chiTietPhieuXuat and return its' ID
        public static void Insert (ChiTietPhieuXuatDTO phieuXuat) {
            ChiTietPhieuXuatDAO.Insert(phieuXuat);
        }
    }
}
