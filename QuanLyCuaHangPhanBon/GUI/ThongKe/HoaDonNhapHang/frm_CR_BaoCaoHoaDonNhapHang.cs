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
using GUI.ThongKe.HoaDonNhapHang;

namespace GUI.ThongKe.HoaDonNhapHang
{
    public partial class frm_CR_BaoCaoHoaDonNhapHang : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;
        public frm_CR_BaoCaoHoaDonNhapHang()
        {
            InitializeComponent();
        }
        public frm_CR_BaoCaoHoaDonNhapHang(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoHoaDonNhapHang_Load_1(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoHoaDonNhapHang(fromDate, toDate);
            cryBaoCaoHoaDonNhapHang bc = new cryBaoCaoHoaDonNhapHang();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }


       
    }
}
