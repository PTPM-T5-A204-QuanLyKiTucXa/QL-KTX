namespace Main
{
    partial class Form1
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
            this.gd_DangNhap1 = new thuVienControls.gd_DangNhap();
            this.SuspendLayout();
            // 
            // gd_DangNhap1
            // 
            this.gd_DangNhap1.Location = new System.Drawing.Point(48, 42);
            this.gd_DangNhap1.Name = "gd_DangNhap1";
            this.gd_DangNhap1.Size = new System.Drawing.Size(529, 282);
            this.gd_DangNhap1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.gd_DangNhap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }




        #endregion

        private thuVienControls.gd_DangNhap gd_DangNhap1;
    }
}

