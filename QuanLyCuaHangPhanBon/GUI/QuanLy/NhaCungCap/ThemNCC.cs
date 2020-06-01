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

namespace GUI.QuanLy.NhaCungCap
{
    public partial class ThemNCC : Form
    {
        private NhaCungCapBUS nhacungcapBUS = null;
        public ThemNCC()
        {
            InitializeComponent();
            this.nhacungcapBUS = NhaCungCapBUSImpl.Instance;
        }
        private void addData(NhaCungCapDTO ncc)
        {
            ncc.TenNCC = txtTenNCC.Text.Trim();
            ncc.DiaChi = txtDiaChi.Text.Trim();
            ncc.Sdt = txtSDT.Text.Trim();
            try
            {
                ncc.SoNo = Convert.ToDecimal(txtSoNo.Text.Trim());
            }
            catch { }
            ncc.GhiChu = txtGhiChu.Text.Trim();
        }

        private void btnSaveNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            addData(ncc);
            if (txtTenNCC.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Tên Nhà Cung Cấp !";
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
            else if (txtSoNo.Text.Length <= 0)
            {
                lblThongBao.Text = "Chưa nhập Số Nợ !";
            }
            else
            {
                if (nhacungcapBUS.AddData(ncc))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }

        private void txtSoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
            }
        }
    }
}
