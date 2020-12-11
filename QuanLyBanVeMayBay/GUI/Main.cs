using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBCThang bct = new ThemBCThang();
            this.Hide();
            bct.Show();
        }

        private void nămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBCNam bcn = new ThemBCNam();
            this.Hide();
            bcn.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var DR = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void ThemChuyenBayToolStrip_Click(object sender, EventArgs e)
        {
            ThemLichCB TLCB = new ThemLichCB();
            this.Hide();
            TLCB.Show();
        }

        private void traCứuSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSB TSB = new ThemSB();
            this.Hide();
            TSB.Show();
        }

        private void CapNhatChuyenBayToolStrip_Click(object sender, EventArgs e)
        {
            CapNhatLichCB LCB = new CapNhatLichCB();
            this.Hide();
            LCB.Show();
        }

        private void cậpNhậtSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatSB DSSB = new CapNhatSB();
            this.Hide();
            DSSB.Show();
        }

        private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanVeCB VCB = new BanVeCB();
            this.Hide();
            VCB.Show();
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatVeCB DVCB = new DatVeCB();
            this.Hide();
            DVCB.Show();
        }

        private void traCứuVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuVe TCV = new TraCuuVe();
            this.Hide();
            TCV.Show();
        }

        private void TraCuuChuyenBayToolStrip_Click(object sender, EventArgs e)
        {
            TraCuuChuyenBay TCCB = new TraCuuChuyenBay();
            this.Hide();
            TCCB.Show();
        }

        private void traCứuSânBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraCuuSanBay TCSB = new TraCuuSanBay();
            this.Hide();
            TCSB.Show();
        }

        private void thêmChiTiếtChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemChiTietCB TCTCB = new ThemChiTietCB();
            this.Hide();
            TCTCB.Show();
        }

        private void cậpNhậtChiTiếtChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatChiTietCB CTCB = new CapNhatChiTietCB();
            this.Hide();
            CTCB.Show();
        }

        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHangVe THV = new ThemHangVe();
            this.Hide();
            THV.Show();
        }

        private void cậpNhậtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatVe CNV = new CapNhatVe();
            this.Hide();
            CNV.Show();
        }

        private void thêmHànhKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHanhKhach THK = new ThemHanhKhach();
            this.Hide();
            THK.Show();
        }

        private void cậpNhậtHànhKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatHanhKhach CNHK = new CapNhatHanhKhach();
            this.Hide();
            CNHK.Show();
        }

        private void traCứuHànhKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuHanhKhach TCHK = new TraCuuHanhKhach();
            this.Hide();
            TCHK.Show();
        }

        private void cậpNhậtHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatHangVe CNHV = new CapNhatHangVe();
            this.Hide();
            CNHV.Show();
        }

        private void chiTiếtBáoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietBCThang CTBCT = new ChiTietBCThang();
            this.Hide();
            CTBCT.Show();
        }

        private void cậpNhậtBáoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatBaoCaoThang CNBCT = new CapNhatBaoCaoThang();
            this.Hide();
            CNBCT.Show();
        }

        private void cậpNhậtBáoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatBaoCaoNam CNBCN = new CapNhatBaoCaoNam();
            this.Hide();
            CNBCN.Show();
        }

        private void cậpNhậtChiTiếtBáoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatChiTietBaoCaoThang CNCTBCT = new CapNhatChiTietBaoCaoThang();
            this.Hide();
            CNCTBCT.Show();
        }

        private void thêmChiTiếtBáoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietBCNam CTBCN = new ChiTietBCNam();
            this.Hide();
            CTBCN.Show();
        }

        private void cậpNhậtChiTiếtBáoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatChiTietBaoCaoNam CNCTBCN = new CapNhatChiTietBaoCaoNam();
            this.Hide();
            CNCTBCN.Show();
        }
    }
}
