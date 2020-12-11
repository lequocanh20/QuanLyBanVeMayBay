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
    public partial class DatVeCB : Form
    {
        public DatVeCB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            dGVbanVe.DataSource = bUL_BanVe.getVe();
            dGVbanVe.Refresh();
            dGVbanVe.Columns[0].HeaderText = "Mã vé chuyến bay";
            dGVbanVe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbanVe.Columns[1].HeaderText = "Mã chuyến bay";
            dGVbanVe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbanVe.Columns[2].HeaderText = "Mã hành khách";
            dGVbanVe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbanVe.Columns[3].HeaderText = "Mã hạng vé";
            dGVbanVe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVbanVe.Columns[4].HeaderText = "Giá tiền";
            dGVbanVe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cBmaCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            cBmaCB.DisplayMember = "MaCB";
            cBmaCB.ValueMember = "MaCB";
            cBhangVe.DataSource = bUL_HangVe.getHV();
            cBhangVe.DisplayMember = "TenHV";
            cBhangVe.ValueMember = "MaHV";
        }

        private void DatVeCB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            if (txtMaVe.Text != "" && txtMaHK.Text != "" && cBhangVe.Text != "" && cBmaCB.Text != "" && txtGiaTien.Text != "")
            {
                BanVe bv = new BanVe(txtMaVe.Text, cBmaCB.SelectedValue.ToString(), cBhangVe.SelectedValue.ToString(), txtGiaTien.Text, txtMaHK.Text);

                if (bUL_BanVe.themVeCB(bv))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVbanVe.DataSource = bUL_BanVe.getVe(); // refresh datagridview
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

        private void DatVeCB_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
