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

namespace GUI.QuanLy.NhanVien
{
    public partial class UpdateNV : Form
    {
        private NhanVienBUS nhanvienBUS = null;
        private NhanVienDTO nhanvienDTO = null;
        public UpdateNV(NhanVienDTO nv)
        {
            InitializeComponent();
            this.nhanvienBUS = NhanVienBUSImpl.Instance;
            this.nhanvienDTO = nv;
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            if (txtTenNV.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Tên Nhân Viên !";
            }
            else if (cbGioiTinh.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa chọn Giới Tính !";
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
            else
            {
                nv.MaNV = Convert.ToInt32(txtMaNV.Text.Trim());
                nv.TenNV = txtTenNV.Text.Trim();
                nv.GioiTinh = cbGioiTinh.Text.Trim();
                nv.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.Trim());
                nv.DiaChi = txtDiaChi.Text.Trim();
                nv.Sdt = txtSDT.Text.Trim();
                nv.GhiChu = txtGhiChu.Text.Trim();
                if (nhanvienBUS.UpDateData(nv))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = nhanvienDTO.MaNV.ToString();
            txtTenNV.Text = nhanvienDTO.TenNV.ToString();
            cbGioiTinh.Text = nhanvienDTO.GioiTinh.ToString();
            dtpNgaySinh.Text = nhanvienDTO.NgaySinh.ToString();
            txtDiaChi.Text = nhanvienDTO.DiaChi.ToString();
            txtSDT.Text = nhanvienDTO.Sdt.ToString();
            txtGhiChu.Text = nhanvienDTO.GhiChu.ToString();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
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
