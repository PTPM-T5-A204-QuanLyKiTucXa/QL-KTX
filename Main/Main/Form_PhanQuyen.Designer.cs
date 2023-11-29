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
            this.phanQuyenDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaiTroDataGridView = new System.Windows.Forms.DataGridView();
            this.vaiTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_luu = new System.Windows.Forms.Button();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.DataSource = this.phanQuyenDKBindingSource;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(663, 64);
            this.phanQuyenDKDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.RowHeadersWidth = 51;
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(518, 409);
            this.phanQuyenDKDataGridView.TabIndex = 2;
            // 
            // phanQuyenDKBindingSource
            // 
            this.phanQuyenDKBindingSource.DataMember = "PhanQuyenDK";
            // 
            // vaiTroDataGridView
            // 
            this.vaiTroDataGridView.AutoGenerateColumns = false;
            this.vaiTroDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vaiTroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaiTroDataGridView.DataSource = this.vaiTroBindingSource;
            this.vaiTroDataGridView.Location = new System.Drawing.Point(50, 91);
            this.vaiTroDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vaiTroDataGridView.Name = "vaiTroDataGridView";
            this.vaiTroDataGridView.RowHeadersWidth = 51;
            this.vaiTroDataGridView.Size = new System.Drawing.Size(529, 318);
            this.vaiTroDataGridView.TabIndex = 3;
            this.vaiTroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vaiTroDataGridView_CellClick);
            // 
            // vaiTroBindingSource
            // 
            this.vaiTroBindingSource.DataMember = "VaiTro";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(103, 456);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(399, 28);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            // 
            // Form_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 554);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.vaiTroDataGridView);
            this.Controls.Add(this.phanQuyenDKDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).EndInit();
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