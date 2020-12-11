using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUL
{
    public class BUL_BanVe
    {
        public DataTable getVe()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getBanVe();
        }
        
        public bool themVeCB(BanVe bV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themBanVeCB(bV);
        }

        public bool SuaVeCB(BanVe bV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaBanVeCB(bV);
        }

        public bool XoaVeCB(BanVe bV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaBanVeCB(bV);
        }
        public DataTable getTimKiemVe(BanVe bV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.GetDataTimKiemVeCB(bV);
        }
    }
}
