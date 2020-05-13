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

namespace GUI.QuanLy.NhanVien
{
    public partial class frm_CR_BaoCaoNhanVien : Form
    {
        NhanVienBUS nhanVienBUS = null;
        public frm_CR_BaoCaoNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = NhanVienBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            cryBaoCaoNhanVien cryBaoCaoNhanVien = new cryBaoCaoNhanVien();
            cryBaoCaoNhanVien.SetDataSource(nhanVienBUS.BaoCaoNhanVien());
            cryBaoCao.ReportSource = cryBaoCaoNhanVien;
        }
    }
}
