﻿using System;
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
    public partial class gd_QLDienNuoc : UserControl
    {
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_QLDienNuoc()
        {
            InitializeComponent();
        }

        public void loadHoaDon()
        {
            dgv_dsHD.DataSource = qldn.loadHoaDonDienNuoc();
        }

        public void loadHoaDonDaLoc()
        {
            dgv_dsHD.DataSource = null;
            int tuThang = int.Parse((cbx_tuThang.SelectedItem.ToString()).Substring(6)); // Lấy phần con số sau "Tháng "
            int denThang = int.Parse((cbx_denThang.SelectedItem.ToString()).Substring(6));
            int tuNam = (int)cbx_tuNam.SelectedItem;
            int denNam = (int)cbx_denNam.SelectedItem;
            string trangThai = cbx_trangThai.SelectedItem.ToString();
            dgv_dsHD.DataSource = qldn.locHoaDon(tuThang, tuNam, denThang, denNam, trangThai);
        }

        public void loadFullCBX()
        {
            int currentYear = DateTime.Now.Year;
            List<int> yearsList = new List<int>();
            for (int i = currentYear - 20; i <= currentYear; i++)
            {
                yearsList.Add(i);
            }

            cbx_tuNam.DataSource = yearsList;
            cbx_denNam.DataSource = yearsList;
            cbx_denNam.SelectedItem = currentYear;
            cbx_tuNam.SelectedItem = currentYear;
            cbx_xuatNam.DataSource = yearsList;
            cbx_xuatNam.DataSource = yearsList;

            string[] months = new string[]
             {
                "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"
             };

            cbx_tuThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_tuThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            cbx_denThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_denThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            cbx_xuatThang.DataSource = months.ToArray();  // Tạo một bản sao của mảng
            cbx_xuatThang.SelectedItem = "Tháng " + DateTime.Now.Month;

            string[] trangThai = { "Tất cả", "Chưa thanh toán", "Đã thanh toán" };
            cbx_trangThai.Items.AddRange(trangThai);
            cbx_trangThai.SelectedItem = "Tất cả";
        }

        public event EventHandler btnLocClick;

        private void btn_loc_Click(object sender, EventArgs e)
        {
            btnLocClick?.Invoke(this, e);
        }

        public event EventHandler btnGhiDienNuocClick;

        private void btn_ghiDienNuoc_Click(object sender, EventArgs e)
        {
            btnGhiDienNuocClick?.Invoke(this, e);
        }

        public void ghiDienNuoc()
        {
            Form_GhiDienNuoc form = new Form_GhiDienNuoc(txt_soPhong.Text.ToString());
            form.Show();
        }

        public event EventHandler btnSuaDonGiaClick;

        private void btn_suaDonGia_Click(object sender, EventArgs e)
        {
            btnSuaDonGiaClick?.Invoke(this, e);
        }
    }
}
