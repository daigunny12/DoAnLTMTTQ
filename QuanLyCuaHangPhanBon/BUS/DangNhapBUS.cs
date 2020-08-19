using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface DangNhapBUS
    {
        DataTable GetTK(string tenDN, string tk);
        bool UpdatePass(int maNV, string mkCu, string mkMoi);
        DataTable CheckTK(int maNV);
        bool AddAccount(TaiKhoanDTO taiKhoanDTO);
    }
}
