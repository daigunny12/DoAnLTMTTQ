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
        DataTable SearchData(string m);
        DataTable SearchData1(string m);
        DataTable SearchData2(string m);
        DataTable SearchData3(string m);
        DataTable SearchData4(string m);
        bool UpDateData(NhaCungCapDTO ncc);
        bool AddData(NhaCungCapDTO ncc);
        bool DelData(int ma);
        DataTable BaoCaoNhaCungCap();

    }
}
