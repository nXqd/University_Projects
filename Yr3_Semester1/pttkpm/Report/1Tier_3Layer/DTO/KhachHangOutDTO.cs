namespace DTO
{
    public class KhachHangOutDTO
    {
        private int _maKH;
        private string _tenKH;
        private decimal _noKH;

        public int MaKH {
            set { _maKH = value; }
            get { return _maKH; }
        }
        public string TenKH {
            set { _tenKH = value; }
            get { return _tenKH; }
        }
        public decimal NoKH {
            set { _noKH = value; }
            get { return _noKH; }
        }
    }
}
