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
    public partial class ThemHanhKhach : Form
    {
        public ThemHanhKhach()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            dGVhanhKhach.DataSource = bUL_HanhKhach.getHK();
            dGVhanhKhach.Refresh();
            dGVhanhKhach.Columns[0].HeaderText = "Mã hành khách";
            dGVhanhKhach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVhanhKhach.Columns[1].HeaderText = "Tên hành khách";
            dGVhanhKhach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVhanhKhach.Columns[2].HeaderText = "CMND";
            dGVhanhKhach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVhanhKhach.Columns[3].HeaderText = "Điện thoại";
            dGVhanhKhach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            if (txtMaHK.Text != "" && txtTenHK.Text != "" && txtCMND.Text != "")
            {
                HanhKhach hk = new HanhKhach(txtMaHK.Text, txtTenHK.Text, txtCMND.Text, txtDienThoai.Text);

                if (bUL_HanhKhach.themHanhKhach(hk))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVhanhKhach.DataSource = bUL_HanhKhach.getHK(); // refresh datagridview
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

        private void ThemHanhKhach_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
