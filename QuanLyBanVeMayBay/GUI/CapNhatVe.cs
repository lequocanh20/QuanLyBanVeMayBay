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
    public partial class CapNhatVe : Form
    {
        public CapNhatVe()
        {
            InitializeComponent();
        }


        public void xemdulieu()
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            BUL_HangVe bUL_HangVe = new BUL_HangVe();
            BUL_LichChuyenBay bUL_LichChuyenBay = new BUL_LichChuyenBay();
            dGVcapNhatVe.DataSource = bUL_BanVe.getVe();
            dGVcapNhatVe.Refresh();
            dGVcapNhatVe.Columns[0].HeaderText = "Mã vé chuyến bay";
            dGVcapNhatVe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatVe.Columns[1].HeaderText = "Mã chuyến bay";
            dGVcapNhatVe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatVe.Columns[2].HeaderText = "Mã hành khách";
            dGVcapNhatVe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatVe.Columns[3].HeaderText = "Mã hạng vé";
            dGVcapNhatVe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcapNhatVe.Columns[4].HeaderText = "Giá tiền";
            dGVcapNhatVe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cBmaCB.DataSource = bUL_LichChuyenBay.getLichChuyenBay();
            cBmaCB.DisplayMember = "MaCB";
            cBmaCB.ValueMember = "MaCB";
            cBhangVe.DataSource = bUL_HangVe.getHV();
            cBhangVe.DisplayMember = "TenHV";
            cBhangVe.ValueMember = "MaHV";
        }

        public void AddBinding()
        {
            txtMaVe.DataBindings.Clear();
            txtMaVe.DataBindings.Add("Text", dGVcapNhatVe.DataSource, "MaVeCB");
            txtMaHK.DataBindings.Clear();
            txtMaHK.DataBindings.Add("Text", dGVcapNhatVe.DataSource, "MaHK");
            txtGiaTien.DataBindings.Clear();
            txtGiaTien.DataBindings.Add("Text", dGVcapNhatVe.DataSource, "GiaTien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            if (txtMaVe.Text != "")
            {
                BanVe bv = new BanVe(txtMaVe.Text, cBmaCB.SelectedValue.ToString(), cBhangVe.SelectedValue.ToString(), txtGiaTien.Text, txtMaHK.Text);
                if (bUL_BanVe.XoaVeCB(bv))
                {
                    MessageBox.Show("Xóa thành công");
                    xemdulieu();
                    AddBinding();
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
            BUL_BanVe bUL_BanVe = new BUL_BanVe();
            if (txtMaVe.Text != "")
            {
                BanVe bv = new BanVe(txtMaVe.Text, cBmaCB.SelectedValue.ToString(), cBhangVe.SelectedValue.ToString(), txtGiaTien.Text, txtMaHK.Text);
                if (bUL_BanVe.SuaVeCB(bv))
                {
                    MessageBox.Show("Sửa thành công");
                    xemdulieu();
                    AddBinding();
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

        private void CapNhatVe_Load(object sender, EventArgs e)
        {
            xemdulieu();
            AddBinding();
        }

        private void CapNhatVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
