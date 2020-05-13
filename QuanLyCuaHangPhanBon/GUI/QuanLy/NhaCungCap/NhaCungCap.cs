using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.QuanLy.NhaCungCap
{
    public partial class NhaCungCap : Form
    {
        private NhaCungCapBUS nhaCungCapBUS = null;
        public NhaCungCap()
        {
            InitializeComponent();
            this.nhaCungCapBUS = NhaCungCapBUSImpl.Instance;
        }
        public void Stt()
        {
            try
            {
                for (int i = 0; i < dtgNhaCungCap.Rows.Count; i++)
                {
                    dtgNhaCungCap.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch { }
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dtgNhaCungCap.DataSource = nhaCungCapBUS.GetData();
            dtgNhaCungCap.BackgroundColor = Color.Red;
            dtgNhaCungCap.ForeColor = Color.Green;
            dtgNhaCungCap.Columns[1].Width = 0;
            dtgNhaCungCap.Columns[0].Width = 40;
            dtgNhaCungCap.Columns[2].Width = 170;
            dtgNhaCungCap.Columns[3].Width = 250;
            dtgNhaCungCap.Columns[5].Width = 120;
            dtgNhaCungCap.Columns[6].Width = 150;
            dtgNhaCungCap.RowHeadersWidth = 5;
            dtgNhaCungCap.EnableHeadersVisualStyles = false;
            dtgNhaCungCap.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dtgNhaCungCap.AllowUserToResizeColumns = false;
            Stt();
        }

        private void dtgNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                lblMa.Text = dtgNhaCungCap.Rows[dong].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void dtgNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtgNhaCungCap.CurrentRow.Selected = true;
            }
            catch { }
        }

        private void dtgNhaCungCap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgNhaCungCap.SelectedRows.Count != -1)
            {
                try
                {
                    int dong = e.RowIndex;
                    NhaCungCapDTO ncc = new NhaCungCapDTO();
                    ncc.MaNCC = Convert.ToInt32(dtgNhaCungCap.Rows[dong].Cells[1].Value.ToString());
                    ncc.TenNCC = dtgNhaCungCap.Rows[dong].Cells[2].Value.ToString();
                    ncc.DiaChi = dtgNhaCungCap.Rows[dong].Cells[3].Value.ToString();
                    ncc.Sdt = dtgNhaCungCap.Rows[dong].Cells[4].Value.ToString();
                    ncc.SoNo = Convert.ToDecimal(dtgNhaCungCap.Rows[dong].Cells[5].Value.ToString());
                    ncc.GhiChu = dtgNhaCungCap.Rows[dong].Cells[6].Value.ToString();
                    UpdateNCC updateNCC = new UpdateNCC(ncc);
                    updateNCC.ShowDialog();
                    NhaCungCap_Load(sender, e);
                }
                catch { }
            }
        }
        void timkiem()
        {
            if (comboBox1.Text == "Nhà Cung Cấp")
            {
                dtgNhaCungCap.DataSource = nhaCungCapBUS.SearchData(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Địa Chỉ")
            {
                dtgNhaCungCap.DataSource = nhaCungCapBUS.SearchData1(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "SĐT")
            {
                dtgNhaCungCap.DataSource = nhaCungCapBUS.SearchData2(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Số Nợ")
            {
                dtgNhaCungCap.DataSource = nhaCungCapBUS.SearchData3(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Ghi Chú")
            {
                dtgNhaCungCap.DataSource = nhaCungCapBUS.SearchData4(txtTimKiem.Text);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ThemNCC themNCC = new ThemNCC();
            themNCC.ShowDialog();
            NhaCungCap_Load(sender, e);
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblMa.Text);
            nhaCungCapBUS.DelData(a);
            NhaCungCap_Load(sender, e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frm_CR_BaoCaoNhaCungCap ncc = new frm_CR_BaoCaoNhaCungCap();
            ncc.Show();
        }
    }
}
