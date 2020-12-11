namespace GUI
{
    partial class CapNhatSB
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dGVdanhSachSB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdanhSachSB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSB
            // 
            this.lbMaSB.AutoSize = true;
            this.lbMaSB.Location = new System.Drawing.Point(67, 62);
            this.lbMaSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSB.Name = "lbMaSB";
            this.lbMaSB.Size = new System.Drawing.Size(68, 13);
            this.lbMaSB.TabIndex = 0;
            this.lbMaSB.Text = "Mã sân bay: ";
            // 
            // lbTenSB
            // 
            this.lbTenSB.AutoSize = true;
            this.lbTenSB.Location = new System.Drawing.Point(67, 109);
            this.lbTenSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSB.Name = "lbTenSB";
            this.lbTenSB.Size = new System.Drawing.Size(72, 13);
            this.lbTenSB.TabIndex = 1;
            this.lbTenSB.Text = "Tên sân bay: ";
            // 
            // txtMaSB
            // 
            this.txtMaSB.Location = new System.Drawing.Point(138, 60);
            this.txtMaSB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaSB.Name = "txtMaSB";
            this.txtMaSB.Size = new System.Drawing.Size(157, 20);
            this.txtMaSB.TabIndex = 1;
            // 
            // txtTenSB
            // 
            this.txtTenSB.Location = new System.Drawing.Point(139, 107);
            this.txtTenSB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenSB.Name = "txtTenSB";
            this.txtTenSB.Size = new System.Drawing.Size(156, 20);
            this.txtTenSB.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(353, 100);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 31);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(353, 53);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(134, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(204, 26);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Danh sách sân bay ";
            // 
            // dGVdanhSachSB
            // 
            this.dGVdanhSachSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdanhSachSB.Location = new System.Drawing.Point(70, 192);
            this.dGVdanhSachSB.Name = "dGVdanhSachSB";
            this.dGVdanhSachSB.Size = new System.Drawing.Size(345, 150);
            this.dGVdanhSachSB.TabIndex = 5;
            // 
            // CapNhatSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 373);
            this.Controls.Add(this.dGVdanhSachSB);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtTenSB);
            this.Controls.Add(this.txtMaSB);
            this.Controls.Add(this.lbTenSB);
            this.Controls.Add(this.lbMaSB);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CapNhatSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật sân bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhSachSB_FormClosing);
            this.Load += new System.EventHandler(this.DanhSachSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdanhSachSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSB;
        private System.Windows.Forms.Label lbTenSB;
        private System.Windows.Forms.TextBox txtMaSB;
        private System.Windows.Forms.TextBox txtTenSB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dGVdanhSachSB;
    }
}