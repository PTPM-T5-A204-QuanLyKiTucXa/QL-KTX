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
    public partial class gd_GiaDien : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_GiaDien()
        {
            InitializeComponent();
        }
        public void loadGia(int stt, int soBatDau, double donGia)
        {
            txt_SoBatDau.Text = soBatDau.ToString();
            txt_DonGia.Text = donGia.ToString();
            lb_stt.Text = stt.ToString();
        }

        public void CapNhatDuLieu()
        {
            int soBatDau = int.Parse(txt_SoBatDau.Text);
            double donGia = double.Parse(txt_DonGia.Text);

            int id = int.Parse(lb_stt.Text);
            if(qldn.capNhatBangGiaDien(id, soBatDau, donGia))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
