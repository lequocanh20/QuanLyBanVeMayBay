namespace GUI
{
    partial class BanVeCB
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dGVbanVe = new System.Windows.Forms.DataGridView();
            this.cBhangVe = new System.Windows.Forms.ComboBox();
            this.cBmaCB = new System.Windows.Forms.ComboBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.lbMaVe = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.lbHangVe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaCB = new System.Windows.Forms.Label();
            this.btnXemHanhKhach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVbanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(264, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(80, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Bán vé";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(368, 203);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 35);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(179, 203);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(81, 34);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dGVbanVe
            // 
            this.dGVbanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVbanVe.Location = new System.Drawing.Point(56, 258);
            this.dGVbanVe.Name = "dGVbanVe";
            this.dGVbanVe.Size = new System.Drawing.Size(478, 173);
            this.dGVbanVe.TabIndex = 9;
            // 
            // cBhangVe
            // 
            this.cBhangVe.FormattingEnabled = true;
            this.cBhangVe.Location = new System.Drawing.Point(119, 144);
            this.cBhangVe.Name = "cBhangVe";
            this.cBhangVe.Size = new System.Drawing.Size(121, 21);
            this.cBhangVe.TabIndex = 5;
            // 
            // cBmaCB
            // 
            this.cBmaCB.FormattingEnabled = true;
            this.cBmaCB.Location = new System.Drawing.Point(430, 103);
            this.cBmaCB.Name = "cBmaCB";
            this.cBmaCB.Size = new System.Drawing.Size(121, 21);
            this.cBmaCB.TabIndex = 4;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(267, 62);
            this.txtMaVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(95, 20);
            this.txtMaVe.TabIndex = 1;
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Location = new System.Drawing.Point(223, 67);
            this.lbMaVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(43, 13);
            this.lbMaVe.TabIndex = 61;
            this.lbMaVe.Text = "Mã vé: ";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(430, 147);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(117, 20);
            this.txtGiaTien.TabIndex = 6;
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(119, 104);
            this.txtMaHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(121, 20);
            this.txtMaHK.TabIndex = 2;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Location = new System.Drawing.Point(370, 150);
            this.lbGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(49, 13);
            this.lbGiaTien.TabIndex = 58;
            this.lbGiaTien.Text = "Giá tiền: ";
            // 
            // lbHangVe
            // 
            this.lbHangVe.AutoSize = true;
            this.lbHangVe.Location = new System.Drawing.Point(61, 147);
            this.lbHangVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHangVe.Name = "lbHangVe";
            this.lbHangVe.Size = new System.Drawing.Size(54, 13);
            this.lbHangVe.TabIndex = 57;
            this.lbHangVe.Text = "Hạng vé: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã hành khách: ";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(333, 107);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 55;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // btnXemHanhKhach
            // 
            this.btnXemHanhKhach.Location = new System.Drawing.Point(244, 103);
            this.btnXemHanhKhach.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemHanhKhach.Name = "btnXemHanhKhach";
            this.btnXemHanhKhach.Size = new System.Drawing.Size(33, 21);
            this.btnXemHanhKhach.TabIndex = 3;
            this.btnXemHanhKhach.Text = "...";
            this.btnXemHanhKhach.UseVisualStyleBackColor = true;
            this.btnXemHanhKhach.Click += new System.EventHandler(this.btnXemHanhKhach_Click);
            // 
            // BanVeCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 443);
            this.Controls.Add(this.cBhangVe);
            this.Controls.Add(this.cBmaCB);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.lbMaVe);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.lbGiaTien);
            this.Controls.Add(this.lbHangVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaCB);
            this.Controls.Add(this.dGVbanVe);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXemHanhKhach);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "BanVeCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VeCB_FormClosing);
            this.Load += new System.EventHandler(this.VeCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVbanVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dGVbanVe;
        private System.Windows.Forms.ComboBox cBhangVe;
        private System.Windows.Forms.ComboBox cBmaCB;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label lbMaVe;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label lbHangVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaCB;
        private System.Windows.Forms.Button btnXemHanhKhach;
    }
}