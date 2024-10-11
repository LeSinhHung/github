namespace QLCHSUA
{
    partial class SP
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.tb_hangsx = new System.Windows.Forms.TextBox();
            this.dtime_hsd = new System.Windows.Forms.DateTimePicker();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_loaisp = new System.Windows.Forms.TextBox();
            this.nut_them = new System.Windows.Forms.Button();
            this.nut_sua = new System.Windows.Forms.Button();
            this.nut_xoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 214);
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
            this.dgv.Size = new System.Drawing.Size(807, 187);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.nut_tim);
            this.groupBox2.Controls.Add(this.tb_tim);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_loaisp);
            this.groupBox2.Controls.Add(this.tb_soluong);
            this.groupBox2.Controls.Add(this.tb_gia);
            this.groupBox2.Controls.Add(this.tb_mota);
            this.groupBox2.Controls.Add(this.dtime_hsd);
            this.groupBox2.Controls.Add(this.tb_hangsx);
            this.groupBox2.Controls.Add(this.tb_masp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HangSX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HSD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "MoTa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "SoLuong";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "LoaiSP";
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(106, 56);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(167, 22);
            this.tb_masp.TabIndex = 7;
            // 
            // tb_hangsx
            // 
            this.tb_hangsx.Location = new System.Drawing.Point(106, 114);
            this.tb_hangsx.Name = "tb_hangsx";
            this.tb_hangsx.Size = new System.Drawing.Size(167, 22);
            this.tb_hangsx.TabIndex = 8;
            // 
            // dtime_hsd
            // 
            this.dtime_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_hsd.Location = new System.Drawing.Point(106, 168);
            this.dtime_hsd.Name = "dtime_hsd";
            this.dtime_hsd.Size = new System.Drawing.Size(167, 22);
            this.dtime_hsd.TabIndex = 9;
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(106, 223);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(167, 22);
            this.tb_mota.TabIndex = 10;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(427, 56);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(147, 22);
            this.tb_gia.TabIndex = 11;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(427, 114);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(147, 22);
            this.tb_soluong.TabIndex = 12;
            // 
            // tb_loaisp
            // 
            this.tb_loaisp.Location = new System.Drawing.Point(427, 165);
            this.tb_loaisp.Name = "tb_loaisp";
            this.tb_loaisp.Size = new System.Drawing.Size(147, 22);
            this.tb_loaisp.TabIndex = 13;
            // 
            // nut_them
            // 
            this.nut_them.Location = new System.Drawing.Point(736, 274);
            this.nut_them.Name = "nut_them";
            this.nut_them.Size = new System.Drawing.Size(89, 33);
            this.nut_them.TabIndex = 2;
            this.nut_them.Text = "Thêm";
            this.nut_them.UseVisualStyleBackColor = true;
            this.nut_them.Click += new System.EventHandler(this.nut_them_Click);
            // 
            // nut_sua
            // 
            this.nut_sua.Location = new System.Drawing.Point(736, 361);
            this.nut_sua.Name = "nut_sua";
            this.nut_sua.Size = new System.Drawing.Size(89, 37);
            this.nut_sua.TabIndex = 3;
            this.nut_sua.Text = "Sửa";
            this.nut_sua.UseVisualStyleBackColor = true;
            this.nut_sua.Click += new System.EventHandler(this.nut_sua_Click);
            // 
            // nut_xoa
            // 
            this.nut_xoa.Location = new System.Drawing.Point(736, 470);
            this.nut_xoa.Name = "nut_xoa";
            this.nut_xoa.Size = new System.Drawing.Size(89, 36);
            this.nut_xoa.TabIndex = 4;
            this.nut_xoa.Text = "Xóa";
            this.nut_xoa.UseVisualStyleBackColor = true;
            this.nut_xoa.Click += new System.EventHandler(this.nut_xoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm theo MaSP";
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(146, 274);
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(127, 22);
            this.tb_tim.TabIndex = 15;
            // 
            // nut_tim
            // 
            this.nut_tim.Location = new System.Drawing.Point(332, 274);
            this.nut_tim.Name = "nut_tim";
            this.nut_tim.Size = new System.Drawing.Size(75, 26);
            this.nut_tim.TabIndex = 16;
            this.nut_tim.Text = "Tìm kiếm";
            this.nut_tim.UseVisualStyleBackColor = true;
            // 
            // SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 578);
            this.Controls.Add(this.nut_xoa);
            this.Controls.Add(this.nut_sua);
            this.Controls.Add(this.nut_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SP";
            this.Text = "SP";
            this.Load += new System.EventHandler(this.SP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_loaisp;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.DateTimePicker dtime_hsd;
        private System.Windows.Forms.TextBox tb_hangsx;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nut_them;
        private System.Windows.Forms.Button nut_sua;
        private System.Windows.Forms.Button nut_xoa;
        private System.Windows.Forms.Button nut_tim;
        private System.Windows.Forms.TextBox tb_tim;
    }
}