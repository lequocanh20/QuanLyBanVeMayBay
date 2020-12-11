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
    public partial class ChiTietBCNam : Form
    {
        public ChiTietBCNam()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_ChiTietBaoCaoNam bUL_ChiTietBaoCaoNam = new BUL_ChiTietBaoCaoNam();
            dGVchiTietBCNam.DataSource = bUL_ChiTietBaoCaoNam.getCTBaoCaoNam();
            dGVchiTietBCNam.Refresh();
            dGVchiTietBCNam.Columns[0].HeaderText = "STT";
            dGVchiTietBCNam.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCNam.Columns[1].HeaderText = "Tháng";
            dGVchiTietBCNam.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCNam.Columns[2].HeaderText = "Số chuyến bay";
            dGVchiTietBCNam.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCNam.Columns[3].HeaderText = "Doanh thu";
            dGVchiTietBCNam.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCNam.Columns[4].HeaderText = "Tỉ lệ";
            dGVchiTietBCNam.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVchiTietBCNam.Columns[5].HeaderText = "Mã báo cáo năm";
            dGVchiTietBCNam.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ChiTietBCNam_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThemBCNam bcnam = new ThemBCNam();
            this.Hide();
            bcnam.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_ChiTietBaoCaoNam bUL_ChiTietBaoCaoNam = new BUL_ChiTietBaoCaoNam();
            if (txtThang.Text != "" && txtBCNam.Text != "")
            {
                ChiTietBaoCaoNam ctbcn = new ChiTietBaoCaoNam(txtMaCTBCNam.Text, txtThang.Text, txtBCNam.Text);

                if (bUL_ChiTietBaoCaoNam.themCTBaoCaoNam(ctbcn))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVchiTietBCNam.DataSource = bUL_ChiTietBaoCaoNam.getCTBaoCaoNam(); // refresh datagridview
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
            ThemBCNam bcnam = new ThemBCNam();
            this.Hide();
            bcnam.Show();
        }

        private void ChiTietBCNam_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
