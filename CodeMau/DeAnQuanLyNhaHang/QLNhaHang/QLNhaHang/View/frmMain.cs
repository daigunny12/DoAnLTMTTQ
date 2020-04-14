using QLNhaHang.crystalreport;
using QLNhaHang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHang
{
    public partial class frmMain : Form
    {
        #region Khai báo biến
        public string tmp;
        public string tmp1;
        public string dg;
        public string dg1;
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }
        public Form FormExist(String FormName)
        {
            foreach (Form frm in MdiChildren)
                if (frm.Name == FormName) return frm;
            return null;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = (frmNhanVien)FormExist("frmNhanVien");
            if (frm == null)
            {
                frm = new frmNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = (frmKhachHang)FormExist("frmKhachHang");
            if (frm == null)
            {
                frm = new frmKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuMonAn_Click(object sender, EventArgs e)
        {
            frmMonAn frm = (frmMonAn)FormExist("frmMonAn");
            if (frm == null)
            {
                frm = new frmMonAn();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = (frmHoaDon)FormExist("frmHoaDon");
            if (frm == null)
            {
                frm = new frmHoaDon();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            tmp1 = tmp;
            dg1 = dg;
        }

        private void mnuMonAnUaThich_Click(object sender, EventArgs e)
        {
            frmUaThich frm = (frmUaThich)FormExist("frmUaThich");
            if (frm == null)
            {
                frm = new frmUaThich();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Focus();
        }

        private void mnuDSNV_Click(object sender, EventArgs e)
        {
            frmDS_NhanVien frm = new frmDS_NhanVien();
            frm.Show();
        }
    }
}
