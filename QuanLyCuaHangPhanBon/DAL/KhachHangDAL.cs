using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface KhachHangDAL
    {
        DataTable GetData();
        bool AddData(KhachHangDTO kh);
        bool UpDateData(KhachHangDTO kh);
        bool DelData(int ma);
    }
}
