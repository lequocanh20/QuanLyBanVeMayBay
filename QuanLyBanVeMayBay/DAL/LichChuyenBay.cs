using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichChuyenBay
    {
        public string MaCB { get; set; }
        public string MaSBDi { get; set; }
        public string MaSBDen { get; set; }
        public int GiaTien { get; set; }
        public string NgayGio { get; set; }
        public string ThoiGianBay { get; set; }
        public int SoLuongGheHang1 { get; set; }
        public int SoLuongGheHang2 { get; set; }
        public LichChuyenBay() { }
        public LichChuyenBay(string MaCB, string MaSBDi, string MaSBDen, int GiaTien, string NgayGio, string ThoiGianBay, int SoLuongGheHang1, int SoLuongGheHang2)
        {
            this.MaCB = MaCB;
            this.MaSBDi = MaSBDi;
            this.MaSBDen = MaSBDen;
            this.GiaTien = GiaTien;
            this.NgayGio = NgayGio;
            this.ThoiGianBay = ThoiGianBay;
            this.SoLuongGheHang1 = SoLuongGheHang1;
            this.SoLuongGheHang2 = SoLuongGheHang2;
        }
        public LichChuyenBay(string MaCB)
        {
            this.MaCB = MaCB;
            this.MaSBDi = MaCB;
            this.MaSBDen = MaCB;
        }
    }
}
