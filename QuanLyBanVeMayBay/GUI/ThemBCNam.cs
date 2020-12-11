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
    public partial class ThemBCNam : Form
    {
        public ThemBCNam()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_BaoCaoNam bUL_BaoCaoNam = new BUL_BaoCaoNam();
            dGVthemBCNam.DataSource = bUL_BaoCaoNam.getBaoCaoNam();
            dGVthemBCNam.Refresh();
            dGVthemBCNam.Columns[0].HeaderText = "Mã báo cáo năm";
            dGVthemBCNam.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemBCNam.Columns[1].HeaderText = "Năm";
            dGVthemBCNam.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemBCNam.Columns[2].HeaderText = "Tổng doanh thu năm";
            dGVthemBCNam.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BCNam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_BaoCaoNam bUL_BaoCaoNam = new BUL_BaoCaoNam();
            if (txtMaBC.Text != "")
            {
                BaoCaoNam bcn = new BaoCaoNam(txtMaBC.Text);

                if (bUL_BaoCaoNam.themBaoCaoNam(bcn))
                {
                    MessageBox.Show("Thêm thành công");
                    txtMaBC.Text = "BCN";
                    dGVthemBCNam.DataSource = bUL_BaoCaoNam.getBaoCaoNam(); // refresh datagridview
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

        private void ThemBCNam_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
