using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void btnDoiMau2_Click(object sender, EventArgs e)
        {
            Form_PhanQuyen form = new Form_PhanQuyen();
            form.TopLevel = false; // Đặt TopLevel thành false để Form 2 không hiển thị độc lập
            pn_form.Controls.Add(form); // Thêm Form 2 vào Panel của Form 1
            form.Dock = DockStyle.Fill; // Đảm bảo Form 2 lấp đầy Panel
            form.Show();
        }

        private void btnDoiMau3_Click(object sender, EventArgs e)
        {
            Form_DSPhong form = new Form_DSPhong();
            form.TopLevel = false; // Đặt TopLevel thành false để Form 2 không hiển thị độc lập
            pn_form.Controls.Add(form); // Thêm Form 2 vào Panel của Form 1
            form.Dock = DockStyle.Fill; // Đảm bảo Form 2 lấp đầy Panel
            form.Show();
        }

        private void pn_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoiMau4_Click(object sender, EventArgs e)
        {
            Form_QLSinhVien form = new Form_QLSinhVien();
            form.TopLevel = false; // Đặt TopLevel thành false để Form 2 không hiển thị độc lập
            pn_form.Controls.Add(form); // Thêm Form 2 vào Panel của Form 1
            form.Dock = DockStyle.Fill; // Đảm bảo Form 2 lấp đầy Panel
            form.Show();
        }
    }
}
