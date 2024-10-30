namespace ShoeStore.Views
{
    partial class frmHoaDon
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
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sohd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaykt = new System.Windows.Forms.DateTimePicker();
            this.ngaybd = new System.Windows.Forms.DateTimePicker();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(12, 472);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(165, 26);
            this.btnChiTietHoaDon.TabIndex = 35;
            this.btnChiTietHoaDon.Text = "Chi tiết hoá đơn";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.textBox1);
            this.groupBoxThongTinBoPhan.Controls.Add(this.label3);
            this.groupBoxThongTinBoPhan.Controls.Add(this.dataGridView1);
            this.groupBoxThongTinBoPhan.Controls.Add(this.sohd);
            this.groupBoxThongTinBoPhan.Controls.Add(this.label2);
            this.groupBoxThongTinBoPhan.Controls.Add(this.label1);
            this.groupBoxThongTinBoPhan.Controls.Add(this.ngaykt);
            this.groupBoxThongTinBoPhan.Controls.Add(this.ngaybd);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(810, 454);
            this.groupBoxThongTinBoPhan.TabIndex = 33;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            this.groupBoxThongTinBoPhan.Enter += new System.EventHandler(this.groupBoxThongTinBoPhan_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 301);
            this.dataGridView1.TabIndex = 5;
            // 
            // sohd
            // 
            this.sohd.AutoSize = true;
            this.sohd.Location = new System.Drawing.Point(516, 45);
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(0, 13);
            this.sohd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê hóa đơn từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "đến";
            // 
            // ngaykt
            // 
            this.ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaykt.Location = new System.Drawing.Point(382, 38);
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.Size = new System.Drawing.Size(100, 20);
            this.ngaykt.TabIndex = 1;
            // 
            // ngaybd
            // 
            this.ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybd.Location = new System.Drawing.Point(246, 38);
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.Size = new System.Drawing.Size(98, 20);
            this.ngaybd.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmHoaDon";
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinBoPhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.DateTimePicker ngaykt;
        private System.Windows.Forms.DateTimePicker ngaybd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sohd;
        private System.Windows.Forms.TextBox textBox1;
    }
}