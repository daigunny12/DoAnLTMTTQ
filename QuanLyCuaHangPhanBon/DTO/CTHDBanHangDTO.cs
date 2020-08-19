using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDBanHangDTO
    {
        private string dvt;
        private int sanPham, sl, maHDBH;
        private decimal donGia, tienCK, thanhTien, ck;
        private bool tinhTrang;

        public CTHDBanHangDTO()
        {
        }

        public CTHDBanHangDTO(string dvt, int sanPham, int sl, int maHDBH, decimal donGia, decimal tienCK, decimal thanhTien, decimal ck, bool tinhTrang)
        {
            this.Dvt = dvt;
            this.SanPham = sanPham;
            this.Sl = sl;
            this.MaHDBH = maHDBH;
            this.DonGia = donGia;
            this.TienCK = tienCK;
            this.ThanhTien = thanhTien;
            this.Ck = ck;
            this.TinhTrang = tinhTrang;
        }

        public string Dvt { get => dvt; set => dvt = value; }
        public int SanPham { get => sanPham; set => sanPham = value; }
        public int Sl { get => sl; set => sl = value; }
        public int MaHDBH { get => maHDBH; set => maHDBH = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public decimal TienCK { get => tienCK; set => tienCK = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public decimal Ck { get => ck; set => ck = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
