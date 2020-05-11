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
    public class NhaCungCapBUSImpl : NhaCungCapBUS
    {
        private NhaCungCapDAL nhaCungCapDAL = null;
        private static NhaCungCapBUSImpl instance;

        public NhaCungCapBUSImpl( )
        {
            this.nhaCungCapDAL = NhaCungCapDALImpl.Instance;
        }
        public static NhaCungCapBUSImpl Instance
        {
            get { if (instance == null) instance = new NhaCungCapBUSImpl(); return NhaCungCapBUSImpl.instance; }
            private set { NhaCungCapBUSImpl.instance = value; }
        }

        public DataTable GetData()
        {
            return nhaCungCapDAL.GetData();
        }

        public DataTable SearchData(string m)
        {
            return nhaCungCapDAL.SearchData(m);
        }

        public DataTable SearchData1(string m)
        {
            return nhaCungCapDAL.SearchData1(m);
        }

        public DataTable SearchData2(string m)
        {
            return nhaCungCapDAL.SearchData2(m);
        }

        public DataTable SearchData3(string m)
        {
            return nhaCungCapDAL.SearchData3(m);
        }

        public DataTable SearchData4(string m)
        {
            return nhaCungCapDAL.SearchData4(m);
        }

        public bool AddData(NhaCungCapDTO ncc)
        {
            return nhaCungCapDAL.AddData(ncc);
        }

        public bool UpDateData(NhaCungCapDTO ncc)
        {
            return nhaCungCapDAL.UpDateData(ncc);
        }

        public bool DelData(int ma)
        {
            return nhaCungCapDAL.DelData(ma);
        }
        public DataTable BaoCaoNhaCungCap()
        {
            return nhaCungCapDAL.BaoCaoNhaCungCap();
        }
    }
}
