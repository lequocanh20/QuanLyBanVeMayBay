using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietBaoCaoThang
    {
        public string MaCB { get; set; }
        public string MaBCThang { get; set; }
        public int STT { get; set; } 
        public int SoVe { get; set; }
        public int DoanhThu { get; set; }
        public ChiTietBaoCaoThang() { }
        public ChiTietBaoCaoThang(int STT, string MaCB, int SoVe, int DoanhThu, string MaBCThang)
        {
            this.STT = STT;
            this.MaCB = MaCB;
            this.SoVe = SoVe;
            this.DoanhThu = DoanhThu;
            this.MaBCThang = MaBCThang;
        }
        public ChiTietBaoCaoThang(string MaCB, string MaBCThang)
        {
            this.MaCB = MaCB;
            this.MaBCThang = MaBCThang;
        }
        public ChiTietBaoCaoThang(string MaCB)
        {
            this.MaCB = MaCB;
            this.MaBCThang = MaCB;
        }
    }
}
