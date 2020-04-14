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

namespace GUI
{
    public partial class Form1 : Form
    {
        private NhanVienBUS nhanVienBUS = null;
        public Form1()
        {
            InitializeComponent();
            this.nhanVienBUS = NhanVienBUSImpl.Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanVienBUS.GetData();
        }
    }
}
