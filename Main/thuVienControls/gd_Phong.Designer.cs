
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_soThanhVien = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_tenPhong);
            this.panel1.Controls.Add(this.lb_soThanhVien);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 173);
            this.panel1.TabIndex = 0;
            // 
            // lb_soThanhVien
            // 
            this.lb_soThanhVien.AutoSize = true;
            this.lb_soThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_soThanhVien.ForeColor = System.Drawing.Color.Red;
            this.lb_soThanhVien.Location = new System.Drawing.Point(3, 131);
            this.lb_soThanhVien.Name = "lb_soThanhVien";
            this.lb_soThanhVien.Size = new System.Drawing.Size(101, 18);
            this.lb_soThanhVien.TabIndex = 2;
            this.lb_soThanhVien.Text = "Số thành viên:";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_loaiPhong.ForeColor = System.Drawing.Color.Red;
            this.lb_loaiPhong.Location = new System.Drawing.Point(3, 78);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(85, 18);
            this.lb_loaiPhong.TabIndex = 1;
            this.lb_loaiPhong.Text = "Loại phòng:";
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenPhong.ForeColor = System.Drawing.Color.Red;
            this.lb_tenPhong.Location = new System.Drawing.Point(3, 27);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(109, 24);
            this.lb_tenPhong.TabIndex = 3;
            this.lb_tenPhong.Text = "Tên phòng:";
            // 
            // gd_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "gd_Phong";
            this.Size = new System.Drawing.Size(214, 179);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soThanhVien;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenPhong;


    }
}
