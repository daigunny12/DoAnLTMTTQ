using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhapHangDTO
    {
        private DateTime ngayLap;
        private int maHDNH, ncc, nhanVienLap;
        private bool tinhTrang;
        private decimal TienTra;

        public HoaDonNhapHangDTO(DateTime ngayLap, int maHDNH, int ncc, int nhanVienLap, bool tinhTrang, decimal tienTra)
        {
            this.NgayLap = ngayLap;
            this.MaHDNH = maHDNH;
            this.Ncc = ncc;
            this.NhanVienLap = nhanVienLap;
            this.TinhTrang = tinhTrang;
            TienTra1 = tienTra;
        }

        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int MaHDNH { get => maHDNH; set => maHDNH = value; }
        public int Ncc { get => ncc; set => ncc = value; }
        public int NhanVienLap { get => nhanVienLap; set => nhanVienLap = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public decimal TienTra1 { get => TienTra; set => TienTra = value; }
    }
}
