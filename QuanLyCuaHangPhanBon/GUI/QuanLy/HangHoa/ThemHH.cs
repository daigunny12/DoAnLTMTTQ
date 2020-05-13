using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.QuanLy.HangHoa
{
    public partial class ThemHH : Form
    {
        private HangHoaBUS hanghoaBUS = null;
        public ThemHH()
        {
            InitializeComponent();
            this.hanghoaBUS = HangHoaBUSImpl.Instance;
        }
        private void addData(HangHoaDTO hh)
        {
            hh.TeHH = txtTenHH.Text.Trim();
            hh.DonViTinh = txtDVT.Text.Trim();
            try
            {
                hh.GiaBan = Convert.ToDecimal(txtGiaBan.Text.Trim());
                hh.GiaMua = Convert.ToDecimal(txtGiaMua.Text.Trim());
            }
            catch { }
            hh.Sl = 0;
            hh.GhiChu = txtGhiChu.Text.Trim();
        }
        private void btnSaveHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaDTO dto = new HangHoaDTO();
            addData(dto);
            if (txtTenHH.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Tên Hàng Hóa !";
            }
            else if (txtDVT.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Đơn Vị Tính !";
            }
            else if (Convert.ToDecimal(txtGiaBan.Text.Length) <= 0)
            {
                lblThongBao.Text = "Chưa nhập Giá Bán !";
            }
            else if (Convert.ToDecimal(txtGiaMua.Text.Length) <= 0)
            {
                lblThongBao.Text = "Chưa nhập Giá Mua !";
            }
            else
            {
                if (hanghoaBUS.AddData(dto))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }
    }
}
