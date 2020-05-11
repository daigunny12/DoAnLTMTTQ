using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDTO
    {
        private string teHH, donViTinh, ghiChu;
        private decimal giaBan, giaMua;
        private int sl, maHH;
        private bool tinhTrang;

        public HangHoaDTO()
        {
        }

        public HangHoaDTO(string teHH, string donViTinh, string ghiChu, decimal giaBan, decimal giaMua, int soLuong, int maHH, bool tinhTrang)
        {
            this.TeHH = teHH;
            this.DonViTinh = donViTinh;
            this.GhiChu = ghiChu;
            this.GiaBan = giaBan;
            this.GiaMua = giaMua;
            this.Sl = soLuong;
            this.MaHH = maHH;
            this.TinhTrang = tinhTrang;
        }

        public string TeHH { get => teHH; set => teHH = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public decimal GiaMua { get => giaMua; set => giaMua = value; }
        public int Sl { get => sl; set => sl = value; }
        public int MaHH { get => maHH; set => maHH = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
