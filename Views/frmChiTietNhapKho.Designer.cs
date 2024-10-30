namespace ShoeStore.Views
{
    partial class frmChiTietNhapKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemChiTietNhapKho = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.View = new System.Windows.Forms.DataGridView();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.gianhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TenGiay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemChiTietNhapKho);
            this.groupBox1.Location = new System.Drawing.Point(18, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 110);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(402, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemChiTietNhapKho
            // 
            this.btnThemChiTietNhapKho.Location = new System.Drawing.Point(189, 39);
            this.btnThemChiTietNhapKho.Name = "btnThemChiTietNhapKho";
            this.btnThemChiTietNhapKho.Size = new System.Drawing.Size(80, 40);
            this.btnThemChiTietNhapKho.TabIndex = 4;
            this.btnThemChiTietNhapKho.Text = "Thêm giày";
            this.btnThemChiTietNhapKho.UseVisualStyleBackColor = true;
            this.btnThemChiTietNhapKho.Click += new System.EventHandler(this.btnThemChiTietNhapKho_Click_1);
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.View);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 191);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 199);
            this.groupBoxThongTinBoPhan.TabIndex = 38;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // View
            // 
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(0, 19);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(810, 165);
            this.View.TabIndex = 0;
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.label7);
            this.groupBoxThongTinChiTiet.Controls.Add(this.mau);
            this.groupBoxThongTinChiTiet.Controls.Add(this.textBox2);
            this.groupBoxThongTinChiTiet.Controls.Add(this.textBox1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label6);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label4);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.size);
            this.groupBoxThongTinChiTiet.Controls.Add(this.soluong);
            this.groupBoxThongTinChiTiet.Controls.Add(this.gianhap);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label5);
            this.groupBoxThongTinChiTiet.Controls.Add(this.TenGiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label3);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(810, 150);
            this.groupBoxThongTinChiTiet.TabIndex = 39;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            this.groupBoxThongTinChiTiet.Enter += new System.EventHandler(this.groupBoxThongTinChiTiet_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hãng giày";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(331, 74);
            this.size.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(57, 20);
            this.size.TabIndex = 17;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(471, 74);
            this.soluong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(57, 20);
            this.soluong.TabIndex = 16;
            // 
            // gianhap
            // 
            this.gianhap.Location = new System.Drawing.Point(646, 77);
            this.gianhap.Name = "gianhap";
            this.gianhap.Size = new System.Drawing.Size(138, 20);
            this.gianhap.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giá nhập";
            // 
            // TenGiay
            // 
            this.TenGiay.FormattingEnabled = true;
            this.TenGiay.Location = new System.Drawing.Point(85, 114);
            this.TenGiay.Name = "TenGiay";
            this.TenGiay.Size = new System.Drawing.Size(312, 21);
            this.TenGiay.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giày";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 22;
            // 
            // mau
            // 
            this.mau.Location = new System.Drawing.Point(523, 114);
            this.mau.Name = "mau";
            this.mau.Size = new System.Drawing.Size(100, 20);
            this.mau.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Màu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmChiTietNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Name = "frmChiTietNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết nhập kho";
            this.Load += new System.EventHandler(this.frmChiTietNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemChiTietNhapKho;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox gianhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TenGiay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown size;
		private System.Windows.Forms.NumericUpDown soluong;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mau;
    }
}