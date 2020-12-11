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
    public partial class TraCuuChuyenBay : Form
    {
        public TraCuuChuyenBay()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            dGVtraCuuCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            dGVtraCuuCB.Refresh();
            dGVtraCuuCB.Columns[0].HeaderText = "Mã chuyến bay";
            dGVtraCuuCB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[1].HeaderText = "Sân bay đi";
            dGVtraCuuCB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[2].HeaderText = "Sân bay đến";
            dGVtraCuuCB.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[3].HeaderText = "Giá tiền";
            dGVtraCuuCB.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[4].HeaderText = "Ngày giờ";
            dGVtraCuuCB.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[5].HeaderText = "Thời gian bay";
            dGVtraCuuCB.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[6].HeaderText = "Số lượng ghế hạng 1";
            dGVtraCuuCB.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVtraCuuCB.Columns[7].HeaderText = "Số lượng ghế hạng 2";
            dGVtraCuuCB.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TraCuuChuyenBay_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            if (txtTraCuu.Text != "")
            {
                LichChuyenBay lcb = new LichChuyenBay(txtTraCuu.Text);
                dGVtraCuuCB.DataSource = bUL_LichChuyenBay.getTimKiemCB(lcb);
            }
            else
            {
                xemdulieu();
            }
        }

        private void TraCuuChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
