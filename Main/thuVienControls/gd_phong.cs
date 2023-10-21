using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_Phong : UserControl
    {

        public string SoPhong { get; set; }

        public gd_Phong()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong, string loaiPhong, string soNguoi)
        {
            lb_tenPhong.Text += tenPhong;
            lb_loaiPhong.Text += loaiPhong;
            lb_soThanhVien.Text += soNguoi;
        }

        private void btn_ghiDienNuoc_Click(object sender, EventArgs e)
        {
            Form_GhiDienNuoc form = new Form_GhiDienNuoc(lb_tenPhong.Text);
            
            form.Show();
        }

        public event EventHandler Controlsclick;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Controlsclick?.Invoke(this, e);
        }
    }
}
