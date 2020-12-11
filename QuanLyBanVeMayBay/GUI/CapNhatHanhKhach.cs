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
    public partial class CapNhatHanhKhach : Form
    {
        public CapNhatHanhKhach()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            dGVcapNhathanhKhach.DataSource = bUL_HanhKhach.getHK();
            dGVcapNhathanhKhach.Refresh();
            dGVcapNhathanhKhach.Columns[0].HeaderText = "Mã hành khách";
            dGVcapNhathanhKhach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhathanhKhach.Columns[1].HeaderText = "Tên hành khách";
            dGVcapNhathanhKhach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhathanhKhach.Columns[2].HeaderText = "CMND";
            dGVcapNhathanhKhach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhathanhKhach.Columns[3].HeaderText = "Điện thoại";
            dGVcapNhathanhKhach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void AddBinding()
        {
            txtMaHK.DataBindings.Clear();
            txtMaHK.DataBindings.Add("Text", dGVcapNhathanhKhach.DataSource, "MaHK");
            txtTenHK.DataBindings.Clear();
            txtTenHK.DataBindings.Add("Text", dGVcapNhathanhKhach.DataSource, "TenHK");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dGVcapNhathanhKhach.DataSource, "CMND");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dGVcapNhathanhKhach.DataSource, "DienThoai");
        }

        private void CapNhatHanhKhach_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void CapNhatHanhKhach_Load(object sender, EventArgs e)
        {
            xemdulieu();
            AddBinding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            if (txtMaHK.Text != "")
            {
                HanhKhach hk = new HanhKhach(txtMaHK.Text, txtTenHK.Text, txtCMND.Text, txtDienThoai.Text);

                if (bUL_HanhKhach.xoaHK(hk))
                {
                    MessageBox.Show("Xóa thành công");
                    xemdulieu();
                    AddBinding();
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
            BUL_HanhKhach bUL_HanhKhach = new BUL_HanhKhach();
            if (txtMaHK.Text != "")
            {
                HanhKhach hk = new HanhKhach(txtMaHK.Text, txtTenHK.Text, txtCMND.Text, txtDienThoai.Text);

                if (bUL_HanhKhach.suaHK(hk))
                {
                    MessageBox.Show("Sửa thành công");
                    xemdulieu();
                    AddBinding();
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
    }
}
