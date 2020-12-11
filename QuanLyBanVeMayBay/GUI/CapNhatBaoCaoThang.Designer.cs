
namespace GUI
{
    partial class CapNhatBaoCaoThang
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
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.lbMaBC = new System.Windows.Forms.Label();
            this.dGVcapNhatBaoCaoThang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatBaoCaoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(298, 83);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(181, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(272, 48);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(37, 20);
            this.txtThang.TabIndex = 2;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(225, 51);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(41, 13);
            this.lbThang.TabIndex = 9;
            this.lbThang.Text = "Tháng:";
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(89, 48);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(100, 20);
            this.txtMaBC.TabIndex = 1;
            // 
            // lbMaBC
            // 
            this.lbMaBC.AutoSize = true;
            this.lbMaBC.Location = new System.Drawing.Point(16, 51);
            this.lbMaBC.Name = "lbMaBC";
            this.lbMaBC.Size = new System.Drawing.Size(67, 13);
            this.lbMaBC.TabIndex = 10;
            this.lbMaBC.Text = "Mã báo cáo:";
            // 
            // dGVcapNhatBaoCaoThang
            // 
            this.dGVcapNhatBaoCaoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhatBaoCaoThang.Location = new System.Drawing.Point(19, 119);
            this.dGVcapNhatBaoCaoThang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVcapNhatBaoCaoThang.Name = "dGVcapNhatBaoCaoThang";
            this.dGVcapNhatBaoCaoThang.RowTemplate.Height = 28;
            this.dGVcapNhatBaoCaoThang.Size = new System.Drawing.Size(511, 295);
            this.dGVcapNhatBaoCaoThang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Báo cáo tháng";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(329, 51);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(86, 13);
            this.lbTongDoanhThu.TabIndex = 10;
            this.lbTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(421, 48);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(109, 20);
            this.txtTongDoanhThu.TabIndex = 3;
            // 
            // CapNhatBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 422);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.txtMaBC);
            this.Controls.Add(this.lbMaBC);
            this.Controls.Add(this.dGVcapNhatBaoCaoThang);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatBaoCaoThang";
            this.Text = "CapNhatBaoCaoThang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatBaoCaoThang_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatBaoCaoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatBaoCaoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Label lbMaBC;
        private System.Windows.Forms.DataGridView dGVcapNhatBaoCaoThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
    }
}