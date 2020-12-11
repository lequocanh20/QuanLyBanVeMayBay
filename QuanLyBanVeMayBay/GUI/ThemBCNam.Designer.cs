namespace GUI
{
    partial class ThemBCNam
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
            this.dGVthemBCNam = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.lbMaBC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemBCNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo năm";
            // 
            // dGVthemBCNam
            // 
            this.dGVthemBCNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVthemBCNam.Location = new System.Drawing.Point(64, 122);
            this.dGVthemBCNam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dGVthemBCNam.Name = "dGVthemBCNam";
            this.dGVthemBCNam.RowTemplate.Height = 28;
            this.dGVthemBCNam.Size = new System.Drawing.Size(411, 298);
            this.dGVthemBCNam.TabIndex = 4;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(289, 85);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(168, 85);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(264, 47);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(100, 20);
            this.txtMaBC.TabIndex = 1;
            // 
            // lbMaBC
            // 
            this.lbMaBC.AutoSize = true;
            this.lbMaBC.Location = new System.Drawing.Point(194, 50);
            this.lbMaBC.Name = "lbMaBC";
            this.lbMaBC.Size = new System.Drawing.Size(67, 13);
            this.lbMaBC.TabIndex = 8;
            this.lbMaBC.Text = "Mã báo cáo:";
            // 
            // ThemBCNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 428);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMaBC);
            this.Controls.Add(this.lbMaBC);
            this.Controls.Add(this.dGVthemBCNam);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ThemBCNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo năm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BCNam_FormClosing);
            this.Load += new System.EventHandler(this.ThemBCNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVthemBCNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVthemBCNam;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Label lbMaBC;
    }
}