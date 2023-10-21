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
    public partial class gd_QLBangGiaDienNuoc : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_DienNuoc qldn = new QL_DienNuoc();
        public List<gd_GiaDien> giaDienControls = new List<gd_GiaDien>();
        public gd_QLBangGiaDienNuoc()
        {
            InitializeComponent();
            loadBangGiaDien();
            loadGiaNuoc();
        }

        public void loadGiaNuoc()
        {
            GiaNuoc g = qldn.loadGiaNuoc();
            txt_giaNuoc.Text = g.Gia.ToString();
        }

        public void loadBangGiaDien()
        {
            List<GiaDien> bangGiaDien = qldn.loadBangGiaDien();
            int i = 1;
            foreach (GiaDien gd in bangGiaDien)
            {
                gd_GiaDien g = new gd_GiaDien();
                g.loadGia(i,(int)gd.so_bat_dau, (double)gd.Gia);
                i++;
                giaDienControls.Add(g);
                flowLayoutPanel1.Controls.Add(g);
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CapNhatThongTinGiaDien();
                CapNhatThongTinGiaNuoc();
            }
        }

        public void CapNhatThongTinGiaDien()
        {
            foreach (gd_GiaDien g in giaDienControls)
            {
                g.CapNhatDuLieu();
            }
        }

        public void CapNhatThongTinGiaNuoc()
        {
            qldn.capNhatGiaNuoc(double.Parse(txt_giaNuoc.Text));
        }

        public event EventHandler huyClick;
        private void btn_huy_Click(object sender, EventArgs e)
        {
            huyClick?.Invoke(this, e);
        }

        public event EventHandler themNacClick;
        private void button3_Click(object sender, EventArgs e)
        {
            double gia = double.Parse(txt_DonGia.Text);
            int soBatDau = int.Parse(txt_SoBatDau.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm một bậc vào bảng giá điện không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(qldn.themNacGiaDien(soBatDau, gia))
                {
                    MessageBox.Show("Thêm nấc thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nấc thất bại");
                }
            }
        }
    }
}
