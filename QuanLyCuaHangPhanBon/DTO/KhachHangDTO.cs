using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHangDTO
    {
        private string tenKH, sdt, diaChi, ghiChu;
        private int maKH;
        private bool tinhTrang;
        private decimal soNo;

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public decimal SoNo { get => soNo; set => soNo = value; }

        public KhachHangDTO(string tenKH, string sdt, string diaChi, string ghiChu, int maKH, bool tinhTrang, decimal soNo)
        {
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.ghiChu = ghiChu;
            this.maKH = maKH;
            this.tinhTrang = tinhTrang;
            this.soNo = soNo;
        }

        public KhachHangDTO()
        {
        }
    }
}
