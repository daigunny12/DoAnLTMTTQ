using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    class HangHoaBUSImpl : HangHoaBUS
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
    }
}
