namespace GUI
{
    partial class ThemSB
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
            this.lbMaSB = new System.Windows.Forms.Label();
            this.lbTenSB = new System.Windows.Forms.Label();
            this.txtMaSB = new System.Windows.Forms.TextBox();
            this.txtTenSB = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dGVthemSanBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemSanBay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSB
            // 
            this.lbMaSB.AutoSize = true;
            this.lbMaSB.Location = new System.Drawing.Point(21, 21);
            this.lbMaSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSB.Name = "lbMaSB";
            this.lbMaSB.Size = new System.Drawing.Size(68, 13);
            this.lbMaSB.TabIndex = 0;
            this.lbMaSB.Text = "Mã sân bay: ";
            // 
            // lbTenSB
            // 
            this.lbTenSB.AutoSize = true;
            this.lbTenSB.Location = new System.Drawing.Point(18, 64);
            this.lbTenSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSB.Name = "lbTenSB";
            this.lbTenSB.Size = new System.Drawing.Size(72, 13);
            this.lbTenSB.TabIndex = 1;
            this.lbTenSB.Text = "Tên sân bay: ";
            // 
            // txtMaSB
            // 
            this.txtMaSB.Location = new System.Drawing.Point(90, 20);
            this.txtMaSB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSB.Name = "txtMaSB";
            this.txtMaSB.Size = new System.Drawing.Size(201, 20);
            this.txtMaSB.TabIndex = 1;
            // 
            // txtTenSB
            // 
            this.txtTenSB.Location = new System.Drawing.Point(90, 62);
            this.txtTenSB.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSB.Name = "txtTenSB";
            this.txtTenSB.Size = new System.Drawing.Size(201, 20);
            this.txtTenSB.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(324, 12);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(79, 32);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(324, 55);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(79, 32);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // dGVthemSanBay
            // 
            this.dGVthemSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVthemSanBay.Location = new System.Drawing.Point(21, 117);
            this.dGVthemSanBay.Name = "dGVthemSanBay";
            this.dGVthemSanBay.Size = new System.Drawing.Size(382, 150);
            this.dGVthemSanBay.TabIndex = 5;
            // 
            // ThemSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 283);
            this.Controls.Add(this.dGVthemSanBay);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtTenSB);
            this.Controls.Add(this.txtMaSB);
            this.Controls.Add(this.lbTenSB);
            this.Controls.Add(this.lbMaSB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sân bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemSB_FormClosing);
            this.Load += new System.EventHandler(this.ThemSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemSanBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSB;
        private System.Windows.Forms.Label lbTenSB;
        private System.Windows.Forms.TextBox txtMaSB;
        private System.Windows.Forms.TextBox txtTenSB;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dGVthemSanBay;
    }
}