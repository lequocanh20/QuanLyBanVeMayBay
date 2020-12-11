using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietBaoCaoNam
    {
        public string Thang { get; set; }
        public string MaBCNam { get; set; }
        public string MaCTBCNam { get; set; }
        public int SoChuyenBay { get; set; }
        public int DoanhThu { get; set; }
        public ChiTietBaoCaoNam() { }
        public ChiTietBaoCaoNam(string MaCTBCNam, string Thang, int SoChuyenBay, int DoanhThu, string MaBCNam)
        {
            this.MaCTBCNam = MaCTBCNam;
            this.Thang = Thang;
            this.SoChuyenBay = SoChuyenBay;
            this.DoanhThu = DoanhThu;
            this.MaBCNam = MaBCNam;
        }
        public ChiTietBaoCaoNam(string MaCTBCNam, string Thang, string MaBCNam)
        {
            this.MaCTBCNam = MaCTBCNam;
            this.Thang = Thang;
            this.MaBCNam = MaBCNam;
        }
        public ChiTietBaoCaoNam(string Thang)
        {
            this.Thang = Thang;
            this.MaBCNam = Thang;
        }
    }
}
