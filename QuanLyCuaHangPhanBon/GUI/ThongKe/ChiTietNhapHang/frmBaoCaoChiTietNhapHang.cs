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

namespace GUI.ThongKe.ChiTietNhapHang
{
    public partial class frmBaoCaoChiTietNhapHang : Form
    {
        private ThongKeBUS thongKeBUS = null;

        public frmBaoCaoChiTietNhapHang()
        {
            InitializeComponent();
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }

        private void btnXem_Click(object sender, EventArgs e)
            
        {
            string fromDate = dtpFromDate.Value.Date.ToString("yyyy-MM-dd");
            string toDate = dtpToDate.Value.Date.ToString("yyyy-MM-dd");

            if(dgvThongKe.Rows.Count < 2)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
            else
            {
                frm_CR_BaoCaoChiTietNhapHang frm = new frm_CR_BaoCaoChiTietNhapHang(fromDate, toDate);
                frm.Show();
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            string fromDate = dtpFromDate.Value.Date.ToString("yyyy-MM-dd");
            string toDate = dtpToDate.Value.Date.ToString("yyyy-MM-dd");

            dgvThongKe.DataSource = thongKeBUS.BaoCaoChiTietNhapHang(fromDate, toDate);
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            string fromDate = dtpFromDate.Value.Date.ToString("yyyy-MM-dd");
            string toDate = dtpToDate.Value.Date.ToString("yyyy-MM-dd");

            dgvThongKe.DataSource = thongKeBUS.BaoCaoChiTietNhapHang(fromDate, toDate);
        }
    }
}
