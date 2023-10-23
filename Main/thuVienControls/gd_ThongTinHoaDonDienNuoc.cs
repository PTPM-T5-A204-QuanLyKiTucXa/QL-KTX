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
    public partial class gd_ThongTinHoaDonDienNuoc : UserControl
    {
        QL_DienNuoc qldn = new QL_DienNuoc();
        public gd_ThongTinHoaDonDienNuoc()
        {
            InitializeComponent();
            loadGiaoDien();
        }


        public event EventHandler clickHuy;
        private void btn_huy_Click(object sender, EventArgs e)
        {
            clickHuy?.Invoke(this, e);
        }

        public void loadGiaoDien()
        {
            string[] trangThai = { "Đã thanh toán", "Chưa thanh toán" };
            cbx_trangThai.DataSource = trangThai;
        }

        public void loadThongTinHoaDon(int maHD)
        {
            HoaDonDienNuoc hd = qldn.loadTTHoaDonDienNuocTheoMa(maHD);
            txt_maHD.Text = hd.hoa_don_id.ToString();
            txt_namGhi.Text = hd.nam.ToString();
            txt_soPhong.Text = hd.Phong.so_phong.ToString();
            txt_soDienTieuThu.Text = hd.so_dien.ToString();
            txt_soNuocTieuThu.Text = hd.so_khoi_nuoc.ToString();
            txt_thangGhi.Text = hd.thang.ToString();
            txt_tongTien.Text = hd.tong_tien.ToString();
            cbx_trangThai.SelectedItem = hd.trang_thai.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txt_maHD.Text.ToString());
            int soDien = int.Parse(txt_soDienTieuThu.Text.ToString());
            int soNuoc = int.Parse(txt_soNuocTieuThu.Text.ToString());
            string trangThai = cbx_trangThai.Text.ToString();
            if(qldn.capNhatHoaDonDienNuoc(maHD, soDien, soNuoc, trangThai))
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
