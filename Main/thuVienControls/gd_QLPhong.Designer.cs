namespace thuVienControls
{
    partial class gd_QLPhong
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_tang = new System.Windows.Forms.RadioButton();
            this.radio_sophong = new System.Windows.Forms.RadioButton();
            this.txt_sophong = new System.Windows.Forms.TextBox();
            this.cbm_trangthai = new System.Windows.Forms.ComboBox();
            this.cbm_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbm_tang = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_tim);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_sophong);
            this.panel1.Controls.Add(this.cbm_trangthai);
            this.panel1.Controls.Add(this.cbm_loaiphong);
            this.panel1.Controls.Add(this.cbm_tang);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 269);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(768, 213);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(201, 22);
            this.txt_tim.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_tang);
            this.groupBox1.Controls.Add(this.radio_sophong);
            this.groupBox1.Location = new System.Drawing.Point(768, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 126);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bộ lọc";
            // 
            // radio_tang
            // 
            this.radio_tang.AutoSize = true;
            this.radio_tang.Location = new System.Drawing.Point(28, 88);
            this.radio_tang.Name = "radio_tang";
            this.radio_tang.Size = new System.Drawing.Size(60, 20);
            this.radio_tang.TabIndex = 1;
            this.radio_tang.TabStop = true;
            this.radio_tang.Text = "Tầng";
            this.radio_tang.UseVisualStyleBackColor = true;
            // 
            // radio_sophong
            // 
            this.radio_sophong.AutoSize = true;
            this.radio_sophong.Location = new System.Drawing.Point(28, 38);
            this.radio_sophong.Name = "radio_sophong";
            this.radio_sophong.Size = new System.Drawing.Size(87, 20);
            this.radio_sophong.TabIndex = 0;
            this.radio_sophong.TabStop = true;
            this.radio_sophong.Text = "Số Phòng";
            this.radio_sophong.UseVisualStyleBackColor = true;
            // 
            // txt_sophong
            // 
            this.txt_sophong.Location = new System.Drawing.Point(196, 48);
            this.txt_sophong.Name = "txt_sophong";
            this.txt_sophong.Size = new System.Drawing.Size(187, 22);
            this.txt_sophong.TabIndex = 16;
            // 
            // cbm_trangthai
            // 
            this.cbm_trangthai.FormattingEnabled = true;
            this.cbm_trangthai.Location = new System.Drawing.Point(543, 46);
            this.cbm_trangthai.Name = "cbm_trangthai";
            this.cbm_trangthai.Size = new System.Drawing.Size(163, 24);
            this.cbm_trangthai.TabIndex = 15;
            // 
            // cbm_loaiphong
            // 
            this.cbm_loaiphong.FormattingEnabled = true;
            this.cbm_loaiphong.Location = new System.Drawing.Point(543, 113);
            this.cbm_loaiphong.Name = "cbm_loaiphong";
            this.cbm_loaiphong.Size = new System.Drawing.Size(163, 24);
            this.cbm_loaiphong.TabIndex = 14;
            // 
            // cbm_tang
            // 
            this.cbm_tang.FormattingEnabled = true;
            this.cbm_tang.Location = new System.Drawing.Point(196, 113);
            this.cbm_tang.Name = "cbm_tang";
            this.cbm_tang.Size = new System.Drawing.Size(187, 24);
            this.cbm_tang.TabIndex = 13;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(477, 200);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 48);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(263, 200);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 48);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tầng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(3, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 477);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vScrollBar1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1264, 471);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(1012, 124);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(71, 48);
            this.btn_lammoi.TabIndex = 21;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 471);
            this.vScrollBar1.TabIndex = 0;
            // 
            // gd_QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gd_QLPhong";
            this.Size = new System.Drawing.Size(1273, 755);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sophong;
        private System.Windows.Forms.ComboBox cbm_trangthai;
        private System.Windows.Forms.ComboBox cbm_loaiphong;
        private System.Windows.Forms.ComboBox cbm_tang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.RadioButton radio_tang;
        private System.Windows.Forms.RadioButton radio_sophong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
