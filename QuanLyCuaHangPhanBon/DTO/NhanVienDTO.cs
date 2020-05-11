using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string tenNV, sdt, diaChi, gioiTinh, ghiChu;
        private int maNV;
        private bool tinhTrang;
        private DateTime ngaySinh;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        //public NhanVienDTO(DataRow row)
        //{
        //    this.tenNV = row["TenNV"].ToString();
        //    this.sdt = row["SDT"].ToString();
        //    this.diaChi = row["DiaChi"].ToString();
        //    this.gioiTinh = row["GioiTinh"].ToString();
        //    this.ghiChu = row["GhiChu"].ToString();
        //    this.maNV = (int)row["MaNV"];
        //    this.tinhTrang = (bool)row["TinhTrang"];
        //    this.ngaySinh = (DateTime)row["NgaySinh"];
        //}

        public NhanVienDTO(string tenNV, string sdt, string diaChi, string gioiTinh, string ghiChu, int maNV, bool tinhTrang, DateTime ngaySinh)
        {
            this.tenNV = tenNV;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ghiChu = ghiChu;
            this.maNV = maNV;
            this.tinhTrang = tinhTrang;
            this.ngaySinh = ngaySinh;
        }

        public NhanVienDTO()
        {
        }
    }
}
