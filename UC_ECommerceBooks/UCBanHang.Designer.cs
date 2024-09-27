namespace UC_ECommerceBooks
{
    partial class UCBanHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaCungUng = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemChiTietSP = new DevExpress.XtraEditors.SimpleButton();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuuChiTietPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(460, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhập Hàng";
            // 
            // cbNhaCungUng
            // 
            this.cbNhaCungUng.FormattingEnabled = true;
            this.cbNhaCungUng.Location = new System.Drawing.Point(155, 96);
            this.cbNhaCungUng.Name = "cbNhaCungUng";
            this.cbNhaCungUng.Size = new System.Drawing.Size(240, 24);
            this.cbNhaCungUng.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemChiTietSP);
            this.groupBox1.Controls.Add(this.dgvSanPham);
            this.groupBox1.Location = new System.Drawing.Point(24, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 437);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Quyển Sách";
            // 
            // btnThemChiTietSP
            // 
            this.btnThemChiTietSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTietSP.ImageOptions.Image")));
            this.btnThemChiTietSP.Location = new System.Drawing.Point(548, 379);
            this.btnThemChiTietSP.Name = "btnThemChiTietSP";
            this.btnThemChiTietSP.Size = new System.Drawing.Size(76, 43);
            this.btnThemChiTietSP.TabIndex = 9;
            this.btnThemChiTietSP.Text = "Thêm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(18, 35);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(618, 320);
            this.dgvSanPham.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.dateNgayKetThuc);
            this.groupBox2.Controls.Add(this.dateNgayBatDau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnHuyPhieuNhap);
            this.groupBox2.Controls.Add(this.btnLuuPhieuNhap);
            this.groupBox2.Controls.Add(this.btnTaoPhieuNhap);
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(704, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 327);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Nhập";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(627, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 25);
            this.textBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành Tiền";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(371, 73);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày Nhập";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 25);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Phiếu Nhập";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(458, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 43);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Location = new System.Drawing.Point(277, 30);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(160, 22);
            this.dateNgayKetThuc.TabIndex = 7;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Location = new System.Drawing.Point(70, 30);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(150, 22);
            this.dateNgayBatDau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ";
            // 
            // btnHuyPhieuNhap
            // 
            this.btnHuyPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyPhieuNhap.ImageOptions.Image")));
            this.btnHuyPhieuNhap.Location = new System.Drawing.Point(597, 273);
            this.btnHuyPhieuNhap.Name = "btnHuyPhieuNhap";
            this.btnHuyPhieuNhap.Size = new System.Drawing.Size(129, 43);
            this.btnHuyPhieuNhap.TabIndex = 3;
            this.btnHuyPhieuNhap.Text = "Hủy Phiếu Nhập";
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuNhap.ImageOptions.Image")));
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(449, 273);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(142, 43);
            this.btnLuuPhieuNhap.TabIndex = 2;
            this.btnLuuPhieuNhap.Text = "Lưu Phiếu Nhập";
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuNhap.ImageOptions.Image")));
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(349, 273);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(94, 43);
            this.btnTaoPhieuNhap.TabIndex = 1;
            this.btnTaoPhieuNhap.Text = "Tạo Mới";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(32, 109);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(696, 158);
            this.dgvPhieuNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà Cung Ứng Sách";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuuChiTietPhieuNhap);
            this.groupBox3.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(704, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 225);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu Nhập";
            // 
            // btnLuuChiTietPhieuNhap
            // 
            this.btnLuuChiTietPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuChiTietPhieuNhap.ImageOptions.Image")));
            this.btnLuuChiTietPhieuNhap.Location = new System.Drawing.Point(632, 11);
            this.btnLuuChiTietPhieuNhap.Name = "btnLuuChiTietPhieuNhap";
            this.btnLuuChiTietPhieuNhap.Size = new System.Drawing.Size(94, 43);
            this.btnLuuChiTietPhieuNhap.TabIndex = 15;
            this.btnLuuChiTietPhieuNhap.Text = "Lưu";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(30, 60);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(696, 159);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            // 
            // UCBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNhaCungUng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCBanHang";
            this.Size = new System.Drawing.Size(1502, 675);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhaCungUng;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnTaoPhieuNhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnHuyPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnLuuPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnThemChiTietSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnLuuChiTietPhieuNhap;
    }
}
