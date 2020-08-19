using BUS;
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

namespace GUI.QuanLy.NhanVien
{
    public partial class frmThemTaiKhoan : Form
    {
        int maNV = 0;
        string tenNV = null;

        private DangNhapBUS dangNhapBUS = null;

        public frmThemTaiKhoan()
        {
            InitializeComponent();
            this.dangNhapBUS = DangNhapBUSImpl.Instance;
        }

        public frmThemTaiKhoan(int maNV, string tenNV):this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void btnthemTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txtTenDN.Text.Length <= 0)
            {
                lblThongBao.Text = "Bạn chưa nhập tên đăng nhập";
            }
            else
            {
                if (txtMK.Text.Length <= 0)
                {
                    lblThongBao.Text = "Bạn chưa nhập mật khẩu";
                }
                else
                {
                    if (txtMK.Text != txtmlMK.Text)
                    {
                        lblThongBao.Text = "Mật khẩu không khớp";
                    }
                    else
                    {
                        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                        taiKhoanDTO.MaNV = maNV;
                        taiKhoanDTO.TenDN = txtTenDN.Text;
                        taiKhoanDTO.MatKhau = txtMK.Text;
                        if(cbChucVu.Text == "Nhân viên")
                        {
                            taiKhoanDTO.ChucVu = false;
                        }
                        else
                        {
                            taiKhoanDTO.ChucVu = true;
                        }
                        if (dangNhapBUS.AddAccount(taiKhoanDTO))
                        {
                            MessageBox.Show("Tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = maNV.ToString();
            lblTenNV.Text = tenNV;
            cbChucVu.Text = "Nhân viên";
        }

        private void txtTenDN_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }
    }
}
