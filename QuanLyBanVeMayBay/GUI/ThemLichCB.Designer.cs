namespace GUI
{
    partial class ThemLichCB
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.txtSLGheHang2 = new System.Windows.Forms.TextBox();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.cBsanBayDi = new System.Windows.Forms.ComboBox();
            this.cBsanBayDen = new System.Windows.Forms.ComboBox();
            this.dTPngayGio = new System.Windows.Forms.DateTimePicker();
            this.txtSLGheHang1 = new System.Windows.Forms.TextBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.lbSLGheHang1 = new System.Windows.Forms.Label();
            this.lbSLGheHang2 = new System.Windows.Forms.Label();
            this.lbThoiGianBay = new System.Windows.Forms.Label();
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.lbGiaVe = new System.Windows.Forms.Label();
            this.lbSBDen = new System.Windows.Forms.Label();
            this.lbSBDi = new System.Windows.Forms.Label();
            this.lbMaCB = new System.Windows.Forms.Label();
            this.dGVthemLichCB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemLichCB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(303, 140);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(81, 34);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(492, 140);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 35);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Location = new System.Drawing.Point(492, 11);
            this.txtThoiGianBay.Margin = new System.Windows.Forms.Padding(2);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(86, 20);
            this.txtThoiGianBay.TabIndex = 2;
            this.txtThoiGianBay.Text = "00:00:00";
            // 
            // txtSLGheHang2
            // 
            this.txtSLGheHang2.Location = new System.Drawing.Point(703, 87);
            this.txtSLGheHang2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSLGheHang2.Name = "txtSLGheHang2";
            this.txtSLGheHang2.Size = new System.Drawing.Size(68, 20);
            this.txtSLGheHang2.TabIndex = 8;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(369, 41);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(192, 20);
            this.txtGiaVe.TabIndex = 5;
            // 
            // cBsanBayDi
            // 
            this.cBsanBayDi.FormattingEnabled = true;
            this.cBsanBayDi.Location = new System.Drawing.Point(126, 41);
            this.cBsanBayDi.Margin = new System.Windows.Forms.Padding(2);
            this.cBsanBayDi.Name = "cBsanBayDi";
            this.cBsanBayDi.Size = new System.Drawing.Size(163, 21);
            this.cBsanBayDi.TabIndex = 3;
            // 
            // cBsanBayDen
            // 
            this.cBsanBayDen.FormattingEnabled = true;
            this.cBsanBayDen.Location = new System.Drawing.Point(126, 84);
            this.cBsanBayDen.Margin = new System.Windows.Forms.Padding(2);
            this.cBsanBayDen.Name = "cBsanBayDen";
            this.cBsanBayDen.Size = new System.Drawing.Size(163, 21);
            this.cBsanBayDen.TabIndex = 4;
            // 
            // dTPngayGio
            // 
            this.dTPngayGio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dTPngayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPngayGio.Location = new System.Drawing.Point(369, 83);
            this.dTPngayGio.Margin = new System.Windows.Forms.Padding(2);
            this.dTPngayGio.Name = "dTPngayGio";
            this.dTPngayGio.Size = new System.Drawing.Size(192, 20);
            this.dTPngayGio.TabIndex = 6;
            this.dTPngayGio.Value = new System.DateTime(2020, 12, 8, 12, 0, 0, 0);
            // 
            // txtSLGheHang1
            // 
            this.txtSLGheHang1.Location = new System.Drawing.Point(703, 46);
            this.txtSLGheHang1.Margin = new System.Windows.Forms.Padding(2);
            this.txtSLGheHang1.Name = "txtSLGheHang1";
            this.txtSLGheHang1.Size = new System.Drawing.Size(67, 20);
            this.txtSLGheHang1.TabIndex = 7;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(303, 11);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(68, 20);
            this.txtMaCB.TabIndex = 1;
            this.txtMaCB.Text = "CB";
            // 
            // lbSLGheHang1
            // 
            this.lbSLGheHang1.AutoSize = true;
            this.lbSLGheHang1.Location = new System.Drawing.Point(589, 47);
            this.lbSLGheHang1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLGheHang1.Name = "lbSLGheHang1";
            this.lbSLGheHang1.Size = new System.Drawing.Size(112, 13);
            this.lbSLGheHang1.TabIndex = 24;
            this.lbSLGheHang1.Text = "Số lượng ghế hạng 1: ";
            // 
            // lbSLGheHang2
            // 
            this.lbSLGheHang2.AutoSize = true;
            this.lbSLGheHang2.Location = new System.Drawing.Point(589, 90);
            this.lbSLGheHang2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLGheHang2.Name = "lbSLGheHang2";
            this.lbSLGheHang2.Size = new System.Drawing.Size(112, 13);
            this.lbSLGheHang2.TabIndex = 23;
            this.lbSLGheHang2.Text = "Số lượng ghế hạng 2: ";
            // 
            // lbThoiGianBay
            // 
            this.lbThoiGianBay.AutoSize = true;
            this.lbThoiGianBay.Location = new System.Drawing.Point(415, 12);
            this.lbThoiGianBay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThoiGianBay.Name = "lbThoiGianBay";
            this.lbThoiGianBay.Size = new System.Drawing.Size(77, 13);
            this.lbThoiGianBay.TabIndex = 22;
            this.lbThoiGianBay.Text = "Thời gian bay: ";
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Location = new System.Drawing.Point(312, 83);
            this.lbNgayGio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(55, 13);
            this.lbNgayGio.TabIndex = 21;
            this.lbNgayGio.Text = "Ngày giờ: ";
            // 
            // lbGiaVe
            // 
            this.lbGiaVe.AutoSize = true;
            this.lbGiaVe.Location = new System.Drawing.Point(312, 44);
            this.lbGiaVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaVe.Name = "lbGiaVe";
            this.lbGiaVe.Size = new System.Drawing.Size(44, 13);
            this.lbGiaVe.TabIndex = 20;
            this.lbGiaVe.Text = "Giá vé: ";
            // 
            // lbSBDen
            // 
            this.lbSBDen.AutoSize = true;
            this.lbSBDen.Location = new System.Drawing.Point(50, 89);
            this.lbSBDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSBDen.Name = "lbSBDen";
            this.lbSBDen.Size = new System.Drawing.Size(74, 13);
            this.lbSBDen.TabIndex = 19;
            this.lbSBDen.Text = "Sân bay đến: ";
            // 
            // lbSBDi
            // 
            this.lbSBDi.AutoSize = true;
            this.lbSBDi.Location = new System.Drawing.Point(50, 46);
            this.lbSBDi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSBDi.Name = "lbSBDi";
            this.lbSBDi.Size = new System.Drawing.Size(64, 13);
            this.lbSBDi.TabIndex = 18;
            this.lbSBDi.Text = "Sân bay đi: ";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(218, 12);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 17;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // dGVthemLichCB
            // 
            this.dGVthemLichCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVthemLichCB.Location = new System.Drawing.Point(53, 209);
            this.dGVthemLichCB.Name = "dGVthemLichCB";
            this.dGVthemLichCB.Size = new System.Drawing.Size(718, 171);
            this.dGVthemLichCB.TabIndex = 11;
            // 
            // ThemLichCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 392);
            this.Controls.Add(this.dGVthemLichCB);
            this.Controls.Add(this.txtThoiGianBay);
            this.Controls.Add(this.txtSLGheHang2);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.cBsanBayDi);
            this.Controls.Add(this.cBsanBayDen);
            this.Controls.Add(this.dTPngayGio);
            this.Controls.Add(this.txtSLGheHang1);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.lbSLGheHang1);
            this.Controls.Add(this.lbSLGheHang2);
            this.Controls.Add(this.lbThoiGianBay);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.lbGiaVe);
            this.Controls.Add(this.lbSBDen);
            this.Controls.Add(this.lbSBDi);
            this.Controls.Add(this.lbMaCB);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemLichCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch chuyến bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemVe_FormClosing);
            this.Load += new System.EventHandler(this.ThemLichCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemLichCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.TextBox txtSLGheHang2;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.ComboBox cBsanBayDi;
        private System.Windows.Forms.ComboBox cBsanBayDen;
        private System.Windows.Forms.DateTimePicker dTPngayGio;
        private System.Windows.Forms.TextBox txtSLGheHang1;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label lbSLGheHang1;
        private System.Windows.Forms.Label lbSLGheHang2;
        private System.Windows.Forms.Label lbThoiGianBay;
        private System.Windows.Forms.Label lbNgayGio;
        private System.Windows.Forms.Label lbGiaVe;
        private System.Windows.Forms.Label lbSBDen;
        private System.Windows.Forms.Label lbSBDi;
        private System.Windows.Forms.Label lbMaCB;
        private System.Windows.Forms.DataGridView dGVthemLichCB;
    }
}