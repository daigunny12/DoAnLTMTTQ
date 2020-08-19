using BUS;
using DTO;
using GUI.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI.LogIn
{
    public partial class frmLogIn : Form
    {
        DangNhapBUS dangNhapBUS = null;

        public frmLogIn()
        {
            InitializeComponent();
            this.dangNhapBUS = DangNhapBUSImpl.Instance;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            if(txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
            }    
            txtTenDangNhap.ForeColor = Color.FromArgb(128, 255, 255);
            pnDangNhap.BackColor = Color.FromArgb(0, 255, 0);

            txtMatKhau.ForeColor = Color.WhiteSmoke;
            pnPass.BackColor = Color.WhiteSmoke;
            if(txtMatKhau.Text.Length <= 0)
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Mật khẩu";
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
            }
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.ForeColor = Color.FromArgb(128, 255, 255);
            pnPass.BackColor = Color.FromArgb(0, 255, 0);

            txtTenDangNhap.ForeColor = Color.WhiteSmoke;
            pnDangNhap.BackColor = Color.WhiteSmoke;
            if (txtTenDangNhap.Text.Length  <=0)
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if(txtTenDangNhap.Text == "Tên đăng nhập" || txtTenDangNhap.Text.Length <= 0)
            {
                lblThongBao.Text = "Vui lòng nhập tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Red;
                pnDangNhap.BackColor = Color.Red;
            }
            else
            {
                if (txtMatKhau.Text == "Mật khẩu" || txtMatKhau.Text.Length <= 0)
                {
                    lblThongBao.Text = "Vui lòng nhập mật khẩu";
                    txtMatKhau.ForeColor = Color.Red;
                    pnPass.BackColor = Color.Red;
                }
                else
                {
                    DataTable datalog = dangNhapBUS.GetTK(txtTenDangNhap.Text, txtMatKhau.Text);
                    if(datalog.Rows.Count <= 0)
                    {
                        lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    }
                    else
                    {
                        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                        taiKhoanDTO.MaNV =Convert.ToInt32(datalog.Rows[0][0].ToString());
                        taiKhoanDTO.TenNV = datalog.Rows[0][1].ToString();
                        taiKhoanDTO.ChucVu = Convert.ToBoolean(datalog.Rows[0][2].ToString());
                        frmMain frm = new frmMain(taiKhoanDTO);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void frmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
