namespace thuVienControls
{
    partial class Form_ThongTinSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_duyet = new System.Windows.Forms.Button();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_soPhong = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_khongDuyet = new System.Windows.Forms.Button();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbx_gioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số phòng đang ở:";
            // 
            // btn_duyet
            // 
            this.btn_duyet.Location = new System.Drawing.Point(133, 325);
            this.btn_duyet.Name = "btn_duyet";
            this.btn_duyet.Size = new System.Drawing.Size(168, 55);
            this.btn_duyet.TabIndex = 8;
            this.btn_duyet.Text = "Duyệt";
            this.btn_duyet.UseVisualStyleBackColor = true;
            this.btn_duyet.Click += new System.EventHandler(this.btn_duyet_Click);
            // 
            // txt_maSV
            // 
            this.txt_maSV.Location = new System.Drawing.Point(101, 59);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(200, 20);
            this.txt_maSV.TabIndex = 9;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(101, 112);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(200, 20);
            this.txt_hoTen.TabIndex = 10;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(101, 165);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(200, 20);
            this.txt_sdt.TabIndex = 11;
            // 
            // txt_soPhong
            // 
            this.txt_soPhong.Location = new System.Drawing.Point(101, 219);
            this.txt_soPhong.Name = "txt_soPhong";
            this.txt_soPhong.Size = new System.Drawing.Size(200, 20);
            this.txt_soPhong.TabIndex = 12;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(423, 165);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(200, 20);
            this.txt_diaChi.TabIndex = 13;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(209, 259);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(276, 49);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_khongDuyet
            // 
            this.btn_khongDuyet.Location = new System.Drawing.Point(385, 325);
            this.btn_khongDuyet.Name = "btn_khongDuyet";
            this.btn_khongDuyet.Size = new System.Drawing.Size(165, 55);
            this.btn_khongDuyet.TabIndex = 15;
            this.btn_khongDuyet.Text = "Không duyệt";
            this.btn_khongDuyet.UseVisualStyleBackColor = true;
            this.btn_khongDuyet.Click += new System.EventHandler(this.btn_khongDuyet_Click);
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaySinh.Location = new System.Drawing.Point(423, 62);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaySinh.TabIndex = 16;
            // 
            // cbx_gioiTinh
            // 
            this.cbx_gioiTinh.FormattingEnabled = true;
            this.cbx_gioiTinh.Location = new System.Drawing.Point(423, 112);
            this.cbx_gioiTinh.Name = "cbx_gioiTinh";
            this.cbx_gioiTinh.Size = new System.Drawing.Size(200, 21);
            this.cbx_gioiTinh.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(423, 219);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // Form_ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 393);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_gioiTinh);
            this.Controls.Add(this.dtp_ngaySinh);
            this.Controls.Add(this.btn_khongDuyet);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_soPhong);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_maSV);
            this.Controls.Add(this.btn_duyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ThongTinSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_duyet;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_soPhong;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_khongDuyet;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.ComboBox cbx_gioiTinh;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label9;
    }
}