using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DangNhapDALImpl : DangNhapDAL
    {
        private static DangNhapDALImpl instance;

        public static DangNhapDALImpl Instance
        {
            get { if (instance == null) instance = new DangNhapDALImpl(); return DangNhapDALImpl.instance; }
            private set { DangNhapDALImpl.instance = value; }
        }

        public bool AddAccount(TaiKhoanDTO taiKhoanDTO)
        {
            string query = string.Format("insert into DangNhap(MaNV,TenDN,MatKhau,ChucVu,TinhTrang) values ({0}, '{1}' , '{2}', '{3}' , 'True')", taiKhoanDTO.MaNV, taiKhoanDTO.TenDN, taiKhoanDTO.MatKhau, taiKhoanDTO.ChucVu);
            int a = DataProvider.Instance.ExecuteNonQuery(query);
            return a > 0;
        }

        public DataTable CheckTK(int maNV)
        {
            string query = string.Format("select MaNV from DangNhap where MaNV = {0}", maNV);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTK(string tenDN, string mk)
        {
            string query = string.Format("select dn.MaNV,nv.TenNV,dn.ChucVu " +
                "from DangNhap dn inner " +
                "join NhanVien nv on nv.MaNV = dn.MaNV " +
                "where TenDN = '{0}' and MatKhau = '{1}' COLLATE SQL_Latin1_General_CP1_CS_AS",tenDN , mk);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }

        public bool UpdatePass(int maNV, string mkCu, string mkMoi)
        {
            string query = string.Format("update DangNhap set MatKhau = '{0}' where MaNV = {1} and MatKhau = '{2}'", mkMoi, maNV, mkCu);
            int a = DataProvider.Instance.ExecuteNonQuery(query);
            return a > 0;
        }


    }
}
