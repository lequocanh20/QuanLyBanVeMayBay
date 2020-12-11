namespace GUI
{
    partial class CapNhatChiTietCB
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
            this.dGVchiTietCB = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtThoiGianDung = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbThoiGianDung = new System.Windows.Forms.Label();
            this.lbMaSBTG = new System.Windows.Forms.Label();
            this.lbMaCB = new System.Windows.Forms.Label();
            this.cBsanBayTrungGian = new System.Windows.Forms.ComboBox();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.cBmaCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietCB)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVchiTietCB
            // 
            this.dGVchiTietCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchiTietCB.Location = new System.Drawing.Point(45, 173);
            this.dGVchiTietCB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVchiTietCB.Name = "dGVchiTietCB";
            this.dGVchiTietCB.RowTemplate.Height = 28;
            this.dGVchiTietCB.Size = new System.Drawing.Size(577, 178);
            this.dGVchiTietCB.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 132);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 27);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(405, 132);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 27);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtThoiGianDung
            // 
            this.txtThoiGianDung.Location = new System.Drawing.Point(434, 36);
            this.txtThoiGianDung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtThoiGianDung.Name = "txtThoiGianDung";
            this.txtThoiGianDung.Size = new System.Drawing.Size(147, 20);
            this.txtThoiGianDung.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(434, 88);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(147, 20);
            this.txtGhiChu.TabIndex = 5;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(380, 91);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(50, 13);
            this.lbGhiChu.TabIndex = 22;
            this.lbGhiChu.Text = "Ghi chú: ";
            // 
            // lbThoiGianDung
            // 
            this.lbThoiGianDung.AutoSize = true;
            this.lbThoiGianDung.Location = new System.Drawing.Point(346, 39);
            this.lbThoiGianDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThoiGianDung.Name = "lbThoiGianDung";
            this.lbThoiGianDung.Size = new System.Drawing.Size(84, 13);
            this.lbThoiGianDung.TabIndex = 21;
            this.lbThoiGianDung.Text = "Thời gian dừng: ";
            // 
            // lbMaSBTG
            // 
            this.lbMaSBTG.AutoSize = true;
            this.lbMaSBTG.Location = new System.Drawing.Point(66, 95);
            this.lbMaSBTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSBTG.Name = "lbMaSBTG";
            this.lbMaSBTG.Size = new System.Drawing.Size(118, 13);
            this.lbMaSBTG.TabIndex = 20;
            this.lbMaSBTG.Text = "Mã sân bay trung gian: ";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(98, 43);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 19;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // cBsanBayTrungGian
            // 
            this.cBsanBayTrungGian.FormattingEnabled = true;
            this.cBsanBayTrungGian.Location = new System.Drawing.Point(189, 92);
            this.cBsanBayTrungGian.Name = "cBsanBayTrungGian";
            this.cBsanBayTrungGian.Size = new System.Drawing.Size(115, 21);
            this.cBsanBayTrungGian.TabIndex = 3;
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Location = new System.Drawing.Point(249, 15);
            this.lbMaCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(59, 13);
            this.lbMaCT.TabIndex = 19;
            this.lbMaCT.Text = "Mã chi tiết:";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(310, 12);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(115, 20);
            this.txtMaCT.TabIndex = 1;
            // 
            // cBmaCB
            // 
            this.cBmaCB.FormattingEnabled = true;
            this.cBmaCB.Location = new System.Drawing.Point(189, 40);
            this.cBmaCB.Name = "cBmaCB";
            this.cBmaCB.Size = new System.Drawing.Size(115, 21);
            this.cBmaCB.TabIndex = 2;
            // 
            // CapNhatChiTietCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 361);
            this.Controls.Add(this.cBmaCB);
            this.Controls.Add(this.cBsanBayTrungGian);
            this.Controls.Add(this.txtThoiGianDung);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbThoiGianDung);
            this.Controls.Add(this.lbMaCT);
            this.Controls.Add(this.lbMaSBTG);
            this.Controls.Add(this.lbMaCB);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dGVchiTietCB);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CapNhatChiTietCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật chi tiết chuyến bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietCB_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVchiTietCB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtThoiGianDung;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbThoiGianDung;
        private System.Windows.Forms.Label lbMaSBTG;
        private System.Windows.Forms.Label lbMaCB;
        private System.Windows.Forms.ComboBox cBsanBayTrungGian;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.ComboBox cBmaCB;
    }
}