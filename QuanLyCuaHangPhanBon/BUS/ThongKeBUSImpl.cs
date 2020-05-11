using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class ThongKeBUSImpl : ThongKeBUS
    {
        private ThongKeDAL thongKeDAL = null;
        private static ThongKeBUSImpl instance;

        public ThongKeBUSImpl()
        {
            this.thongKeDAL = ThongKeDALImpl.Instance;
        }

        public static ThongKeBUSImpl Instance
        {
            get { if (instance == null) instance = new ThongKeBUSImpl() ; return ThongKeBUSImpl.instance; }
            private set { ThongKeBUSImpl.instance = value; }
        }

        public DataTable BaoCaoChiTietBanHang(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoChiTietBanHang(fromDate, toDate);
        }
        public DataTable BaoCaoChiTietNhapHang(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoChiTietNhapHang(fromDate, toDate);
        }
        public DataTable BaoCaoHoaDonBanHang(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoHoaDonBanHang(fromDate, toDate);
        }
        public DataTable BaoCaoHoaDonNhapHang(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoHoaDonNhapHang(fromDate, toDate);
        }
        public DataTable BaoCaoXuatKho(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoXuatKho(fromDate, toDate);
        }
        public DataTable BaoCaoNhapKho(string fromDate, string toDate)
        {
            return thongKeDAL.BaoCaoNhapKho(fromDate, toDate);
        }
        public DataTable BaoCaoTonKho()
        {
            return thongKeDAL.BaoCaoTonKho();
        }
        public DataTable BaoCaoSoNoKH()
        {
            return thongKeDAL.BaoCaoSoNoKH();
        }
    }
}
