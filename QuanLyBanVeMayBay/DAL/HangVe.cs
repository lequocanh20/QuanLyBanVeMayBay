using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangVe
    {
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string GhiChu { get; set; }
        public HangVe() { }
        public HangVe(string MaHV, string TenHV, string GhiChu)
        {
            this.MaHV = MaHV;
            this.TenHV = TenHV;
            this.GhiChu = GhiChu;
        }
        public HangVe(string MaHV, string TenHV)
        {
            this.MaHV = MaHV;
            this.TenHV = TenHV; 
        }
    }
}
