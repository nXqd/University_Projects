namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private int _maChiTietPhieuNhap;
        private int _maPhieuNhap;
        private int _maSach;
        private int _luongNhap;

        public int MaChiTietPhieuNhap {
            set { _maChiTietPhieuNhap = value; }
            get { return _maChiTietPhieuNhap; }
        }
        public int MaPhieuNhap {
            set { _maPhieuNhap = value; }
            get { return _maPhieuNhap; }
        }
        public int MaSach {
            set { _maSach = value; }
            get { return _maSach; }
        }
        public int LuongNhap {
            set { _luongNhap = value; }
            get { return _luongNhap; }
        }
    }
}
