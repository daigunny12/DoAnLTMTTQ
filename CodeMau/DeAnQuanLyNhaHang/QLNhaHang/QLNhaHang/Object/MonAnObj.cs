using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Object
{
    class MonAnObj
    {
        string ma, ten;
        int dongia;
        string soluong;

        public string SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string TenMA
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaMA
        {
            get { return ma; }
            set { ma = value; }
        }

        public MonAnObj() { }
        public MonAnObj(string ma, string ten, int dongia, string soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.dongia = dongia;
            this.soluong = soluong;
        }
    }
}
