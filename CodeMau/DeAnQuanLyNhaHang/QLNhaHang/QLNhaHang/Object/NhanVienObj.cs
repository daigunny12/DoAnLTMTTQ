using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau;
        string namsinh;

        public string NamSinh { get => namsinh; set => namsinh = value; }
        public string MaNV { get => ma; set => ma = value; }
        public string TenNV { get => ten; set => ten = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }

        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, string diachi, string sdt, string matkhau, string namsinh)
        {
            this.ten = ten;
            this.ma = ma;
            this.diachi = diachi;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            this.matkhau = matkhau;
            this.namsinh = namsinh;

        }

    }
}
