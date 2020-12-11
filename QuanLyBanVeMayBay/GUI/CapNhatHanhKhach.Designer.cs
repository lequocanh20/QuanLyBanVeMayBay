
namespace GUI
{
    partial class CapNhatHanhKhach
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
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHK = new System.Windows.Forms.TextBox();
            this.lbTenHK = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.lbMaHK = new System.Windows.Forms.Label();
            this.dGVcapNhathanhKhach = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhathanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(395, 59);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(156, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(303, 62);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbDienThoai.TabIndex = 74;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(395, 19);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(156, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "CMND:";
            // 
            // txtTenHK
            // 
            this.txtTenHK.Location = new System.Drawing.Point(106, 59);
            this.txtTenHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(156, 20);
            this.txtTenHK.TabIndex = 2;
            // 
            // lbTenHK
            // 
            this.lbTenHK.AutoSize = true;
            this.lbTenHK.Location = new System.Drawing.Point(14, 62);
            this.lbTenHK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenHK.Name = "lbTenHK";
            this.lbTenHK.Size = new System.Drawing.Size(92, 13);
            this.lbTenHK.TabIndex = 70;
            this.lbTenHK.Text = "Tên hành khách: ";
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(106, 19);
            this.txtMaHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(156, 20);
            this.txtMaHK.TabIndex = 1;
            // 
            // lbMaHK
            // 
            this.lbMaHK.AutoSize = true;
            this.lbMaHK.Location = new System.Drawing.Point(14, 22);
            this.lbMaHK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaHK.Name = "lbMaHK";
            this.lbMaHK.Size = new System.Drawing.Size(88, 13);
            this.lbMaHK.TabIndex = 68;
            this.lbMaHK.Text = "Mã hành khách: ";
            // 
            // dGVcapNhathanhKhach
            // 
            this.dGVcapNhathanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhathanhKhach.Location = new System.Drawing.Point(19, 170);
            this.dGVcapNhathanhKhach.Name = "dGVcapNhathanhKhach";
            this.dGVcapNhathanhKhach.Size = new System.Drawing.Size(534, 173);
            this.dGVcapNhathanhKhach.TabIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(371, 107);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(182, 107);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // CapNhatHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.dGVcapNhathanhKhach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHK);
            this.Controls.Add(this.lbTenHK);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.lbMaHK);
            this.Name = "CapNhatHanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hành khách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatHanhKhach_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhathanhKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHK;
        private System.Windows.Forms.Label lbTenHK;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label lbMaHK;
        private System.Windows.Forms.DataGridView dGVcapNhathanhKhach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}