using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUL
{
    public class BUL_LichChuyenBay
    {
        public DataTable getLichChuyenBay()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getDSLCB();
        }
        public bool themLichChuyenBay(LichChuyenBay lCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themLichChuyenBay(lCB);
        }
        public bool suaLichChuyenBay(LichChuyenBay lCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaLichChuyenBay(lCB);
        }
        public bool xoaLichChuyenBay(LichChuyenBay lCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaLichChuyenBay(lCB);
        }
        public DataTable getTimKiemCB(LichChuyenBay lCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.GetDataTimKiemCB(lCB);
        }
    }
}
