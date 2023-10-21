namespace Main
{
    partial class Form_PhanQuyen
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
            this.components = new System.ComponentModel.Container();
            this.phanQuyenDKDataGridView = new System.Windows.Forms.DataGridView();
            this.vaiTroDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_luu = new System.Windows.Forms.Button();
            this.vaiTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.phanQuyenDKDataGridView.DataSource = this.phanQuyenDKBindingSource;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(305, 118);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(346, 302);
            this.phanQuyenDKDataGridView.TabIndex = 2;
            // 
            // vaiTroDataGridView
            // 
            this.vaiTroDataGridView.AutoGenerateColumns = false;
            this.vaiTroDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vaiTroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaiTroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vaiTroDataGridView.DataSource = this.vaiTroBindingSource;
            this.vaiTroDataGridView.Location = new System.Drawing.Point(-1, 118);
            this.vaiTroDataGridView.Name = "vaiTroDataGridView";
            this.vaiTroDataGridView.Size = new System.Drawing.Size(300, 220);
            this.vaiTroDataGridView.TabIndex = 3;
            this.vaiTroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vaiTroDataGridView_CellClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(0, 364);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(299, 23);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // vaiTroBindingSource
            // 
            this.vaiTroBindingSource.DataMember = "VaiTro";
            // 
            // ql_KTX_DATASET
            // 
            // 
            // phanQuyenDKBindingSource
            // 
            this.phanQuyenDKBindingSource.DataMember = "PhanQuyenDK";
            // 
            // phanQuyenDKTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            // 
            // phanQuyenTableAdapter
            // 
            // 
            // vaiTroTableAdapter
            // 
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vai_tro_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vai trò";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ten_vai_tro";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên vai trò";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma_Man_Hinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten_Man_Hinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên màn hình";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Co_Quyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Có quyền";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Form_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 680);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.vaiTroDataGridView);
            this.Controls.Add(this.phanQuyenDKDataGridView);
            this.Name = "Form_PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      
        private System.Windows.Forms.BindingSource phanQuyenDKBindingSource;
        private System.Windows.Forms.DataGridView phanQuyenDKDataGridView;
        private System.Windows.Forms.BindingSource vaiTroBindingSource;
        private System.Windows.Forms.DataGridView vaiTroDataGridView;
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}