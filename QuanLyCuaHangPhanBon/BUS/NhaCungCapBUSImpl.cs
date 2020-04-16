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

        public bool AddData(NhaCungCapDTO ncc)
        {
            return nhaCungCapDAL.AddData(ncc);
        }

        public bool DelData(int ma)
        {
            return nhaCungCapDAL.DelData(ma);
        }
    }
}
