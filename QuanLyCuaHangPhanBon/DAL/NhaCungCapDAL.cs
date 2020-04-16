using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface NhaCungCapDAL
    {
        DataTable GetData();
        bool AddData(NhaCungCapDTO ncc);
        bool UpDateData(NhaCungCapDTO ncc);
        bool DelData(int ma);
    }
}
