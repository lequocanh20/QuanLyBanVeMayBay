
namespace GUI
{
    partial class ThemHangVe
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
            this.txtMaHangVe = new System.Windows.Forms.TextBox();
            this.lbMaVe = new System.Windows.Forms.Label();
            this.lbHangVe = new System.Windows.Forms.Label();
            this.txtTenHangVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dGVthemHangVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHangVe
            // 
            this.txtMaHangVe.Location = new System.Drawing.Point(114, 20);
            this.txtMaHangVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHangVe.Name = "txtMaHangVe";
            this.txtMaHangVe.Size = new System.Drawing.Size(95, 20);
            this.txtMaHangVe.TabIndex = 1;
            this.txtMaHangVe.TextChanged += new System.EventHandler(this.txtMaHangVe_TextChanged);
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Location = new System.Drawing.Point(21, 23);
            this.lbMaVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(70, 13);
            this.lbMaVe.TabIndex = 28;
            this.lbMaVe.Text = "Mã hạng vé: ";
            this.lbMaVe.Click += new System.EventHandler(this.lbMaVe_Click);
            // 
            // lbHangVe
            // 
            this.lbHangVe.AutoSize = true;
            this.lbHangVe.Location = new System.Drawing.Point(235, 26);
            this.lbHangVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHangVe.Name = "lbHangVe";
            this.lbHangVe.Size = new System.Drawing.Size(74, 13);
            this.lbHangVe.TabIndex = 25;
            this.lbHangVe.Text = "Tên hạng vé: ";
            this.lbHangVe.Click += new System.EventHandler(this.lbHangVe_Click);
            // 
            // txtTenHangVe
            // 
            this.txtTenHangVe.Location = new System.Drawing.Point(328, 23);
            this.txtTenHangVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenHangVe.Name = "txtTenHangVe";
            this.txtTenHangVe.Size = new System.Drawing.Size(95, 20);
            this.txtTenHangVe.TabIndex = 2;
            this.txtTenHangVe.TextChanged += new System.EventHandler(this.txtTenHangVe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ghi Chú";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(543, 23);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(95, 20);
            this.txtGhiChu.TabIndex = 3;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(383, 73);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 35);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(207, 73);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(81, 34);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dGVthemHangVe
            // 
            this.dGVthemHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVthemHangVe.Location = new System.Drawing.Point(24, 127);
            this.dGVthemHangVe.Name = "dGVthemHangVe";
            this.dGVthemHangVe.Size = new System.Drawing.Size(614, 249);
            this.dGVthemHangVe.TabIndex = 6;
            this.dGVthemHangVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVthemHangVe_CellContentClick);
            // 
            // ThemHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.dGVthemHangVe);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMaHangVe);
            this.Controls.Add(this.lbMaVe);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHangVe);
            this.Controls.Add(this.lbHangVe);
            this.Name = "ThemHangVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hạng vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemHangVe_FormClosing);
            this.Load += new System.EventHandler(this.ThemHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemHangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaHangVe;
        private System.Windows.Forms.Label lbMaVe;
        private System.Windows.Forms.Label lbHangVe;
        private System.Windows.Forms.TextBox txtTenHangVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dGVthemHangVe;
    }
}