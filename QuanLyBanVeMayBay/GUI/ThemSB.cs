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
    public partial class ThemSB : Form
    {
        public ThemSB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            dGVthemSanBay.DataSource = bUL_SanBay.getSanBay();
            dGVthemSanBay.Refresh();
            dGVthemSanBay.Columns[0].HeaderText = "Mã sân bay";
            dGVthemSanBay.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemSanBay.Columns[1].HeaderText = "Tên sân bay";
            dGVthemSanBay.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ThemSB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void ThemSB_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            if (txtMaSB.Text != "" && txtTenSB.Text != "")
            {
                SanBay sb = new SanBay(txtMaSB.Text, txtTenSB.Text);

                if (bUL_SanBay.themSanBay(sb))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVthemSanBay.DataSource = bUL_SanBay.getSanBay(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra","Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
