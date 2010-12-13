namespace DTO
{
    public class ChiTietPhieuXuatDTO
    {
        private int _maChiTiet;
        private int _maSach;
        private int _maPhieu;
        private decimal _donGia;
        private int _soLuong;

        public int MaChiTietBan
        {
            set { _maChiTiet = value; }
            get { return _maChiTiet; }
        }
        public int MaSach 
        {
            set { _maSach = value; }
            get { return _maSach; }
        }
        public int MaPhieuXuat {
            set { _maPhieu = value; }
            get { return _maPhieu; }
        }
        public decimal DonGia {
            set { _donGia = value; }
            get { return _donGia; }
        }
        public int SoLuong {
            set { _soLuong = value; }
            get { return _soLuong; }
        }
    }
}
