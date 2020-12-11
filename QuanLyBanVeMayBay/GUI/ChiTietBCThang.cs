using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUL;

namespace GUI
{
    public partial class ChiTietBCThang : Form
    {
        public ChiTietBCThang()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_ChiTietBaoCaoThang bUL_ChiTietBaoCaoThang = new BUL_ChiTietBaoCaoThang();
            dGVchiTietBCThang.DataSource = bUL_ChiTietBaoCaoThang.getCTBaoCaoThang();
            dGVchiTietBCThang.Refresh();
            dGVchiTietBCThang.Columns[0].HeaderText = "STT";
            dGVchiTietBCThang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCThang.Columns[1].HeaderText = "Mã chuyến bay";
            dGVchiTietBCThang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCThang.Columns[2].HeaderText = "Số vé";
            dGVchiTietBCThang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCThang.Columns[3].HeaderText = "Doanh thu";
            dGVchiTietBCThang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCThang.Columns[4].HeaderText = "Tỉ lệ";
            dGVchiTietBCThang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCThang.Columns[5].HeaderText = "Mã báo cáo tháng";
            dGVchiTietBCThang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ChiTietBCThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThemBCThang bcthang = new ThemBCThang();
            this.Hide();
            bcthang.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_ChiTietBaoCaoThang bUL_ChiTietBaoCaoThang = new BUL_ChiTietBaoCaoThang();
            if (txtMaCB.Text != "" && txtBCThang.Text != "")
            {
                ChiTietBaoCaoThang ctbct = new ChiTietBaoCaoThang(txtMaCB.Text, txtBCThang.Text);

                if (bUL_ChiTietBaoCaoThang.themCTBaoCaoThang(ctbct))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVchiTietBCThang.DataSource = bUL_ChiTietBaoCaoThang.getCTBaoCaoThang(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ThemBCThang bcthang = new ThemBCThang();
            this.Hide();
            bcthang.Show();
        }

        private void ChiTietBCThang_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
