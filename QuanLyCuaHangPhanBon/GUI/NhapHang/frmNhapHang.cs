using DTO;
using GUI.QuanLy.NhaCungCap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhapHang
{
    public partial class frmNhapHang : Form
    {
        TaiKhoanDTO taiKhoanDTO = null;
        public delegate void deleGetRow(CTHDNhapHangDTO ctnh, string tenHH, string ghiChu);
        public delegate void deleGetUpdate(string sL, string giaMua);
        public delegate void delethanhToan(bool Luu);
        private ArrayList mangCTHD;
        public frmNhapHang()
        {
            InitializeComponent();
        }

        public frmNhapHang(TaiKhoanDTO taiKhoanDTO):this()
        {
            this.taiKhoanDTO = taiKhoanDTO;
        }

        #region methods
        void kiemTraRowTrungValue()
        {
            int colNumber = 1;
            for (int i = 0; i < dtgNhaphang.Rows.Count - 1; i++)
            {
                if (dtgNhaphang.Rows[i].IsNewRow) continue;
                string tmp = dtgNhaphang.Rows[i].Cells[colNumber].Value.ToString();
                for (int j = dtgNhaphang.Rows.Count - 1; j > i; j--)
                {
                    if (dtgNhaphang.Rows[j].IsNewRow) continue;
                    if (tmp == dtgNhaphang.Rows[j].Cells[colNumber].Value.ToString())
                    {
                        dtgNhaphang.Rows.RemoveAt(j);
                        MessageBox.Show("Hàng đã được thêm vào hóa đơn. Vui lòng tùy chỉnh hàng trong bảng hóa đơn !");
                    }
                }
            }
        }
        public void getRow(CTHDNhapHangDTO ctnh, string tenhh, string ghiChu)
        {
            DataGridViewRow row = (DataGridViewRow)dtgNhaphang.Rows[0].Clone();

            row.Cells[1].Value = ctnh.MaHDNH;
            row.Cells[2].Value = tenhh;
            row.Cells[3].Value = ctnh.Dvt;
            row.Cells[4].Value = ctnh.Sl;
            row.Cells[5].Value = ctnh.DonGia;
            row.Cells[6].Value = ctnh.ThanhTien;
            row.Cells[7].Value = ghiChu;
            dtgNhaphang.Rows.Add(row);
            kiemTraRowTrungValue();
        }
        public void getUpdate(string sL, string giaMua)
        {
            dtgNhaphang.CurrentRow.Cells[4].Value = sL;
            dtgNhaphang.CurrentRow.Cells[5].Value = giaMua;
        }
        void tinhTongTien()
        {
            int tong = 0;
            if (dtgNhaphang.Rows.Count == 1)
                lblTongcong.Text = tong.ToString();
            else
            {
                for (int row = 0; row < dtgNhaphang.Rows.Count - 1; row++)
                {
                    if (dtgNhaphang.Rows[row].Cells[6].Value != null)
                    {
                        tong += Convert.ToInt32(dtgNhaphang.Rows[row].Cells[6].Value);
                        lblTongcong.Text = tong.ToString();
                    }
                }
            }
        }
        void valueMember()
        {
            try
            {
                cbTenncc.ValueMember = "sdt";
                lblSdt.Text = cbTenncc.SelectedValue.ToString();
                cbTenncc.ValueMember = "DiaChi";
                lblDiachi.Text = cbTenncc.SelectedValue.ToString();
                cbTenncc.ValueMember = "GhiChu";
                lblGhichu.Text = cbTenncc.SelectedValue.ToString();
                cbTenncc.ValueMember = "SoNo";
                lblNocucuahang.Text = cbTenncc.SelectedValue.ToString();
            }
            catch { }
        }
        public void thanhToan(bool Luu)
        {
            if (Luu == true)
            {
                dtgNhaphang.Rows.Clear();
                thongTinNCC();
            }
        }
        void thongTinNCC()
        {
            using (DataNhapHang dt = new DataNhapHang())
            {
                cbTenncc.DataSource = dt.NhaCungCaps.Where(d => d.TinhTrang.Equals("True")).Select(d => d);
                cbTenncc.DisplayMember = "TenNCC";
            }
            valueMember();
        }
        #endregion
        private void btnResetHoaDon_Click(object sender, EventArgs e)
        {
            dtgNhaphang.Rows.Clear();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtgNhaphang.Columns[1].Visible = false;
            lblTenNV.Text = taiKhoanDTO.TenNV;
            if(taiKhoanDTO.ChucVu == true)
            {
                lblChucVu.Text = "Quản lý";
            }
            else
            {
                lblChucVu.Text = "Nhân viên";
            }
            thongTinNCC();

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            ThemHoaDon themHoaDon = new ThemHoaDon();
            themHoaDon.eventGetRow += getRow;
            themHoaDon.ShowDialog();
        }

        private void dtgNhaphang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // cập nhật stt khi add rows
            dtgNhaphang.Rows[e.RowIndex].Cells["Stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void dtgNhaphang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string tenHH = dtgNhaphang.SelectedCells[0].OwningRow.Cells["TenHH"].Value.ToString();
                string Sl = dtgNhaphang.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString();
                string giaMua = dtgNhaphang.SelectedCells[0].OwningRow.Cells["GiaMua"].Value.ToString();
                UpdateHoaDon uhd = new UpdateHoaDon(Sl, tenHH, giaMua);
                uhd.eventGetUpdate += getUpdate;
                uhd.ShowDialog();
            }
            catch { }
            // thay đổi giá trị SL cho bảng
        }

        private void dtgNhaphang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgNhaphang.CurrentRow.Cells[4].Value != null)
                    dtgNhaphang.CurrentRow.Cells[6].Value = Convert.ToInt32(dtgNhaphang.CurrentRow.Cells[4].Value) * Convert.ToInt32(dtgNhaphang.CurrentRow.Cells[5].Value);
                // cập nhật giá tiền khi số lượng thay đổi
            }
            catch { }
            
            //tong hh va tong sl trong hoa don
            lblTonghh.Text = (dtgNhaphang.Rows.Count - 1).ToString();
            int tong = 0;
            if (dtgNhaphang.Rows.Count == 1)
                lblTongsl.Text = tong.ToString();
            else
            {
                for (int row = 0; row < dtgNhaphang.Rows.Count - 1; row++)
                {
                    try
                    {
                        tong += Convert.ToInt32(dtgNhaphang.Rows[row].Cells[4].Value.ToString());
                        lblTongsl.Text = tong.ToString();
                    }
                    catch { }
                }
            }
            tinhTongTien();

            //enable false thanh toan neu khong co hang trong hoa don
            if (dtgNhaphang.Rows.Count < 2)
                btnThanhtoan.Enabled = false;
            else
                btnThanhtoan.Enabled = true;
        }

        private void cbTenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueMember();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            mangCTHD = new ArrayList();
            for (int i = 0; i < dtgNhaphang.Rows.Count - 1; i++)
            {

                CTHDNhapHangDTO cTHDNhap = new CTHDNhapHangDTO();
                cTHDNhap.SanPham = Convert.ToInt32(dtgNhaphang.Rows[i].Cells[1].Value.ToString());
                cTHDNhap.Sl = Convert.ToInt32(dtgNhaphang.Rows[i].Cells[4].Value.ToString());
                cTHDNhap.DonGia = Convert.ToDecimal(dtgNhaphang.Rows[i].Cells[5].Value.ToString());

                mangCTHD.Add(cTHDNhap);
            }
            try
            {
                cbTenncc.ValueMember = "MaNCC";
                int maNV = taiKhoanDTO.MaNV;
                string maNCC = cbTenncc.SelectedValue.ToString();
                string tenNCC = cbTenncc.Text;
                string tienHang = lblTongcong.Text;
                string noCuCuaHang = lblNocucuahang.Text;
                ThanhToan tt = new ThanhToan(tenNCC, tienHang, noCuCuaHang, maNCC, mangCTHD, maNV);
                tt.eventLuu += thanhToan;
                tt.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Tên nhà cung cấp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ThemNCC themNCC = new ThemNCC();
            themNCC.ShowDialog();
            thongTinNCC();
        }
    }
}
