using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUL
{
    public class BUL_BaoCaoNam
    {
        public DataTable getBaoCaoNam()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getBaoCaoNam();
        }

        public bool themBaoCaoNam(BaoCaoNam bCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themBaoCaoNam(bCN);
        }
        public bool suaBaoCaoNam(BaoCaoNam bCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaBCNam(bCN);
        }
        public bool xoaBaoCaoNam(BaoCaoNam bCN)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaBCNam(bCN);
        }
    }
}
