using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private int maNV;
        private string tenNV, matKhau, tenDN;
        private bool chucVu;

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(int maNV, string tenNV, string matKhau, string tenDN, bool chucVu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.MatKhau = matKhau;
            this.TenDN = tenDN;
            this.ChucVu = chucVu;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        public bool ChucVu { get => chucVu; set => chucVu = value; }
    }
}
