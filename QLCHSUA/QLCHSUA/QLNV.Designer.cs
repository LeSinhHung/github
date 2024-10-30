namespace QLCHSUA
{
    partial class QLNV
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtime_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.nut_tim = new System.Windows.Forms.Button();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nut_them = new System.Windows.Forms.Button();
            this.nut_sua = new System.Windows.Forms.Button();
            this.nut_xoa = new System.Windows.Forms.Button();
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
            this.groupBox1.Size = new System.Drawing.Size(751, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(739, 223);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtime_ngaysinh);
            this.groupBox2.Controls.Add(this.nut_tim);
            this.groupBox2.Controls.Add(this.tb_tim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_diachi);
            this.groupBox2.Controls.Add(this.tb_sdt);
            this.groupBox2.Controls.Add(this.tb_tennv);
            this.groupBox2.Controls.Add(this.tb_manv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // dtime_ngaysinh
            // 
            this.dtime_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_ngaysinh.Location = new System.Drawing.Point(98, 151);
            this.dtime_ngaysinh.Name = "dtime_ngaysinh";
            this.dtime_ngaysinh.Size = new System.Drawing.Size(120, 22);
            this.dtime_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtime_ngaysinh.TabIndex = 13;
            // 
            // nut_tim
            // 
            this.nut_tim.BackColor = System.Drawing.Color.LightBlue;
            this.nut_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nut_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nut_tim.Location = new System.Drawing.Point(387, 207);
            this.nut_tim.Name = "nut_tim";
            this.nut_tim.Size = new System.Drawing.Size(85, 29);
            this.nut_tim.TabIndex = 12;
            this.nut_tim.Text = "Tìm kiếm";
            this.nut_tim.UseVisualStyleBackColor = false;
            this.nut_tim.Click += new System.EventHandler(this.nut_tim_Click);
            // 
            // tb_tim
            // 
            this.tb_tim.Location = new System.Drawing.Point(169, 210);
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(176, 22);
            this.tb_tim.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm theo mã";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(452, 94);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(118, 22);
            this.tb_diachi.TabIndex = 8;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(452, 46);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(118, 22);
            this.tb_sdt.TabIndex = 7;
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(98, 94);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(120, 22);
            this.tb_tennv.TabIndex = 6;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(98, 43);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(120, 22);
            this.tb_manv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(384, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // nut_them
            // 
            this.nut_them.BackColor = System.Drawing.Color.LightGreen;
            this.nut_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nut_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nut_them.Location = new System.Drawing.Point(688, 299);
            this.nut_them.Name = "nut_them";
            this.nut_them.Size = new System.Drawing.Size(75, 37);
            this.nut_them.TabIndex = 2;
            this.nut_them.Text = "Thêm";
            this.nut_them.UseVisualStyleBackColor = false;
            this.nut_them.Click += new System.EventHandler(this.nut_them_Click);
            // 
            // nut_sua
            // 
            this.nut_sua.BackColor = System.Drawing.Color.Yellow;
            this.nut_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nut_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nut_sua.Location = new System.Drawing.Point(688, 383);
            this.nut_sua.Name = "nut_sua";
            this.nut_sua.Size = new System.Drawing.Size(69, 37);
            this.nut_sua.TabIndex = 3;
            this.nut_sua.Text = "Sửa";
            this.nut_sua.UseVisualStyleBackColor = false;
            this.nut_sua.Click += new System.EventHandler(this.nut_sua_Click);
            // 
            // nut_xoa
            // 
            this.nut_xoa.BackColor = System.Drawing.Color.Red;
            this.nut_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nut_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nut_xoa.ForeColor = System.Drawing.Color.White;
            this.nut_xoa.Location = new System.Drawing.Point(688, 478);
            this.nut_xoa.Name = "nut_xoa";
            this.nut_xoa.Size = new System.Drawing.Size(69, 37);
            this.nut_xoa.TabIndex = 4;
            this.nut_xoa.Text = "Xóa";
            this.nut_xoa.UseVisualStyleBackColor = false;
            this.nut_xoa.Click += new System.EventHandler(this.nut_xoa_Click);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 530);
            this.Controls.Add(this.nut_xoa);
            this.Controls.Add(this.nut_sua);
            this.Controls.Add(this.nut_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QLNV_Load);
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
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nut_tim;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Button nut_them;
        private System.Windows.Forms.Button nut_sua;
        private System.Windows.Forms.Button nut_xoa;
        private System.Windows.Forms.DateTimePicker dtime_ngaysinh;
    }
}