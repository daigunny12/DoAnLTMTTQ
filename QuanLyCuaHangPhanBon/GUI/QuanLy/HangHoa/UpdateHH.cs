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

namespace GUI.QuanLy.HangHoa
{
    public partial class UpdateHH : Form
    {
        private HangHoaDTO hhDTO = null;
        private HangHoaBUS hanghoaBUS = null;
        public UpdateHH(HangHoaDTO hh)
        {
            InitializeComponent();
            this.hanghoaBUS = HangHoaBUSImpl.Instance;
            this.hhDTO = hh;
        }

        private void frmUpdateHangHoa_Load(object sender, EventArgs e)
        {
            txtMaHH.Text = hhDTO.MaHH.ToString();
            txtTenHHS.Text = hhDTO.TeHH.ToString();
            txtDVTS.Text = hhDTO.DonViTinh.ToString();
            txtGiaBanS.Text = hhDTO.GiaBan.ToString();
            txtGiaMuaS.Text = hhDTO.GiaMua.ToString();
            txtGhiChuS.Text = hhDTO.GhiChu.ToString();
        }

        private void btnSaveHangHoaS_Click(object sender, EventArgs e)
        {
            HangHoaDTO hh = new HangHoaDTO();
            if (txtTenHHS.Text.Length <= 0)
            {
                lblThongBaoS.Text = "Chưa nhập Tên Hàng Hóa !";
            }
            else if (txtDVTS.Text.Length <= 0)
            {
                lblThongBaoS.Text = "Chưa nhập Đơn Vị Tính !";
            }
            else if (txtGiaBanS.Text.Length <= 0)
            {
                lblThongBaoS.Text = "Chưa nhập Giá Bán !";
            }
            else if (txtGiaMuaS.Text.Length <= 0)
            {
                lblThongBaoS.Text = "Chưa nhập Giá Mua !";
            }
            else
            {
                hh.MaHH = Convert.ToInt32(txtMaHH.Text);
                hh.TeHH = txtTenHHS.Text;
                hh.DonViTinh = txtDVTS.Text;
                hh.GiaBan = Convert.ToDecimal(txtGiaBanS.Text);
                hh.GiaMua = Convert.ToDecimal(txtGiaMuaS.Text);
                hh.GhiChu = txtGhiChuS.Text;
                if (hanghoaBUS.UpDateData(hh))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiaBanS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBaoS.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }

        private void txtGiaMuaS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBaoS.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }
    }
}
