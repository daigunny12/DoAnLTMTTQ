using GUI.BanHang;
using GUI.NhapHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ThongKe.BaoCaoTongHop
{
    public partial class frmBaoCaoTongHop : Form
    {
        public frmBaoCaoTongHop()
        {
            InitializeComponent();
        }
        #region methods
        void banHangToday()
        {
            using (DataBanHang dt = new DataBanHang())
            {
                var tongHoaDonToDay = (from hdbh in dt.HoaDonBanHangs
                                       where hdbh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                       select hdbh.MaHDB).Count();
                lblBanHangToday.Text = "BÁN HÀNG (" + tongHoaDonToDay + " hóa đơn)";
                // Tổng Hóa đơn hôm nay
                if (tongHoaDonToDay != 0)
                {
                    var tongTienHoaDonToday = (from hdbh in dt.HoaDonBanHangs
                                               join ctbh in dt.CTHDBanHangs on hdbh.MaHDB equals ctbh.MaHDB
                                               where hdbh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                               select (ctbh.SL * ctbh.DonGia) - ((ctbh.SL * ctbh.DonGia) * (hdbh.CK / 100))).Sum();

                    var tongTienHoaDonToday1 = (from hdbh in dt.HoaDonBanHangs
                                                where hdbh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                                select hdbh.NoCu).Sum();

                    double tongTienHDToday = tongTienHoaDonToday.Value + tongTienHoaDonToday1.Value;
                    lblBantongcongToday.Text = Math.Round(tongTienHDToday, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn hôm nay

                    var tienThuToDay = (from hdbh in dt.HoaDonBanHangs
                                        where hdbh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                        select hdbh.TienTra).Sum();
                    lblBandathuToday.Text = tienThuToDay.ToString();
                    // tổng tiền đã thu của kh hôm nay

                    lblBanconnoToday.Text = (Convert.ToInt32(lblBantongcongToday.Text) - Convert.ToInt32(lblBandathuToday.Text)).ToString();
                    // tong tiền các kh còn nợ lại hôm nay
                }
                else
                {
                    lblBantongcongToday.Text = "0";
                    lblBandathuToday.Text = "0";
                    lblBanconnoToday.Text = "0";
                }
            }
        }
        void nhapHangToday()
        {
            using (DataNhapHang dt = new DataNhapHang())
            {
                var tongHoaDonToDay = (from hdnh in dt.HoaDonNhapHangs
                                       where hdnh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                       select hdnh.MaHDN).Count();
                lblNhaphangToday.Text = "NHẬP HÀNG (" + tongHoaDonToDay + " hóa đơn)";
                // Tổng Hóa đơn hôm nay
                if (tongHoaDonToDay != 0)
                {
                    var tongTienHoaDonToday = (from hdnh in dt.HoaDonNhapHangs
                                               join ctnh in dt.CTHDNhapHangs on hdnh.MaHDN equals ctnh.MaHDN
                                               where hdnh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                               select (ctnh.SL * ctnh.DonGia) - ((ctnh.SL * ctnh.DonGia) * (hdnh.CK / 100))).Sum();

                    var tongTienHoaDonToday1 = (from hdnh in dt.HoaDonNhapHangs
                                                where hdnh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                                select hdnh.NoCu).Sum();

                    double tongTienHDToday = tongTienHoaDonToday.Value + tongTienHoaDonToday1.Value;
                    lblNhaptongcongToday.Text = Math.Round(tongTienHDToday, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn hôm nay

                    var tienTraToDay = (from hdnh in dt.HoaDonNhapHangs
                                        where hdnh.NgayLap.Equals(DateTime.Now.ToString("yyyy-MM-dd"))
                                        select hdnh.TienTra).Sum();
                    lblNhapdatraToday.Text = tienTraToDay.ToString();
                    // tổng tiền đã trả của cửa hàng hôm nay

                    lblNhapconnoToday.Text = (Convert.ToInt32(lblNhaptongcongToday.Text) - Convert.ToInt32(lblNhapdatraToday.Text)).ToString();
                    // tong tiền các kh còn nợ lại hôm nay
                }
                else
                {
                    lblNhaptongcongToday.Text = "0";
                    lblNhapdatraToday.Text = "0";
                    lblNhapconnoToday.Text = "0";
                }
            }
        }
        void banHangYesterday()
        {
            using (DataBanHang dt = new DataBanHang())
            {
                var tongHoaDonYesterday = (from hdbh in dt.HoaDonBanHangs
                                           where hdbh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                           select hdbh.MaHDB).Count();
                lblBanhangYesterday.Text = "BÁN HÀNG (" + tongHoaDonYesterday + " hóa đơn)";
                // Tổng Hóa đơn hôm qua
                if (tongHoaDonYesterday != 0)
                {
                    var tongTienHoaDonYesterday = (from hdbh in dt.HoaDonBanHangs
                                                   join ctbh in dt.CTHDBanHangs on hdbh.MaHDB equals ctbh.MaHDB
                                                   where hdbh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                                   select (ctbh.SL * ctbh.DonGia) - ((ctbh.SL * ctbh.DonGia) * (hdbh.CK / 100))).Sum();

                    var tongTienHoaDonYesterday1 = (from hdbh in dt.HoaDonBanHangs
                                                    where hdbh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                                    select hdbh.NoCu).Sum();

                    double tongTienHDYesterday = tongTienHoaDonYesterday.Value + tongTienHoaDonYesterday1.Value;
                    lblBantongcongYesterday.Text = Math.Round(tongTienHDYesterday, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn hôm qua

                    var tienThuYesterday = (from hdbh in dt.HoaDonBanHangs
                                            where hdbh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                            select hdbh.TienTra).Sum();
                    lblBandathuYesterday.Text = tienThuYesterday.ToString();
                    // tổng tiền đã thu của kh hôm qua

                    lblBanconnoYesterday.Text = (Convert.ToInt32(lblBantongcongYesterday.Text) - Convert.ToInt32(lblBandathuYesterday.Text)).ToString();
                    // tổng tiền các kh còn nợ lại hôm qua
                }
                else
                {
                    lblBantongcongYesterday.Text = "0";
                    lblBandathuYesterday.Text = "0";
                    lblBanconnoYesterday.Text = "0";
                }
            }
        }
        void nhapHangYesterday()
        {
            using (DataNhapHang dt = new DataNhapHang())
            {
                var tongHoaDonYesterday = (from hdnh in dt.HoaDonNhapHangs
                                           where hdnh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                           select hdnh.MaHDN).Count();
                lblNhaphangYesterday.Text = "NHẬP HÀNG (" + tongHoaDonYesterday + " hóa đơn)";
                // Tổng Hóa đơn hôm qua
                if (tongHoaDonYesterday != 0)
                {
                    var tongTienHoaDonYesterday = (from hdnh in dt.HoaDonNhapHangs
                                                   join ctnh in dt.CTHDNhapHangs on hdnh.MaHDN equals ctnh.MaHDN
                                                   where hdnh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                                   select (ctnh.SL * ctnh.DonGia) - ((ctnh.SL * ctnh.DonGia) * (hdnh.CK / 100))).Sum();

                    var tongTienHoaDonYesterday1 = (from hdnh in dt.HoaDonNhapHangs
                                                    where hdnh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                                    select hdnh.NoCu).Sum();

                    double tongTienHDYesterday = tongTienHoaDonYesterday.Value + tongTienHoaDonYesterday1.Value;
                    lblNhaptongcongYesterday.Text = Math.Round(tongTienHDYesterday, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn hôm qua

                    var tienTraYesterday = (from hdnh in dt.HoaDonNhapHangs
                                            where hdnh.NgayLap.Equals(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"))
                                            select hdnh.TienTra).Sum();
                    lblNhapdatraYesterday.Text = tienTraYesterday.ToString();
                    // tổng tiền đã trả của cửa hàng hôm qua

                    lblNhapconnoYesterday.Text = (Convert.ToInt32(lblNhaptongcongYesterday.Text) - Convert.ToInt32(lblNhapdatraYesterday.Text)).ToString();
                    // tong tiền các kh còn nợ lại hôm qua
                }
                else
                {
                    lblNhaptongcongYesterday.Text = "0";
                    lblNhapdatraYesterday.Text = "0";
                    lblNhapconnoYesterday.Text = "0";
                }
            }
        }
        void banHangFromdateTodate()
        {
            using (DataBanHang dt = new DataBanHang())
            {
                var tongHoaDon = (from hdbh in dt.HoaDonBanHangs
                                  where hdbh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                  where hdbh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                  select hdbh.MaHDB).Count();
                lblBanhang.Text = "BÁN HÀNG (" + tongHoaDon + " hóa đơn)";
                // Tổng Hóa đơn
                if (tongHoaDon != 0)
                {
                    var tongTienHoaDon = (from hdbh in dt.HoaDonBanHangs
                                          join ctbh in dt.CTHDBanHangs on hdbh.MaHDB equals ctbh.MaHDB
                                          where hdbh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                          where hdbh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                          select (ctbh.SL * ctbh.DonGia) - ((ctbh.SL * ctbh.DonGia) * (hdbh.CK / 100))).Sum();
                    var tongTienHoaDon1 = (from hdbh in dt.HoaDonBanHangs
                                           where hdbh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                           where hdbh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                           select hdbh.NoCu).Sum();

                    double tongTienHD = tongTienHoaDon1.Value + tongTienHoaDon.Value;
                    lblBantongcong.Text = Math.Round(tongTienHD, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn

                    var tienThu = (from hdbh in dt.HoaDonBanHangs
                                   where hdbh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                   where hdbh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                   select hdbh.TienTra).Sum();
                    lblBandathu.Text = tienThu.ToString();
                    // tổng tiền đã thu của kh 

                    lblBanconno.Text = (Convert.ToDouble(lblBantongcong.Text) - Convert.ToDouble(lblBandathu.Text)).ToString();
                    // tong tiền các kh còn nợ lại
                }
                else
                {
                    lblBantongcong.Text = "0";
                    lblBandathu.Text = "0";
                    lblBanconno.Text = "0";
                }
            }
        }
        void nhapHangFromdateTodate()
        {
            using (DataNhapHang dt = new DataNhapHang())
            {
                var tongHoaDon = (from hdnh in dt.HoaDonNhapHangs
                                  where hdnh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                  where hdnh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                  select hdnh.MaHDN).Count();
                lblNhaphang.Text = "NHẬP HÀNG (" + tongHoaDon + " hóa đơn)";
                // Tổng Hóa đơn 
                if (tongHoaDon != 0)
                {
                    var tongTienHoaDon = (from hdnh in dt.HoaDonNhapHangs
                                          join ctnh in dt.CTHDNhapHangs on hdnh.MaHDN equals ctnh.MaHDN
                                          where hdnh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                          where hdnh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                          select (ctnh.SL * ctnh.DonGia) - ((ctnh.SL * ctnh.DonGia) * (hdnh.CK / 100))).Sum();
                    var tongTienHoaDon1 = (from hdnh in dt.HoaDonNhapHangs
                                           where hdnh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                           where hdnh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                           select hdnh.NoCu).Sum();

                    double tongTienHD = tongTienHoaDon.Value + tongTienHoaDon1.Value;
                    lblNhaptongcong.Text = Math.Round(tongTienHD, 0, MidpointRounding.ToEven).ToString();
                    // tổng tiền các hóa đơn 

                    var tienTra = (from hdnh in dt.HoaDonNhapHangs
                                   where hdnh.NgayLap >= Convert.ToDateTime(dtpFromDate.Text)
                                   where hdnh.NgayLap <= Convert.ToDateTime(dtpToDate.Text)
                                   select hdnh.TienTra).Sum();
                    lblNhapdatra.Text = tienTra.ToString();
                    // tổng tiền đã trả của cửa hàng 

                    lblNhapconno.Text = (Convert.ToDouble(lblNhaptongcong.Text) - Convert.ToDouble(lblNhapdatra.Text)).ToString();
                    // tong tiền các kh còn nợ lại 
                }
                else
                {
                    lblNhaptongcong.Text = "0";
                    lblNhapdatra.Text = "0";
                    lblNhapconno.Text = "0";
                }
            }
        }
        #endregion
        private void BaoCaoTongHop_Load(object sender, EventArgs e)
        {
            lblToDay.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");
            banHangToday();
            nhapHangToday();
            lblYesterday.Text = "Hôm qua: " + DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
            banHangYesterday();
            nhapHangYesterday();
            dtpFromDate.Value = DateTime.Today;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            banHangFromdateTodate();
            nhapHangFromdateTodate();
        }
    }
}
