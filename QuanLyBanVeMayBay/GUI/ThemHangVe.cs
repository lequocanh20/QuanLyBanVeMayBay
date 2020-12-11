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
    public partial class ThemHangVe : Form
    {
        public ThemHangVe()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            dGVthemHangVe.DataSource = bUL_HangVe.getHV();
            dGVthemHangVe.Refresh();
            dGVthemHangVe.Columns[0].HeaderText = "Mã hạng vé";
            dGVthemHangVe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemHangVe.Columns[1].HeaderText = "Tên hạng vé";
            dGVthemHangVe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemHangVe.Columns[2].HeaderText = "Ghi chú";
            dGVthemHangVe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            if (txtMaHangVe.Text != "" && txtTenHangVe.Text != "")
            {
                HangVe hv = new HangVe(txtMaHangVe.Text, txtTenHangVe.Text, txtGhiChu.Text);

                if (bUL_HangVe.themHangVe(hv))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVthemHangVe.DataSource = bUL_HangVe.getHV(); // refresh datagridview
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

        private void ThemHangVe_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemHangVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void dGVthemHangVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaHangVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaVe_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHangVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHangVe_Click(object sender, EventArgs e)
        {

        }
    }
}
