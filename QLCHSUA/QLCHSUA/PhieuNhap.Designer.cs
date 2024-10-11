namespace QLCHSUA
{
    partial class PhieuNhap
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_map = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.tb_tenncc = new System.Windows.Forms.TextBox();
            this.dtime_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.nut_them = new System.Windows.Forms.Button();
            this.nut_sua = new System.Windows.Forms.Button();
            this.nut_xoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.nut_tim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(858, 169);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nut_tim);
            this.groupBox2.Controls.Add(this.tb_tim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtime_ngaynhap);
            this.groupBox2.Controls.Add(this.tb_tenncc);
            this.groupBox2.Controls.Add(this.tb_tong);
            this.groupBox2.Controls.Add(this.tb_masp);
            this.groupBox2.Controls.Add(this.tb_manv);
            this.groupBox2.Controls.Add(this.tb_map);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MaNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaSP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NgayNhap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "TenNCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tong";
            // 
            // tb_map
            // 
            this.tb_map.Location = new System.Drawing.Point(102, 59);
            this.tb_map.Name = "tb_map";
            this.tb_map.Size = new System.Drawing.Size(177, 22);
            this.tb_map.TabIndex = 6;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(102, 112);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(177, 22);
            this.tb_manv.TabIndex = 7;
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(102, 165);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(177, 22);
            this.tb_masp.TabIndex = 8;
            // 
            // tb_tong
            // 
            this.tb_tong.Location = new System.Drawing.Point(410, 165);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(134, 22);
            this.tb_tong.TabIndex = 9;
            // 
            // tb_tenncc
            // 
            this.tb_tenncc.Location = new System.Drawing.Point(410, 115);
            this.tb_tenncc.Name = "tb_tenncc";
            this.tb_tenncc.Size = new System.Drawing.Size(134, 22);
            this.tb_tenncc.TabIndex = 10;
            // 
            // dtime_ngaynhap
            // 
            this.dtime_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_ngaynhap.Location = new System.Drawing.Point(410, 59);
            this.dtime_ngaynhap.Name = "dtime_ngaynhap";
            this.dtime_ngaynhap.Size = new System.Drawing.Size(134, 22);
            this.dtime_ngaynhap.TabIndex = 11;
            // 
            // nut_them
            // 
            this.nut_them.Location = new System.Drawing.Point(735, 266);
            this.nut_them.Name = "nut_them";
            this.nut_them.Size = new System.Drawing.Size(75, 33);
            this.nut_them.TabIndex = 2;
            this.nut_them.Text = "Thêm";
            this.nut_them.UseVisualStyleBackColor = true;
            this.nut_them.Click += new System.EventHandler(this.nut_them_Click);
            // 
            // nut_sua
            // 
            this.nut_sua.Location = new System.Drawing.Point(735, 336);
            this.nut_sua.Name = "nut_sua";
            this.nut_sua.Size = new System.Drawing.Size(75, 33);
            this.nut_sua.TabIndex = 3;
            this.nut_sua.Text = "Sửa";
            this.nut_sua.UseVisualStyleBackColor = true;
            this.nut_sua.Click += new System.EventHandler(this.nut_sua_Click);
            // 
            // nut_xoa
            // 
            this.nut_xoa.Location = new System.Drawing.Point(735, 413);
            this.nut_xoa.Name = "nut_xoa";
            this.nut_xoa.Size = new System.Drawing.Size(75, 27);
            this.nut_xoa.TabIndex = 4;
            this.nut_xoa.Text = "Xóa";
            this.nut_xoa.UseVisualStyleBackColor = true;
            this.nut_xoa.Click += new System.EventHandler(this.nut_xoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tìm theo mã phiếu";
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(179, 231);
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(160, 22);
            this.tb_tim.TabIndex = 13;
            // 
            // nut_tim
            // 
            this.nut_tim.Location = new System.Drawing.Point(401, 231);
            this.nut_tim.Name = "nut_tim";
            this.nut_tim.Size = new System.Drawing.Size(75, 23);
            this.nut_tim.TabIndex = 14;
            this.nut_tim.Text = "Tìm";
            this.nut_tim.UseVisualStyleBackColor = true;
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 539);
            this.Controls.Add(this.nut_xoa);
            this.Controls.Add(this.nut_sua);
            this.Controls.Add(this.nut_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtime_ngaynhap;
        private System.Windows.Forms.TextBox tb_tenncc;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.TextBox tb_map;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nut_tim;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nut_them;
        private System.Windows.Forms.Button nut_sua;
        private System.Windows.Forms.Button nut_xoa;
    }
}