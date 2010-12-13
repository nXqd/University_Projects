using System;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private int _maPhieuNhap;
        private DateTime _ngayNhap;

        public int MaPhieuNhap {
            set { _maPhieuNhap = value; }
            get { return _maPhieuNhap; }
        }
        public DateTime NgayNhap {
            set { _ngayNhap = value; }
            get { return _ngayNhap; }
        }
    }
}
