namespace DTO
{
    public class KhachHangDTO
    {
        private static int _maKh;
        private static string _hoTenKh;
        private static decimal _noKh;
        private static string _diaChiKh;
        private static string _emailKh;

        public int MaKH {
            get { return _maKh; }
            set { _maKh = value; }
        }
        public string HoTen {
            get { return _hoTenKh; }
            set { _hoTenKh = value; }
        }
        public decimal No {
            get { return _noKh; }
            set { _noKh = value; }
        }
        public string DiaChi {
            get { return _diaChiKh; }
            set { _diaChiKh = value; }
        }
        public string Email {
            get { return _emailKh; }
            set { _emailKh = value; }
        }
    }
}
