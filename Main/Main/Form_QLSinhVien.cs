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
    public partial class Form_QLSinhVien : Form
    {
        Ql_SinhVien qlsv = new Ql_SinhVien();
        public Form_QLSinhVien()
        {
            InitializeComponent();
            loadDSSinhVien();
        }

        public void loadDSSinhVien()
        {
            gd_QLSinhVien gd = new gd_QLSinhVien();
            DataGridView dgv = new DataGridView();
            dgv.DataSource = qlsv.loadDanhSachSinhVien().DataSource;
            gd.loadGridSinhVien(dgv);
            gd.loadCbxTrangThai();
            
            flowLayoutPanel1.Controls.Add(gd);
        }
    }
}
