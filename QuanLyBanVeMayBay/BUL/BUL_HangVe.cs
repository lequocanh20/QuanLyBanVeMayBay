using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUL
{
    public class BUL_HangVe
    {
        public DataTable getHV()
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.getHangVe();
        }
        public bool themHangVe(HangVe hV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.themHangVe(hV);
        }
        public bool suaHangVe(HangVe hV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.suaHangVe(hV);
        }
        public bool xoaHangVe(HangVe hV)
        {
            Ultilies ultilies = new Ultilies();
            return ultilies.xoaHangVe(hV);
        }
    }
}
