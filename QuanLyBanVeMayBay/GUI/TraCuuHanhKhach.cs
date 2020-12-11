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
    public partial class TraCuuHanhKhach : Form
    {
        public TraCuuHanhKhach()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            dGVtraCuuHK.DataSource = bUL_HanhKhach.getHK();
            dGVtraCuuHK.Refresh();
            dGVtraCuuHK.Columns[0].HeaderText = "Mã hành khách";
            dGVtraCuuHK.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuHK.Columns[1].HeaderText = "Tên hành khách";
            dGVtraCuuHK.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuHK.Columns[2].HeaderText = "CMND";
            dGVtraCuuHK.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuHK.Columns[3].HeaderText = "Điện thoại";
            dGVtraCuuHK.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            if(txtTraCuu.Text != "")
            {
                HanhKhach hk = new HanhKhach(txtTraCuu.Text);
                dGVtraCuuHK.DataSource = bUL_HanhKhach.getTimKiem(hk);
            }    
            else
            {
                xemdulieu();
            }    
        }

        private void TraCuuHanhKhach_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void TraCuuHanhKhach_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
