using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_DangNhap : UserControl
    {
        public gd_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (txtChiNhapSo1.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống" + txtChiNhapSo1.Text.ToLower());
                this.txtChiNhapSo1.Focus();
                return;
            }
            if (txt_matKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống" + txt_matKhau.Text.ToLower());
                this.txt_matKhau.Focus();
                return;
            }
            Ql_NguoiDung cauhinh = new Ql_NguoiDung();
            int kq = cauhinh.check_config();
            if (kq == 0)
            {
                processLogin();
                //đăng nhập đi mày
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                processConfig();
                // Xử lý cấu hình đi mày
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                processConfig();
                // chuỗi sai kìa mày, sửa đi mày
            }
        }
        public void processLogin()
        {
            Ql_NguoiDung cauhinh = new Ql_NguoiDung();
            int kq = cauhinh.check_user(txtChiNhapSo1.Text.ToString(), txt_matKhau.Text.ToString());
            if (kq == 1)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
            else if (kq == 2)
            {
                MessageBox.Show("Tài khoản đang bị khóa");
                return;
            }
            //if (Program.mainForm == null || Program.mainForm.IsDisposed)
            //{
            //    Program.mainForm = new gd_Main();
            //}
            //this.Visible = false;
            //Program.mainForm.Show();
        }

        public void processConfig()
        {
            cauHinh chForm = new cauHinh();
            chForm.Show();
        }
    }
}
