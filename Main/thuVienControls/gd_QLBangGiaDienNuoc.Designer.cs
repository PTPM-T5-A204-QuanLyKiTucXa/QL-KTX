
namespace thuVienControls
{
    partial class gd_QLBangGiaDienNuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giaNuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_themNac = new System.Windows.Forms.Button();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_SoBatDau = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA ĐƠN GIÁ ĐIỆN NƯỚC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHỈNH SỬA ĐƠN GIÁ NƯỚC";
            // 
            // txt_giaNuoc
            // 
            this.txt_giaNuoc.Location = new System.Drawing.Point(118, 103);
            this.txt_giaNuoc.Name = "txt_giaNuoc";
            this.txt_giaNuoc.Size = new System.Drawing.Size(100, 20);
            this.txt_giaNuoc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá nước(VNĐ)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_giaNuoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 181);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CHỈNH SỬA ĐƠN GIÁ ĐIỆN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_DonGia);
            this.panel3.Controls.Add(this.txt_SoBatDau);
            this.panel3.Controls.Add(this.btn_themNac);
            this.panel3.Controls.Add(this.btn_xacNhan);
            this.panel3.Controls.Add(this.btn_huy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 106);
            this.panel3.TabIndex = 20;
            // 
            // btn_themNac
            // 
            this.btn_themNac.Location = new System.Drawing.Point(251, 22);
            this.btn_themNac.Name = "btn_themNac";
            this.btn_themNac.Size = new System.Drawing.Size(116, 21);
            this.btn_themNac.TabIndex = 2;
            this.btn_themNac.Text = "Thêm nấc";
            this.btn_themNac.UseVisualStyleBackColor = true;
            this.btn_themNac.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Location = new System.Drawing.Point(64, 61);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(135, 23);
            this.btn_xacNhan.TabIndex = 1;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(205, 61);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(135, 23);
            this.btn_huy.TabIndex = 0;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 269);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // txt_SoBatDau
            // 
            this.txt_SoBatDau.Location = new System.Drawing.Point(39, 23);
            this.txt_SoBatDau.Name = "txt_SoBatDau";
            this.txt_SoBatDau.Size = new System.Drawing.Size(100, 20);
            this.txt_SoBatDau.TabIndex = 30;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(145, 23);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(100, 20);
            this.txt_DonGia.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Đơn giá(VNĐ)";
            // 
            // gd_QLBangGiaDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "gd_QLBangGiaDienNuoc";
            this.Size = new System.Drawing.Size(398, 556);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giaNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_themNac;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoBatDau;
    }
}
