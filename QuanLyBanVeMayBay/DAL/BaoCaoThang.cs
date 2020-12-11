using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoCaoThang
    {
        public string MaBCThang { get; set; }
        public string Thang { get; set; }
        public string TongDoanhThu { get; set; }

        public BaoCaoThang(string MaBCThang, string Thang, string TongDoanhThu)
        {
            this.MaBCThang = MaBCThang;
            this.Thang = Thang;
            this.TongDoanhThu = TongDoanhThu;
        }

        public BaoCaoThang (string MaBCThang, string Thang)
        {
            this.MaBCThang = MaBCThang;
            this.Thang = Thang;
        }
        public BaoCaoThang(string MaBCThang)
        {
            this.MaBCThang = MaBCThang;
            this.Thang = MaBCThang;
        }
    }
}
