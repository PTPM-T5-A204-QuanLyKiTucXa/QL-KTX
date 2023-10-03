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

            //if(sv.trang_thai=="Chờ duyệt")
            //{
            //    btn_luu.Visible = false;
            //}

            if(sv.trang_thai == "Đang ở")
            {
                btn_duyet.Visible = false;
                btn_khongDuyet.Visible = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maSV = txt_maSV.Text;
            string hoTen = txt_hoTen.Text;
            DateTime ngaysinh = dtp_ngaySinh.Value ;
            string gioiTinh = cbx_gioiTinh.Text.ToString();
            string sdt = txt_sdt.Text;
            string diaChi = txt_diaChi.Text;
            string email = txt_email.Text;
            string soPhong = txt_soPhong.Text;
            if(qlsv.UpdateSinhVien(maSV,hoTen,ngaysinh,gioiTinh,sdt,diaChi,email,soPhong))
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btn_duyet_Click(object sender, EventArgs e)
        {

        }

        private void btn_khongDuyet_Click(object sender, EventArgs e)
        {

        }
    }
}
