using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnNV_Click(object sender, EventArgs e)
        {
            QuanLy.NhanVien.NhanVien nhanVien = new QuanLy.NhanVien.NhanVien();
            nhanVien.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            QuanLy.KhachHang.KhachHang khachHang = new QuanLy.KhachHang.KhachHang();
            khachHang.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            QuanLy.NhaCungCap.NhaCungCap nhaCungCap = new QuanLy.NhaCungCap.NhaCungCap();
            nhaCungCap.ShowDialog();
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            QuanLy.HangHoa.HangHoa aasd = new QuanLy.HangHoa.HangHoa();
            aasd.ShowDialog();
        }

        private void btnChiTietBanHang_Click(object sender, EventArgs e)
        {
            ThongKe.ChiTietBanHang.frmBaoCaoChiTietBanHang bh = new ThongKe.ChiTietBanHang.frmBaoCaoChiTietBanHang();
            bh.ShowDialog();
        }

        private void btnChiTietNhapHang_Click(object sender, EventArgs e)
        {
            ThongKe.ChiTietNhapHang.frmBaoCaoChiTietNhapHang nh = new ThongKe.ChiTietNhapHang.frmBaoCaoChiTietNhapHang();
            nh.ShowDialog();
        }

        private void btnHoaDonBanHang_Click(object sender, EventArgs e)
        {
            ThongKe.HoaDonBanHang.frmBaoCaoHoaDonBanHang bh = new ThongKe.HoaDonBanHang.frmBaoCaoHoaDonBanHang();
            bh.ShowDialog();
        }

        private void btnHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            ThongKe.HoaDonNhapHang.frmBaoCaoHoaDonNhapHang nh = new ThongKe.HoaDonNhapHang.frmBaoCaoHoaDonNhapHang();
            nh.ShowDialog();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            ThongKe.XuatKho.frmBaoCaoXuatKho xk = new ThongKe.XuatKho.frmBaoCaoXuatKho();
            xk.ShowDialog();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            ThongKe.NhapKho.frmBaoCaoNhapKho nk = new ThongKe.NhapKho.frmBaoCaoNhapKho();
            nk.Show();
        }




    }
}
