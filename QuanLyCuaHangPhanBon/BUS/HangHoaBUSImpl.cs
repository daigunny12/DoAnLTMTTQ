using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HangHoaBUSImpl : HangHoaBUS
    {
        private HangHoaDAL hangHoaDAL = null;
        private static HangHoaBUSImpl instance;

        public HangHoaBUSImpl()
        {
            this.hangHoaDAL = HangHoaDALImpl.Instance;
        }

        public static HangHoaBUSImpl Instance
        {
            get { if (instance == null) instance = new HangHoaBUSImpl(); return HangHoaBUSImpl.instance; }
            private set { HangHoaBUSImpl.instance = value; }
        }

        public DataTable GetData()
        {
            return hangHoaDAL.GetData();
        }
        public DataTable SearchData(string m)
        {
            return hangHoaDAL.SearchData(m);
        }
        public DataTable SearchData1(string m)
        {
            return hangHoaDAL.SearchData1(m);
        }
        public DataTable SearchData2(string m)
        {
            return hangHoaDAL.SearchData2(m);
        }
        public DataTable SearchData3(string m)
        {
            return hangHoaDAL.SearchData3(m);
        }
        public DataTable SearchData4(string m)
        {
            return hangHoaDAL.SearchData4(m);
        }
        public DataTable SearchData5(string m)
        {
            return hangHoaDAL.SearchData5(m);
        }
        public bool CheckSL(int MaHH, int SL)
        {
            return hangHoaDAL.CheckSL(MaHH, SL);
        }

        public bool DelData(int ma)
        {
            return hangHoaDAL.DelData(ma);
        }

        public bool UpDateData(HangHoaDTO hh)
        {
            return hangHoaDAL.UpDateData(hh);
        }

        public bool UpDateSLBanHang(int MaHH, int SL)
        {
            return hangHoaDAL.UpDateSLBanHang(MaHH, SL);
        }

        public bool UpDateSLNhapHang(int MaHH, int SL)
        {
            return hangHoaDAL.UpDateSLNhapHang(MaHH, SL);
        }

        public bool AddData(HangHoaDTO hh)
        {
            return hangHoaDAL.AddData(hh);
        }
        public DataTable BaoCaoHangHoa()
        {
            return hangHoaDAL.BaoCaoHangHoa();
        }
    }
}
