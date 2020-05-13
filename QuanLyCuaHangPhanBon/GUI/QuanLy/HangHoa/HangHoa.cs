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
        void timkiem()
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
        void Stt()
        {
            try
            {
                for (int i = 0; i < dtgHangHoa.Rows.Count; i++)
                {
                    dtgHangHoa.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch { }
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            dtgHangHoa.DataSource = hanghoaBUS.GetData();
            Stt();
            dtgHangHoa.BackgroundColor = Color.Red;
            dtgHangHoa.ForeColor = Color.Green;
            dtgHangHoa.Columns[1].Width = 0;
            dtgHangHoa.Columns[0].Width = 40;
            dtgHangHoa.Columns[6].Width = 75;
            dtgHangHoa.Columns[2].Width = 150;
            dtgHangHoa.Columns[4].Width = 120;
            dtgHangHoa.Columns[5].Width = 120;
            dtgHangHoa.Columns[7].Width = 150;
            dtgHangHoa.RowHeadersWidth = 5;
            dtgHangHoa.EnableHeadersVisualStyles = false;
            dtgHangHoa.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
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
    }
}
