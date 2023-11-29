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
    public partial class gd_LapHopDongThuePhong : UserControl
    {
        QL_KTXDataContext qlktx = new QL_KTXDataContext();
        Ql_SinhVien qlsv = new Ql_SinhVien();
        QL_Phong qlp = new QL_Phong();
        QL_HopDongThuePhong qlhd = new QL_HopDongThuePhong();

        public gd_LapHopDongThuePhong()
        {
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            cbx_loaiPhong.DataSource = qlp.layDSLoaiPhong();
            cbx_loaiPhong.DisplayMember = "ten_loai_phong";
            string[] trangThai = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = trangThai;
            string[] phai = { "Nam", "Nữ" };
            cbx_gioiTinh.DataSource = phai;
        }

        public void load_thongtin(string massv)
        {
            SinhVien sv = qlsv.loadThongTinSinhVienTheoMa(massv);
            txt_maSV.Text = sv.ma_sinh_vien.ToString();
            dtp_ngaySinh.Value = sv.ngay_sinh.Value;
            cbx_gioiTinh.SelectedItem = sv.gioi_tinh.ToString();
            txt_tenSV.Text = sv.ho_ten;
            txt_CCCD.Text = sv.CCCD;
            txt_SDT.Text = sv.so_dien_thoai;
            txt_diaChi.Text = sv.dia_chi;
            txt_email.Text = sv.email;
        }



        private void dateTimePicker3_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayKetThuc.Value = DateTime.Now;
            }
            else
            {
                txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, loaiPhong).ToString();
            }
        }

        private void dtp_ngayBatDau_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayBatDau.Value = DateTime.Now;
            }
            else
            {
                txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, loaiPhong).ToString();
            }

        }

        private void dtp_ngayLap_CloseUp(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            TimeSpan timeSpan = endDate - startDate;
            int daysDifference = timeSpan.Days;
            string loaiPhong = cbx_loaiPhong.Text;
            if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
            {
                MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                dtp_ngayLap.Value = DateTime.Now;
            }
            else
            {
                txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, loaiPhong).ToString();
            }

        }

        private void txn_lapHD_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_ngayBatDau.Value;
            DateTime endDate = dtp_ngayKetThuc.Value;
            DateTime ngayLap = dtp_ngayLap.Value;
            string masv = txt_maSV.Text;
            string hoTen = txt_tenSV.Text;
            string cccd = txt_CCCD.Text;
            DateTime ngaySinh = dtp_ngaySinh.Value;
            string gioiTinh = cbx_gioiTinh.Text;
            string loaiPhong = cbx_loaiPhong.Text;
            string sdt = txt_SDT.Text;
            string diaChi = txt_diaChi.Text;
            string email = txt_email.Text;
            string trangThai = cbx_trangThai.Text;
            string tienThu = txt_tienThu.Text;
            Ql_SinhVien ql_sv=new Ql_SinhVien();
            if (ql_sv.IsEmailValid(txt_email.Text))
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập hợp đồng cho sinh viên " + txt_tenSV.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int kq = qlhd.lapHopDongThuePhong(masv, hoTen, ngaySinh, cccd, gioiTinh, loaiPhong, sdt, diaChi, email, ngayLap, startDate, endDate, trangThai, double.Parse(tienThu));
                    if (kq == 0)
                    {
                        MessageBox.Show("Không thể lập hợp đồng do sinh viên đang có hợp đồng còn giá trị!");
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Lập hợp đồng thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Lập hợp đồng thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thành công !");
                }
            }
            else
            {
                MessageBox.Show("Email nhập sai rồi!");
            }    
        }

        private void txt_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || txt_CCCD.Text.Length >= 12)
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void txt_diaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        private void txt_tienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
