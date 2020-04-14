using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, sdt, email;
        string namsinh;
        int diem;

        public string NamSinh { get => namsinh; set => namsinh = value; }
        public string MaKH { get => ma; set => ma = value; }
        public string TenKH { get => ten; set => ten = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int Diem { get => diem; set => diem = value; }

        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string diachi, string sdt, string email, string namsinh, int diem)
        {
            this.ten = ten;
            this.ma = ma;
            this.diachi = diachi;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            this.email = email;
            this.namsinh = namsinh;
            this.email = email;
            this.diem = diem;
        }
    }
}
