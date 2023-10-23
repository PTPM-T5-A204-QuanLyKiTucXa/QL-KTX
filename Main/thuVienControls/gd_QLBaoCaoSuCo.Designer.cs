
namespace thuVienControls
{
    partial class gd_QLBaoCaoSuCo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dsSuCo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_trangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_tuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_denNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSuCo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO SỰ CỐ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_dsSuCo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 415);
            this.panel2.TabIndex = 2;
            // 
            // dgv_dsSuCo
            // 
            this.dgv_dsSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsSuCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_dsSuCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsSuCo.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsSuCo.Name = "dgv_dsSuCo";
            this.dgv_dsSuCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsSuCo.Size = new System.Drawing.Size(594, 415);
            this.dgv_dsSuCo.TabIndex = 2;
            this.dgv_dsSuCo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_dsSuCo_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "su_co_id";
            this.Column1.HeaderText = "Mã sự cố";
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
            this.Column3.DataPropertyName = "ngay_bao_cao";
            this.Column3.HeaderText = "Ngày báo cáo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mo_ta_su_co";
            this.Column4.HeaderText = "Mô tả";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trang_thai_xu_ly";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_denNgay);
            this.groupBox1.Controls.Add(this.dtp_tuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_trangThai);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbx_trangThai
            // 
            this.cbx_trangThai.FormattingEnabled = true;
            this.cbx_trangThai.Location = new System.Drawing.Point(78, 17);
            this.cbx_trangThai.Name = "cbx_trangThai";
            this.cbx_trangThai.Size = new System.Drawing.Size(121, 21);
            this.cbx_trangThai.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // dtp_tuNgay
            // 
            this.dtp_tuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tuNgay.Location = new System.Drawing.Point(266, 17);
            this.dtp_tuNgay.Name = "dtp_tuNgay";
            this.dtp_tuNgay.Size = new System.Drawing.Size(121, 20);
            this.dtp_tuNgay.TabIndex = 2;
            // 
            // dtp_denNgay
            // 
            this.dtp_denNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_denNgay.Location = new System.Drawing.Point(461, 17);
            this.dtp_denNgay.Name = "dtp_denNgay";
            this.dtp_denNgay.Size = new System.Drawing.Size(121, 20);
            this.dtp_denNgay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gd_QLBaoCaoSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gd_QLBaoCaoSuCo";
            this.Size = new System.Drawing.Size(594, 522);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSuCo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_dsSuCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_trangThai;
        private System.Windows.Forms.DateTimePicker dtp_tuNgay;
    }
}
