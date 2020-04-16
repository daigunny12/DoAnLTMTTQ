using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public  class NhanVienDALImpl : NhanVienDAL
    {

        //private NhanVienDALImpl() { }

        private static NhanVienDALImpl instance;

        public static NhanVienDALImpl Instance
        {
            get { if (instance == null) instance = new NhanVienDALImpl(); return NhanVienDALImpl.instance; }
            private set { NhanVienDALImpl.instance = value; }
        }

        public DataTable GetData()
        {
            string query = "select *from NhanVien where TinhTrang = 'True'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool AddData(NhanVienDTO nv)
        {
            string query = string.Format("INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh,DiaChi,SDT,GhiChu,TinhTrang) VALUES (N'{0}',N'{1}',CONVERT (date,{2},103),N'{3}',{4},N'{5}','True')",nv.TenNV , nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.Sdt, nv.GhiChu );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateData(NhanVienDTO nv)
        {
            string query = string.Format("UPDATE NhanVien SET TenNV=N'{0}', GioiTinh =N'{1}', NgaySinh =CONVERT (date,{2},103), DiaChi =N'{3}', SDT ={4} , GhiChu =N'{5}'  where    MaNV={6}", nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.Sdt, nv.GhiChu, nv.MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DelData(int ma)
        {
            string query = string.Format("UPDATE NhanVien SET TinhTrang= 'False' where MaNV= {0}", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
