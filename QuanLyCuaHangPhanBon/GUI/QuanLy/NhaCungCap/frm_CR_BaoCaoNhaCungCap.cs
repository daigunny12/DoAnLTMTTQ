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

namespace GUI.QuanLy.NhaCungCap
{
    public partial class frm_CR_BaoCaoNhaCungCap : Form
    {
        NhaCungCapBUS nhaCungCapBUS = null;
        public frm_CR_BaoCaoNhaCungCap()
        {
            InitializeComponent();
            nhaCungCapBUS = NhaCungCapBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoNhaCungCap_Load(object sender, EventArgs e)
        {
            cryBaoCaoNhaCungCap cryBaoCaoNhaCungCap = new cryBaoCaoNhaCungCap();
            cryBaoCaoNhaCungCap.SetDataSource(nhaCungCapBUS.BaoCaoNhaCungCap());
            cryBaoCao.ReportSource = cryBaoCaoNhaCungCap;
        }
    }
}
