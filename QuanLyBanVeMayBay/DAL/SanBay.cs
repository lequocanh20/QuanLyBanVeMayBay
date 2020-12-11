using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanBay
    {
        public string MaSB { get; set; }
        public string TenSB { get; set; }
        public SanBay() { }
        public SanBay(string MaSB, string TenSB)
        {
            this.MaSB = MaSB;
            this.TenSB = TenSB;
        }
        public SanBay(string MaSB)
        {
            this.MaSB = MaSB;
            this.TenSB = MaSB;
        }
    }
}
