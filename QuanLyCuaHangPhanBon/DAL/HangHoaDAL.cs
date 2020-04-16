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
        bool AddData(HangHoaDTO hh);
        bool UpDateData(HangHoaDTO hh);
        bool DelData(int ma);
        bool CheckSL(int MaHH, int SL);
        bool UpDateSLBanHang(int MaHH, int SL);
        bool UpDateSLNhapHang(int MaHH, int SL);
    }
}
