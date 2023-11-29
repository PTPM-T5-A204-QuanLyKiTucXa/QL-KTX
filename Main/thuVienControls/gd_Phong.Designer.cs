
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ghiDienNuoc = new System.Windows.Forms.Button();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.lb_soThanhVien = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_ghiDienNuoc);
            this.panel1.Controls.Add(this.lb_tenPhong);
            this.panel1.Controls.Add(this.lb_soThanhVien);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 173);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(263, 109);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 57);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(355, 109);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 57);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ghiDienNuoc
            // 
            this.btn_ghiDienNuoc.Location = new System.Drawing.Point(263, 14);
            this.btn_ghiDienNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ghiDienNuoc.Name = "btn_ghiDienNuoc";
            this.btn_ghiDienNuoc.Size = new System.Drawing.Size(167, 73);
            this.btn_ghiDienNuoc.TabIndex = 4;
            this.btn_ghiDienNuoc.Text = "Ghi chỉ số điện nước mới";
            this.btn_ghiDienNuoc.UseVisualStyleBackColor = true;
            this.btn_ghiDienNuoc.Click += new System.EventHandler(this.btn_ghiDienNuoc_Click);
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenPhong.ForeColor = System.Drawing.Color.Red;
            this.lb_tenPhong.Location = new System.Drawing.Point(11, 14);
            this.lb_tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(136, 29);
            this.lb_tenPhong.TabIndex = 3;
            this.lb_tenPhong.Text = "Tên phòng:";
            // 
            // lb_soThanhVien
            // 
            this.lb_soThanhVien.AutoSize = true;
            this.lb_soThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_soThanhVien.ForeColor = System.Drawing.Color.Red;
            this.lb_soThanhVien.Location = new System.Drawing.Point(17, 123);
            this.lb_soThanhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soThanhVien.Name = "lb_soThanhVien";
            this.lb_soThanhVien.Size = new System.Drawing.Size(130, 24);
            this.lb_soThanhVien.TabIndex = 2;
            this.lb_soThanhVien.Text = "Số thành viên:";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_loaiPhong.ForeColor = System.Drawing.Color.Red;
            this.lb_loaiPhong.Location = new System.Drawing.Point(17, 63);
            this.lb_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(110, 24);
            this.lb_loaiPhong.TabIndex = 1;
            this.lb_loaiPhong.Text = "Loại phòng:";
            // 
            // gd_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gd_Phong";
            this.Size = new System.Drawing.Size(441, 178);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_soThanhVien;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenPhong;
        private System.Windows.Forms.Button btn_ghiDienNuoc;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}
