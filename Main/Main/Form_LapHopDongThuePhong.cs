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
    public partial class Form_LapHopDongThuePhong : Form
    {
        gd_LapHopDongThuePhong gd = new gd_LapHopDongThuePhong();
        public Form_LapHopDongThuePhong()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(gd);
        }
    }
}
