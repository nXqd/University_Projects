using System;

namespace DTO
{
    public class PhieuThuTienDTO
    {
        private int _makh;
        private DateTime _ngay;
        private decimal _tien;
        
        public int MaKH {
            get { return _makh; }
            set { _makh= value; }
        }

        public DateTime Ngay{
            get { return _ngay; }
            set { _ngay = value; }
        }

        public decimal TienThu{
            get { return _tien; }
            set { _tien = value; }
        }
    }
}
