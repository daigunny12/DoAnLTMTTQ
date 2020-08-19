using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.NhapHang.frmNhapHang;

namespace GUI.NhapHang
{
    public partial class ThanhToan : Form
    {
        #region properties
        private string tenNCC = null;
        private string TienHang = null;
        private string noCuCuaHang = null;
        private string maNCC = null;
        private int maNV = 0;
        private ArrayList mangCTHD = null;
        public event delethanhToan eventLuu = null;
        #endregion

        #region methods
        void tongThanhToan()
        {
            txtTongthanhtoan.Text = (Convert.ToInt32(txtTienhang.Text) + Convert.ToInt32(txtNocu.Text)).ToString();
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
        void luuHoaDon()
        {
            using (DataNhapHang data = new DataNhapHang())
            {
                HoaDonNhapHang hdnh = new HoaDonNhapHang();
                var a = data.HoaDonNhapHangs.Max(d => d.MaHDN);
                hdnh.MaHDN = a + 1;
                hdnh.NCC = Convert.ToInt32(lblMancc.Text);
                hdnh.NhanVienLap = maNV;
                hdnh.NgayLap = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                hdnh.CK = Convert.ToInt32(txtCk.Text);
                hdnh.NoCu = Convert.ToInt32(txtNocu.Text);
                hdnh.TienTra = Convert.ToInt32(txtCuahangtra.Text);
                hdnh.GhiChu = txtGhichu.Text;
                hdnh.TinhTrang = true;
                data.HoaDonNhapHangs.InsertOnSubmit(hdnh);
                foreach (CTHDNhapHangDTO item in mangCTHD)
                {
                    CTHDNhapHang cthdnh = new CTHDNhapHang();
                    cthdnh.MaHDN = hdnh.MaHDN;
                    cthdnh.SanPham = item.SanPham;
                    cthdnh.SL = item.Sl;
                    cthdnh.TinhTrang = true;
                    cthdnh.DonGia = Convert.ToDouble(item.DonGia);
                    data.CTHDNhapHangs.InsertOnSubmit(cthdnh);
                    data.SubmitChanges();
                }
                foreach (CTHDNhapHangDTO item in mangCTHD)
                {
                    CTHDNhapHang cthdnh = new CTHDNhapHang();
                    HangHoa hh = data.HangHoas.Where(d => d.MaHH.Equals(item.SanPham)).FirstOrDefault();
                    hh.SoLuong = hh.SoLuong + item.Sl;
                    //sau khi thanh toán thành công thì phải xét lại sl trong bảng hóa đơn hoặc reset bảng hóa đơn
                    data.SubmitChanges();
                }
                NhaCungCap ncc = data.NhaCungCaps.Where(d => d.MaNCC.Equals(lblMancc.Text)).SingleOrDefault();
                ncc.SoNo = Convert.ToInt32(txtNolai.Text);
                data.SubmitChanges();
                MessageBox.Show("Lưu Thành Công !");
                this.Close();
                resetHoaDon();
            }          
        }
        #endregion
        public ThanhToan(string tenNCC, string tienHang, string noCuCuaHang, string maNCC, ArrayList mangCTHD, int maNV)
        {
            InitializeComponent();
            this.tenNCC = tenNCC;
            this.TienHang = tienHang;
            this.noCuCuaHang = noCuCuaHang;
            this.maNCC = maNCC;
            this.mangCTHD = mangCTHD;
            this.maNV = maNV;
        }
        private void ThanhToan_Load_1(object sender, EventArgs e)
        {
            lblMancc.Text = maNCC;
            lblTenNCC.Text = tenNCC;
            txtTienhang.Text = TienHang;
            txtNocu.Text = noCuCuaHang;
            tongThanhToan();
            enableFalseLuuVaIn();
        }
        private void txtCk_TextChanged(object sender, EventArgs e)
        {
            txtTienhang.Text = TienHang;
            try
            {
                txtTienhang.Text = ((Convert.ToDouble(txtTienhang.Text) - ((Convert.ToDouble(txtTienhang.Text)) * (Convert.ToDouble(txtCk.Text) / 100)))).ToString();
                tongThanhToan();
            }
            catch { tongThanhToan(); }
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

        private void txtCuahangtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCuahangtra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtCuahangtra.Text) > Convert.ToInt32(txtTongthanhtoan.Text))
                {
                    txtCuahangtra.Text = txtTongthanhtoan.Text;
                    txtNolai.Text = "0";
                    enableTrueLuuVaIn();
                }
                if (Convert.ToInt32(txtCuahangtra.Text) < Convert.ToInt32(txtTongthanhtoan.Text))
                {
                    txtNolai.Text = (Convert.ToInt32(txtTongthanhtoan.Text) - Convert.ToInt32(txtCuahangtra.Text)).ToString();
                    enableTrueLuuVaIn();
                }
                if (Convert.ToInt32(txtCuahangtra.Text) == Convert.ToInt32(txtTongthanhtoan.Text))
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
            luuHoaDon();
            frmCR_NhapHang frmCR_NhapHang = new frmCR_NhapHang();
            frmCR_NhapHang.ShowDialog();
        }
    }
}
