namespace GUI_ECommerceBooks.UIBanHang
{
    partial class UC_GioHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GioHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ThemGioHang = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_TongTien = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_ThemGioHang
            // 
            this.btn_ThemGioHang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemGioHang.Appearance.Options.UseFont = true;
            this.btn_ThemGioHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemGioHang.ImageOptions.Image")));
            this.btn_ThemGioHang.Location = new System.Drawing.Point(352, 30);
            this.btn_ThemGioHang.Name = "btn_ThemGioHang";
            this.btn_ThemGioHang.Size = new System.Drawing.Size(120, 36);
            this.btn_ThemGioHang.TabIndex = 6;
            this.btn_ThemGioHang.Text = "Xóa khỏi giỏ hàng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(352, 216);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 42);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thanh Toán";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTien.Appearance.Options.UseFont = true;
            this.lbl_TongTien.Appearance.Options.UseForeColor = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(9, 222);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(97, 24);
            this.lbl_TongTien.TabIndex = 8;
            this.lbl_TongTien.Text = "Tổng Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giỏ Hàng ----------";
            // 
            // UC_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_ThemGioHang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_GioHang";
            this.Size = new System.Drawing.Size(473, 276);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemGioHang;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lbl_TongTien;
        private System.Windows.Forms.Label label1;
    }
}
