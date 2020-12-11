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
    public partial class TraCuuVe : Form
    {
        public TraCuuVe()
        {
            InitializeComponent();
        }
        public void xemdulieu()
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            dGVtraCuuVe.DataSource = bUL_BanVe.getVe();
            dGVtraCuuVe.Refresh();
            dGVtraCuuVe.Columns[0].HeaderText = "Mã vé chuyến bay";
            dGVtraCuuVe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuVe.Columns[1].HeaderText = "Mã chuyến bay";
            dGVtraCuuVe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuVe.Columns[2].HeaderText = "Mã hành khách";
            dGVtraCuuVe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuVe.Columns[3].HeaderText = "Mã hạng vé";
            dGVtraCuuVe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuVe.Columns[4].HeaderText = "Giá tiền";
            dGVtraCuuVe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }      

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            if(txtTraCuu.Text != "")
            {
                BanVe bv = new BanVe(txtTraCuu.Text);
                dGVtraCuuVe.DataSource = bUL_BanVe.getTimKiemVe(bv);
            }    
            else
            {
                xemdulieu();
            }    
        }

        private void TraCuuVe_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void TraCuuVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
