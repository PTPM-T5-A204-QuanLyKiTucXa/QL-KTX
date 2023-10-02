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
    public partial class gd_ThongTinPhong : UserControl
    {

        
        public gd_ThongTinPhong()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong, string loaiPhong, string tang ,string soNguoi)
        {
            lb_tenPhong.Text += tenPhong;
            lb_loaiPhong.Text += loaiPhong;
            lb_tang.Text += tang;
            lb_soNguoi.Text += soNguoi;
        }

        public void loadGridSinhVien(DataGridView dgv)
        {
            grid_sinhVien.DataSource = dgv.DataSource;
        }
    }
}
