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
    }
}
