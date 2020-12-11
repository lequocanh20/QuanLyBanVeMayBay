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
    public partial class CapNhatLichCB : Form
    {
        public CapNhatLichCB()
        {
            InitializeComponent();
        }

        private void LichCB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }

        private void LichCB_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }

        public void xemdulieu()
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            dGVLichChuyenBay.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            dGVLichChuyenBay.Columns[0].HeaderText = "Mã chuyến bay";
            dGVLichChuyenBay.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[1].HeaderText = "Mã sân bay đi";
            dGVLichChuyenBay.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[2].HeaderText = "Mã sân bay đến";
            dGVLichChuyenBay.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[3].HeaderText = "Giá tiền";
            dGVLichChuyenBay.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[4].HeaderText = "Ngày giờ";
            dGVLichChuyenBay.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[5].HeaderText = "Thời gian bay";
            dGVLichChuyenBay.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[6].HeaderText = "Số lượng ghế hạng 1";
            dGVLichChuyenBay.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVLichChuyenBay.Columns[7].HeaderText = "Số lượng ghế hạng 2";
            dGVLichChuyenBay.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addbinding()
        {
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            txtMaCB.DataBindings.Clear();
            txtMaCB.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "MaCB");
            cBsanBayDen.DataBindings.Clear();
            cBsanBayDen.DataSource = bUL_SanBay.getSanBay();
            cBsanBayDen.DisplayMember = "TenSB";
            cBsanBayDen.ValueMember = "MaSB";
            cBsanBayDen.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "TenSB1");
            cBsanBayDi.DataBindings.Clear();
            cBsanBayDi.DataSource = bUL_SanBay.getSanBay();
            cBsanBayDi.DisplayMember = "TenSB";
            cBsanBayDi.ValueMember = "MaSB";
            cBsanBayDi.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "TenSB");
            txtGiaVe.DataBindings.Clear();
            txtGiaVe.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "GiaTien");
            txtSLGheHang1.DataBindings.Clear();
            txtSLGheHang1.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "SoLuongGheHang1");
            txtSLGheHang2.DataBindings.Clear();
            txtSLGheHang2.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "SoLuongGheHang2");
            txtThoiGianBay.DataBindings.Clear();
            txtThoiGianBay.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "ThoiGianBay");
            dTPngayGio.DataBindings.Clear();
            dTPngayGio.DataBindings.Add("Text", dGVLichChuyenBay.DataSource, "NgayGio", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy HH:mm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            if (txtMaCB.Text != "")
            {
                LichChuyenBay lcb = new LichChuyenBay(txtMaCB.Text, cBsanBayDi.SelectedValue.ToString(), cBsanBayDen.SelectedValue.ToString(), Convert.ToInt32(txtGiaVe.Text), Convert.ToString(dTPngayGio.Value), txtThoiGianBay.Text, Convert.ToInt32(txtSLGheHang1.Text), Convert.ToInt32(txtSLGheHang2.Text));
                if (bUL_LichChuyenBay.xoaLichChuyenBay(lcb))
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
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            if (txtMaCB.Text != "")
            {
                LichChuyenBay lcb = new LichChuyenBay(txtMaCB.Text, cBsanBayDi.SelectedValue.ToString(), cBsanBayDen.SelectedValue.ToString(), Convert.ToInt32(txtGiaVe.Text), Convert.ToString(dTPngayGio.Value), txtThoiGianBay.Text, Convert.ToInt32(txtSLGheHang1.Text), Convert.ToInt32(txtSLGheHang2.Text));

                if (bUL_LichChuyenBay.suaLichChuyenBay(lcb))
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
    }
}
