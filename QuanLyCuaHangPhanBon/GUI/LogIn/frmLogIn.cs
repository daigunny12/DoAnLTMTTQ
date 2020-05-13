using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LogIn
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void txtTenDangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtTenDangNhap_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
