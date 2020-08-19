using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DTO;
using GUI.QuanLy.KhachHang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BanHang
{
    public partial class frmBanHang : Form
    {
        #region properties
        public delegate void deleGetRow(CTHDBanHangDTO bh, string tenHH, string ghiChu);
        public delegate void deleGetUpdate(string sL, string giaBan);
        public delegate void delethanhToan(bool Luu);

        private TaiKhoanDTO taiKhoanDTO = null;
        private ArrayList mangCTHD;
        #endregion
        public frmBanHang()
        {
            InitializeComponent();
        }

        public frmBanHang(TaiKhoanDTO taiKhoanDTO) : this()
        {
            this.taiKhoanDTO = taiKhoanDTO;
        }
        #region methods
        void kiemTraRowTrungValue()
        {
            int colNumber = 1;
            for (int i = 0; i < dtgBanHang.Rows.Count - 1; i++)
            {
                if (dtgBanHang.Rows[i].IsNewRow) continue;
                string tmp = dtgBanHang.Rows[i].Cells[colNumber].Value.ToString();
                for (int j = dtgBanHang.Rows.Count - 1; j > i; j--)
                {
                    if (dtgBanHang.Rows[j].IsNewRow) continue;
                    if (tmp == dtgBanHang.Rows[j].Cells[colNumber].Value.ToString())
                    {
                        dtgBanHang.Rows.RemoveAt(j);
                        MessageBox.Show("Hàng đã được thêm vào hóa đơn. Vui lòng tùy chỉnh hàng trong bảng hóa đơn !");
                    }
                }
            }
        }
        public void getRow(CTHDBanHangDTO ctbh, string tenhh, string ghiChu)
        {
            DataGridViewRow row = (DataGridViewRow)dtgBanHang.Rows[0].Clone();

            row.Cells[1].Value = ctbh.MaHDBH;
            row.Cells[2].Value = tenhh;
            row.Cells[3].Value = ctbh.Dvt;
            row.Cells[4].Value = ctbh.Sl;
            row.Cells[5].Value = ctbh.DonGia;
            row.Cells[6].Value = ctbh.ThanhTien;
            row.Cells[7].Value = ghiChu;
            dtgBanHang.Rows.Add(row);
            kiemTraRowTrungValue();
        }
        public void getUpdate(string sL, string giaBan)
        {
            dtgBanHang.CurrentRow.Cells[4].Value = sL;
            dtgBanHang.CurrentRow.Cells[5].Value = giaBan;
        }
        void tinhTongTien()
        {
            int tong = 0;
            if (dtgBanHang.Rows.Count == 1)
                lblTongcong.Text = tong.ToString();
            else
            {
                for (int row = 0; row < dtgBanHang.Rows.Count - 1; row++)
                {
                    if (dtgBanHang.Rows[row].Cells[6].Value != null)
                    {
                        tong += Convert.ToInt32(dtgBanHang.Rows[row].Cells[6].Value);
                        lblTongcong.Text = tong.ToString();
                    }
                }
            }
        }
        void valueMember()
        {
            try
            {
                cbTenkh.ValueMember = "sdt";
                lblSdt.Text = cbTenkh.SelectedValue.ToString();
                cbTenkh.ValueMember = "DiaChi";
                lblDiachi.Text = cbTenkh.SelectedValue.ToString();
                cbTenkh.ValueMember = "GhiChu";
                lblGhichu.Text = cbTenkh.SelectedValue.ToString();
                cbTenkh.ValueMember = "soNo";
                lblNocukh.Text = cbTenkh.SelectedValue.ToString();
            }
            catch { }
        }
        void thongTinKH()
        {
            using (DataBanHang dt = new DataBanHang())
            {
                cbTenkh.DataSource = dt.KhachHangs.Where(d => d.TinhTrang.Equals("True")).Select(d => d);
                cbTenkh.DisplayMember = "TenKH";

            }
            valueMember();
        }
        public void thanhToan(bool Luu)
        {
            if(Luu == true)
            {
                dtgBanHang.Rows.Clear();
                thongTinKH();
            }
        }
        #endregion

        private void BanHang_Load(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTenNV.Text = taiKhoanDTO.TenNV;
            if (taiKhoanDTO.ChucVu == true)
            {
                lblchucVu.Text = "Quản lý";
            }
            else
            {
                lblchucVu.Text = "Nhân viên";
            }
            dtgBanHang.Columns[1].Visible = false;
            thongTinKH();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            ThemHoaDon themHoaDon = new ThemHoaDon();
            themHoaDon.eventGetRow += getRow;
            themHoaDon.ShowDialog();
        }

        private void dtgBanHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // cập nhật stt khi add rows
            dtgBanHang.Rows[e.RowIndex].Cells["Stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void dtgBanHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgBanHang.CurrentRow.Cells[4].Value != null)
                    dtgBanHang.CurrentRow.Cells[6].Value = Convert.ToInt32(dtgBanHang.CurrentRow.Cells[4].Value) * Convert.ToInt32(dtgBanHang.CurrentRow.Cells[5].Value);
                // cập nhật giá tiền khi số lượng thay đổi
            }
            catch { }

            //tong hh va tong sl trong hoa don
            lblTonghh.Text = (dtgBanHang.Rows.Count - 1).ToString();
            int tong = 0;
            if (dtgBanHang.Rows.Count == 1)
                lblTongsl.Text = tong.ToString();
            else
            {
                for (int row = 0; row < dtgBanHang.Rows.Count - 1; row++)
                {
                    try
                    {
                        tong += Convert.ToInt32(dtgBanHang.Rows[row].Cells[4].Value.ToString());
                        lblTongsl.Text = tong.ToString();
                    }
                    catch { }
                }
            }
            tinhTongTien();

            //enable false thanh toan neu khong co hang trong hoa don
            if (dtgBanHang.Rows.Count < 2)
                btnThanhtoan.Enabled = false;
            else
                btnThanhtoan.Enabled = true;
        }

        private void dtgBanHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string maHH = dtgBanHang.SelectedCells[0].OwningRow.Cells["MaHH"].Value.ToString();
                string tenHH = dtgBanHang.SelectedCells[0].OwningRow.Cells["TenHH"].Value.ToString();
                string Sl = dtgBanHang.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString();
                string giaBan = dtgBanHang.SelectedCells[0].OwningRow.Cells["GiaBan"].Value.ToString();
                UpdateHoaDon uhd = new UpdateHoaDon(Sl,tenHH,maHH,giaBan);
                uhd.eventGetUpdate += getUpdate;
                uhd.ShowDialog();
            }
            catch { }
            // thay đổi giá trị SL cho bảng
        }

        private void btnResetHoaDon_Click(object sender, EventArgs e)
        {
            dtgBanHang.Rows.Clear();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            mangCTHD = new ArrayList();
            for (int i = 0; i < dtgBanHang.Rows.Count -1 ; i++)
            {
                
                CTHDBanHangDTO cTHDBan = new CTHDBanHangDTO();
                cTHDBan.SanPham = Convert.ToInt32(dtgBanHang.Rows[i].Cells[1].Value.ToString());
                cTHDBan.Sl = Convert.ToInt32( dtgBanHang.Rows[i].Cells[4].Value.ToString());
                cTHDBan.DonGia = Convert.ToDecimal(dtgBanHang.Rows[i].Cells[5].Value.ToString());
                
                mangCTHD.Add(cTHDBan);
            }
            try
            {
                cbTenkh.ValueMember = "MaKH";
                int maNV = taiKhoanDTO.MaNV;
                string maKH = cbTenkh.SelectedValue.ToString();
                string tenKH = cbTenkh.Text;
                string tienHang = lblTongcong.Text;
                string noCuKH = lblNocukh.Text;
                ThanhToan tt = new ThanhToan(tenKH, tienHang, noCuKH, maKH, mangCTHD, maNV);
                tt.eventLuu += thanhToan;
                tt.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Tên khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void cbTenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueMember();

        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            ThemKH themKH = new ThemKH();
            themKH.ShowDialog();
            thongTinKH();
        }
    }
}
