using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface NhanVienBUS
    {
        DataTable GetData();
        bool AddData(NhanVienDTO nv);
        bool DelData(int ma);
    }
}
