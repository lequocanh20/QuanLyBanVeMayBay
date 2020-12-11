using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUL
{
    public class BUL_BaoCaoThang
    {
        public DataTable getBaoCaoThang()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getBaoCaoThang();
        }

        public bool themBaoCaoThang(BaoCaoThang bCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themBaoCaoThang(bCT);
        }
        public bool suaBaoCaoThang(BaoCaoThang bCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaBCThang(bCT);
        }
        public bool xoaBaoCaoThang(BaoCaoThang bCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaBCThang(bCT);
        }
    }
}
