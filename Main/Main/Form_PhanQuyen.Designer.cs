
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_luu = new System.Windows.Forms.Button();
            this.phanQuyenDKDataGridView = new System.Windows.Forms.DataGridView();
            this.vaiTroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaiTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_KTX_DATASET = new Main.Ql_KTX_DATASET();
            this.phanQuyenDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phanQuyenDKTableAdapter = new Main.Ql_KTX_DATASETTableAdapters.PhanQuyenDKTableAdapter();
            this.tableAdapterManager = new Main.Ql_KTX_DATASETTableAdapters.TableAdapterManager();
            this.phanQuyenTableAdapter = new Main.Ql_KTX_DATASETTableAdapters.PhanQuyenTableAdapter();
            this.phanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaiTroTableAdapter = new Main.Ql_KTX_DATASETTableAdapters.VaiTroTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_KTX_DATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.vaiTroDataGridView);
            this.panel1.Controls.Add(this.phanQuyenDKDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 742);
            this.panel1.TabIndex = 3;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(3, 356);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(317, 29);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2});
            this.phanQuyenDKDataGridView.DataSource = this.phanQuyenDKBindingSource;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(325, 36);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(456, 349);
            this.phanQuyenDKDataGridView.TabIndex = 0;
            // 
            // vaiTroDataGridView
            // 
            this.vaiTroDataGridView.AutoGenerateColumns = false;
            this.vaiTroDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vaiTroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaiTroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vaiTroDataGridView.DataSource = this.vaiTroBindingSource;
            this.vaiTroDataGridView.Location = new System.Drawing.Point(3, 36);
            this.vaiTroDataGridView.Name = "vaiTroDataGridView";
            this.vaiTroDataGridView.Size = new System.Drawing.Size(300, 303);
            this.vaiTroDataGridView.TabIndex = 5;
            this.vaiTroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vaiTroDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "vai_tro_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "vai_tro_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ten_vai_tro";
            this.dataGridViewTextBoxColumn8.HeaderText = "ten_vai_tro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // vaiTroBindingSource
            // 
            this.vaiTroBindingSource.DataMember = "VaiTro";
            this.vaiTroBindingSource.DataSource = this.ql_KTX_DATASET;
            // 
            // ql_KTX_DATASET
            // 
            this.ql_KTX_DATASET.DataSetName = "Ql_KTX_DATASET";
            this.ql_KTX_DATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phanQuyenDKBindingSource
            // 
            this.phanQuyenDKBindingSource.DataMember = "PhanQuyenDK";
            this.phanQuyenDKBindingSource.DataSource = this.ql_KTX_DATASET;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ma_Man_Hinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ma_Man_Hinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ten_Man_Hinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ten_Man_Hinh";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Co_Quyen";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Co_Quyen";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // phanQuyenDKTableAdapter
            // 
            this.phanQuyenDKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhMucManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = null;
            this.tableAdapterManager.PhanQuyenTableAdapter = this.phanQuyenTableAdapter;
            this.tableAdapterManager.UpdateOrder = Main.Ql_KTX_DATASETTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VaiTroTableAdapter = null;
            // 
            // phanQuyenTableAdapter
            // 
            this.phanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenBindingSource
            // 
            this.phanQuyenBindingSource.DataMember = "PhanQuyen";
            this.phanQuyenBindingSource.DataSource = this.ql_KTX_DATASET;
            // 
            // vaiTroTableAdapter
            // 
            this.vaiTroTableAdapter.ClearBeforeFill = true;
            // 
            // Form_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 742);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_PhanQuyen";
            this.Text = "Form_PhanQuyen";
            this.Load += new System.EventHandler(this.Form_PhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaiTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_KTX_DATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btn_luu;
        private Ql_KTX_DATASET ql_KTX_DATASET;
        private System.Windows.Forms.BindingSource phanQuyenDKBindingSource;
        private Ql_KTX_DATASETTableAdapters.PhanQuyenDKTableAdapter phanQuyenDKTableAdapter;
        private Ql_KTX_DATASETTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView phanQuyenDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private Ql_KTX_DATASETTableAdapters.PhanQuyenTableAdapter phanQuyenTableAdapter;
        private System.Windows.Forms.BindingSource phanQuyenBindingSource;
        private System.Windows.Forms.BindingSource vaiTroBindingSource;
        private Ql_KTX_DATASETTableAdapters.VaiTroTableAdapter vaiTroTableAdapter;
        private System.Windows.Forms.DataGridView vaiTroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}