using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUL
{
    public class BUL_ChiTietBaoCaoNam
    {
        public DataTable getCTBaoCaoNam()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getCTBaoCaoNam();
        }

        public bool themCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themCTBaoCaoNam(ctBCN);
        }

        public bool suaCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaCTBaoCaoNam(ctBCN);
        }

        public bool xoaCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaCTBaoCaoNam(ctBCN);
        }
    }
}
