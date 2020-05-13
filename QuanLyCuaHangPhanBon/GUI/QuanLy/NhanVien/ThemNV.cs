using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.QuanLy.NhanVien
{
    public partial class ThemNV : Form
    {
        private NhanVienBUS nhanvienBUS = null;
        public ThemNV()
        {
            InitializeComponent();
            this.nhanvienBUS = NhanVienBUSImpl.Instance;
        }
        private void addData(NhanVienDTO nv)
        {
            nv.TenNV = txtTenNV.Text.Trim();
            nv.GioiTinh = cbGioiTinh.Text.Trim();
            try
            {
                nv.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.Trim());
            }
            catch { }
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.Sdt = txtSDT.Text.Trim();
            nv.GhiChu = txtGhiChu.Text.Trim();
        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            addData(nv);
            if (txtTenNV.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Tên Nhân Viên !";
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
            else if (cbGioiTinh.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa chọn Giới Tính !";
            }
            else
            {
                if (nhanvienBUS.AddData(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
