using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface ThongKeBUS
    {
        DataTable BaoCaoChiTietBanHang(string fromDate, string toDate);
    }
}
