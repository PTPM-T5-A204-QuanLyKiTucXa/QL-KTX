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
            Form_PhanQuyen form = new Form_PhanQuyen();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DSPhong form = new Form_DSPhong();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QLSinhVien form = new Form_QLSinhVien();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QLDienNuoc form = new Form_QLDienNuoc();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýHợpĐồngThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QLHopDongThuePhong form = new Form_QLHopDongThuePhong();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
        }
    }
}
