using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using GUI.ThongKe.XuatKho;
using System.Windows.Forms;

namespace GUI.ThongKe.XuatKho
{
    public partial class frm_CR_BaoCaoXuatKho : Form
    {
        private string fromDate, toDate;
        private ThongKeBUS thongKeBUS = null;
        public frm_CR_BaoCaoXuatKho()
        {
            InitializeComponent();
        }

        private void frm_CR_BaoCaoXuatKho_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.BaoCaoXuatKho(fromDate, toDate);
            cryXuatKho bc = new cryXuatKho();
            bc.SetDataSource(data);
            cryBaoCao.ReportSource = bc;
        }

        public frm_CR_BaoCaoXuatKho(string fromDate, string toDate) : this()
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.thongKeBUS = ThongKeBUSImpl.Instance;
        }
    }
}
