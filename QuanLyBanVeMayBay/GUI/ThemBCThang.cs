using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DAL;

namespace GUI
{
    public partial class ThemBCThang : Form
    {
        public ThemBCThang()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_BaoCaoThang bUL_BaoCaoThang = new BUL_BaoCaoThang();
            dGVbaoCaoThang.DataSource = bUL_BaoCaoThang.getBaoCaoThang();
            dGVbaoCaoThang.Refresh();
            dGVbaoCaoThang.Columns[0].HeaderText = "Mã báo cáo tháng";
            dGVbaoCaoThang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbaoCaoThang.Columns[1].HeaderText = "Tháng";
            dGVbaoCaoThang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbaoCaoThang.Columns[2].HeaderText = "Tổng doanh thu";
            dGVbaoCaoThang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BCThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_BaoCaoThang bUL_BaoCaoThang = new BUL_BaoCaoThang();
            if (txtMaBC.Text != "" && txtThang.Text != "")
            {
                BaoCaoThang bct = new BaoCaoThang(txtMaBC.Text, txtThang.Text);

                if (bUL_BaoCaoThang.themBaoCaoThang(bct))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVbaoCaoThang.DataSource = bUL_BaoCaoThang.getBaoCaoThang(); // refresh datagridview
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
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemBCThang_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbThang_Click(object sender, EventArgs e)
        {

        }

        private void txtMaBC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaBC_Click(object sender, EventArgs e)
        {

        }

        private void dGVbaoCaoThang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
