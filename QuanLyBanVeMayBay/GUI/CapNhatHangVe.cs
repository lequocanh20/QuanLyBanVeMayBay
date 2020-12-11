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
    public partial class CapNhatHangVe : Form
    {
        public CapNhatHangVe()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            dGVcapNhatHangVe.DataSource = bUL_HangVe.getHV();
            dGVcapNhatHangVe.Refresh();
            dGVcapNhatHangVe.Columns[0].HeaderText = "Mã hạng vé";
            dGVcapNhatHangVe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatHangVe.Columns[1].HeaderText = "Tên hạng vé";
            dGVcapNhatHangVe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatHangVe.Columns[2].HeaderText = "Ghi chú";
            dGVcapNhatHangVe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addbinding()
        {
            txtMaHangVe.DataBindings.Clear();
            txtMaHangVe.DataBindings.Add("Text", dGVcapNhatHangVe.DataSource, "MaHV");
            txtTenHangVe.DataBindings.Clear();
            txtTenHangVe.DataBindings.Add("Text", dGVcapNhatHangVe.DataSource, "TenHV");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dGVcapNhatHangVe.DataSource, "GhiChu");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            if (txtMaHangVe.Text != "")
            {
                HangVe hv = new HangVe(txtMaHangVe.Text, txtTenHangVe.Text);

                if (bUL_HangVe.xoaHangVe(hv))
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
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            if (txtMaHangVe.Text != "")
            {
                HangVe hv = new HangVe(txtMaHangVe.Text, txtTenHangVe.Text, txtGhiChu.Text);

                if (bUL_HangVe.suaHangVe(hv))
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

        private void CapNhatHangVe_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        private void CapNhatHangVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
