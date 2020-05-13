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
    public partial class UpdateNCC : Form
    {
        private NhaCungCapDTO nhacungcapDTO = null;
        private NhaCungCapBUS nhacungcapBUS = null;
        public UpdateNCC(NhaCungCapDTO ncc)
        {
            InitializeComponent();
            this.nhacungcapBUS = NhaCungCapBUSImpl.Instance;
            this.nhacungcapDTO = ncc;
        }

        private void btnSaveNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
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
                ncc.MaNCC = Convert.ToInt32(txtMaNCC.Text.Trim());
                ncc.TenNCC = txtTenNCC.Text.Trim();
                ncc.DiaChi = txtDiaChi.Text.Trim();
                ncc.Sdt = txtSDT.Text.Trim();
                ncc.SoNo = decimal.Parse(txtSoNo.Text.Trim());
                ncc.GhiChu = txtGhiChuS.Text.Trim();
                if (nhacungcapBUS.UpDateData(ncc))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật Lại đê bạn ơi,wrong rùi :>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Text = Convert.ToString(nhacungcapDTO.MaNCC);
            txtTenNCC.Text = nhacungcapDTO.TenNCC;
            txtDiaChi.Text = nhacungcapDTO.DiaChi;
            txtSDT.Text = nhacungcapDTO.Sdt;
            txtSoNo.Text = Convert.ToString(nhacungcapDTO.SoNo);
            txtGhiChuS.Text = nhacungcapDTO.GhiChu;
        }

        private void txtSoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                lblThongBao.Text = "Chỉ được nhập số!";
                e.Handled = true;
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
    }
}
