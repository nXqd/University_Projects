using System;

namespace DTO
{
    public class PhieuXuatDTO
    {
        private int _maPhieuXuat;
        private DateTime _ngay;
        private int _maKH;
        private decimal _tien;

        public decimal ThanhTien {
            get { return _tien; }
            set { _tien = value; }
        }
        public int MaKH {
            set { _maKH = value; }
            get { return _maKH; }
        }
        public int MaPhieuXuat
        {
            set { _maPhieuXuat = value; }
            get { return _maPhieuXuat; }
        }
        public DateTime NgayXuat
        {
            set { _ngay = value; }
            get { return _ngay; }
        }
    }
}
