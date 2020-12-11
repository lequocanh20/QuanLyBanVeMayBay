using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoCaoNam
    {
        public string MaBCNam { get; set; }
        public string Nam { get; set; }
        public string TongDoanhThuNam { get; set; }
        public BaoCaoNam() { }
        public BaoCaoNam (string MaBCNam, string Nam, string TongDoanhThuNam)
        {
            this.MaBCNam = MaBCNam;
            this.Nam = Nam;
            this.TongDoanhThuNam = TongDoanhThuNam;
        }
        public BaoCaoNam (string MaBCNam, string Nam)
        {
            this.MaBCNam = MaBCNam;
            this.Nam = Nam;
        }
        public BaoCaoNam (string MaBCNam)
        {
            this.MaBCNam = MaBCNam;
            this.Nam = MaBCNam;
            this.TongDoanhThuNam = MaBCNam;
        }
    }
}
