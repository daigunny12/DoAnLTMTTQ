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
    public class KhachHangBUSImpl :KhachHangBUS
    {
        private KhachHangDAL khachHangDAL = null;
        private static KhachHangBUSImpl instance;

        public KhachHangBUSImpl()
        {
            this.khachHangDAL = KhachHangDALImpl.Instance;
        }

        public static KhachHangBUSImpl Instance
        {
            get { if (instance == null) instance = new KhachHangBUSImpl(); return KhachHangBUSImpl.instance; }
            private set { KhachHangBUSImpl.instance = value; }
        }

        public DataTable GetData()
        {
            return khachHangDAL.GetData();
        }

        public bool AddData(KhachHangDTO kh)
        {
            return khachHangDAL.AddData(kh);
        }

        public bool DelData(int ma)
        {
            return khachHangDAL.DelData(ma);
        }
    }
}
