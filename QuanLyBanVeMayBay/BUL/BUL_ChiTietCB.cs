using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUL
{
    public class BUL_ChiTietCB
    {
        public DataTable getChiTietCB()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getDSChiTietCB();
        }
        public bool themChiTietCB(ChiTietChuyenBay ctCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themChiTietCB(ctCB);
        }
        public bool suaChiTietCB(ChiTietChuyenBay ctCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaChiTietCB(ctCB);
        }
        public bool xoaChiTietCB(ChiTietChuyenBay ctCB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaChiTietCB(ctCB);
        }
    }
}
