using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHang.Control;
using QLNhaHang.crystal_report;
using QLNhaHang.Object;

namespace QLNhaHang.View
{
    public partial class frmHoaDon : Form
    {

        HoaDonCtrl hdCtr = new HoaDonCtrl();
        ChiTietCtrl ctCtr = new ChiTietCtrl();
        KhachHangCtrl khCtr = new KhachHangCtrl();
        MonAnCtrl hhctr = new MonAnCtrl();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;

        public frmHoaDon()
        {
            InitializeComponent();
        }
        // tai du lieu tu dtgvDSHD sang cac txt
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }
        // tai du lieu tu dtgvDSMA sang cac txt
        private void bingding1()
        {
            try
            {
                txtDonGia.DataBindings.Clear();
                txtDonGia.DataBindings.Add("Text", dtgvDSMA.DataSource, "DonGia");
                nudSL.DataBindings.Clear();
                nudSL.DataBindings.Add("Text", dtgvDSMA.DataSource, "SoLuong");
                cmbMA.DataBindings.Clear();
                cmbMA.DataBindings.Add("Text", dtgvDSMA.DataSource, "MonAn");
                lbThanhTien.DataBindings.Clear();
                lbThanhTien.DataBindings.Add("Text", dtgvDSMA.DataSource, "ThanhTien");
                TongTien();
            }
            catch { return; }
        }
        // xet Enabled
        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVien.Enabled = e;
            cmbKhachHang.Enabled = e;
            btnAdd.Enabled = !e;
            btnDel.Enabled = !e;
            btnPrint.Enabled = !e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnCham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbMA.Enabled = e;
            nudSL.Enabled = e;
        }
        // xu ly LoadcmbKhachHang
        private void LoadcmbKhachHang()
        {
            KhachHangCtrl khctr = new KhachHangCtrl();
            cmbKhachHang.DataSource = khctr.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.SelectedIndex = 0;
            //KhachHangObj khObj = new KhachHangObj();
            //addData1(khObj);
            //Diem2 = khCtr.abbDiem(khObj);
        }
        // xu ly LoadcmbMA
        private void LoadcmbMA()
        {
            MonAnCtrl hhctr = new MonAnCtrl();
            cmbMA.DataSource = hhctr.GetData();
            cmbMA.DisplayMember = "TenMA";
            cmbMA.ValueMember = "MaMA";

        }

        // Xoa du lieu trong cac txt
        private void clearData()
        {
            txtMa.Text = "";
            txtNhanVien.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmbKhachHang();
        }

        private void addData(HoaDonObj hdObj)
        {

            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = txtNhanVien.Text;
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }
        // cap nhat diem
        public int Diem2 = 0;
        private void addData1(KhachHangObj khObj)
        {
            khObj.MaKH = cmbKhachHang.SelectedValue.ToString();
            khObj.Diem = Diem2 + 1;
        }

        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        public void TongTien()
        {
            double Tong = 0;
            for (int i = 0; i < dtgvDSMA.Rows.Count; i++)
            {
                Tong += double.Parse(dtgvDSMA.Rows[i].Cells["ThanhTien"].Value.ToString());
                lblTongTien.Text = Tong.ToString();
            }

        }

        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }




        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            bingding1();
            txtNgayLap.Enabled = false;
            //TongTien();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSMA.DataSource = dt;

            }
            catch
            {
                dtgvDSMA.DataSource = null;
            }
            bingding1();
        }

        // tao bien chen nhan vien lap
        public static string NVLap = string.Empty;
        public void ChenVNLap()
        {
            frmDangNhap frm = new frmDangNhap();
            if (!string.IsNullOrEmpty(NVLap))
                this.txtNhanVien.Text = NVLap;
            txtNhanVien.Enabled = false;
        }

        //ma tu dong
        public void MaTuDong()
        {
            int count = 0;
            count = dtgvDSHD.Rows.Count; // dem tat ca cac dong trong dtgv roi gan cho count
            if (count == 0)
                txtMa.Text = "HD001";
            else
            {
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dtgvDSHD.Rows[0].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2))); //loai bo ki tu trong chuoi
                if (chuoi2 + 1 < 10)
                    txtMa.Text = "HD00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMa.Text = "HD0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 1000)
                    txtMa.Text = "HD" + (chuoi2 + 1).ToString();
            }
            txtMa.Enabled = false;
        }
        // btn tao hoa don
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbMA();
            LoadcmbKhachHang();
            MaTuDong();
            ChenVNLap();
            dtDSCT.Columns.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("MonAn");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
            cmbMA.Text = "";
            txtDonGia.Text = "";
            nudSL.Text = "1";
        }

        // btn thay doi thoi gian
        private void btnCham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }

        //btn xoa hoa don
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHoaDon_Load(sender, e);
        }
        // btn luu hoa don
        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            KhachHangObj khObj = new KhachHangObj();
            addData1(khObj);
            if (hdCtr.AddData(hdObj))
            {
                if ((ctCtr.AddData(dtDSCT)))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    khCtr.UpdDiem(khObj);
                }
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmHoaDon_Load(sender, e);
        }

        //btn huy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmHoaDon_Load(sender, e);
            else
                return;
        }

        //btn in hoa don
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtgvDSMA.Rows.Count <= 0)
            {
                MessageBox.Show("Không có");
            }
            else
            {
                frm_TK_HoaDon frm = new frm_TK_HoaDon(txtMa.Text.ToString().Trim());
                frm.Show();
            }
        }

        //btn them mon an
        private void btnThem_Click(object sender, EventArgs e)
        {
            var index2 = cmbKhachHang.FindStringExact(cmbKhachHang.Text);// kiem tra có nhập sai combobox mon an hay không
            if (index2 > -1)
            {
                KhachHangObj khObj = new KhachHangObj();
                addData1(khObj);
                Diem2 = khCtr.abbDiem(khObj);


                if (!string.IsNullOrEmpty(cmbMA.Text))
                {
                    var index = cmbMA.FindStringExact(cmbMA.Text);// kiem tra có nhập sai combobox mon an hay không
                    if (index > -1)
                    {
                        if (!checktrung(cmbMA.SelectedValue.ToString()))// kiem tra mon 
                        {
                            try
                            {
                                DataRow dr = dtDSCT.NewRow();
                                dr[0] = txtMa.Text.Trim();
                                dr[1] = cmbMA.SelectedValue.ToString();
                                dr[2] = txtDonGia.Text;
                                dr[3] = nudSL.Text;
                                dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(nudSL.Text)).ToString();
                                dtDSCT.Rows.Add(dr);
                                if(dtDSCT != null && dtDSCT.Rows.Count != 0)
                                {
                                    for (int i = 0; i < dtDSCT.Rows.Count; i++)
                                    {
                                        if (dtDSCT.Rows[i][0].ToString().Equals(string.Empty))
                                        {
                                            dtDSCT.Rows.Remove(dtDSCT.Rows[i]);
                                            i = -1;
                                        }
                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                return;
                            }
                        }
                        else
                        {
                            capnhatSL(cmbMA.SelectedValue.ToString(), int.Parse(nudSL.Text));
                        }

                        dtgvDSMA.DataSource = dtDSCT;
                        cmbKhachHang.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(" nhập sai món ăn kia", "Lỗi");
                        cmbMA.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập món ăn", "Lỗi");
                    cmbMA.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập sai khách hàng kia ba", "Lỗi");
                cmbKhachHang.Focus();
            }
        }

        // btn bot mon an
        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSMA.DataSource = dtDSCT;
            }
        }

        private void cmbMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = hhctr.GetData("Where MaMA = '" + cmbMA.SelectedValue.ToString() + "'");
                double ChietKhau = 0;
                if (Diem2 >= 150)
                    ChietKhau = 0.85;
                else if (Diem2 >= 100)
                    ChietKhau = 0.9;
                else if (Diem2 >= 50)
                    ChietKhau = 0.95;
                else ChietKhau = 1;
                if (dt.Rows.Count > 0)
                {
                    double gia = double.Parse(dt.Rows[0][3].ToString());

                    txtDonGia.Text = (gia * ChietKhau).ToString();

                    lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(nudSL.Text)).ToString();
                }
            }
            catch { return; }
        }

        private void dtgvDSMA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriclick = e.RowIndex;
        }
    }
}
