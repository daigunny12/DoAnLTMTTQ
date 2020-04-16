using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface KhachHangBUS
    {
        DataTable GetData();
        bool AddData(KhachHangDTO kh);
        bool DelData(int ma);
    }
}
