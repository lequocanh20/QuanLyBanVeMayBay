
namespace GUI
{
    partial class CapNhatBaoCaoNam
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
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.lbMaBC = new System.Windows.Forms.Label();
            this.dGVcapNhatBaoCaoNam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatBaoCaoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(302, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(185, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(276, 43);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(37, 20);
            this.txtNam.TabIndex = 20;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(229, 46);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(32, 13);
            this.lbThang.TabIndex = 17;
            this.lbThang.Text = "Năm:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(425, 46);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(109, 20);
            this.txtTongDoanhThu.TabIndex = 21;
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(333, 46);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(86, 13);
            this.lbTongDoanhThu.TabIndex = 18;
            this.lbTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(93, 43);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(100, 20);
            this.txtMaBC.TabIndex = 22;
            // 
            // lbMaBC
            // 
            this.lbMaBC.AutoSize = true;
            this.lbMaBC.Location = new System.Drawing.Point(20, 46);
            this.lbMaBC.Name = "lbMaBC";
            this.lbMaBC.Size = new System.Drawing.Size(67, 13);
            this.lbMaBC.TabIndex = 19;
            this.lbMaBC.Text = "Mã báo cáo:";
            // 
            // dGVcapNhatBaoCaoNam
            // 
            this.dGVcapNhatBaoCaoNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVcapNhatBaoCaoNam.Location = new System.Drawing.Point(23, 114);
            this.dGVcapNhatBaoCaoNam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVcapNhatBaoCaoNam.Name = "dGVcapNhatBaoCaoNam";
            this.dGVcapNhatBaoCaoNam.RowTemplate.Height = 28;
            this.dGVcapNhatBaoCaoNam.Size = new System.Drawing.Size(511, 295);
            this.dGVcapNhatBaoCaoNam.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Báo cáo năm";
            // 
            // CapNhatBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.txtMaBC);
            this.Controls.Add(this.lbMaBC);
            this.Controls.Add(this.dGVcapNhatBaoCaoNam);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatBaoCaoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatBaoCaoNam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatBaoCaoNam_FormClosing);
            this.Load += new System.EventHandler(this.CapNhatBaoCaoNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVcapNhatBaoCaoNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Label lbMaBC;
        private System.Windows.Forms.DataGridView dGVcapNhatBaoCaoNam;
        private System.Windows.Forms.Label label1;
    }
}