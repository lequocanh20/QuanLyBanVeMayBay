using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUL
{
    public class BUL_ChiTietBaoCaoThang
    {
        public DataTable getCTBaoCaoThang()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getChiTietBaoCaoThang();
        }

        public bool themCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themCTBaoCaoThang(ctBCT);
        }

        public bool suaCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaCTBaoCaoThang(ctBCT);
        }

        public bool xoaCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaCTBaoCaoThang(ctBCT);
        }
    }
}
