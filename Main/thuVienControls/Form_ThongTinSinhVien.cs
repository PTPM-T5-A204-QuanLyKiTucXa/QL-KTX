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
    public partial class Form_ThongTinSinhVien : Form
    {
        Ql_SinhVien qlsv = new Ql_SinhVien();
        private string MaSV;
        public Form_ThongTinSinhVien()
        {
            InitializeComponent();
            loadCBXGioiTinh();
            loadSinhVien();
        }

        public Form_ThongTinSinhVien(string masv)
        { 
            InitializeComponent();
            this.MaSV = masv;
            loadCBXGioiTinh();
            loadSinhVien();
            
        }

        public void loadCBXGioiTinh()
        {
            cbx_gioiTinh.Items.Add("Nam");
            cbx_gioiTinh.Items.Add("Nữ");
        }

        public void loadSinhVien()
        {
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(this.MaSV);
            txt_diaChi.Text = sv.dia_chi;
            txt_hoTen.Text = sv.ho_ten;
            txt_maSV.Text = sv.ma_sinh_vien;
            txt_sdt.Text = sv.so_dien_thoai;
            txt_soPhong.Text = sv.so_phong;
            dtp_ngaySinh.Value = sv.ngay_sinh.Value;
            txt_email.Text = sv.email;
            string gioiTinh = sv.gioi_tinh;

            if (cbx_gioiTinh.Items.Contains(gioiTinh))
            {
                cbx_gioiTinh.SelectedItem = gioiTinh;
            }

            if(sv.trang_thai == "Đang ở")
            {
                btn_duyet.Visible = false;
                btn_khongDuyet.Visible = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }
    }
}
