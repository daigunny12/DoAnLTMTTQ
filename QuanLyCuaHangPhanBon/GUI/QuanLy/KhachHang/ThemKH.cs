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
    public partial class ThemKH : Form
    {
        private KhachHangBUS khachhangBus = null;
        public ThemKH()
        {
            InitializeComponent();
            this.khachhangBus = KhachHangBUSImpl.Instance;
        }
        private void addData(KhachHangDTO kh)
        {
            kh.TenKH = txtTenKH.Text.ToString().Trim();
            kh.DiaChi = txtDiaChi.Text.ToString().Trim();
            kh.Sdt = txtSDT.Text.ToString().Trim();
            try
            {
                kh.SoNo = Convert.ToDecimal(txtSoNo.Text.Trim());
            }
            catch { }
            kh.GhiChu = txtGhiChu.Text.ToString().Trim();
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            KhachHangDTO dto = new KhachHangDTO();
            addData(dto);
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
                if (khachhangBus.AddData(dto))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
