using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.NhapHang.frmNhapHang;

namespace GUI.NhapHang
{
    public partial class ThemHoaDon : Form
    {
        public event deleGetRow eventGetRow = null;
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        #region methods
        void dataSourceHangHoa()
        {
            using (DataNhapHang dthh = new DataNhapHang())
            {
                dtgThemHoaDon.DataSource = from h in dthh.HangHoas
                                           where h.TinhTrang.Equals("True")
                                           select new
                                           {
                                               MaHH = h.MaHH,
                                               TenHH = h.TenHH,
                                               DonViTinh = h.DonViTinh,
                                               GiaMua = h.GiaMua,
                                               SoLuong = h.SoLuong,
                                               GhiChu = h.GhiChu
                                           };
            }
        }
        void timKiemHangHoa()
        {
            using (DataNhapHang dthh = new DataNhapHang())
            {
                dtgThemHoaDon.DataSource = from h in dthh.HangHoas
                                           where h.TinhTrang.Equals("True")
                                           select new
                                           {
                                               MaHH = h.MaHH,
                                               TenHH = h.TenHH,
                                               DonViTinh = h.DonViTinh,
                                               GiaMua = h.GiaMua,
                                               SoLuong = h.SoLuong,
                                               GhiChu = h.GhiChu
                                           } into newselect
                                           where newselect.TenHH.Contains(txtTimkiem.Text)
                                           select newselect;
            }
        }
        void layDuLieuTuHangHoa()
        {
            btnThem.Enabled = true;
            txtMahh.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["MaHH"].Value.ToString();
            txtTenHH.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["TenHH"].Value.ToString();
            txtSoluong.Text = "1";
            lblDonvitinh.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["DonViTinh"].Value.ToString();
            txtGiamua.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["GiaMua"].Value.ToString();
            double a = Convert.ToDouble(txtSoluong.Text) * Convert.ToInt32(txtGiamua.Text);
            txtThanhtien.Text = a.ToString();
            txtGhichu.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["GhiChu"].Value.ToString();
        }
        void erroColorSL()
        {
            lblSL.ForeColor = Color.Red;
            txtThanhtien.Text = "";
        }
        void eventDeThemHangHoaVaoHoaDon()
        {
            CTHDNhapHangDTO ctnh = new CTHDNhapHangDTO();

            ctnh.MaHDNH = Convert.ToInt32(txtMahh.Text);
            string tehh = txtTenHH.Text;
            ctnh.Dvt = lblDonvitinh.Text;
            ctnh.Sl = Convert.ToInt32(txtSoluong.Text);
            ctnh.DonGia = Convert.ToInt32(txtGiamua.Text);
            ctnh.ThanhTien = Convert.ToInt32(txtThanhtien.Text);
            string ghiChu = txtGhichu.Text;

            eventGetRow(ctnh, tehh, ghiChu);
        }
        bool kiemTraSoLuong()
        {
            try
            {
                if (txtSoluong.Text.Length > 0)
                {
                    if (txtSoluong.Text == "0")
                    {
                        erroColorSL();
                        lblThongBaoSL.Text = "Số lượng nhập vào ít nhất là 1 !";
                        return false;
                    }
                    if (Convert.ToInt32(txtSoluong.Text) > 0)
                    {
                        lblThongBaoSL.Text = "";
                        lblSL.ForeColor = Color.Black;
                        double a = Convert.ToDouble(txtSoluong.Text) * Convert.ToInt32(txtGiamua.Text);
                        txtThanhtien.Text = a.ToString();
                        return true;
                    }
                }
                else
                {
                    erroColorSL();
                    lblThongBaoSL.Text = "Chưa nhập Số Lượng !";
                    return false;
                }
            }
            catch { return false; }
            return true;
        }
        bool kiemTraGiaMua()
        {
            if (txtGiamua.Text.Length == 0)
            {
                lblThongbaogiamua.Text = "Chưa nhập giá bán !";
                lblGiamua.ForeColor = Color.Red;
                return false;
            }
            if (txtGiamua.Text.Length > 0)
            {
                lblGiamua.ForeColor = Color.Black;
                lblThongbaogiamua.Text = "";
                return true;
            }
            return true;
        }
        #endregion

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            dataSourceHangHoa();
            dtgThemHoaDon.Columns[1].Visible = false;
        }
        private void dtgThemHoaDon_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            layDuLieuTuHangHoa();
        }

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            timKiemHangHoa();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            kiemTraSoLuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraSoLuong() && kiemTraGiaMua())
            {
                eventDeThemHangHoaVaoHoaDon();
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                erroColorSL();
                lblThongBaoSL.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }

        private void dtgThemHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow iteam in dtgThemHoaDon.Rows)
            {
                iteam.Cells["Stt"].Value = iteam.Index + 1;
            }
        }

        private void txtGiamua_TextChanged(object sender, EventArgs e)
        {
            kiemTraGiaMua();
        }
    }
}
