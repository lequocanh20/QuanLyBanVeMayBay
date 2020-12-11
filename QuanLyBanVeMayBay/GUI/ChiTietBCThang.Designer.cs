namespace GUI
{
    partial class ChiTietBCThang
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
            this.lbMaCB = new System.Windows.Forms.Label();
            this.lbMaBCThang = new System.Windows.Forms.Label();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.txtBCThang = new System.Windows.Forms.TextBox();
            this.dGVchiTietBCThang = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietBCThang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(49, 25);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 1;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // lbMaBCThang
            // 
            this.lbMaBCThang.AutoSize = true;
            this.lbMaBCThang.Location = new System.Drawing.Point(289, 25);
            this.lbMaBCThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaBCThang.Name = "lbMaBCThang";
            this.lbMaBCThang.Size = new System.Drawing.Size(97, 13);
            this.lbMaBCThang.TabIndex = 3;
            this.lbMaBCThang.Text = "Mã báo cáo tháng:";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(148, 22);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(102, 20);
            this.txtMaCB.TabIndex = 5;
            // 
            // txtBCThang
            // 
            this.txtBCThang.Location = new System.Drawing.Point(405, 22);
            this.txtBCThang.Margin = new System.Windows.Forms.Padding(2);
            this.txtBCThang.Name = "txtBCThang";
            this.txtBCThang.Size = new System.Drawing.Size(102, 20);
            this.txtBCThang.TabIndex = 7;
            // 
            // dGVchiTietBCThang
            // 
            this.dGVchiTietBCThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchiTietBCThang.Location = new System.Drawing.Point(52, 107);
            this.dGVchiTietBCThang.Margin = new System.Windows.Forms.Padding(2);
            this.dGVchiTietBCThang.Name = "dGVchiTietBCThang";
            this.dGVchiTietBCThang.RowTemplate.Height = 24;
            this.dGVchiTietBCThang.Size = new System.Drawing.Size(455, 288);
            this.dGVchiTietBCThang.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(197, 58);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(62, 29);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(309, 59);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(62, 28);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ChiTietBCThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 406);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dGVchiTietBCThang);
            this.Controls.Add(this.txtBCThang);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.lbMaBCThang);
            this.Controls.Add(this.lbMaCB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChiTietBCThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết báo cáo tháng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietBCThang_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietBCThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietBCThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMaCB;
        private System.Windows.Forms.Label lbMaBCThang;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtBCThang;
        private System.Windows.Forms.DataGridView dGVchiTietBCThang;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnQuayLai;
    }
}