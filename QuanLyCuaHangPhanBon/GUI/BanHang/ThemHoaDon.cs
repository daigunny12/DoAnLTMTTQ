using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.BanHang.frmBanHang;

namespace GUI.BanHang
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
            using (DataBanHang dthh = new DataBanHang())
            {
                dtgThemHoaDon.DataSource = from h in dthh.HangHoas
                                           where h.TinhTrang.Equals("True")
                                           select new
                                           {
                                               MaHH = h.MaHH,
                                               TenHH = h.TenHH,
                                               DonViTinh = h.DonViTinh,
                                               GiaBan = h.GiaBan,
                                               SoLuong = h.SoLuong,
                                               GhiChu = h.GhiChu
                                           };
            }
        }
        void timKiemHangHoa()
        {
            using (DataBanHang dthh = new DataBanHang())
            {
                dtgThemHoaDon.DataSource = from h in dthh.HangHoas
                                           where h.TinhTrang.Equals("True")
                                           select new
                                           {
                                               MaHH = h.MaHH,
                                               TenHH = h.TenHH,
                                               DonViTinh = h.DonViTinh,
                                               GiaBan = h.GiaBan,
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
            //txtSoluong.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString();
            lblDonvitinh.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["DonViTinh"].Value.ToString();
            txtGiaban.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["GiaBan"].Value.ToString();
            double a = Convert.ToDouble(txtSoluong.Text) * Convert.ToInt32(txtGiaban.Text);
            txtThanhtien.Text = a.ToString();
            txtGhichu.Text = dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["GhiChu"].Value.ToString();
        }
        void erroColorSL()
        {
            lblSL.ForeColor = Color.Red;
            txtThanhtien.Text = "";
        }
        bool kiemTraSLDaLaySoVoiSLBangHangHoa()
        {
            try
            {
                if (txtSoluong.Text.Length > 0)
                {
                    if (Convert.ToInt32(txtSoluong.Text) > Convert.ToInt32(dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString()))
                    {
                        erroColorSL();
                        lblThongBaoSL.Text = "Vượt quá số lượng kho !";
                        return false;
                    }
                    if (Convert.ToInt32(txtSoluong.Text) == 0)
                    {
                        lblThongBaoSL.Text = "Số lượng không hợp lệ !";
                        erroColorSL();
                        return false;
                    }
                    if (Convert.ToInt32(txtSoluong.Text) > 0 && Convert.ToInt32(txtSoluong.Text) <= Convert.ToInt32(dtgThemHoaDon.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString()))
                    {
                        double a = Convert.ToDouble(txtSoluong.Text) * Convert.ToInt32(txtGiaban.Text);
                        txtThanhtien.Text = a.ToString();
                        lblSL.ForeColor = Color.Black;
                        lblThongBaoSL.Text = "";
                        return true;
                    }
                }
                else
                {
                    lblThongBaoSL.Text = "Số lượng không được trống !";
                    erroColorSL();
                    return false;
                }
            }
            catch
            {
                kiemTraGiaBan();
                lblSL.ForeColor = Color.Black;
                lblThongBaoSL.Text = "";
                return false;
            }
            return true;
        }
        bool kiemTraGiaBan()
        {
            if (txtGiaban.Text.Length == 0)
            {
                lblThongbaogiaban.Text = "Chưa nhập giá bán !";
                lblGiaban.ForeColor = Color.Red;
                return false;
            }
            if (txtGiaban.Text.Length > 0)
            {
                lblGiaban.ForeColor = Color.Black;
                lblThongbaogiaban.Text = "";
                return true;
            }
            return true;
        }
        void eventDeThemHangHoaVaoHoaDon()
        {
            CTHDBanHangDTO ctbh = new CTHDBanHangDTO();

            ctbh.MaHDBH = Convert.ToInt32(txtMahh.Text);
            string tehh = txtTenHH.Text;
            ctbh.Dvt = lblDonvitinh.Text;
            ctbh.Sl = Convert.ToInt32(txtSoluong.Text);
            ctbh.DonGia = Convert.ToInt32(txtGiaban.Text);
            ctbh.ThanhTien = Convert.ToInt32(txtThanhtien.Text);
            string ghiChu = txtGhichu.Text;

            eventGetRow(ctbh, tehh, ghiChu);
        }
        #endregion

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            dataSourceHangHoa();
            dtgThemHoaDon.Columns[1].Visible = false;
        }

        private void dtgThemHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            layDuLieuTuHangHoa();
        }
        
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            timKiemHangHoa();
        }
              
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            kiemTraSLDaLaySoVoiSLBangHangHoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(kiemTraSLDaLaySoVoiSLBangHangHoa() && kiemTraGiaBan())
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

        private void txtGiaban_TextChanged(object sender, EventArgs e)
        {
            kiemTraGiaBan();
        }
    }
}
