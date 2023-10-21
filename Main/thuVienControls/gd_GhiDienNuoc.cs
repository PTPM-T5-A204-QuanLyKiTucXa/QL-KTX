using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_GhiDienNuoc : UserControl
    {
        public gd_GhiDienNuoc()
        {
            InitializeComponent();
        }

        public void loadThongTinPhong(string tenPhong)
        {
            lb_tenPhong.Text += tenPhong;
            loadCBXNam();
            loadCBXThang();
        }
        public void loadCBXNam()
        {
            int currentYear = DateTime.Now.Year;
            List<int> yearsList = new List<int>();
            for (int i = currentYear - 20; i <= currentYear; i++)
            {
                yearsList.Add(i);
            }
            cbx_nam.DataSource = yearsList;
        }
        public void loadCBXThang()
        {
            List<string> monthsList = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                string monthName = "Tháng " + i;
                monthsList.Add(monthName);
            }

            // Gán danh sách tháng vào ComboBox
            cbx_thang.DataSource = monthsList;
        }
        private void btn_xacNhan_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }
    }
}
