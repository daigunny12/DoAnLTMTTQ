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
    public partial class UpdateHoaDon : Form
    {
        public event deleGetUpdate eventGetUpdate = null;
        private string sl = null;
        private string tenHH = null;
        private string maHH = null;
        private string giaBan = null;

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
        bool kiemTraSoLuong()
        {
            using (DataBanHang data = new DataBanHang())
            {
                try
                {
                    var a = data.HangHoas.Where(d => d.MaHH.Equals(maHH)).Select(d => d.SoLuong);
                    if (Convert.ToInt32(txtSl.Text) > Convert.ToInt32(a.FirstOrDefault()))
                    {
                        lblSl.ForeColor = Color.Red;
                        lblThongbao.Text = "Vượt quá SL trong kho !";
                        return false;
                    }
                    if (Convert.ToInt32(txtSl.Text) == 0)
                    {
                        lblSl.ForeColor = Color.Red;
                        lblThongbao.Text = "SL ít nhất phải là 1 !";
                        return false;
                    }
                    if (Convert.ToInt32(txtSl.Text) <= Convert.ToInt32(a.FirstOrDefault()) && Convert.ToInt32(txtSl.Text) > 0)
                    {
                        lblSl.ForeColor = Color.Black;
                        lblThongbao.Text = "";
                        return true;
                    }
                }
                catch
                {
                    lblSl.ForeColor = Color.Red;
                    lblThongbao.Text = "SL đang trống !";
                    return false;
                }
            }
            return true;
        }
        public UpdateHoaDon(string sl, string tenHH, string maHH, string giaBan)
        {
            InitializeComponent();
            this.sl = sl;
            this.tenHH = tenHH;
            this.maHH = maHH;
            this.giaBan = giaBan;
        }

        private void UpdateHoaDon_Load(object sender, EventArgs e)
        {
            lblThongbao.ForeColor = Color.Red;
            lblMahh.Text = maHH;
            lblTenhh.Text = tenHH;
            txtSl.Text = sl;
            txtGiaban.Text = giaBan;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraSoLuong() && kiemTraGiaBan()) 
            {
                string sL = txtSl.Text;
                string giaBan = txtGiaban.Text;
                eventGetUpdate(sL, giaBan);
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

        private void txtGiaban_TextChanged(object sender, EventArgs e)
        {
            kiemTraGiaBan();
        }

        private void lblGiaban_Click(object sender, EventArgs e)
        {

        }

        private void lblThongbaogiaban_Click(object sender, EventArgs e)
        {

        }
    }
}
