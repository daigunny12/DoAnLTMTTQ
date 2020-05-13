using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using GUI.ThongKe.NhapKho;
using System.Windows.Forms;

namespace GUI.ThongKe.NhapKho
{
    public partial class frm_CR_BaoCaoNhapKho : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;

        private void frm_CR_BaoCaoNhapKho_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoNhapKho(fromDate, toDate);
            cryNhapKho bc = new cryNhapKho();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }
        public frm_CR_BaoCaoNhapKho(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }
        public frm_CR_BaoCaoNhapKho()
        {
            InitializeComponent();
        }
    }
}
