using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ThongKeDAL
    {
        DataTable BaoCaoChiTietBanHang(string fromDate, string toDate);
    }
}
