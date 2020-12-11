
namespace GUI
{
    partial class TraCuuHanhKhach
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
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.lbtimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dGVtraCuuHK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVtraCuuHK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(289, 52);
            this.txtTraCuu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(156, 20);
            this.txtTraCuu.TabIndex = 1;
            // 
            // lbtimKiem
            // 
            this.lbtimKiem.AutoSize = true;
            this.lbtimKiem.Location = new System.Drawing.Point(152, 55);
            this.lbtimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtimKiem.Name = "lbtimKiem";
            this.lbtimKiem.Size = new System.Drawing.Size(116, 13);
            this.lbtimKiem.TabIndex = 70;
            this.lbtimKiem.Text = "Nhập thông tin tra cứu:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(245, 84);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dGVtraCuuHK
            // 
            this.dGVtraCuuHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVtraCuuHK.Location = new System.Drawing.Point(19, 134);
            this.dGVtraCuuHK.Name = "dGVtraCuuHK";
            this.dGVtraCuuHK.Size = new System.Drawing.Size(534, 304);
            this.dGVtraCuuHK.TabIndex = 3;
            // 
            // TraCuuHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.dGVtraCuuHK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.lbtimKiem);
            this.Name = "TraCuuHanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hành khách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraCuuHanhKhach_FormClosing);
            this.Load += new System.EventHandler(this.TraCuuHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVtraCuuHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label lbtimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dGVtraCuuHK;
    }
}