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
    }
}
