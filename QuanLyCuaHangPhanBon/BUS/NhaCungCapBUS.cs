using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface NhaCungCapBUS
    {
        DataTable GetData();
        bool AddData(NhaCungCapDTO ncc);
        bool DelData(int ma);
    }
}
