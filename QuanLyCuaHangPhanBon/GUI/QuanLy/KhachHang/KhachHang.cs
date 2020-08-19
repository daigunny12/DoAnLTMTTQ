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

namespace GUI.QuanLy.KhachHang
{
    public partial class KhachHang : Form
    {
        private KhachHangBUS khachHangBUS = null;
        public KhachHang()
        {
            InitializeComponent();
            this.khachHangBUS = KhachHangBUSImpl.Instance;
        }
        

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dtgKhachHang.DataSource = khachHangBUS.GetData();         
            dtgKhachHang.RowHeadersWidth = 10;
            dtgKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245);
            dtgKhachHang.Columns[1].Visible = false;
            dtgKhachHang.EnableHeadersVisualStyles = false;
            dtgKhachHang.AllowUserToResizeColumns = false;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKH themKH = new ThemKH();
            themKH.ShowDialog();
            KhachHang_Load(sender, e);
        }

        private void dtgKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtgKhachHang.CurrentRow.Selected = true;
            }
            catch { }
        }

        private void dtgKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                lblMa.Text = dtgKhachHang.Rows[dong].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void dtgKhachHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgKhachHang.SelectedRows.Count != -1)
            {
                try
                {
                    int dong = e.RowIndex;
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKH = Convert.ToInt32(dtgKhachHang.Rows[dong].Cells[1].Value.ToString());
                    kh.TenKH = dtgKhachHang.Rows[dong].Cells[2].Value.ToString();
                    kh.DiaChi = dtgKhachHang.Rows[dong].Cells[3].Value.ToString();
                    kh.Sdt = dtgKhachHang.Rows[dong].Cells[4].Value.ToString();
                    kh.SoNo = Convert.ToDecimal(dtgKhachHang.Rows[dong].Cells[5].Value.ToString());
                    kh.GhiChu = dtgKhachHang.Rows[dong].Cells[6].Value.ToString();
                    UpdateKH updateKH = new UpdateKH(kh);
                    updateKH.ShowDialog();
                    KhachHang_Load(sender, e);
                }
                catch { }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblMa.Text);
            khachHangBUS.DelData(a);
            KhachHang_Load(sender, e);
        }
        void timkiem()
        {
            if (comboBox1.Text == "Khách Hàng")
            {
                dtgKhachHang.DataSource = khachHangBUS.SearchData(txtKH.Text);
            }
            else if (comboBox1.Text == "Địa Chỉ")
            {
                dtgKhachHang.DataSource = khachHangBUS.SearchData1(txtKH.Text);
            }
            else if (comboBox1.Text == "SĐT")
            {
                dtgKhachHang.DataSource = khachHangBUS.SearchData2(txtKH.Text);
            }
            else if (comboBox1.Text == "Số Nợ")
            {
                dtgKhachHang.DataSource = khachHangBUS.SearchData3(txtKH.Text);
            }
            else if (comboBox1.Text == "Ghi Chú")
            {
                dtgKhachHang.DataSource = khachHangBUS.SearchData4(txtKH.Text);
            }
        }
        private void txtKH_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frm_CR_BaoCaoKhachHang kh = new frm_CR_BaoCaoKhachHang();
            kh.Show();
        }

        private void dtgKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dtgKhachHang.Rows)
            {
                r.Cells["soTT"].Value = r.Index + 1;
            }
        }

        private void dtgKhachHang_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dtgKhachHang.Rows[e.Row.Index].Cells["soTT"].Value = e.Row.Index + 1;
        }
    }
}
