using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.NhapHang.frmNhapHang;

namespace GUI.NhapHang
{
    public partial class UpdateHoaDon : Form
    {
        public event deleGetUpdate eventGetUpdate = null;
        private string sl = null;
        private string tenHH = null;
        private string giaMua = null;
        bool kiemTraSoLuong()
        {
            try
            {
                if (txtSl.Text == "0")
                {
                    lblThongbao.Text = "SL ít nhất phải là 1 !";
                    lblSl.ForeColor = Color.Red;
                    return false;
                }
                if (Convert.ToInt32(txtSl.Text) > 0)
                {
                    lblThongbao.Text = "";
                    lblSl.ForeColor = Color.Black;
                    return true;
                }
            }
            catch
            {
                lblThongbao.Text = "SL đang trống !";
                lblSl.ForeColor = Color.Red;
                return false;
            }
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
        public UpdateHoaDon(string sl, string tenHH, string giaMua)
        {
            InitializeComponent();
            this.sl = sl;
            this.tenHH = tenHH;
            this.giaMua = giaMua;
        }
        private void UpdateHoaDon_Load(object sender, EventArgs e)
        {
            lblTenhh.Text = tenHH;
            txtSl.Text = sl;
            txtGiamua.Text = giaMua;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraSoLuong() && kiemTraGiaMua())
            {
                string sL = txtSl.Text;
                string giaMua = txtGiamua.Text;
                eventGetUpdate(sL, giaMua);
                this.Close();
            }
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            kiemTraSoLuong();
        }

        private void txtGiamua_TextChanged(object sender, EventArgs e)
        {
            kiemTraGiaMua();
        }
    }
}
