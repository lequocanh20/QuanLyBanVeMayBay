
namespace GUI
{
    partial class ThemChiTietCB
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
            this.cBsanBayTrungGian = new System.Windows.Forms.ComboBox();
            this.txtThoiGianDung = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbThoiGianDung = new System.Windows.Forms.Label();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.lbMaSBTG = new System.Windows.Forms.Label();
            this.lbMaCB = new System.Windows.Forms.Label();
            this.dGVthemChiTietCB = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cBmaCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemChiTietCB)).BeginInit();
            this.SuspendLayout();
            // 
            // cBsanBayTrungGian
            // 
            this.cBsanBayTrungGian.FormattingEnabled = true;
            this.cBsanBayTrungGian.Location = new System.Drawing.Point(217, 91);
            this.cBsanBayTrungGian.Name = "cBsanBayTrungGian";
            this.cBsanBayTrungGian.Size = new System.Drawing.Size(115, 21);
            this.cBsanBayTrungGian.TabIndex = 3;
            // 
            // txtThoiGianDung
            // 
            this.txtThoiGianDung.Location = new System.Drawing.Point(462, 35);
            this.txtThoiGianDung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtThoiGianDung.Name = "txtThoiGianDung";
            this.txtThoiGianDung.Size = new System.Drawing.Size(147, 20);
            this.txtThoiGianDung.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(462, 87);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(147, 20);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(338, 11);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(115, 20);
            this.txtMaCT.TabIndex = 1;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(408, 90);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(50, 13);
            this.lbGhiChu.TabIndex = 32;
            this.lbGhiChu.Text = "Ghi chú: ";
            // 
            // lbThoiGianDung
            // 
            this.lbThoiGianDung.AutoSize = true;
            this.lbThoiGianDung.Location = new System.Drawing.Point(374, 38);
            this.lbThoiGianDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThoiGianDung.Name = "lbThoiGianDung";
            this.lbThoiGianDung.Size = new System.Drawing.Size(84, 13);
            this.lbThoiGianDung.TabIndex = 31;
            this.lbThoiGianDung.Text = "Thời gian dừng: ";
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Location = new System.Drawing.Point(277, 14);
            this.lbMaCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(59, 13);
            this.lbMaCT.TabIndex = 28;
            this.lbMaCT.Text = "Mã chi tiết:";
            // 
            // lbMaSBTG
            // 
            this.lbMaSBTG.AutoSize = true;
            this.lbMaSBTG.Location = new System.Drawing.Point(94, 94);
            this.lbMaSBTG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSBTG.Name = "lbMaSBTG";
            this.lbMaSBTG.Size = new System.Drawing.Size(118, 13);
            this.lbMaSBTG.TabIndex = 30;
            this.lbMaSBTG.Text = "Mã sân bay trung gian: ";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(126, 42);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 29;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // dGVthemChiTietCB
            // 
            this.dGVthemChiTietCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVthemChiTietCB.Location = new System.Drawing.Point(52, 178);
            this.dGVthemChiTietCB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVthemChiTietCB.Name = "dGVthemChiTietCB";
            this.dGVthemChiTietCB.RowTemplate.Height = 28;
            this.dGVthemChiTietCB.Size = new System.Drawing.Size(620, 178);
            this.dGVthemChiTietCB.TabIndex = 8;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(424, 128);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 35);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(235, 128);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(81, 34);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cBmaCB
            // 
            this.cBmaCB.FormattingEnabled = true;
            this.cBmaCB.Location = new System.Drawing.Point(217, 39);
            this.cBmaCB.Name = "cBmaCB";
            this.cBmaCB.Size = new System.Drawing.Size(115, 21);
            this.cBmaCB.TabIndex = 2;
            // 
            // ThemChiTietCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 367);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dGVthemChiTietCB);
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
            this.Name = "ThemChiTietCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi tiết chuyến bay";
            this.Load += new System.EventHandler(this.ThemChiTietCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemChiTietCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBsanBayTrungGian;
        private System.Windows.Forms.TextBox txtThoiGianDung;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbThoiGianDung;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.Label lbMaSBTG;
        private System.Windows.Forms.Label lbMaCB;
        private System.Windows.Forms.DataGridView dGVthemChiTietCB;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cBmaCB;
    }
}