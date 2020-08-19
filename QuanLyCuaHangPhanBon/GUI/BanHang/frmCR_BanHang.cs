using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BanHang
{
    public partial class frmCR_BanHang : Form
    {
        public frmCR_BanHang()
        {
            InitializeComponent();
        }
        private void frmCR_BanHang_Load(object sender, EventArgs e)
        {
            using (DataBanHang data = new DataBanHang())
            {
                CR_BanHang cR_BanHang = new CR_BanHang();
                var result = data.sp_BillBanHang().ToList();
                CollectionHelper ch = new CollectionHelper();
                DataTable dt = ch.ConvertTo(result);
                cR_BanHang.SetDataSource(dt);
                crBanHang.ReportSource = cR_BanHang;
            }
        }
    }
}
