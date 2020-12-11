using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUL
{
    public class BUL_SanBay
    {
        public DataTable getSanBay()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getDSSB();
        }
        public bool themSanBay(SanBay sB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themSanBay(sB);
        }
        public bool suaSanBay(SanBay sB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaSanBay(sB);
        }
        public bool xoaSanBay(SanBay sB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaSanBay(sB);
        }
        public DataTable getTimKiemSanBay(SanBay sB)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.GetDataTimKiemSB(sB);
        }
    }
}
