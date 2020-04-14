using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBanHangDTO
    {
        private DateTime ngayLap;
        private int maHDBH, khachHang, nhanVienLap;
        private bool tinhTrang;
        private decimal TienTra;

        public HoaDonBanHangDTO(DateTime ngayLap, int maHDBH, int khachHang, int nhanVienLap, bool tinhTrang, decimal tienTra)
        {
            this.NgayLap = ngayLap;
            this.MaHDBH = maHDBH;
            this.KhachHang = khachHang;
            this.NhanVienLap = nhanVienLap;
            this.TinhTrang = tinhTrang;
            TienTra1 = tienTra;
        }

        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int MaHDBH { get => maHDBH; set => maHDBH = value; }
        public int KhachHang { get => khachHang; set => khachHang = value; }
        public int NhanVienLap { get => nhanVienLap; set => nhanVienLap = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public decimal TienTra1 { get => TienTra; set => TienTra = value; }
    }
}
