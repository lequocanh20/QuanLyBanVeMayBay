using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUL
{
    public class BUL_HanhKhach
    {
        public DataTable getHK()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getHanhKhach();
        }
        public bool themHanhKhach(HanhKhach hK)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themHanhKhach(hK);
        }
        public bool suaHK(HanhKhach hK)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaHanhKhach(hK);
        }
        public bool xoaHK(HanhKhach hK)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaHanhKhach(hK);
        }
        public DataTable getTimKiem(HanhKhach hK)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.GetDataTimKiemHK(hK);
        }
    }
}
