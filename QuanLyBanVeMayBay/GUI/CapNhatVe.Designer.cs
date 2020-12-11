
namespace GUI
{
    partial class CapNhatVe
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dGVcapNhatVe = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(328, 146);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(200, 146);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dGVcapNhatVe
            // 
            this.dGVcapNhatVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhatVe.Location = new System.Drawing.Point(44, 228);
            this.dGVcapNhatVe.Name = "dGVcapNhatVe";
            this.dGVcapNhatVe.Size = new System.Drawing.Size(483, 210);
            this.dGVcapNhatVe.TabIndex = 8;
            // 
            // cBhangVe
            // 
            this.cBhangVe.FormattingEnabled = true;
            this.cBhangVe.Location = new System.Drawing.Point(111, 92);
            this.cBhangVe.Name = "cBhangVe";
            this.cBhangVe.Size = new System.Drawing.Size(121, 21);
            this.cBhangVe.TabIndex = 4;
            // 
            // cBmaCB
            // 
            this.cBmaCB.FormattingEnabled = true;
            this.cBmaCB.IntegralHeight = false;
            this.cBmaCB.Location = new System.Drawing.Point(422, 51);
            this.cBmaCB.Name = "cBmaCB";
            this.cBmaCB.Size = new System.Drawing.Size(121, 21);
            this.cBmaCB.TabIndex = 3;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(259, 10);
            this.txtMaVe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(95, 20);
            this.txtMaVe.TabIndex = 1;
            // 
            // lbMaVe
            // 
            this.lbMaVe.AutoSize = true;
            this.lbMaVe.Location = new System.Drawing.Point(215, 15);
            this.lbMaVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaVe.Name = "lbMaVe";
            this.lbMaVe.Size = new System.Drawing.Size(43, 13);
            this.lbMaVe.TabIndex = 50;
            this.lbMaVe.Text = "Mã vé: ";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(422, 95);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(117, 20);
            this.txtGiaTien.TabIndex = 5;
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(111, 52);
            this.txtMaHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(156, 20);
            this.txtMaHK.TabIndex = 2;
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Location = new System.Drawing.Point(362, 98);
            this.lbGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(49, 13);
            this.lbGiaTien.TabIndex = 44;
            this.lbGiaTien.Text = "Giá tiền: ";
            // 
            // lbHangVe
            // 
            this.lbHangVe.AutoSize = true;
            this.lbHangVe.Location = new System.Drawing.Point(53, 95);
            this.lbHangVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHangVe.Name = "lbHangVe";
            this.lbHangVe.Size = new System.Drawing.Size(54, 13);
            this.lbHangVe.TabIndex = 43;
            this.lbHangVe.Text = "Hạng vé: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã hành khách: ";
            // 
            // lbMaCB
            // 
            this.lbMaCB.AutoSize = true;
            this.lbMaCB.Location = new System.Drawing.Point(325, 55);
            this.lbMaCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCB.Name = "lbMaCB";
            this.lbMaCB.Size = new System.Drawing.Size(86, 13);
            this.lbMaCB.TabIndex = 38;
            this.lbMaCB.Text = "Mã chuyến bay: ";
            // 
            // CapNhatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
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
            this.Controls.Add(this.dGVcapNhatVe);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Name = "CapNhatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật vé chuyến bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatVe_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dGVcapNhatVe;
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
    }
}