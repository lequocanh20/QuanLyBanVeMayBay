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
    public partial class CapNhatBaoCaoNam : Form
    {
        public CapNhatBaoCaoNam()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_BaoCaoNam bUL_BaoCaoNam = new BUL_BaoCaoNam();
            dGVcapNhatBaoCaoNam.DataSource = bUL_BaoCaoNam.getBaoCaoNam();
            dGVcapNhatBaoCaoNam.Refresh();
            dGVcapNhatBaoCaoNam.Columns[0].HeaderText = "Mã báo cáo năm";
            dGVcapNhatBaoCaoNam.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatBaoCaoNam.Columns[1].HeaderText = "Năm";
            dGVcapNhatBaoCaoNam.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatBaoCaoNam.Columns[2].HeaderText = "Tổng doanh thu";
            dGVcapNhatBaoCaoNam.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        public void addbinding()
        {
            txtMaBC.DataBindings.Clear();
            txtMaBC.DataBindings.Add("Text", dGVcapNhatBaoCaoNam.DataSource, "MaBaoCaoNam");
            txtNam.DataBindings.Clear();
            txtNam.DataBindings.Add("Text", dGVcapNhatBaoCaoNam.DataSource, "Nam");
            txtTongDoanhThu.DataBindings.Clear();
            txtTongDoanhThu.DataBindings.Add("Text", dGVcapNhatBaoCaoNam.DataSource, "TongDoanhThuNam");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_BaoCaoNam bUL_BaoCaoNam = new BUL_BaoCaoNam();
            if (txtMaBC.Text != "")
            {
                BaoCaoNam bcn = new BaoCaoNam(txtMaBC.Text, txtNam.Text);

                if (bUL_BaoCaoNam.xoaBaoCaoNam(bcn))
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
            BUL_BaoCaoNam bUL_BaoCaoNam = new BUL_BaoCaoNam();
            if (txtMaBC.Text != "")
            {
                BaoCaoNam bcn = new BaoCaoNam(txtMaBC.Text, txtNam.Text, txtTongDoanhThu.Text);

                if (bUL_BaoCaoNam.suaBaoCaoNam(bcn))
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

        private void CapNhatBaoCaoNam_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        private void CapNhatBaoCaoNam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
