﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.QuanLy.NhanVien
{
    public partial class NhanVien : Form
    {
        private DangNhapBUS dangNhapBUS = null;
        private NhanVienBUS nhanvienBUS = null;

        private string tenNVZZ = null;
        public NhanVien()
        {
            InitializeComponent();
            this.nhanvienBUS = NhanVienBUSImpl.Instance;
            this.dangNhapBUS = DangNhapBUSImpl.Instance;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dtgNhanVien.DataSource = nhanvienBUS.GetData();
            dtgNhanVien.Columns[1].Visible = false;      
            dtgNhanVien.RowHeadersWidth = 10;
            dtgNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 245);
            dtgNhanVien.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgNhanVien.EnableHeadersVisualStyles = false;
            dtgNhanVien.AllowUserToResizeColumns = false;
            lblMa.Text = dtgNhanVien.Rows[0].Cells[1].Value.ToString();
            tenNVZZ = dtgNhanVien.Rows[0].Cells[2].Value.ToString();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemNV themNV = new ThemNV();
            themNV.ShowDialog();
            NhanVien_Load(sender, e);
        }

        private void dtgNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtgNhanVien.CurrentRow.Selected = true;
            }
            catch { }
        }

        private void dtgNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                lblMa.Text = dtgNhanVien.Rows[dong].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void dtgNhanVien_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count != -1)
            {
                try
                {
                    int dong = e.RowIndex;
                    NhanVienDTO nv = new NhanVienDTO();
                    tenNVZZ = dtgNhanVien.Rows[dong].Cells[2].Value.ToString();
                    nv.MaNV = Convert.ToInt32(dtgNhanVien.Rows[dong].Cells[1].Value.ToString());
                    nv.TenNV = dtgNhanVien.Rows[dong].Cells[2].Value.ToString();
                    nv.GioiTinh = dtgNhanVien.Rows[dong].Cells[3].Value.ToString();
                    nv.NgaySinh = Convert.ToDateTime(dtgNhanVien.Rows[dong].Cells[4].Value.ToString());
                    nv.DiaChi = dtgNhanVien.Rows[dong].Cells[5].Value.ToString();
                    nv.Sdt = dtgNhanVien.Rows[dong].Cells[6].Value.ToString();
                    nv.GhiChu = dtgNhanVien.Rows[dong].Cells[7].Value.ToString();
                    UpdateNV updateNV = new UpdateNV(nv);
                    updateNV.ShowDialog();
                    NhanVien_Load(sender, e);
                }
                catch { }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblMa.Text);
            nhanvienBUS.DelData(a);
            NhanVien_Load(sender, e);
        }
        void timkiem()
        {
            if (comboBox1.Text == "Nhân Viên")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Giới Tính")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData1(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Ngày Sinh")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData2(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Địa Chỉ")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData3(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "SĐT")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData4(txtTimKiem.Text);
            }
            else if (comboBox1.Text == "Ghi Chú")
            {
                dtgNhanVien.DataSource = nhanvienBUS.SearchData5(txtTimKiem.Text);
            }
        }
            private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frm_CR_BaoCaoNhanVien nv = new frm_CR_BaoCaoNhanVien();
            nv.Show();        }

        private void dtgNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dtgNhanVien.Rows)
            {
                r.Cells["soTT"].Value = r.Index + 1;
            }
        }

        private void dtgNhanVien_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dtgNhanVien.Rows[e.Row.Index].Cells["soTT"].Value = e.Row.Index + 1;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblMa.Text);
            if (dangNhapBUS.CheckTK(a).Rows.Count > 0)
            {
                MessageBox.Show("Nhân viên đã có tài khoản", "Thông báo!");
            }
            else
            {
                frmThemTaiKhoan frmThemTaiKhoan = new frmThemTaiKhoan(a, tenNVZZ);
                frmThemTaiKhoan.ShowDialog();
            }
            
        }
    }
}
