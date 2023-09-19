
namespace thuVienControls
{
    partial class gd_Phong
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
            this.gr_Phong = new System.Windows.Forms.GroupBox();
            this.list_sinhVien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gr_Phong.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_Phong
            // 
            this.gr_Phong.Controls.Add(this.label2);
            this.gr_Phong.Controls.Add(this.label1);
            this.gr_Phong.Controls.Add(this.list_sinhVien);
            this.gr_Phong.Location = new System.Drawing.Point(3, 3);
            this.gr_Phong.Name = "gr_Phong";
            this.gr_Phong.Size = new System.Drawing.Size(291, 239);
            this.gr_Phong.TabIndex = 1;
            this.gr_Phong.TabStop = false;
            this.gr_Phong.Text = "gr";
            // 
            // list_sinhVien
            // 
            this.list_sinhVien.FormattingEnabled = true;
            this.list_sinhVien.Location = new System.Drawing.Point(6, 86);
            this.list_sinhVien.Name = "list_sinhVien";
            this.list_sinhVien.Size = new System.Drawing.Size(279, 147);
            this.list_sinhVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng:";
            // 
            // gd_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gr_Phong);
            this.Name = "gd_phong";
            this.Size = new System.Drawing.Size(297, 245);
            this.gr_Phong.ResumeLayout(false);
            this.gr_Phong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_Phong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_sinhVien;

    }
}
