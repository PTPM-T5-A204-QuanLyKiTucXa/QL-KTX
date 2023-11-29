namespace thuVienControls
{
    partial class gd_QLSinhVien
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
            this.grid_dssv = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_laphopdong = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_trangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dssv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_dssv
            // 
            this.grid_dssv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_dssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_dssv.Location = new System.Drawing.Point(0, 0);
            this.grid_dssv.Margin = new System.Windows.Forms.Padding(4);
            this.grid_dssv.Name = "grid_dssv";
            this.grid_dssv.RowHeadersWidth = 72;
            this.grid_dssv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_dssv.Size = new System.Drawing.Size(1273, 489);
            this.grid_dssv.TabIndex = 0;
            this.grid_dssv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dssv_CellContentClick);
            this.grid_dssv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_dssv_MouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ma_sinh_vien";
            this.Column6.HeaderText = "MÃ SINH VIÊN";
            this.Column6.MinimumWidth = 9;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ho_ten";
            this.Column1.HeaderText = "HỌ TÊN";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "so_dien_thoai";
            this.Column2.HeaderText = "SỐ ĐIỆN THOẠI";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "EMAIL";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gioi_tinh";
            this.Column4.HeaderText = "GIỚI TÍNH";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trang_thai";
            this.Column5.HeaderText = "TRẠNG THÁI";
            this.Column5.MinimumWidth = 9;
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 601);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_dssv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1273, 489);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_laphopdong);
            this.panel2.Controls.Add(this.btn_tailai);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbx_trangThai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 112);
            this.panel2.TabIndex = 0;
            // 
            // btn_laphopdong
            // 
            this.btn_laphopdong.Location = new System.Drawing.Point(905, 33);
            this.btn_laphopdong.Name = "btn_laphopdong";
            this.btn_laphopdong.Size = new System.Drawing.Size(149, 46);
            this.btn_laphopdong.TabIndex = 6;
            this.btn_laphopdong.Text = "Lập hợp đồng";
            this.btn_laphopdong.UseVisualStyleBackColor = true;
            this.btn_laphopdong.Click += new System.EventHandler(this.btn_laphopdong_Click);
            // 
            // btn_tailai
            // 
            this.btn_tailai.Location = new System.Drawing.Point(674, 32);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(149, 46);
            this.btn_tailai.TabIndex = 5;
            this.btn_tailai.Text = "Tải lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(433, 33);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(141, 46);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm sinh viên";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái";
            // 
            // cbx_trangThai
            // 
            this.cbx_trangThai.FormattingEnabled = true;
            this.cbx_trangThai.Location = new System.Drawing.Point(99, 44);
            this.cbx_trangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_trangThai.Name = "cbx_trangThai";
            this.cbx_trangThai.Size = new System.Drawing.Size(279, 24);
            this.cbx_trangThai.TabIndex = 1;
            this.cbx_trangThai.SelectedIndexChanged += new System.EventHandler(this.cbx_trangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ lọc";
            // 
            // gd_QLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gd_QLSinhVien";
            this.Size = new System.Drawing.Size(1273, 601);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dssv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_dssv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_trangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tailai;
        private System.Windows.Forms.Button btn_laphopdong;
    }
}
