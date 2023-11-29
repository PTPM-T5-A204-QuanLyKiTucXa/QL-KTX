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

        private void pn_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_PhanQuyen form = new Form_PhanQuyen();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_DSPhong form = new Form_DSPhong();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLSinhVien form = new Form_QLSinhVien();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void quảnLýĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLDienNuoc form = new Form_QLDienNuoc();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void quảnLýHợpĐồngThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLHopDongThuePhong form = new Form_QLHopDongThuePhong();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void báoCáoSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_QLBaoCaoSuCo form = new Form_QLBaoCaoSuCo();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            testKM form = new testKM();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_trangchu.Controls.Clear();
            Form_NguoiDung form =new Form_NguoiDung();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_trangchu.Controls.Add(form);
            form.Show();
        }
    }
}
