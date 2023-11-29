namespace thuVienControls
{
    partial class gd_Them_sinhvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masket_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_masv = new thietKeControls.txtChiNhapSo();
            this.txt_hotensv = new thietKeControls.txtChiNhapChu();
            this.txt_cccd = new thietKeControls.txtCCCD();
            this.txtEmail1 = new thietKeControls.txtEmail();
            this.txt_sodienthoai = new thietKeControls.txtChiNhapSo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_nu = new System.Windows.Forms.RadioButton();
            this.radio_nam = new System.Windows.Forms.RadioButton();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_masket_ngaysinh
            // 
            this.txt_masket_ngaysinh.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.txt_masket_ngaysinh.Location = new System.Drawing.Point(203, 196);
            this.txt_masket_ngaysinh.Mask = "00/00/0000";
            this.txt_masket_ngaysinh.Name = "txt_masket_ngaysinh";
            this.txt_masket_ngaysinh.Size = new System.Drawing.Size(201, 22);
            this.txt_masket_ngaysinh.TabIndex = 6;
            this.txt_masket_ngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_masket_ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(203, 79);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(201, 22);
            this.txt_masv.TabIndex = 13;
            // 
            // txt_hotensv
            // 
            this.txt_hotensv.Location = new System.Drawing.Point(203, 142);
            this.txt_hotensv.Name = "txt_hotensv";
            this.txt_hotensv.Size = new System.Drawing.Size(201, 22);
            this.txt_hotensv.TabIndex = 14;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(203, 255);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(201, 22);
            this.txt_cccd.TabIndex = 15;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(203, 494);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(201, 22);
            this.txtEmail1.TabIndex = 16;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(203, 374);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(201, 22);
            this.txt_sodienthoai.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(227, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_nu);
            this.groupBox2.Controls.Add(this.radio_nam);
            this.groupBox2.Location = new System.Drawing.Point(203, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 57);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // radio_nu
            // 
            this.radio_nu.AutoSize = true;
            this.radio_nu.Location = new System.Drawing.Point(131, 24);
            this.radio_nu.Name = "radio_nu";
            this.radio_nu.Size = new System.Drawing.Size(45, 20);
            this.radio_nu.TabIndex = 21;
            this.radio_nu.TabStop = true;
            this.radio_nu.Text = "Nữ";
            this.radio_nu.UseVisualStyleBackColor = true;
            // 
            // radio_nam
            // 
            this.radio_nam.AutoSize = true;
            this.radio_nam.Location = new System.Drawing.Point(22, 24);
            this.radio_nam.Name = "radio_nam";
            this.radio_nam.Size = new System.Drawing.Size(57, 20);
            this.radio_nam.TabIndex = 20;
            this.radio_nam.Text = "Nam";
            this.radio_nam.UseVisualStyleBackColor = true;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(203, 442);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(200, 22);
            this.txt_diachi.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 34);
            this.label9.TabIndex = 22;
            this.label9.Text = "Thêm Sinh Viên";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(388, 601);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 16);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Thoát";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gd_Them_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.txt_hotensv);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_masket_ngaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gd_Them_sinhvien";
            this.Size = new System.Drawing.Size(469, 633);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_masket_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private thietKeControls.txtChiNhapSo txt_masv;
        private thietKeControls.txtChiNhapChu txt_hotensv;
        private thietKeControls.txtCCCD txt_cccd;
        private thietKeControls.txtEmail txtEmail1;
        private thietKeControls.txtChiNhapSo txt_sodienthoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_nu;
        private System.Windows.Forms.RadioButton radio_nam;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
