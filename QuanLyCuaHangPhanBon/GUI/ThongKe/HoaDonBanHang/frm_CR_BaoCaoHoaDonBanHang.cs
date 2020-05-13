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
using GUI.ThongKe.HoaDonBanHang;

namespace GUI.ThongKe.HoaDonBanHang
{
    public partial class frm_CR_BaoCaoHoaDonBanHang : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;
        public frm_CR_BaoCaoHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frm_CR_BaoCaoHoaDonBanHang_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoHoaDonBanHang(fromDate, toDate);
            cryBaoCaoHoaDonBanHang bc = new cryBaoCaoHoaDonBanHang();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }

        public frm_CR_BaoCaoHoaDonBanHang(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }
    }
}
