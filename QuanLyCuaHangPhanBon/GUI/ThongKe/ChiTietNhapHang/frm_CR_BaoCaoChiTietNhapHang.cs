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
using CrystalDecisions.CrystalReports.Engine;
using GUI.ThongKe.ChiTietNhapHang;

namespace GUI.ThongKe.ChiTietNhapHang
{
    public partial class frm_CR_BaoCaoChiTietNhapHang : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;
        public frm_CR_BaoCaoChiTietNhapHang()
        {
            InitializeComponent();
        }


        public frm_CR_BaoCaoChiTietNhapHang(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoChiTietNhapHang_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoChiTietNhapHang(fromDate, toDate);
            cryBaoCaoChiTietNhapHang bc = new cryBaoCaoChiTietNhapHang();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }


    }
}
