using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface DangNhapDAL
    {
        DataTable GetTK(string tenDN, string mk);
        bool UpdatePass(int maNV, string mkCu, string mkMoi);

        DataTable CheckTK(int maNV);
        bool AddAccount(TaiKhoanDTO taiKhoanDTO);
    }
}
