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
    public partial class CapNhatSB : Form
    {
        public CapNhatSB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            dGVdanhSachSB.DataSource = bUL_SanBay.getSanBay();
            dGVdanhSachSB.Refresh();
            dGVdanhSachSB.Columns[0].HeaderText = "Mã sân bay";
            dGVdanhSachSB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVdanhSachSB.Columns[1].HeaderText = "Tên sân bay";
            dGVdanhSachSB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addbinding()
        {
            txtMaSB.DataBindings.Clear();
            txtMaSB.DataBindings.Add("Text", dGVdanhSachSB.DataSource, "MaSB");
            txtTenSB.DataBindings.Clear();
            txtTenSB.DataBindings.Add("Text", dGVdanhSachSB.DataSource, "TenSB");
        }

        private void DanhSachSB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            if (txtMaSB.Text != "")
            {
                SanBay sb = new SanBay(txtMaSB.Text, txtTenSB.Text);

                if (bUL_SanBay.xoaSanBay(sb))
                {
                    MessageBox.Show("Xóa thành công");
                    xemdulieu();
                    addbinding();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            if (txtMaSB.Text != "")
            {
                SanBay sb = new SanBay(txtMaSB.Text, txtTenSB.Text);

                if (bUL_SanBay.suaSanBay(sb))
                {
                    MessageBox.Show("Sửa thành công");
                    xemdulieu();
                    addbinding();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại");
            }
        }

        private void DanhSachSB_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }
    }
}
