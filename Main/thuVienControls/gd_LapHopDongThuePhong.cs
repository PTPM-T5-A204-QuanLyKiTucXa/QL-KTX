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
            int kq = qlhd.lapHopDongThuePhong(masv,hoTen,ngaySinh,cccd,gioiTinh,loaiPhong,sdt,diaChi,email,ngayLap,startDate,endDate,trangThai,double.Parse(tienThu));
            if (kq == 0)
            {
                MessageBox.Show("Không thể lập hợp đồng do sinh viên đang có hợp đồng còn giá trị!");
            }  
            else if(kq ==1)
            {
                MessageBox.Show("Lập hợp đồng thất bại");
            }    
            else
            {
                MessageBox.Show("Lập hợp đồng thành công");
            }    
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
  
    }
}
