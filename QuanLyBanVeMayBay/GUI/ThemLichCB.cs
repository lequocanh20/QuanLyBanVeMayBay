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
    public partial class ThemLichCB : Form
    {
        public ThemLichCB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            dGVthemLichCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            dGVthemLichCB.Refresh();
            dGVthemLichCB.Columns[0].HeaderText = "Mã chuyến bay";
            dGVthemLichCB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[1].HeaderText = "Sân bay đi";
            dGVthemLichCB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[2].HeaderText = "Sân bay đến";
            dGVthemLichCB.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[3].HeaderText = "Giá tiền";
            dGVthemLichCB.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[4].HeaderText = "Ngày giờ";
            dGVthemLichCB.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            dGVthemLichCB.Columns[5].HeaderText = "Thời gian bay";
            dGVthemLichCB.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[6].HeaderText = "Số lượng ghế hạng 1";
            dGVthemLichCB.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVthemLichCB.Columns[7].HeaderText = "Số lượng ghế hạng 2";
            dGVthemLichCB.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cBsanBayDi.DataSource = bUL_SanBay.getSanBay();
            cBsanBayDi.DisplayMember = "TenSB";
            cBsanBayDi.ValueMember = "MaSB";
            cBsanBayDen.DataSource = bUL_SanBay.getSanBay();
            cBsanBayDen.DisplayMember = "TenSB";
            cBsanBayDen.ValueMember = "MaSB";
        }

        private void ThemVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            if (txtMaCB.Text != "" && txtThoiGianBay.Text != "" && cBsanBayDen.Text != "" && cBsanBayDi.Text != "" && txtGiaVe.Text != "" && txtSLGheHang1.Text != "" && txtSLGheHang2.Text != "")
            {
                LichChuyenBay lcb = new LichChuyenBay(txtMaCB.Text, cBsanBayDi.SelectedValue.ToString(), cBsanBayDen.SelectedValue.ToString(), Convert.ToInt32(txtGiaVe.Text), Convert.ToString(dTPngayGio.Value), txtThoiGianBay.Text, Convert.ToInt32(txtSLGheHang1.Text), Convert.ToInt32(txtSLGheHang2.Text));

                if (bUL_LichChuyenBay.themLichChuyenBay(lcb))
                {
                    MessageBox.Show("Thêm thành công");
                    txtGiaVe.Text = "";
                    txtSLGheHang1.Text = "";
                    txtSLGheHang2.Text = "";
                    txtThoiGianBay.Text = "00:00:00";
                    txtMaCB.Text = "CB";
                    dGVthemLichCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay(); // refresh datagridview
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

        private void ThemLichCB_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

    }
}
