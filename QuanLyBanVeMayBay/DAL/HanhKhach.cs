using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HanhKhach
    {
        public string MaHK { get; set; }
        public string TenHK { get; set; }
        public string CMND { get; set; }
        public string DienThoai { get; set; }
        public HanhKhach() { }
        public HanhKhach(string MaHK, string TenHK, string CMND, string DienThoai)
        {
            this.MaHK = MaHK;
            this.TenHK = TenHK;
            this.CMND = CMND;
            this.DienThoai = DienThoai;
        }
        public HanhKhach (string TenHK)
        {
            this.MaHK = TenHK;
            this.TenHK = TenHK;
            this.CMND = TenHK;
            this.DienThoai = TenHK;
        }
    }
}
