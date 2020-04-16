using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string tenNCC, diaChi, sdt, ghiChu;
        private int maNCC;
        private bool tinhTrang;
        private decimal soNo;

        public NhaCungCapDTO(string tenNCC, string diaChi, string sdt, string ghiChu, int maNCC, bool tinhTrang, decimal soNo)
        {
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.GhiChu = ghiChu;
            this.MaNCC = maNCC;
            this.TinhTrang = tinhTrang;
            SoNo = soNo;
        }

        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public decimal SoNo { get => soNo; set => soNo = value; }
    }
}
