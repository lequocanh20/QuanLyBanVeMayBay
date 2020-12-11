
namespace GUI
{
    partial class ThemHanhKhach
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
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.lbMaHK = new System.Windows.Forms.Label();
            this.txtTenHK = new System.Windows.Forms.TextBox();
            this.lbTenHK = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dGVhanhKhach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVhanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHK
            // 
            this.txtMaHK.Location = new System.Drawing.Point(111, 54);
            this.txtMaHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(156, 20);
            this.txtMaHK.TabIndex = 1;
            // 
            // lbMaHK
            // 
            this.lbMaHK.AutoSize = true;
            this.lbMaHK.Location = new System.Drawing.Point(19, 57);
            this.lbMaHK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaHK.Name = "lbMaHK";
            this.lbMaHK.Size = new System.Drawing.Size(88, 13);
            this.lbMaHK.TabIndex = 60;
            this.lbMaHK.Text = "Mã hành khách: ";
            // 
            // txtTenHK
            // 
            this.txtTenHK.Location = new System.Drawing.Point(111, 94);
            this.txtTenHK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(156, 20);
            this.txtTenHK.TabIndex = 2;
            // 
            // lbTenHK
            // 
            this.lbTenHK.AutoSize = true;
            this.lbTenHK.Location = new System.Drawing.Point(19, 97);
            this.lbTenHK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenHK.Name = "lbTenHK";
            this.lbTenHK.Size = new System.Drawing.Size(92, 13);
            this.lbTenHK.TabIndex = 62;
            this.lbTenHK.Text = "Tên hành khách: ";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(400, 54);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(156, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "CMND:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(400, 94);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(156, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(308, 97);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbDienThoai.TabIndex = 66;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(374, 145);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 35);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(185, 145);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(81, 34);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dGVhanhKhach
            // 
            this.dGVhanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVhanhKhach.Location = new System.Drawing.Point(22, 208);
            this.dGVhanhKhach.Name = "dGVhanhKhach";
            this.dGVhanhKhach.Size = new System.Drawing.Size(534, 173);
            this.dGVhanhKhach.TabIndex = 7;
            // 
            // ThemHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 389);
            this.Controls.Add(this.dGVhanhKhach);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHK);
            this.Controls.Add(this.lbTenHK);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.lbMaHK);
            this.Name = "ThemHanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hành khách";
            this.Load += new System.EventHandler(this.ThemHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVhanhKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label lbMaHK;
        private System.Windows.Forms.TextBox txtTenHK;
        private System.Windows.Forms.Label lbTenHK;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dGVhanhKhach;
    }
}