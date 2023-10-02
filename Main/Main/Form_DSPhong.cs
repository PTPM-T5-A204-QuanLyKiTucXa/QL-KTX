using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuVienControls;
namespace Main
{
    public partial class Form_DSPhong : Form
    {
        QL_Phong qlp = new QL_Phong();
        
        public Form_DSPhong()
        {
            InitializeComponent();
            loadPhong();
             // Khởi tạo biến thành viên
          
        }

        public void loadPhong()
        {
            List<Phong> phongs = qlp.loadDSPhong();
            foreach(Phong p in phongs)
            {
                gd_Phong gd = new gd_Phong();
                gd.Width = 250;
                gd.Height = 250;
                gd.BackColor = Color.Aqua;
                gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, qlp.DemSoSinhVienTrongPhong(p.so_phong));
                gd.Click += gd_Click;
                gd.SoPhong = p.so_phong;
                flowLayoutPanel1.Controls.Add(gd);
            }
        }

        void gd_Click(object sender, EventArgs e)
        {
            gd_Phong gd = sender as gd_Phong;
            if (gd != null)
            {
                string soPhong = gd.SoPhong;
                Form_ThongTinPhong form = new Form_ThongTinPhong(soPhong);
                form.Show();
            }
        }


        private void Form_DSPhong_Load(object sender, EventArgs e)
        {

        }


    }
}
