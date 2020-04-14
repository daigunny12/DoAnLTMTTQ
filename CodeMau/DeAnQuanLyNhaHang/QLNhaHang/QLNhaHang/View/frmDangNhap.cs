using QLNhaHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNhaHang.Object;

namespace QLNhaHang.View
{
    public partial class frmDangNhap : Form
    {
         public frmDangNhap()
        {
            InitializeComponent();
        }
        public void PhanQuyen(frmMain home, int a)
        {
            if (a == 1)
            {
                home.mnuHoaDon.Enabled = true;
                home.mnuDangXuat.Enabled = true;
                home.mnuMonAnUaThich.Enabled = true;
                home.mnuKhachHang.Enabled = true;

            }
            if (a == 2)
            {
                home.mnuKhachHang.Enabled = true;
                home.mnuMonAn.Enabled = true;
                home.mnuNhanVien.Enabled = true;
                home.mnuHoaDon.Enabled = true;
                home.mnuDangXuat.Enabled = true;
                home.mnuMonAnUaThich.Enabled = true;
            }
        }
        
       
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
            lblTaiKhoan.Parent = pictureBox1;
            lblTaiKhoan.BackColor = Color.Transparent;
            lblMatKhau.Parent = pictureBox1;
            lblMatKhau.BackColor = Color.Transparent;
        }

        //btn dang nhap
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text)) //kem tra rong 
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    String tk = txtTaiKhoan.Text;
                    String mk = txtMatKhau.Text;
                    DataTable log1 = new DataTable();
                    String sql = "Select MaNV, MatKhau from NhanVien Where MaNV='" + tk + "'and MatKhau='" + mk + "'";
                    log1 = DataProvider.GetData(sql);
                    int i = log1.Rows.Count;
                    int TuCach = 0;
                    String Str1 = tk.Substring(0, 2);
                    String str2 = tk;
                    if (Str1 == "NV" || Str1 == "nv" || Str1 == "Nv" || Str1 == "nV")
                    {
                        TuCach = 1;
                    }
                    if (Str1 == "QL" || Str1 == "ql" || Str1 == "qL" || Str1 == "Ql")
                    {
                        TuCach = 2;
                    }
                    if (i > 0)
                    {
                        frmHoaDon.NVLap = txtTaiKhoan.Text;
                        this.Hide();
                        frmMain home = new frmMain();
                        PhanQuyen(home, TuCach);
                        home.tmp = log1.Rows[0][0].ToString();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập/mật khẩu", "Mật khẩu");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Lỗi");
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Lỗi");
                txtTaiKhoan.Focus();
            }
        }

    private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
