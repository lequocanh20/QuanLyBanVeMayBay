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
    public partial class ThemChiTietCB : Form
    {
        public ThemChiTietCB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            BUL_ChiTietCB bUL_ChiTietCB = new BUL_ChiTietCB();
            dGVthemChiTietCB.DataSource = bUL_ChiTietCB.getChiTietCB();
            dGVthemChiTietCB.Refresh();
            dGVthemChiTietCB.Columns[0].HeaderText = "Mã chi tiết";
            dGVthemChiTietCB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemChiTietCB.Columns[1].HeaderText = "Mã chuyến bay";
            dGVthemChiTietCB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemChiTietCB.Columns[2].HeaderText = "Mã sân bay trung gian";
            dGVthemChiTietCB.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemChiTietCB.Columns[3].HeaderText = "Thời gian dừng";
            dGVthemChiTietCB.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemChiTietCB.Columns[4].HeaderText = "Ghi chú";
            dGVthemChiTietCB.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cBmaCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            cBmaCB.DisplayMember = "MaCB";
            cBmaCB.ValueMember = "MaCB";
            cBsanBayTrungGian.DataSource = bUL_SanBay.getSanBay();
            cBsanBayTrungGian.DisplayMember = "TenSB";
            cBsanBayTrungGian.ValueMember = "MaSB";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_ChiTietCB bUL_ChiTietCB = new BUL_ChiTietCB();
            if (txtMaCT.Text != "" && cBmaCB.Text != "" && txtThoiGianDung.Text != "")
            {
                ChiTietChuyenBay ctcb = new ChiTietChuyenBay(txtMaCT.Text, cBmaCB.SelectedValue.ToString(),cBsanBayTrungGian.SelectedValue.ToString(), Convert.ToString(txtThoiGianDung.Text), txtGhiChu.Text);

                if (bUL_ChiTietCB.themChiTietCB(ctcb))
                {
                    MessageBox.Show("Thêm thành công");
                    dGVthemChiTietCB.DataSource = bUL_ChiTietCB.getChiTietCB(); // refresh datagridview
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

        private void ThemChiTietCB_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }
    }
}
