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
    public class DangNhapBUSImpl : DangNhapBUS
    {
        private DangNhapDAL dangNhapDAL = null;

        private static DangNhapBUSImpl instance;

        public DangNhapBUSImpl()
        {
            this.dangNhapDAL = DangNhapDALImpl.Instance;
        }

        public static DangNhapBUSImpl Instance
        {
            get { if (instance == null) instance = new DangNhapBUSImpl(); return DangNhapBUSImpl.instance; }
            private set { DangNhapBUSImpl.instance = value; }
        }

        public DataTable GetTK(string tenDN, string tk)
        {
            return dangNhapDAL.GetTK(tenDN,tk);
        }

        public bool UpdatePass(int maNV, string mkCu, string mkMoi)
        {
            return dangNhapDAL.UpdatePass(maNV, mkCu, mkMoi);
        }

        public DataTable CheckTK(int maNV)
        {
           return dangNhapDAL.CheckTK(maNV);
        }

        public bool AddAccount(TaiKhoanDTO taiKhoanDTO)
        {
            return dangNhapDAL.AddAccount(taiKhoanDTO);
        }
    }
}
