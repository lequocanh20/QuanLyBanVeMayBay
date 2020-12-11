namespace GUI
{
    partial class ThemBCThang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGVbaoCaoThang = new System.Windows.Forms.DataGridView();
            this.lbMaBC = new System.Windows.Forms.Label();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVbaoCaoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo tháng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dGVbaoCaoThang
            // 
            this.dGVbaoCaoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVbaoCaoThang.Location = new System.Drawing.Point(11, 117);
            this.dGVbaoCaoThang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVbaoCaoThang.Name = "dGVbaoCaoThang";
            this.dGVbaoCaoThang.RowTemplate.Height = 28;
            this.dGVbaoCaoThang.Size = new System.Drawing.Size(511, 295);
            this.dGVbaoCaoThang.TabIndex = 3;
            this.dGVbaoCaoThang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVbaoCaoThang_CellContentClick);
            // 
            // lbMaBC
            // 
            this.lbMaBC.AutoSize = true;
            this.lbMaBC.Location = new System.Drawing.Point(78, 48);
            this.lbMaBC.Name = "lbMaBC";
            this.lbMaBC.Size = new System.Drawing.Size(67, 13);
            this.lbMaBC.TabIndex = 4;
            this.lbMaBC.Text = "Mã báo cáo:";
            this.lbMaBC.Click += new System.EventHandler(this.lbMaBC_Click);
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(148, 45);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(100, 20);
            this.txtMaBC.TabIndex = 5;
            this.txtMaBC.TextChanged += new System.EventHandler(this.txtMaBC_TextChanged);
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(305, 48);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(41, 13);
            this.lbThang.TabIndex = 4;
            this.lbThang.Text = "Tháng:";
            this.lbThang.Click += new System.EventHandler(this.lbThang_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(352, 45);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(37, 20);
            this.txtThang.TabIndex = 5;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(182, 81);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(279, 81);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ThemBCThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 422);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.txtMaBC);
            this.Controls.Add(this.lbMaBC);
            this.Controls.Add(this.dGVbaoCaoThang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ThemBCThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tháng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BCThang_FormClosing);
            this.Load += new System.EventHandler(this.ThemBCThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVbaoCaoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVbaoCaoThang;
        private System.Windows.Forms.Label lbMaBC;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnQuayLai;
    }
}