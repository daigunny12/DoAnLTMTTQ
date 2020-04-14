using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string tenDN, matKhau, chucVu, tenNV;
        private int maTK;
        private bool tinhTrang;

        public TaiKhoanDTO(string tenDN, string matKhau, string chucVu, string tenNV, int maTK, bool tinhTrang)
        {
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.ChucVu = chucVu;
            this.TenNV = tenNV;
            this.MaTK = maTK;
            this.TinhTrang = tinhTrang;
        }

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int MaTK { get => maTK; set => maTK = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
