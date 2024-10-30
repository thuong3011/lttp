namespace ShoeStore.Views
{
    partial class frmGiay
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
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.View = new System.Windows.Forms.DataGridView();
            this.btnTimKiemTen = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chitiet = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.magiay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hanggiay = new System.Windows.Forms.ComboBox();
            this.ncc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gianhap = new System.Windows.Forms.Label();
            this.tengiay = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.piBImage = new System.Windows.Forms.PictureBox();
            this.luu = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.View);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 51);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 199);
            this.groupBoxThongTinBoPhan.TabIndex = 29;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // View
            // 
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(0, 19);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(810, 174);
            this.View.TabIndex = 0;
            // 
            // btnTimKiemTen
            // 
            this.btnTimKiemTen.Location = new System.Drawing.Point(282, 12);
            this.btnTimKiemTen.Name = "btnTimKiemTen";
            this.btnTimKiemTen.Size = new System.Drawing.Size(73, 23);
            this.btnTimKiemTen.TabIndex = 28;
            this.btnTimKiemTen.Text = "Tìm kiếm";
            this.btnTimKiemTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTen.Click += new System.EventHandler(this.btnTimKiemTen_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(179, 20);
            this.txtTimKiem.TabIndex = 27;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.luu);
            this.groupBox3.Controls.Add(this.chitiet);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Location = new System.Drawing.Point(12, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 54);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // chitiet
            // 
            this.chitiet.Location = new System.Drawing.Point(100, 19);
            this.chitiet.Name = "chitiet";
            this.chitiet.Size = new System.Drawing.Size(107, 34);
            this.chitiet.TabIndex = 3;
            this.chitiet.Text = "Chi tiết giày";
            this.chitiet.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(338, 14);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.piBImage);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Controls.Add(this.magiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.button1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.hanggiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.ncc);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label6);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label3);
            this.groupBoxThongTinChiTiet.Controls.Add(this.gianhap);
            this.groupBoxThongTinChiTiet.Controls.Add(this.tengiay);
            this.groupBoxThongTinChiTiet.Controls.Add(this.textBox1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label4);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtGiaBan);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 256);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(810, 209);
            this.groupBoxThongTinChiTiet.TabIndex = 30;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã giày";
            // 
            // magiay
            // 
            this.magiay.Location = new System.Drawing.Point(100, 15);
            this.magiay.Name = "magiay";
            this.magiay.Size = new System.Drawing.Size(100, 20);
            this.magiay.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hanggiay
            // 
            this.hanggiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hanggiay.FormattingEnabled = true;
            this.hanggiay.Location = new System.Drawing.Point(100, 105);
            this.hanggiay.Name = "hanggiay";
            this.hanggiay.Size = new System.Drawing.Size(258, 21);
            this.hanggiay.TabIndex = 35;
            // 
            // ncc
            // 
            this.ncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ncc.FormattingEnabled = true;
            this.ncc.Location = new System.Drawing.Point(100, 72);
            this.ncc.Name = "ncc";
            this.ncc.Size = new System.Drawing.Size(258, 21);
            this.ncc.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hãng giày";
            // 
            // gianhap
            // 
            this.gianhap.AutoSize = true;
            this.gianhap.Location = new System.Drawing.Point(6, 185);
            this.gianhap.Name = "gianhap";
            this.gianhap.Size = new System.Drawing.Size(53, 13);
            this.gianhap.TabIndex = 26;
            this.gianhap.Text = "Giá nhập ";
            // 
            // tengiay
            // 
            this.tengiay.Location = new System.Drawing.Point(100, 41);
            this.tengiay.Name = "tengiay";
            this.tengiay.Size = new System.Drawing.Size(258, 20);
            this.tengiay.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên giày";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(100, 146);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShoeStore.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // piBImage
            // 
            this.piBImage.Location = new System.Drawing.Point(545, 15);
            this.piBImage.Name = "piBImage";
            this.piBImage.Size = new System.Drawing.Size(253, 183);
            this.piBImage.TabIndex = 38;
            this.piBImage.TabStop = false;
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(545, 14);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(97, 39);
            this.luu.TabIndex = 4;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            // 
            // frmGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Controls.Add(this.btnTimKiemTen);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Name = "frmGiay";
            this.Text = "Giày";
            this.Load += new System.EventHandler(this.frmGiay_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.Button btnTimKiemTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView View;
		private System.Windows.Forms.Label gianhap;
		private System.Windows.Forms.TextBox tengiay;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox hanggiay;
		private System.Windows.Forms.ComboBox ncc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox magiay;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button chitiet;
        private System.Windows.Forms.PictureBox piBImage;
        private System.Windows.Forms.Button luu;
    }
}