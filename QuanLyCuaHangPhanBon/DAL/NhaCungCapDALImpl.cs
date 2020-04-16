using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDALImpl : NhaCungCapDAL
    {
        private static NhaCungCapDALImpl instance;

        public static NhaCungCapDALImpl Instance
        {
            get { if (instance == null) instance = new NhaCungCapDALImpl(); return NhaCungCapDALImpl.instance; }
            private set { NhaCungCapDALImpl.instance = value; }
        }

        public DataTable GetData()
        {
            string query = "select * from NhaCungCap where TinhTrang = 'True'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool AddData(NhaCungCapDTO ncc)
        {
            string query = string.Format("insert into NhaCungCap(TenNCC,DiaChi,SDT,SoNo,GhiChu,TinhTrang) values (N'{0}',N'{1}',{2},{3},N'{4}','True')",ncc.TenNCC , ncc.DiaChi, ncc.Sdt , ncc.SoNo, ncc.GhiChu );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateData(NhaCungCapDTO ncc)
        {
            string query = string.Format("update NhaCungCap set TenNCC =N'{0}', DiaChi =N'{1}', SDT ={2}, SoNo ={3}, GhiChu =N'{4}' , TinhTrang = 'True' where MaNCC = {5}", ncc.TenNCC, ncc.DiaChi, ncc.Sdt, ncc.SoNo, ncc.GhiChu, ncc.MaNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DelData(int ma)
        {
            string query = string.Format("UPDATE NhaCungCap SET TinhTrang= 'False' where MaNCC= {0}", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
