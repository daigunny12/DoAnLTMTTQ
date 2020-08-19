using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Numerics;
using System.Runtime.InteropServices;
using DTO;
using static GUI.BanHang.frmBanHang;
using System.Linq.Expressions;
using Microsoft.SqlServer.Server;

namespace GUI.BanHang
{
    public partial class ThanhToan : Form
    {
        #region properties
        private int maNV = 0;
        private string tenKH = null;
        private string TienHang = null;
        private string noCuKH = null;
        private string maKH = null;
        private ArrayList mangCTHD = null;
        public event delethanhToan eventLuu = null;
        #endregion
        #region methods
        void tongThanhToan()
        {
            double tongTT = (Convert.ToDouble(txtTienhang.Text) + Convert.ToDouble(txtNocu.Text));
            txtTongthanhtoan.Text = tongTT.ToString();
            txtTongthanhtoan.Text = Math.Round(tongTT, 0, MidpointRounding.ToEven).ToString();
        }
        void resetHoaDon()
        {
            bool luu = true;
            eventLuu(luu);
        }
        void enableTrueLuuVaIn()
        {
            btnLuuvain.Enabled = true;
            btnLuu.Enabled = true;
        }
        void enableFalseLuuVaIn()
        {
            btnLuuvain.Enabled = false;
            btnLuu.Enabled = false;
        }
        void kiemTraTienKhTra()
        {
            try
            {
                if (Convert.ToInt32(txtKhachtra.Text) > Convert.ToInt32(txtTongthanhtoan.Text))
                {
                    txtKhachtra.Text = txtTongthanhtoan.Text;
                    txtNolai.Text = "0";
                    enableTrueLuuVaIn();
                }
                if (Convert.ToInt32(txtKhachtra.Text) < Convert.ToInt32(txtTongthanhtoan.Text))
                {
                    txtNolai.Text = (Convert.ToInt32(txtTongthanhtoan.Text) - Convert.ToInt32(txtKhachtra.Text)).ToString();
                    enableTrueLuuVaIn();
                }
                if (Convert.ToInt32(txtKhachtra.Text) == Convert.ToInt32(txtTongthanhtoan.Text))
                {
                    txtNolai.Text = "0";
                    enableTrueLuuVaIn();
                }
            }
            catch
            {
                txtNolai.Text = "0";
                enableFalseLuuVaIn();
            }
        }
        bool luuHoaDon()
        {
            bool check = false;
            if (lblTenKH.Text == "Khách lẻ" && Convert.ToInt32(txtNolai.Text) > 0)
            {
                MessageBox.Show("Khách lẻ không cho nợ !");
                check = false;
            }
            else
            {
                using (DataBanHang data = new DataBanHang())
                {
                    HoaDonBanHang hdbh = new HoaDonBanHang();
                    var a = data.HoaDonBanHangs.Max(d => d.MaHDB);
                    hdbh.MaHDB = a + 1;
                    hdbh.KhachHang = Convert.ToInt32(lblMakh.Text);
                    hdbh.NhanVienLap = maNV;
                    hdbh.NgayLap = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    hdbh.CK = Convert.ToInt32(txtCk.Text);
                    hdbh.NoCu = Convert.ToInt32(txtNocu.Text);
                    hdbh.TienTra = Convert.ToInt32(txtKhachtra.Text);
                    hdbh.GhiChu = txtGhichu.Text;
                    hdbh.TinhTrang = true;
                    data.HoaDonBanHangs.InsertOnSubmit(hdbh);
                    foreach (CTHDBanHangDTO item in mangCTHD)
                    {
                        CTHDBanHang cthdbh = new CTHDBanHang();
                        cthdbh.MaHDB = hdbh.MaHDB;
                        cthdbh.SanPham = item.SanPham;
                        cthdbh.SL = item.Sl;
                        cthdbh.TinhTrang = true;
                        cthdbh.DonGia = Convert.ToDouble(item.DonGia);
                        data.CTHDBanHangs.InsertOnSubmit(cthdbh);
                        data.SubmitChanges();
                    }
                    foreach (CTHDBanHangDTO item in mangCTHD)
                    {
                        CTHDBanHang cthdbh = new CTHDBanHang();
                        HangHoa hh = data.HangHoas.Where(d => d.MaHH.Equals(item.SanPham)).FirstOrDefault();
                        hh.SoLuong = hh.SoLuong - item.Sl;
                        //sau khi thanh toán thành công thì phải xét lại sl trong bảng hóa đơn hoặc reset bảng hóa đơn
                        data.SubmitChanges();
                    }
                    KhachHang kh = data.KhachHangs.Where(d => d.MaKH.Equals(lblMakh.Text)).SingleOrDefault();
                    kh.SoNo = Convert.ToInt32(txtNolai.Text);
                    data.SubmitChanges();
                    MessageBox.Show("Lưu Thành Công !");
                    check = true;
                    this.Close();
                    resetHoaDon();
                }
            }
            return check;
        }
        #endregion
        public ThanhToan(string tenKH, string tienHang, string noCuKH, string maKH, ArrayList mangCTHD , int maNV)
        {
            InitializeComponent();
            this.tenKH = tenKH;
            this.TienHang = tienHang;
            this.noCuKH = noCuKH;
            this.maKH = maKH;
            this.mangCTHD = mangCTHD;
            this.maNV = maNV;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            lblMakh.Text = maKH;
            lblTenKH.Text = tenKH;
            txtTienhang.Text = TienHang;
            txtNocu.Text = noCuKH;
            tongThanhToan();
            enableFalseLuuVaIn();
        }

        private void txtCk_TextChanged_1(object sender, EventArgs e)
        {
            txtTienhang.Text = TienHang;
            try
            {
                double tienHang = ((Convert.ToDouble(txtTienhang.Text) - ((Convert.ToDouble(txtTienhang.Text)) * (Convert.ToDouble(txtCk.Text) / 100))));
                txtTienhang.Text = tienHang.ToString();
                txtTienhang.Text = Math.Round(tienHang, 0, MidpointRounding.ToEven).ToString();
                tongThanhToan();
            }
            catch { tongThanhToan(); }
            kiemTraTienKhTra();
            if (txtTongthanhtoan.Text == "0")
            {
                txtKhachtra.Text = "0";
                txtKhachtra.Enabled = false;
            }
            else
                txtKhachtra.Enabled = true;
        }
        private void txtCk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCk_Leave(object sender, EventArgs e)
        {
            if (txtCk.Text.Length == 0)
            {
                txtCk.Text = "0";
            }
            if (Convert.ToInt32(txtCk.Text) > 100)
            {
                txtCk.Text = "";
                txtCk.Focus();
                MessageBox.Show("CK không thể vượt quá 100% !");
            }
        }

        private void txtKhachtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
       
        private void txtKhachtra_TextChanged(object sender, EventArgs e)
        {
            kiemTraTienKhTra();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luuHoaDon();
        }

        private void btnLuuvain_Click(object sender, EventArgs e)
        {
            if (luuHoaDon())
            {
                frmCR_BanHang frmCR_BanHang = new frmCR_BanHang();
                frmCR_BanHang.Show();
            }
           
        }
    }
}
