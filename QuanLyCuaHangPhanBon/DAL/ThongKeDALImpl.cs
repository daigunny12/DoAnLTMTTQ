using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDALImpl : ThongKeDAL
    {
        private static ThongKeDALImpl instance;
        public static ThongKeDALImpl Instance
        {
            get { if (instance == null) instance = new ThongKeDALImpl(); return ThongKeDALImpl.instance; }
            private set { ThongKeDALImpl.instance = value; }
        }

        public DataTable BaoCaoChiTietBanHang(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoChiTietBanHang @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query , new object[] {fromDate, toDate });
        }
        public DataTable BaoCaoChiTietNhapHang(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoChiTietNhapHang @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
        }
        public DataTable BaoCaoHoaDonBanHang(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoHoaDonBanHang @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
        }
        public DataTable BaoCaoHoaDonNhapHang(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoHoaDonNhapHang @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
        }
        public DataTable BaoCaoXuatKho(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoXuatKho @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
        }
        public DataTable BaoCaoNhapKho(string fromDate, string toDate)
        {
            string query = "exec dbo.sp_BaoCaoNhapKho @FromDate , @ToDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
        }
        public DataTable BaoCaoTonKho()
        {
            string query = "exec dbo.sp_BaoCaoTonKho ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable BaoCaoSoNoKH()
        {
            string query = "exec dbo.sp_BaoCaoSoNoKH ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
