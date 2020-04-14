using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Object
{
    class ChiTietObj
    {
        string mahd, mama;

        public string MaMA
        {
            get { return mama; }
            set { mama = value; }
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
            this.mama = mahh;
            this.sl = sl;
            this.dongia = dongia;
        }
    }
}
