
namespace GUI
{
    partial class CapNhatChiTietBaoCaoNam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVcapNhatChiTietBCNam = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaBCNam = new System.Windows.Forms.TextBox();
            this.txtTiLe = new System.Windows.Forms.TextBox();
            this.lbMaBaoCaoNam = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lbTiLe = new System.Windows.Forms.Label();
            this.txtSoChuyenBay = new System.Windows.Forms.TextBox();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbSoChuyenBay = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtMaCTBCNam = new System.Windows.Forms.TextBox();
            this.lbMaCTBCNam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatChiTietBCNam)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVcapNhatChiTietBCNam
            // 
            this.dGVcapNhatChiTietBCNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhatChiTietBCNam.Location = new System.Drawing.Point(24, 151);
            this.dGVcapNhatChiTietBCNam.Margin = new System.Windows.Forms.Padding(2);
            this.dGVcapNhatChiTietBCNam.Name = "dGVcapNhatChiTietBCNam";
            this.dGVcapNhatChiTietBCNam.RowTemplate.Height = 24;
            this.dGVcapNhatChiTietBCNam.Size = new System.Drawing.Size(595, 288);
            this.dGVcapNhatChiTietBCNam.TabIndex = 24;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(365, 98);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 35);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(189, 98);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaBCNam
            // 
            this.txtMaBCNam.Location = new System.Drawing.Point(519, 55);
            this.txtMaBCNam.Name = "txtMaBCNam";
            this.txtMaBCNam.Size = new System.Drawing.Size(100, 20);
            this.txtMaBCNam.TabIndex = 21;
            // 
            // txtTiLe
            // 
            this.txtTiLe.Location = new System.Drawing.Point(519, 12);
            this.txtTiLe.Name = "txtTiLe";
            this.txtTiLe.Size = new System.Drawing.Size(100, 20);
            this.txtTiLe.TabIndex = 20;
            // 
            // lbMaBaoCaoNam
            // 
            this.lbMaBaoCaoNam.AutoSize = true;
            this.lbMaBaoCaoNam.Location = new System.Drawing.Point(423, 58);
            this.lbMaBaoCaoNam.Name = "lbMaBaoCaoNam";
            this.lbMaBaoCaoNam.Size = new System.Drawing.Size(90, 13);
            this.lbMaBaoCaoNam.TabIndex = 10;
            this.lbMaBaoCaoNam.Text = "Mã báo cáo năm:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(293, 55);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(100, 20);
            this.txtDoanhThu.TabIndex = 19;
            // 
            // lbTiLe
            // 
            this.lbTiLe.AutoSize = true;
            this.lbTiLe.Location = new System.Drawing.Point(483, 15);
            this.lbTiLe.Name = "lbTiLe";
            this.lbTiLe.Size = new System.Drawing.Size(30, 13);
            this.lbTiLe.TabIndex = 11;
            this.lbTiLe.Text = "Tỉ lệ:";
            // 
            // txtSoChuyenBay
            // 
            this.txtSoChuyenBay.Location = new System.Drawing.Point(293, 9);
            this.txtSoChuyenBay.Name = "txtSoChuyenBay";
            this.txtSoChuyenBay.Size = new System.Drawing.Size(100, 20);
            this.txtSoChuyenBay.TabIndex = 18;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Location = new System.Drawing.Point(227, 58);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(60, 13);
            this.lbDoanhThu.TabIndex = 12;
            this.lbDoanhThu.Text = "Doanh thu:";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(108, 55);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(71, 20);
            this.txtThang.TabIndex = 17;
            // 
            // lbSoChuyenBay
            // 
            this.lbSoChuyenBay.AutoSize = true;
            this.lbSoChuyenBay.Location = new System.Drawing.Point(206, 12);
            this.lbSoChuyenBay.Name = "lbSoChuyenBay";
            this.lbSoChuyenBay.Size = new System.Drawing.Size(81, 13);
            this.lbSoChuyenBay.TabIndex = 13;
            this.lbSoChuyenBay.Text = "Số chuyến bay:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(61, 58);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(41, 13);
            this.lbThang.TabIndex = 14;
            this.lbThang.Text = "Tháng:";
            // 
            // txtMaCTBCNam
            // 
            this.txtMaCTBCNam.Location = new System.Drawing.Point(108, 9);
            this.txtMaCTBCNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCTBCNam.Name = "txtMaCTBCNam";
            this.txtMaCTBCNam.Size = new System.Drawing.Size(71, 20);
            this.txtMaCTBCNam.TabIndex = 26;
            // 
            // lbMaCTBCNam
            // 
            this.lbMaCTBCNam.AutoSize = true;
            this.lbMaCTBCNam.Location = new System.Drawing.Point(22, 12);
            this.lbMaCTBCNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCTBCNam.Name = "lbMaCTBCNam";
            this.lbMaCTBCNam.Size = new System.Drawing.Size(82, 13);
            this.lbMaCTBCNam.TabIndex = 25;
            this.lbMaCTBCNam.Text = "Mã CT BC năm:";
            // 
            // CapNhatChiTietBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.txtMaCTBCNam);
            this.Controls.Add(this.lbMaCTBCNam);
            this.Controls.Add(this.dGVcapNhatChiTietBCNam);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaBCNam);
            this.Controls.Add(this.txtTiLe);
            this.Controls.Add(this.lbMaBaoCaoNam);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.lbTiLe);
            this.Controls.Add(this.txtSoChuyenBay);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbSoChuyenBay);
            this.Controls.Add(this.lbThang);
            this.Name = "CapNhatChiTietBaoCaoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật chi tiết báo cáo năm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatChiTietBaoCaoNam_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatChiTietBaoCaoNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatChiTietBCNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVcapNhatChiTietBCNam;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaBCNam;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.Label lbMaBaoCaoNam;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lbTiLe;
        private System.Windows.Forms.TextBox txtSoChuyenBay;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lbSoChuyenBay;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtMaCTBCNam;
        private System.Windows.Forms.Label lbMaCTBCNam;
    }
}