using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LogIn
{
    public partial class frmDoiPass : Form
    {
        private DangNhapBUS dangNhapBUS = null;
        private int maNV = 0 ;
        private string tenNV = null;

        public frmDoiPass()
        {
            InitializeComponent();
            this.dangNhapBUS = DangNhapBUSImpl.Instance;
        }

        public frmDoiPass(int maNV , string tenNV): this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKM.Text.Length > 0 || txtMKM.Text.Length > 0)
            {
                if (txtMKM.Text != txtmlMKM.Text)
                {
                    lblThongBao.Text = "Mật khẩu không khớp";
                }
                else
                {
                    if (!dangNhapBUS.UpdatePass(maNV, txtMKC.Text, txtMKM.Text))
                    {
                        lblThongBao.Text = "Mật khẩu cũ không đúng";
                    }
                    else
                    {
                        lblThongBao.Text = "Đổi mật khẩu thành công";
                    }
                }
            }
            else
            {
                lblThongBao.Text = "Chưa nhập mật khẩu";
            }
        }

        private void frmDoiPass_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = maNV.ToString();
            lblTenNV.Text = tenNV;
        }
    }
}
