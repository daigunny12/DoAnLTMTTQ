using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface NhanVienDAL
    {
        DataTable GetData();
        DataTable SearchData(string m);
        DataTable SearchData1(string m);
        DataTable SearchData2(string m);
        DataTable SearchData3(string m);
        DataTable SearchData4(string m);
        DataTable SearchData5(string m);
        bool AddData(NhanVienDTO nv);
        bool UpDateData(NhanVienDTO nv);
        bool DelData(int ma);
        DataTable BaoCaoNhanVien();

    }
}
