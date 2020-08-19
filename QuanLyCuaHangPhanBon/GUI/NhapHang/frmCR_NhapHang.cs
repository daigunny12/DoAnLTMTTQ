using GUI.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhapHang
{
    public partial class frmCR_NhapHang : Form
    {
        public frmCR_NhapHang()
        {
            InitializeComponent();
        }

        private void frmCR_NhapHang_Load(object sender, EventArgs e)
        {
            using (DataNhapHang data = new DataNhapHang())
            {
                CR_NhapHang cR_NhapHang = new CR_NhapHang();
                var result = data.sp_BillNhapHang().ToList();
                CollectionHelper ch = new CollectionHelper();
                DataTable dt = ch.ConvertTo(result);
                cR_NhapHang.SetDataSource(dt);
                crNhapHang.ReportSource = cR_NhapHang;
            }
        }
    }
}
