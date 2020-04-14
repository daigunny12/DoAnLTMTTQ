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
    class MonAnCtrl
    {
        MonAnMod hhMod = new MonAnMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(MonAnObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdData(MonAnObj hhObj)
        {
            return hhMod.UpdData(hhObj);
        }


        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}
