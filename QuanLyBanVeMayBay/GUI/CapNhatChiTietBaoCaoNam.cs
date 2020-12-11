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
    public partial class CapNhatChiTietBaoCaoNam : Form
    {
        public CapNhatChiTietBaoCaoNam()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_ChiTietBaoCaoNam bUL_ChiTietBaoCaoNam = new BUL_ChiTietBaoCaoNam();
            dGVcapNhatChiTietBCNam.DataSource = bUL_ChiTietBaoCaoNam.getCTBaoCaoNam();
            dGVcapNhatChiTietBCNam.Refresh();
            dGVcapNhatChiTietBCNam.Columns[0].HeaderText = "Mã chi tiết";
            dGVcapNhatChiTietBCNam.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCNam.Columns[1].HeaderText = "Tháng";
            dGVcapNhatChiTietBCNam.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCNam.Columns[2].HeaderText = "Số chuyến bay";
            dGVcapNhatChiTietBCNam.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCNam.Columns[3].HeaderText = "Doanh thu";
            dGVcapNhatChiTietBCNam.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCNam.Columns[4].HeaderText = "Tỉ lệ";
            dGVcapNhatChiTietBCNam.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatChiTietBCNam.Columns[5].HeaderText = "Mã báo cáo năm";
            dGVcapNhatChiTietBCNam.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addbinding()
        {
            txtMaCTBCNam.DataBindings.Clear();
            txtMaCTBCNam.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "MaCTBCNam");
            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "Thang");
            txtSoChuyenBay.DataBindings.Clear();
            txtSoChuyenBay.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "SoChuyenBay");
            txtDoanhThu.DataBindings.Clear();
            txtDoanhThu.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "DoanhThu");
            txtTiLe.DataBindings.Clear();
            txtTiLe.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "TiLe");
            txtMaBCNam.DataBindings.Clear();
            txtMaBCNam.DataBindings.Add("Text", dGVcapNhatChiTietBCNam.DataSource, "MaBaoCaoNam");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_ChiTietBaoCaoNam bUL_ChiTietBaoCaoNam = new BUL_ChiTietBaoCaoNam();
            if (txtMaCTBCNam.Text != "")
            {
                ChiTietBaoCaoNam ctbcn = new ChiTietBaoCaoNam(txtMaCTBCNam.Text, txtThang.Text, Convert.ToInt32(txtSoChuyenBay.Text), Convert.ToInt32(txtDoanhThu.Text), txtMaBCNam.Text);

                if (bUL_ChiTietBaoCaoNam.xoaCTBaoCaoNam(ctbcn))
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
            BUL_ChiTietBaoCaoNam bUL_ChiTietBaoCaoNam = new BUL_ChiTietBaoCaoNam();
            if (txtMaCTBCNam.Text != "")
            {
                ChiTietBaoCaoNam ctbcn = new ChiTietBaoCaoNam(txtMaCTBCNam.Text, txtThang.Text, Convert.ToInt32(txtSoChuyenBay.Text), Convert.ToInt32(txtDoanhThu.Text), txtMaBCNam.Text);

                if (bUL_ChiTietBaoCaoNam.suaCTBaoCaoNam(ctbcn))
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

        private void CapNhatChiTietBaoCaoNam_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        private void CapNhatChiTietBaoCaoNam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
