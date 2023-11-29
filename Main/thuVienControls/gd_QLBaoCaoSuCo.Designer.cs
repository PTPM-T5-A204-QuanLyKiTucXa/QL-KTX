
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_denNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_tuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_trangThai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dsSuCo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSuCo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 132);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tailai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_denNgay);
            this.groupBox1.Controls.Add(this.dtp_tuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_trangThai);
            this.groupBox1.Location = new System.Drawing.Point(221, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(784, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày";
            // 
            // dtp_denNgay
            // 
            this.dtp_denNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_denNgay.Location = new System.Drawing.Point(615, 21);
            this.dtp_denNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_denNgay.Name = "dtp_denNgay";
            this.dtp_denNgay.Size = new System.Drawing.Size(160, 22);
            this.dtp_denNgay.TabIndex = 3;
            // 
            // dtp_tuNgay
            // 
            this.dtp_tuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tuNgay.Location = new System.Drawing.Point(355, 21);
            this.dtp_tuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_tuNgay.Name = "dtp_tuNgay";
            this.dtp_tuNgay.Size = new System.Drawing.Size(160, 22);
            this.dtp_tuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // cbx_trangThai
            // 
            this.cbx_trangThai.FormattingEnabled = true;
            this.cbx_trangThai.Location = new System.Drawing.Point(104, 21);
            this.cbx_trangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_trangThai.Name = "cbx_trangThai";
            this.cbx_trangThai.Size = new System.Drawing.Size(160, 24);
            this.cbx_trangThai.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_dsSuCo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 469);
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
            this.dgv_dsSuCo.Location = new System.Drawing.Point(221, 8);
            this.dgv_dsSuCo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_dsSuCo.Name = "dgv_dsSuCo";
            this.dgv_dsSuCo.RowHeadersWidth = 51;
            this.dgv_dsSuCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsSuCo.Size = new System.Drawing.Size(784, 457);
            this.dgv_dsSuCo.TabIndex = 2;
            this.dgv_dsSuCo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_dsSuCo_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "su_co_id";
            this.Column1.HeaderText = "Mã sự cố";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "so_phong";
            this.Column2.HeaderText = "Số phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngay_bao_cao";
            this.Column3.HeaderText = "Ngày báo cáo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mo_ta_su_co";
            this.Column4.HeaderText = "Mô tả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trang_thai_xu_ly";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btn_tailai
            // 
            this.btn_tailai.Location = new System.Drawing.Point(355, 69);
            this.btn_tailai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(160, 47);
            this.btn_tailai.TabIndex = 7;
            this.btn_tailai.Text = "Tải Lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click);
            // 
            // gd_QLBaoCaoSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gd_QLBaoCaoSuCo";
            this.Size = new System.Drawing.Size(1273, 601);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsSuCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btn_tailai;
    }
}
