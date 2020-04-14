using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhaHang.Model;
using QLNhaHang.Object;


namespace QLNhaHang.Control
{
    class KhachHangCtrl
    {
        KhachHangMod khMod = new KhachHangMod();
        public DataTable GetData()
        {
            return khMod.GetData();
        }

        public bool AddData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return khMod.UpdData(khObj);
        }
        public int abbDiem(KhachHangObj khObj)
        {
            return khMod.addDiem(khObj);
        }

        public bool UpdDiem(KhachHangObj khObj)
        {
            return khMod.UpdDiem(khObj);
        }

        public bool DelData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
