using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SachOutDTO
    {
        private int _maSach;
        private string _tenSach;
        private int _luongTon;

        public int MaSach {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public string TenSach {
            get { return _tenSach; }
            set { _tenSach = value; }
        }
        public int LuongTon {
            get { return _luongTon; }
            set { _luongTon = value; }
        }
    }
}
