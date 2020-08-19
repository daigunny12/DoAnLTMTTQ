using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class HangHoaDALImpl : HangHoaDAL
    {
        private static HangHoaDALImpl instance;

        public static HangHoaDALImpl Instance
        {
            get { if (instance == null) instance = new HangHoaDALImpl(); return HangHoaDALImpl.instance; }
            private set { HangHoaDALImpl.instance = value; }
        }

        public DataTable GetData()
        {
            string query = "select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where TinhTrang = 'True' and MaHH != 3";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable SearchData(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where TenHH like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData1(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where DonViTinh like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData2(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where GiaBan like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData3(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where GiaMua like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData4(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where SoLuong like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable SearchData5(string m)
        {
            string query = string.Format("select MaHH,TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu from HangHoa where GhiChu like N'%{0}%' AND TinhTrang = 'true'", m);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool AddData(HangHoaDTO hh)
        {
            string query = string.Format("insert into HangHoa(TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu,TinhTrang) values(N'{1}', N'{2}',{3}, {4}, {5}, N'{6}', 'True')", hh.MaHH, hh.TeHH, hh.DonViTinh, hh.GiaBan, hh.GiaMua, hh.Sl, hh.GhiChu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateData(HangHoaDTO hh)
        {
            string query = string.Format("update HangHoa set TenHH =N'{0}' , DonViTinh =N'{1}', GiaBan = {2}, GiaMua = {3}, GhiChu = N'{4}', TinhTrang ='True' where MaHH ={5}",hh.TeHH, hh.DonViTinh, hh.GiaBan, hh.GiaMua, hh.GhiChu, hh.MaHH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public bool DelData(int ma)
        {
            string query = string.Format("UPDATE HangHoa SET TinhTrang= 'False' where MaHH= {0}", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CheckSL(int MaHH, int SL)
        {
            string query = string.Format("select SoLuong from HangHoa where MaHH ={0} and SoLuong >={1}", MaHH , SL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateSLBanHang(int MaHH, int SL)
        {
            string query = string.Format("update HangHoa set SoLuong = SoLuong - {0} where MaHH = {1}", MaHH, SL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpDateSLNhapHang(int MaHH, int SL)
        {
            string query = string.Format("update HangHoa set SoLuong = SoLuong + {0} where MaHH = {1}", MaHH, SL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable BaoCaoHangHoa()
        {
            string query = "exec dbo.sp_BaoCaoHangHoa";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
