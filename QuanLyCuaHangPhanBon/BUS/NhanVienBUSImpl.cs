using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;


namespace BUS
{      
    public class NhanVienBUSImpl : NhanVienBUS
    {

        private NhanVienDAL nhanVienDAL = null;
        private static NhanVienBUSImpl instance;

        public NhanVienBUSImpl()
        {
            this.nhanVienDAL = NhanVienDALImpl.Instance;
        }

        public static NhanVienBUSImpl Instance
        {
            get { if (instance == null) instance = new NhanVienBUSImpl(); return NhanVienBUSImpl.instance; }
            private set { NhanVienBUSImpl.instance = value; }
        }

 
        public DataTable GetData()
        {
            return nhanVienDAL.GetData();
        }

        public DataTable SearchData(string m)
        {
            return nhanVienDAL.SearchData(m);
        }

        public DataTable SearchData1(string m)
        {
            return nhanVienDAL.SearchData1(m);
        }

        public DataTable SearchData2(string m)
        {
            return nhanVienDAL.SearchData2(m);
        }

        public DataTable SearchData3(string m)
        {
            return nhanVienDAL.SearchData3(m);
        }

        public DataTable SearchData4(string m)
        {
            return nhanVienDAL.SearchData4(m);
        }

        public DataTable SearchData5(string m)
        {
            return nhanVienDAL.SearchData5(m);
        }

        public bool AddData(NhanVienDTO nv)
        {
            return nhanVienDAL.AddData(nv);
        }

        public bool UpDateData(NhanVienDTO nv)
        {
            return nhanVienDAL.UpDateData(nv);
        }

        public bool DelData(int ma)
        {
            return nhanVienDAL.DelData(ma);
        }
        public DataTable BaoCaoNhanVien()
        {
            return nhanVienDAL.BaoCaoNhanVien();
        }
    }
}
