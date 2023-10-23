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
    public partial class gd_ThongTinHopDong : UserControl
    {

        QL_HopDongThuePhong qlhd = new QL_HopDongThuePhong();
        public gd_ThongTinHopDong()
        {
            InitializeComponent();
            loadCBXTrangThai();
        }

        public void loadCBXTrangThai()
        {
            string[] tt = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = tt;
        }

        public void loadThongTinHopDong(int maHD)
        {
            HopDongThuePhong hd = qlhd.loadHopDongThuePhong(maHD);
            txt_maHD.Text = hd.hop_dong_id.ToString();
            txt_soPhong.Text = hd.Phong.so_phong.ToString();
            txt_tenSV.Text = hd.SinhVien.ho_ten.ToString();
            txt_tienThu.Text = hd.tienthu.ToString();
            dtp_ngayBatDau.Value = (DateTime)hd.ngay_bat_dau_thue;
            dtp_ngayKetThuc.Value = (DateTime)hd.ngay_ket_thuc_thue;
            dtp_ngayLap.Value= (DateTime)hd.ngay_lap;
            cbx_trangThai.SelectedItem = hd.trangthai.ToString(); 
        }

        public event EventHandler huyBoClick;
        private void button3_Click(object sender, EventArgs e)
        {
            huyBoClick?.Invoke(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi trên?", "Lưu", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                int maHD = int.Parse(txt_maHD.Text.ToString());
                HopDongThuePhong hd = qlhd.loadHopDongThuePhong(maHD);
                int maPhong = int.Parse(hd.phong_id.ToString());

                if (qlhd.CapNhatHopDongThuePhong(maHD,maPhong,dtp_ngayLap.Value,dtp_ngayBatDau.Value, dtp_ngayKetThuc.Value,cbx_trangThai.SelectedItem.ToString()))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại");
                }    
                
            }    
        }
    }
}
