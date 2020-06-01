using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanLy.KhachHang
{
    public partial class frm_CR_BaoCaoKhachHang : Form
    {
        KhachHangBUS khachHangBUS = null;
        public frm_CR_BaoCaoKhachHang()
        {
            InitializeComponent();
            khachHangBUS = KhachHangBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            cryBaoCaoKhachHang cryBaoCaoKhachHang = new cryBaoCaoKhachHang();
            cryBaoCaoKhachHang.SetDataSource(khachHangBUS.BaoCaoKhachHang());
            cryBaoCao.ReportSource = cryBaoCaoKhachHang;
        }
    }
}
