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
    public partial class CapNhatBaoCaoThang : Form
    {
        public CapNhatBaoCaoThang()
        {
            InitializeComponent();
        }



        public void xemdulieu()
        {
            BUL_BaoCaoThang bUL_BaoCaoThang = new BUL_BaoCaoThang();
            dGVcapNhatBaoCaoThang.DataSource = bUL_BaoCaoThang.getBaoCaoThang();
            dGVcapNhatBaoCaoThang.Refresh();
            dGVcapNhatBaoCaoThang.Columns[0].HeaderText = "Mã báo cáo tháng";
            dGVcapNhatBaoCaoThang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatBaoCaoThang.Columns[1].HeaderText = "Tháng";
            dGVcapNhatBaoCaoThang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatBaoCaoThang.Columns[2].HeaderText = "Tổng doanh thu";
            dGVcapNhatBaoCaoThang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        public void addbinding()
        {
            txtMaBC.DataBindings.Clear();
            txtMaBC.DataBindings.Add("Text", dGVcapNhatBaoCaoThang.DataSource, "MaBaoCaoThang");
            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", dGVcapNhatBaoCaoThang.DataSource, "Thang");
            txtTongDoanhThu.DataBindings.Clear();
            txtTongDoanhThu.DataBindings.Add("Text", dGVcapNhatBaoCaoThang.DataSource, "TongDoanhThu");
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_BaoCaoThang bUL_BaoCaoThang = new BUL_BaoCaoThang();
            if (txtMaBC.Text != "")
            {
                BaoCaoThang bct = new BaoCaoThang(txtMaBC.Text, txtThang.Text);

                if (bUL_BaoCaoThang.xoaBaoCaoThang(bct))
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
            BUL_BaoCaoThang bUL_BaoCaoThang = new BUL_BaoCaoThang();
            if (txtMaBC.Text != "")
            {
                BaoCaoThang bct = new BaoCaoThang(txtMaBC.Text, txtThang.Text, txtTongDoanhThu.Text);

                if (bUL_BaoCaoThang.suaBaoCaoThang(bct))
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

        private void CapNhatBaoCaoThang_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        private void CapNhatBaoCaoThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
