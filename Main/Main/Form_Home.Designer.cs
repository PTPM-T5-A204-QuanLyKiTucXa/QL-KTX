
namespace Main
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_form = new System.Windows.Forms.Panel();
            this.btnDoiMau5 = new thietKeControls.btnDoiMau();
            this.btnDoiMau4 = new thietKeControls.btnDoiMau();
            this.btnDoiMau3 = new thietKeControls.btnDoiMau();
            this.btnDoiMau2 = new thietKeControls.btnDoiMau();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnDoiMau5);
            this.panel2.Controls.Add(this.btnDoiMau4);
            this.panel2.Controls.Add(this.btnDoiMau3);
            this.panel2.Controls.Add(this.btnDoiMau2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 599);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 164);
            this.panel3.TabIndex = 0;
            // 
            // pn_form
            // 
            this.pn_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_form.Location = new System.Drawing.Point(200, 0);
            this.pn_form.Name = "pn_form";
            this.pn_form.Size = new System.Drawing.Size(776, 599);
            this.pn_form.TabIndex = 2;
            this.pn_form.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_form_Paint);
            // 
            // btnDoiMau5
            // 
            this.btnDoiMau5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMau5.Location = new System.Drawing.Point(0, 374);
            this.btnDoiMau5.Name = "btnDoiMau5";
            this.btnDoiMau5.Size = new System.Drawing.Size(200, 83);
            this.btnDoiMau5.TabIndex = 5;
            this.btnDoiMau5.Text = "btnDoiMau5";
            this.btnDoiMau5.UseVisualStyleBackColor = true;
            // 
            // btnDoiMau4
            // 
            this.btnDoiMau4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMau4.Location = new System.Drawing.Point(0, 298);
            this.btnDoiMau4.Name = "btnDoiMau4";
            this.btnDoiMau4.Size = new System.Drawing.Size(200, 76);
            this.btnDoiMau4.TabIndex = 4;
            this.btnDoiMau4.Text = "Quản lý sinh viên";
            this.btnDoiMau4.UseVisualStyleBackColor = true;
            this.btnDoiMau4.Click += new System.EventHandler(this.btnDoiMau4_Click);
            // 
            // btnDoiMau3
            // 
            this.btnDoiMau3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMau3.Location = new System.Drawing.Point(0, 228);
            this.btnDoiMau3.Name = "btnDoiMau3";
            this.btnDoiMau3.Size = new System.Drawing.Size(200, 70);
            this.btnDoiMau3.TabIndex = 3;
            this.btnDoiMau3.Text = "Danh Sách Phòng";
            this.btnDoiMau3.UseVisualStyleBackColor = true;
            this.btnDoiMau3.Click += new System.EventHandler(this.btnDoiMau3_Click);
            // 
            // btnDoiMau2
            // 
            this.btnDoiMau2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMau2.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMau2.Image")));
            this.btnDoiMau2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMau2.Location = new System.Drawing.Point(0, 164);
            this.btnDoiMau2.Name = "btnDoiMau2";
            this.btnDoiMau2.Size = new System.Drawing.Size(200, 64);
            this.btnDoiMau2.TabIndex = 2;
            this.btnDoiMau2.Text = "Phân Quyền";
            this.btnDoiMau2.UseVisualStyleBackColor = true;
            this.btnDoiMau2.Click += new System.EventHandler(this.btnDoiMau2_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 599);
            this.Controls.Add(this.pn_form);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_KTX HUIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pn_form;
        private thietKeControls.btnDoiMau btnDoiMau5;
        private thietKeControls.btnDoiMau btnDoiMau4;
        private thietKeControls.btnDoiMau btnDoiMau3;
        private thietKeControls.btnDoiMau btnDoiMau2;
    }
}