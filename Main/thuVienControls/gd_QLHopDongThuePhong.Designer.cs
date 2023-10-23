
namespace thuVienControls
{
    partial class gd_QLHopDongThuePhong
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_dsHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_xuatNam = new System.Windows.Forms.ComboBox();
            this.cbx_xuatThang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_maSinhVien = new System.Windows.Forms.TextBox();
            this.btn_lapHopDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_denNam = new System.Windows.Forms.ComboBox();
            this.cbx_tuNam = new System.Windows.Forms.ComboBox();
            this.cbx_denThang = new System.Windows.Forms.ComboBox();
            this.cbx_tuThang = new System.Windows.Forms.ComboBox();
            this.cbx_trangThai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xemHopDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_dsHD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 271);
            this.panel3.TabIndex = 5;
            // 
            // dgv_dsHD
            // 
            this.dgv_dsHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8});
            this.dgv_dsHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsHD.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsHD.Name = "dgv_dsHD";
            this.dgv_dsHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsHD.Size = new System.Drawing.Size(682, 271);
            this.dgv_dsHD.TabIndex = 0;
            this.dgv_dsHD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_dsHD_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "hop_dong_id";
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "so_phong";
            this.Column2.HeaderText = "Số phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ho_ten";
            this.Column3.HeaderText = "Sinh viên";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tienthu";
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "trangthai";
            this.Column8.HeaderText = "Trạng thái";
            this.Column8.Name = "Column8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "XUẤT FILE EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tháng";
            // 
            // cbx_xuatNam
            // 
            this.cbx_xuatNam.FormattingEnabled = true;
            this.cbx_xuatNam.Location = new System.Drawing.Point(209, 19);
            this.cbx_xuatNam.Name = "cbx_xuatNam";
            this.cbx_xuatNam.Size = new System.Drawing.Size(113, 21);
            this.cbx_xuatNam.TabIndex = 4;
            // 
            // cbx_xuatThang
            // 
            this.cbx_xuatThang.FormattingEnabled = true;
            this.cbx_xuatThang.Location = new System.Drawing.Point(62, 19);
            this.cbx_xuatThang.Name = "cbx_xuatThang";
            this.cbx_xuatThang.Size = new System.Drawing.Size(106, 21);
            this.cbx_xuatThang.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã sinh viên";
            // 
            // txt_maSinhVien
            // 
            this.txt_maSinhVien.Location = new System.Drawing.Point(85, 76);
            this.txt_maSinhVien.Name = "txt_maSinhVien";
            this.txt_maSinhVien.Size = new System.Drawing.Size(141, 20);
            this.txt_maSinhVien.TabIndex = 3;
            // 
            // btn_lapHopDong
            // 
            this.btn_lapHopDong.Location = new System.Drawing.Point(417, 74);
            this.btn_lapHopDong.Name = "btn_lapHopDong";
            this.btn_lapHopDong.Size = new System.Drawing.Size(179, 23);
            this.btn_lapHopDong.TabIndex = 1;
            this.btn_lapHopDong.Text = "LẬP HỢP ĐỒNG";
            this.btn_lapHopDong.UseVisualStyleBackColor = true;
            this.btn_lapHopDong.Click += new System.EventHandler(this.btn_lapHopDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_xuatNam);
            this.groupBox1.Controls.Add(this.cbx_xuatThang);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất dữ liệu";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(26, 135);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(106, 23);
            this.btn_loc.TabIndex = 10;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đến năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trạng thái thanh toán";
            // 
            // cbx_denNam
            // 
            this.cbx_denNam.FormattingEnabled = true;
            this.cbx_denNam.Location = new System.Drawing.Point(399, 103);
            this.cbx_denNam.Name = "cbx_denNam";
            this.cbx_denNam.Size = new System.Drawing.Size(144, 21);
            this.cbx_denNam.TabIndex = 4;
            // 
            // cbx_tuNam
            // 
            this.cbx_tuNam.FormattingEnabled = true;
            this.cbx_tuNam.Location = new System.Drawing.Point(399, 64);
            this.cbx_tuNam.Name = "cbx_tuNam";
            this.cbx_tuNam.Size = new System.Drawing.Size(144, 21);
            this.cbx_tuNam.TabIndex = 3;
            // 
            // cbx_denThang
            // 
            this.cbx_denThang.FormattingEnabled = true;
            this.cbx_denThang.Location = new System.Drawing.Point(138, 103);
            this.cbx_denThang.Name = "cbx_denThang";
            this.cbx_denThang.Size = new System.Drawing.Size(159, 21);
            this.cbx_denThang.TabIndex = 2;
            // 
            // cbx_tuThang
            // 
            this.cbx_tuThang.FormattingEnabled = true;
            this.cbx_tuThang.Location = new System.Drawing.Point(138, 64);
            this.cbx_tuThang.Name = "cbx_tuThang";
            this.cbx_tuThang.Size = new System.Drawing.Size(159, 21);
            this.cbx_tuThang.TabIndex = 1;
            // 
            // cbx_trangThai
            // 
            this.cbx_trangThai.FormattingEnabled = true;
            this.cbx_trangThai.Location = new System.Drawing.Point(138, 26);
            this.cbx_trangThai.Name = "cbx_trangThai";
            this.cbx_trangThai.Size = new System.Drawing.Size(159, 21);
            this.cbx_trangThai.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xemHopDong);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_lapHopDong);
            this.panel2.Controls.Add(this.txt_maSinhVien);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 118);
            this.panel2.TabIndex = 4;
            // 
            // btn_xemHopDong
            // 
            this.btn_xemHopDong.Location = new System.Drawing.Point(232, 74);
            this.btn_xemHopDong.Name = "btn_xemHopDong";
            this.btn_xemHopDong.Size = new System.Drawing.Size(179, 23);
            this.btn_xemHopDong.TabIndex = 5;
            this.btn_xemHopDong.Text = "XEM HỢP ĐỒNG";
            this.btn_xemHopDong.UseVisualStyleBackColor = true;
            this.btn_xemHopDong.Click += new System.EventHandler(this.btn_xemHopDong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_loc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_denNam);
            this.panel1.Controls.Add(this.cbx_tuNam);
            this.panel1.Controls.Add(this.cbx_denThang);
            this.panel1.Controls.Add(this.cbx_tuThang);
            this.panel1.Controls.Add(this.cbx_trangThai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 173);
            this.panel1.TabIndex = 3;
            // 
            // gd_QLHopDongThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gd_QLHopDongThuePhong";
            this.Size = new System.Drawing.Size(682, 562);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_dsHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_xuatNam;
        private System.Windows.Forms.ComboBox cbx_xuatThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_maSinhVien;
        private System.Windows.Forms.Button btn_lapHopDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_denNam;
        private System.Windows.Forms.ComboBox cbx_tuNam;
        private System.Windows.Forms.ComboBox cbx_denThang;
        private System.Windows.Forms.ComboBox cbx_tuThang;
        private System.Windows.Forms.ComboBox cbx_trangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_xemHopDong;
    }
}
