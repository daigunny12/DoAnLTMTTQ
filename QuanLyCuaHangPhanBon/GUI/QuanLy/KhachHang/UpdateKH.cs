using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.QuanLy.KhachHang
{
    public partial class UpdateKH : Form
    {
        private KhachHangDTO khachhangDTO = null;
        private KhachHangBUS khachhangBUS = null;
        public UpdateKH(KhachHangDTO kh)
        {
            InitializeComponent();
            this.khachhangBUS = KhachHangBUSImpl.Instance;
            this.khachhangDTO = kh;
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            if (txtTenKH.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Tên Khách Hàng !";
            }
            else if (txtDiaChi.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Địa Chỉ !";
            }
            else if (txtSDT.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập SĐT !";
            }
            else if (txtSDT.Text.Length < 10)
            {
                lblThongBao.Text = "SĐT nhập chưa đủ số !";
            }
            else if (txtSoNo.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Số Nợ !";
            }
            else
            {
                kh.MaKH = Convert.ToInt32(txtMaKH.Text.Trim());
                kh.TenKH = txtTenKH.Text.Trim();
                kh.DiaChi = txtDiaChi.Text.Trim();
                kh.Sdt = txtSDT.Text.ToString().Trim();
                kh.SoNo = Convert.ToDecimal(txtSoNo.Text.Trim());
                kh.GhiChu = txtGhiChuS.Text.Trim();
                if (khachhangBUS.UpDateData(kh))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateKH_Load(object sender, EventArgs e)
        {
                txtMaKH.Text = khachhangDTO.MaKH.ToString();
                txtTenKH.Text = khachhangDTO.TenKH.ToString();
                txtDiaChi.Text = khachhangDTO.DiaChi.ToString();
                txtSDT.Text = khachhangDTO.Sdt.ToString();
                txtSoNo.Text = khachhangDTO.SoNo.ToString();
                txtGhiChuS.Text = khachhangDTO.GhiChu.ToString();
        }

        private void txtSoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }
    }
}
