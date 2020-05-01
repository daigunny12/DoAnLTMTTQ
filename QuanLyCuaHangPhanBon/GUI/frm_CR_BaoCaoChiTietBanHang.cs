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

namespace GUI
{
    public partial class frm_CR_BaoCaoChiTietBanHang : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;
        public frm_CR_BaoCaoChiTietBanHang()
        {
            InitializeComponent();
        }


        public frm_CR_BaoCaoChiTietBanHang(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoChiTietBanHang_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoChiTietBanHang(fromDate, toDate);
            cryBaoCaoChiTietBanHang bc = new cryBaoCaoChiTietBanHang();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }


    }
}
