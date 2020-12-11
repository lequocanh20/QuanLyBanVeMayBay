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
    public partial class CapNhatChiTietCB : Form
    {
        public CapNhatChiTietCB()
        {
            InitializeComponent();
        }

        public void xemdulieu()
        {
            BUL_ChiTietCB bUL_ChiTietCB = new BUL_ChiTietCB();
            dGVchiTietCB.DataSource = bUL_ChiTietCB.getChiTietCB();
        }

        public void addbinding()
        {
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            BUL_SanBay bUL_SanBay = new BUL_SanBay();
            txtMaCT.DataBindings.Clear();
            txtMaCT.DataBindings.Add("Text", dGVchiTietCB.DataSource, "MaCT");
            cBmaCB.DataBindings.Clear();
            cBmaCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            cBmaCB.DisplayMember = "MaCB";
            cBmaCB.ValueMember = "MaCB";
            cBsanBayTrungGian.DataBindings.Clear();
            cBsanBayTrungGian.DataSource = bUL_SanBay.getSanBay();
            cBsanBayTrungGian.DisplayMember = "TenSB";
            cBsanBayTrungGian.ValueMember = "MaSB";
            txtThoiGianDung.DataBindings.Clear();
            txtThoiGianDung.DataBindings.Add("Text", dGVchiTietCB.DataSource, "ThoiGianDung");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dGVchiTietCB.DataSource, "GhiChu");
        }

        private void ChiTietCB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_ChiTietCB bUL_ChiTietCB = new BUL_ChiTietCB();
            if (txtMaCT.Text != "")
            {
                ChiTietChuyenBay ctcb = new ChiTietChuyenBay(txtMaCT.Text, cBmaCB.SelectedValue.ToString(), cBsanBayTrungGian.SelectedValue.ToString(), Convert.ToString(txtThoiGianDung.Text), txtGhiChu.Text);

                if (bUL_ChiTietCB.xoaChiTietCB(ctcb))
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
            BUL_ChiTietCB bUL_ChiTietCB = new BUL_ChiTietCB();
            if (txtMaCT.Text != "")
            {
                ChiTietChuyenBay ctcb = new ChiTietChuyenBay(txtMaCT.Text, cBmaCB.SelectedValue.ToString(), cBsanBayTrungGian.SelectedValue.ToString(), Convert.ToString(txtThoiGianDung.Text), txtGhiChu.Text);
                if (bUL_ChiTietCB.suaChiTietCB(ctcb))
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

        private void ChiTietCB_Load(object sender, EventArgs e)
        {
            xemdulieu();
            addbinding();
        }
    }
}
