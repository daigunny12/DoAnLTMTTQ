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

namespace GUI.QuanLy.HangHoa
{
    public partial class frm_CR_BaoCaoHangHoa : Form
    {
        HangHoaBUS hangHoaBUS = null;
        public frm_CR_BaoCaoHangHoa()
        {
            InitializeComponent();
            hangHoaBUS = HangHoaBUSImpl.Instance;
        }

        private void frm_CR_BaoCaoHangHoa_Load(object sender, EventArgs e)
        {
            cryBaoCaoHangHoa cryBaoCaoHangHoa = new cryBaoCaoHangHoa();
            cryBaoCaoHangHoa.SetDataSource(hangHoaBUS.BaoCaoHangHoa());
            cryBaoCao.ReportSource = cryBaoCaoHangHoa;
        }
    }
}
