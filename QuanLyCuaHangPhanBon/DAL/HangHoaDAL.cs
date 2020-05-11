using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface HangHoaDAL
    {
        DataTable GetData();
        DataTable SearchData(string m);
        DataTable SearchData1(string m);
        DataTable SearchData2(string m);
        DataTable SearchData3(string m);
        DataTable SearchData4(string m);
        DataTable SearchData5(string m);
        bool AddData(HangHoaDTO hh);
        bool UpDateData(HangHoaDTO hh);
        bool DelData(int ma);
        bool CheckSL(int MaHH, int SL);
        bool UpDateSLBanHang(int MaHH, int SL);
        bool UpDateSLNhapHang(int MaHH, int SL);
        DataTable BaoCaoHangHoa();

    }
}
