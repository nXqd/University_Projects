namespace DTO
{
    public class DauSachDTO
    {
        private int _maSach;
        private string _tenSach;
        private string _theLoai;
        private string _tacGia;
        private int _luongTon;

        public int MaSach
        {
            get { return _maSach; ; }
            set { _maSach = value; }
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
        public int LuongTon 
        {
            get { return _luongTon; }
            set { _luongTon = value; }
        }
    }
}
