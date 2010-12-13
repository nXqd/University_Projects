using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        // Insert a ChiTietPhieuNhap and return its' ID
        public static int Insert(ChiTietPhieuNhapDTO chiTietPN) {
            return ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap(chiTietPN);
        }
    }
}
