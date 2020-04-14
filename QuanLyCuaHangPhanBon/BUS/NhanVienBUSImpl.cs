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

        public bool AddData(NhanVienDTO nv)
        {
            return nhanVienDAL.AddData(nv);
        }

        public bool DelData(int ma)
        {
            return nhanVienDAL.DelData(ma);
        }
       
    }
}
