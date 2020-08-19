using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using GUI.Main;
using GUI.QuanLy.HangHoa;
using GUI.QuanLy.NhanVien;
using GUI.QuanLy.KhachHang;
using GUI.QuanLy.NhaCungCap;
using GUI.ThongKe.ChiTietBanHang;
using GUI.ThongKe.ChiTietNhapHang;
using GUI.ThongKe.HoaDonBanHang;
using GUI.ThongKe.HoaDonNhapHang;
using GUI.ThongKe.XuatKho;
using GUI.ThongKe.NhapKho;
using GUI.ThongKe.BaoCaoTongHop;

namespace GUI
{

    public partial class supMenu : UserControl 
    {

        private HangHoa frmHangHoa = null;
        private NhanVien frmNhanVien = null;
        private KhachHang frmKhachHang = null;
        private NhaCungCap frmNhaCungCap = null;

        private frmBaoCaoChiTietBanHang frmBaoCaoChiTietBanHang = null;
        private frmBaoCaoChiTietNhapHang frmBaoCaoChiTietNhapHang = null;
        private frmBaoCaoHoaDonBanHang frmBaoCaoHoaDonBanHang = null;
        private frmBaoCaoHoaDonNhapHang frmBaoCaoHoaDonNhapHang = null;
        private frmBaoCaoNhapKho frmBaoCaoNhap = null;
        private frmBaoCaoXuatKho frmBaoCaoXuatKho = null;
        private frmBaoCaoTongHop frmBaoCaoTongHop = null;

        public event deleSetfrm deleSetfrm = null;
        public supMenu()
        {
            InitializeComponent();

            if (Program.IsInDesignMode()) return;
            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
            //pnChe.Height = 35;
        }

        #region Quản lý      
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            if(frmHangHoa == null)
            {
                frmHangHoa = new HangHoa();
            }        
            if (deleSetfrm != null)
            {
                deleSetfrm(frmHangHoa);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (frmNhanVien == null)
            {
                frmNhanVien = new NhanVien();
            }           
            if (deleSetfrm != null)
            {
                deleSetfrm(frmNhanVien);
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if(frmKhachHang == null)
            {
                frmKhachHang = new KhachHang();
            }

            if (deleSetfrm != null)
            {
                deleSetfrm(frmKhachHang);
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (frmNhaCungCap == null)
            {
                frmNhaCungCap = new NhaCungCap();
            }
            
            if (deleSetfrm != null)
            {
                deleSetfrm(frmNhaCungCap);
            }
        }
        #endregion

        #region Thống kê
        private void btnCTBH_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoChiTietBanHang == null)
            {
                frmBaoCaoChiTietBanHang = new frmBaoCaoChiTietBanHang();
            }

            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoChiTietBanHang);
            }
        }

        private void btnCTNH_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoChiTietNhapHang == null)
            {
                frmBaoCaoChiTietNhapHang  = new frmBaoCaoChiTietNhapHang();
            }
            
            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoChiTietNhapHang);
            }
        }

        private void btnHDBH_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoHoaDonBanHang == null)
            {
                frmBaoCaoHoaDonBanHang = new frmBaoCaoHoaDonBanHang();
            }
            
            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoHoaDonBanHang);
            }
        }

        private void btnHDNH_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoHoaDonNhapHang == null)
            {
                frmBaoCaoHoaDonNhapHang = new frmBaoCaoHoaDonNhapHang();
            }
            
            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoHoaDonNhapHang);
            }
        }

        private void btnXK_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoXuatKho == null)
            {
                frmBaoCaoXuatKho = new frmBaoCaoXuatKho();
            }
           
            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoXuatKho);
            }
        }

        private void btnNK_Click(object sender, EventArgs e)
        {
            if(frmBaoCaoNhap == null)
            {
                frmBaoCaoNhap = new frmBaoCaoNhapKho();
            }
            
            if (deleSetfrm != null)
            {
                deleSetfrm(frmBaoCaoNhap);
            }
        }

        private void btnBaoCaoTongHop_Click(object sender, EventArgs e)
        {
            if (frmBaoCaoTongHop != null)
            {
                frmBaoCaoTongHop.Close();
              
            }

            if (deleSetfrm != null)
            {
                frmBaoCaoTongHop = new frmBaoCaoTongHop();
                deleSetfrm(frmBaoCaoTongHop);
            }
        }
        #endregion

        #region get sellected thong ke
        public void GetSellectedThongKe()
        {
            if (btnCTBH.selected)
            {
                if (frmBaoCaoChiTietBanHang == null)
                {
                    frmBaoCaoChiTietBanHang = new frmBaoCaoChiTietBanHang();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoChiTietBanHang);
                }
            }

            if (btnCTNH.selected)
            {
                if (frmBaoCaoChiTietNhapHang == null)
                {
                    frmBaoCaoChiTietNhapHang = new frmBaoCaoChiTietNhapHang();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoChiTietNhapHang);
                }
            }

            if (btnHDBH.selected)
            {
                if (frmBaoCaoHoaDonBanHang == null)
                {
                    frmBaoCaoHoaDonBanHang = new frmBaoCaoHoaDonBanHang();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoHoaDonBanHang);
                }
            }

            if (btnHDNH.selected)
            {
                if (frmBaoCaoHoaDonNhapHang == null)
                {
                    frmBaoCaoHoaDonNhapHang = new frmBaoCaoHoaDonNhapHang();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoHoaDonNhapHang);
                }
            }

            if (btnXK.selected)
            {
                if (frmBaoCaoXuatKho == null)
                {
                    frmBaoCaoXuatKho = new frmBaoCaoXuatKho();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoXuatKho);
                }
            }

            if (btnNK.selected)
            {
                if (frmBaoCaoNhap == null)
                {
                    frmBaoCaoNhap = new frmBaoCaoNhapKho();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoNhap);
                }
            }
            if (btnBaoCaoTongHop.selected)
            {
                if (frmBaoCaoTongHop == null)
                {
                    frmBaoCaoTongHop = new frmBaoCaoTongHop();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmBaoCaoTongHop);
                }
            }
        }
  
        #endregion

        #region get sellected quan ly
        public void getSelectedQuanLy()
        {          
            if (btnHangHoa.selected)
            {
                if (frmHangHoa == null)
                {
                    frmHangHoa = new HangHoa();
                }
                if (deleSetfrm != null)
                {
                    deleSetfrm(frmHangHoa);
                }
            }

            if (btnNhanVien.selected)
            {
                if (frmNhanVien == null)
                {
                    frmNhanVien = new NhanVien();
                }
                if (deleSetfrm != null)
                {
                    deleSetfrm(frmNhanVien);
                }
            }

            if (btnKhachHang.selected)
            {
                if (frmKhachHang == null)
                {
                    frmKhachHang = new KhachHang();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmKhachHang);
                }
            }

            if (btnNhaCungCap.selected)
            {
                if (frmNhaCungCap == null)
                {
                    frmNhaCungCap = new NhaCungCap();
                }

                if (deleSetfrm != null)
                {
                    deleSetfrm(frmNhaCungCap);
                }
            }
        }


        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
