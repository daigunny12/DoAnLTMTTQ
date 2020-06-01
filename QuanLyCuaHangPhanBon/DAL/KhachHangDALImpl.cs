using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDALImpl :KhachHangDAL
    {
        private static KhachHangDALImpl instance;

        public static KhachHangDALImpl Instance
        {
            get { if (instance == null) instance = new KhachHangDALImpl(); return KhachHangDALImpl.instance; }
            private set { KhachHangDALImpl.instance = value; }
        }

        public DataTable GetData()
        {
            string query = "select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where TinhTrang = 'True'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData(string m)
        {
            string query = string.Format("select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where TenKH like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData1(string m)
        {
            string query = string.Format("select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where DiaChi like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData2(string m)
        {
            string query = string.Format("select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where SDT like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData3(string m)
        {
            string query = string.Format("select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where SoNo like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData4(string m)
        {
            string query = string.Format("select MaKH,TenKH,DiaChi,SDT,SoNo,GhiChu from KhachHang where GhiChu like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool AddData(KhachHangDTO kh)
        {
            string query = string.Format("insert into KhachHang(TenKH,DiaChi,SDT,SoNo,GhiChu,TinhTrang) values (N'{1}',N'{2}','{3}',{4},N'{5}','True')",kh.MaKH, kh.TenKH, kh.DiaChi , kh.Sdt , kh.SoNo, kh.GhiChu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateData(KhachHangDTO kh)
        {
            string query = string.Format("update KhachHang set TenKH = N'{0}' , DiaChi=N'{1}', SDT ='{2}', SoNo = {3} , GhiChu =N'{4}' , TinhTrang = 'True' where MaKH ={5}", kh.TenKH, kh.DiaChi, kh.Sdt, kh.SoNo, kh.GhiChu, kh.MaKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DelData(int ma)
        {
            string query = string.Format("UPDATE KhachHang SET TinhTrang= 'False' where MaKH= {0}", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable BaoCaoKhachHang()
        {
            string query = "exec dbo.sp_BaoCaoKhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
