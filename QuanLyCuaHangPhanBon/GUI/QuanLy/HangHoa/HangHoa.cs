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
    public partial class HangHoa : Form
    {
        private HangHoaBUS hanghoaBUS = null;
        public HangHoa()
        {
            InitializeComponent();
            this.hanghoaBUS = HangHoaBUSImpl.Instance;
        }
        private void timkiem()
        {
             if (comboBox1.Text == "Sản Phẩm")
             {
                 dtgHangHoa.DataSource = hanghoaBUS.SearchData(textBox1.Text);
             }
             else if (comboBox1.Text == "Đơn Vị Tính")
             {
                 dtgHangHoa.DataSource = hanghoaBUS.SearchData1(textBox1.Text);         
             }
             else if (comboBox1.Text == "Giá Bán")
             {
                 dtgHangHoa.DataSource = hanghoaBUS.SearchData2(textBox1.Text);
             }
             else if (comboBox1.Text == "Giá Mua")
             {
                dtgHangHoa.DataSource = hanghoaBUS.SearchData3(textBox1.Text);
             }
             else if (comboBox1.Text == "SL")
             {
                dtgHangHoa.DataSource = hanghoaBUS.SearchData4(textBox1.Text);
             }
             else if (comboBox1.Text == "Ghi Chú")
             {
                dtgHangHoa.DataSource = hanghoaBUS.SearchData5(textBox1.Text);
             }
        }
            
        private void HangHoa_Load(object sender, EventArgs e)
        {
            dtgHangHoa.DataSource = hanghoaBUS.GetData();
            dtgHangHoa.Columns[1].Visible = false;
            dtgHangHoa.RowHeadersWidth = 10;
            dtgHangHoa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245);
            dtgHangHoa.EnableHeadersVisualStyles = false;
            dtgHangHoa.AllowUserToResizeColumns = false;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ThemHH themhh = new ThemHH();
            themhh.ShowDialog();
            HangHoa_Load(sender, e);
        }

        private void dtgHangHoa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgHangHoa.SelectedRows.Count != -1)
            {
                try
                {
                    int dong = e.RowIndex;
                    HangHoaDTO hh = new HangHoaDTO();
                    hh.MaHH = Convert.ToInt32(dtgHangHoa.Rows[dong].Cells[1].Value.ToString());
                    hh.TeHH = dtgHangHoa.Rows[dong].Cells[2].Value.ToString();
                    hh.DonViTinh = dtgHangHoa.Rows[dong].Cells[3].Value.ToString();
                    hh.GiaBan = Convert.ToDecimal(dtgHangHoa.Rows[dong].Cells[4].Value.ToString());
                    hh.GiaMua = Convert.ToDecimal(dtgHangHoa.Rows[dong].Cells[5].Value.ToString());
                    hh.GhiChu = dtgHangHoa.Rows[dong].Cells[7].Value.ToString();
                UpdateHH frmUpdateHangHoa = new UpdateHH(hh);
                frmUpdateHangHoa.ShowDialog();
                HangHoa_Load(sender, e);
                }
                catch { }
            }

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblMa.Text);
            hanghoaBUS.DelData(a);
            HangHoa_Load(sender, e);
        }
        private void dtgHangHoa_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            int dong = e.RowIndex;
            try
            {
                lblMa.Text = dtgHangHoa.Rows[dong].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void dtgHangHoa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtgHangHoa.CurrentRow.Selected = true;
            }
            catch { }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frm_CR_BaoCaoHangHoa hh = new frm_CR_BaoCaoHangHoa();
            hh.Show();
        }

        private void dtgHangHoa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dtgHangHoa.Rows)
            {
                r.Cells["soTT"].Value = r.Index + 1;
            }
        }

        private void dtgHangHoa_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dtgHangHoa.Rows[e.Row.Index].Cells["soTT"].Value = e.Row.Index + 1;
        }
    }
}
