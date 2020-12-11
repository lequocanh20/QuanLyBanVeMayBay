using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanVe
    {
        public string MaHK { get; set; }
        public string MaVeCB { get; set; }
        public string MaCB { get; set; }
        public string MaHV { get; set; }
        public string GiaTien { get; set; }
        public BanVe() { }
        public BanVe(string MaVeCB, string MaCB, string MaHV, string GiaTien, string MaHK)
        {
            this.MaVeCB = MaVeCB;
            this.MaCB = MaCB;
            this.MaHV = MaHV;
            this.GiaTien = GiaTien;
            this.MaHK = MaHK;
        }
        public BanVe(string MaVeCB)
        {
            this.MaVeCB = MaVeCB;
            this.MaHK = MaVeCB;
        }
    }
}
