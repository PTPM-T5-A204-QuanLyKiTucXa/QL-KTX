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
        QL_Phong p=new QL_Phong();
        
        public gd_Phong()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong, string loaiPhong, string soNguoi)
        {
            lb_tenPhong.Text += tenPhong;
            lb_loaiPhong.Text += loaiPhong;
            lb_soThanhVien.Text += soNguoi;
            this.SoPhong = tenPhong;
        }

        private void btn_ghiDienNuoc_Click(object sender, EventArgs e)
        {
            Form_GhiDienNuoc form = new Form_GhiDienNuoc(this.SoPhong);
            
            form.Show();
        }

        public event EventHandler Controlsclick;
        public event EventHandler Controlsclick_sua;
        public event EventHandler Controlsclick_xoa;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Controlsclick?.Invoke(this, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Phong phong = p.loadThongTinPhong(SoPhong);
            gd_QLPhong ql=new gd_QLPhong(phong);
            Controlsclick_sua?.Invoke(this, e);
            ql.load_sua(phong);

       
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa phòng " + this.SoPhong + " không ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes) 
            {
                p.xoa_Phong(this.SoPhong);
                MessageBox.Show("Đã xóa thành công !", "Thông báo", MessageBoxButtons.OK);
                Controlsclick_xoa?.Invoke(this, e);
            }
           
        }
    }
}
