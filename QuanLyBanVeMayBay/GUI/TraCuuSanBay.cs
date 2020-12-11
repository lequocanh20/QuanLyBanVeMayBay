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
    public partial class TraCuuSanBay : Form
    {
        public TraCuuSanBay()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            dGVtraCuuSanBay.DataSource = bUL_SanBay.getSanBay();
            dGVtraCuuSanBay.Refresh();
            dGVtraCuuSanBay.Columns[0].HeaderText = "Mã sân bay";
            dGVtraCuuSanBay.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuSanBay.Columns[1].HeaderText = "Tên sân bay";
            dGVtraCuuSanBay.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TraCuuSanBay_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            if (txtTraCuu.Text != "")
            {
                SanBay sb = new SanBay(txtTraCuu.Text);
                dGVtraCuuSanBay.DataSource = bUL_SanBay.getTimKiemSanBay(sb);
            }
            else
            {
                xemdulieu();
            }
        }

        private void TraCuuSanBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
