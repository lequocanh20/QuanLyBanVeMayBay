using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietChuyenBay
    {
        public string MaCT { get; set; }
        public string MaCB { get; set; }
        public string MaSBTrungGian { get; set; }
        public string ThoiGianDung { get; set; }
        public string GhiChu { get; set; }
        public ChiTietChuyenBay() { }
        public ChiTietChuyenBay(string MaCT, string MaCB, string MaSBTrungGian, string ThoiGianDung, string GhiChu)
        {
            this.MaCT = MaCT;
            this.MaCB = MaCB;
            this.MaSBTrungGian = MaSBTrungGian;
            this.ThoiGianDung = ThoiGianDung;
            this.GhiChu = GhiChu;
        }
    }
}
