namespace DTO
{
    public class SachNhapDTO
    {
        private int _stt;
        private string _tenSach;
        private string _theLoai;
        private string _tacGia;
        private int _soLuong;
        private decimal _donGia;

        public decimal DonGia {
            get { return _donGia; }
            set { _donGia = value;}
        }
        public int STT
        {
            get { return _stt; ; }
            set { _stt = value; }
        }
        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }
        public string TheLoai
        {
            get { return _theLoai; }
            set { _theLoai = value; }
        }
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
