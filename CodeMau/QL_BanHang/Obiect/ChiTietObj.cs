using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_BanHang.Obiect
{
    class ChiTietObj
    {
        string mahd, mahh;

        public string MaHangHoa
        {
            get { return mahh; }
            set { mahh = value; }
        }

        public string MaHoaDon
        {
            get { return mahd; }
            set { mahd = value; }
        }
        int sl, dongia;

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public int SoLuong
        {
            get { return sl; }
            set { sl = value; }
        }

        
        public ChiTietObj() { }

        public ChiTietObj(string mahd, string mahh, int sl, int dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.sl = sl;
            this.dongia = dongia;
        }
    }
}
