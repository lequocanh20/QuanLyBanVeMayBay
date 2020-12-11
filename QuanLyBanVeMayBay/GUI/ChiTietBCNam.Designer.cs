namespace GUI
{
    partial class ChiTietBCNam
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dGVchiTietBCNam = new System.Windows.Forms.DataGridView();
            this.txtBCNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbMaBCNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbMaCTBCNam = new System.Windows.Forms.Label();
            this.txtMaCTBCNam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietBCNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(281, 50);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(62, 28);
            this.btnQuayLai.TabIndex = 17;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(169, 49);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(62, 29);
            this.btnXacNhan.TabIndex = 16;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dGVchiTietBCNam
            // 
            this.dGVchiTietBCNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchiTietBCNam.Location = new System.Drawing.Point(24, 98);
            this.dGVchiTietBCNam.Margin = new System.Windows.Forms.Padding(2);
            this.dGVchiTietBCNam.Name = "dGVchiTietBCNam";
            this.dGVchiTietBCNam.RowTemplate.Height = 24;
            this.dGVchiTietBCNam.Size = new System.Drawing.Size(455, 288);
            this.dGVchiTietBCNam.TabIndex = 15;
            // 
            // txtBCNam
            // 
            this.txtBCNam.Location = new System.Drawing.Point(364, 13);
            this.txtBCNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtBCNam.Name = "txtBCNam";
            this.txtBCNam.Size = new System.Drawing.Size(115, 20);
            this.txtBCNam.TabIndex = 14;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(240, 13);
            this.txtThang.Margin = new System.Windows.Forms.Padding(2);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(26, 20);
            this.txtThang.TabIndex = 13;
            // 
            // lbMaBCNam
            // 
            this.lbMaBCNam.AutoSize = true;
            this.lbMaBCNam.Location = new System.Drawing.Point(270, 16);
            this.lbMaBCNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaBCNam.Name = "lbMaBCNam";
            this.lbMaBCNam.Size = new System.Drawing.Size(90, 13);
            this.lbMaBCNam.TabIndex = 12;
            this.lbMaBCNam.Text = "Mã báo cáo năm:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(191, 16);
            this.lbThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(41, 13);
            this.lbThang.TabIndex = 11;
            this.lbThang.Text = "Tháng:";
            // 
            // lbMaCTBCNam
            // 
            this.lbMaCTBCNam.AutoSize = true;
            this.lbMaCTBCNam.Location = new System.Drawing.Point(22, 16);
            this.lbMaCTBCNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCTBCNam.Name = "lbMaCTBCNam";
            this.lbMaCTBCNam.Size = new System.Drawing.Size(82, 13);
            this.lbMaCTBCNam.TabIndex = 12;
            this.lbMaCTBCNam.Text = "Mã CT BC năm:";
            // 
            // txtMaCTBCNam
            // 
            this.txtMaCTBCNam.Location = new System.Drawing.Point(116, 13);
            this.txtMaCTBCNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCTBCNam.Name = "txtMaCTBCNam";
            this.txtMaCTBCNam.Size = new System.Drawing.Size(71, 20);
            this.txtMaCTBCNam.TabIndex = 14;
            // 
            // ChiTietBCNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 424);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dGVchiTietBCNam);
            this.Controls.Add(this.txtMaCTBCNam);
            this.Controls.Add(this.txtBCNam);
            this.Controls.Add(this.lbMaCTBCNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbMaBCNam);
            this.Controls.Add(this.lbThang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChiTietBCNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết báo cáo năm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietBCNam_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietBCNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchiTietBCNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dGVchiTietBCNam;
        private System.Windows.Forms.TextBox txtBCNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lbMaBCNam;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbMaCTBCNam;
        private System.Windows.Forms.TextBox txtMaCTBCNam;
    }
}