using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DAL;

namespace GUI
{
    public partial class CapNhatChiTietBaoCaoThang : Form
    {
        public CapNhatChiTietBaoCaoThang()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_ChiTietBaoCaoThang bUL_ChiTietBaoCaoThang = new BUL_ChiTietBaoCaoThang();
            dGVcapNhatChiTietBCThang.DataSource = bUL_ChiTietBaoCaoThang.getCTBaoCaoThang();
            dGVcapNhatChiTietBCThang.Refresh();
            dGVcapNhatChiTietBCThang.Columns[0].HeaderText = "STT";
            dGVcapNhatChiTietBCThang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCThang.Columns[1].HeaderText = "Mã chuyến bay";
            dGVcapNhatChiTietBCThang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCThang.Columns[2].HeaderText = "Số vé";
            dGVcapNhatChiTietBCThang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCThang.Columns[3].HeaderText = "Doanh thu";
            dGVcapNhatChiTietBCThang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCThang.Columns[4].HeaderText = "Tỉ lệ";
            dGVcapNhatChiTietBCThang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCThang.Columns[5].HeaderText = "Mã báo cáo tháng";
            dGVcapNhatChiTietBCThang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addbinding()
        {
            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "STT");
            txtMaCB.DataBindings.Clear();
            txtMaCB.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "MaCB");
            txtSoVe.DataBindings.Clear();
            txtSoVe.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "SoVe");
            txtDoanhThu.DataBindings.Clear();
            txtDoanhThu.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "DoanhThu");
            txtTiLe.DataBindings.Clear();
            txtTiLe.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "TiLe");
            txtMaBCThang.DataBindings.Clear();
            txtMaBCThang.DataBindings.Add("Text", dGVcapNhatChiTietBCThang.DataSource, "MaBaoCaoThang");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_ChiTietBaoCaoThang bUL_ChiTietBaoCaoThang = new BUL_ChiTietBaoCaoThang();
            if (txtSTT.Text != "")
            {
                ChiTietBaoCaoThang ctbct = new ChiTietBaoCaoThang(Convert.ToInt32(txtSTT.Text), txtMaCB.Text, Convert.ToInt32(txtSoVe.Text), Convert.ToInt32(txtDoanhThu.Text), txtMaBCThang.Text);

                if (bUL_ChiTietBaoCaoThang.xoaCTBaoCaoThang(ctbct))
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
            BUL_ChiTietBaoCaoThang bUL_ChiTietBaoCaoThang = new BUL_ChiTietBaoCaoThang();
            if (txtSTT.Text != "")
            {
                ChiTietBaoCaoThang ctbct = new ChiTietBaoCaoThang(Convert.ToInt32(txtSTT.Text), txtMaCB.Text, Convert.ToInt32(txtSoVe.Text), Convert.ToInt32(txtDoanhThu.Text), txtMaBCThang.Text);

                if (bUL_ChiTietBaoCaoThang.suaCTBaoCaoThang(ctbct))
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

        private void CapNhatChiTietBaoCaoThang_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        private void CapNhatChiTietBaoCaoThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
