using QLNV.Data;
using QLNV.DTO;

namespace QLNV.Business
{
    public class bNhanVien
    {
        static public int Add(dtoNhanVien nhanVien) {
            // Kiem tra thu msnv co ton tai khong
            if (dNhanVien.Search(nhanVien.Msnv) != null) {
                return 2;
            }
            return dNhanVien.Add(nhanVien) ? 1 : 0;
        }
        static public dtoNhanVien Search(int msnv) {
            return dNhanVien.Search(msnv);
        }
    }
}
