
namespace GUI
{
    partial class CapNhatHangVe
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
            this.dGVcapNhatHangVe = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaHangVe = new System.Windows.Forms.TextBox();
            this.lbMaVe = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenHangVe = new System.Windows.Forms.TextBox();
            this.lbHangVe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVcapNhatHangVe
            // 
            this.dGVcapNhatHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhatHangVe.Location = new System.Drawing.Point(27, 117);
            this.dGVcapNhatHangVe.Name = "dGVcapNhatHangVe";
            this.dGVcapNhatHangVe.Size = new System.Drawing.Size(614, 249);
            this.dGVcapNhatHangVe.TabIndex = 34;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(386, 63);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 35);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 63);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaHangVe
            // 
            this.txtMaHangVe.Location = new System.Drawing.Point(117, 10);
            this.txtMaHangVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHangVe.Name = "txtMaHangVe";
            this.txtMaHangVe.Size = new System.Drawing.Size(95, 20);
            this.txtMaHangVe.TabIndex = 29;
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Location = new System.Drawing.Point(24, 13);
            this.lbMaVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(70, 13);
            this.lbMaVe.TabIndex = 37;
            this.lbMaVe.Text = "Mã hạng vé: ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(546, 13);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(95, 20);
            this.txtGhiChu.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ghi Chú";
            // 
            // txtTenHangVe
            // 
            this.txtTenHangVe.Location = new System.Drawing.Point(331, 13);
            this.txtTenHangVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenHangVe.Name = "txtTenHangVe";
            this.txtTenHangVe.Size = new System.Drawing.Size(95, 20);
            this.txtTenHangVe.TabIndex = 30;
            // 
            // lbHangVe
            // 
            this.lbHangVe.AutoSize = true;
            this.lbHangVe.Location = new System.Drawing.Point(238, 16);
            this.lbHangVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHangVe.Name = "lbHangVe";
            this.lbHangVe.Size = new System.Drawing.Size(74, 13);
            this.lbHangVe.TabIndex = 36;
            this.lbHangVe.Text = "Tên hạng vé: ";
            // 
            // CapNhatHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.dGVcapNhatHangVe);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaHangVe);
            this.Controls.Add(this.lbMaVe);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHangVe);
            this.Controls.Add(this.lbHangVe);
            this.Name = "CapNhatHangVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hạng vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatHangVe_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatHangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVcapNhatHangVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaHangVe;
        private System.Windows.Forms.Label lbMaVe;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHangVe;
        private System.Windows.Forms.Label lbHangVe;
    }
}