namespace thuVienControls
{
    partial class gd_ThongTinPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_soNguoi = new System.Windows.Forms.Label();
            this.lb_tang = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grid_sinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_soNguoi);
            this.panel1.Controls.Add(this.lb_tang);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Controls.Add(this.lb_tenPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 217);
            this.panel1.TabIndex = 6;
            // 
            // lb_soNguoi
            // 
            this.lb_soNguoi.AutoSize = true;
            this.lb_soNguoi.Location = new System.Drawing.Point(21, 183);
            this.lb_soNguoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soNguoi.Name = "lb_soNguoi";
            this.lb_soNguoi.Size = new System.Drawing.Size(122, 16);
            this.lb_soNguoi.TabIndex = 9;
            this.lb_soNguoi.Text = "Số người ở hiện tại: ";
            // 
            // lb_tang
            // 
            this.lb_tang.AutoSize = true;
            this.lb_tang.Location = new System.Drawing.Point(23, 140);
            this.lb_tang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tang.Name = "lb_tang";
            this.lb_tang.Size = new System.Drawing.Size(80, 16);
            this.lb_tang.TabIndex = 8;
            this.lb_tang.Text = "Thuộc tầng: ";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Location = new System.Drawing.Point(21, 97);
            this.lb_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(80, 16);
            this.lb_loaiPhong.TabIndex = 7;
            this.lb_loaiPhong.Text = "Loại phòng: ";
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Location = new System.Drawing.Point(21, 58);
            this.lb_tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(78, 16);
            this.lb_tenPhong.TabIndex = 6;
            this.lb_tenPhong.Text = "Tên phòng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin chung:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 626);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grid_sinhVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 116);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 510);
            this.panel4.TabIndex = 2;
            // 
            // grid_sinhVien
            // 
            this.grid_sinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_sinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_sinhVien.Location = new System.Drawing.Point(0, 0);
            this.grid_sinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_sinhVien.Name = "grid_sinhVien";
            this.grid_sinhVien.RowHeadersWidth = 51;
            this.grid_sinhVien.Size = new System.Drawing.Size(995, 510);
            this.grid_sinhVien.TabIndex = 0;
            this.grid_sinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_sinhVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ho_ten";
            this.Column1.HeaderText = "Họ tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ma_sinh_vien";
            this.Column2.HeaderText = "Mã sinh viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioi_tinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "email";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 116);
            this.panel3.TabIndex = 1;
            // 
            // gd_ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gd_ThongTinPhong";
            this.Size = new System.Drawing.Size(995, 843);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soNguoi;
        private System.Windows.Forms.Label lb_tang;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_sinhVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
