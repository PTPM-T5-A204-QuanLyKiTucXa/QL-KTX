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
        Dictionary<string, List<string>> cityData = new Dictionary<string, List<string>>()
            {
                { "Hà Nội", new List<string>
                    {
                        "Ba Đình", "Hoàn Kiếm", "Hai Bà Trưng", "Đống Đa", "Cầu Giấy",
                        "Long Biên", "Tây Hồ", "Hà Đông", "Nam Từ Liêm", "Thanh Xuân",
                        "Sóc Sơn", "Mê Linh", "Ba Vì", "Phúc Thọ", "Đan Phượng",
                        "Hoài Đức", "Quốc Oai", "Thạch Thất", "Chương Mỹ", "Thường Tín",
                        "Phú Xuyên", "Ứng Hòa", "Mỹ Đức",
                    }
                },
                { "Hồ Chí Minh", new List<string>
                    {
                        "Quận 1", "Quận 2", "Quận 3", "Quận 4", "Quận 5",
                        "Quận 6", "Quận 7", "Quận 8", "Quận 9", "Quận 10",
                        "Quận 11", "Quận 12", "Gò Vấp", "Tân Bình", "Tân Phú",
                        "Bình Thạnh", "Phú Nhuận", "Thủ Đức", "Bình Tân",
                        "Củ Chi", "Hóc Môn", "Nhà Bè", "Cần Giờ"
                    }
                },
                { "Hải Phòng", new List<string>
                    {
                        "Hồng Bàng", "Lê Chân", "Ngô Quyền", "Kiến An", "Hải An",
                        "Đồ Sơn", "Kiến Thụy", "Tiên Lãng", "An Dương", "An Lão",
                        "Vĩnh Bảo", "Cát Hải", "Bạch Long Vĩ"
                    }
                },
                // Thêm dữ liệu cho các tỉnh/thành phố khác tại đây
            };
        public gd_LapHopDongThuePhong()
        {
            InitializeComponent();
            loadTinhThanh();
            loadCBXLoaiPhong();
        }

        public void loadCBXLoaiPhong()
        {
            cbx_loaiPhong.DataSource = qlp.layDSLoaiPhong();
            cbx_loaiPhong.DisplayMember = "ten_loai_phong";
        }


        public void loadTinhThanh()
        {
            foreach (string tinhThanhPho in cityData.Keys)
            {
                cbx_tinhThanh.Items.Add(tinhThanhPho);
            }
            cbx_tinhThanh.SelectedIndex = 0;
        }

        private void cbx_tinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_quanHuyen.Text = "";
            cbx_quanHuyen.Items.Clear();

            // Lấy Tỉnh/Thành phố được chọn
            if (cbx_tinhThanh.SelectedItem != null)
            {
                string selectedTinhThanhPho = cbx_tinhThanh.SelectedItem.ToString();

                // Nếu Tỉnh/Thành phố được chọn tồn tại trong dữ liệu, thêm các Thành phố tương ứng vào ComboBox Thành phố
                if (cityData.ContainsKey(selectedTinhThanhPho))
                {
                    List<string> cities = cityData[selectedTinhThanhPho];
                    cbx_quanHuyen.Items.AddRange(cities.ToArray());
                    if (cbx_quanHuyen.Items.Count > 0)
                    {
                        cbx_quanHuyen.SelectedIndex = 0;
                    }
                }
            }
        }

        public event EventHandler XacNhanlapHDClick;

        private void txn_lapHD_Click(object sender, EventArgs e)
        {
            XacNhanlapHDClick?.Invoke(this, e);
        }

        private void cbx_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_soPhong.DataSource = qlp.LayDanhSachPhongChuaDayTheoLoaiPhong(cbx_loaiPhong.Text.ToString());
            cbx_soPhong.DisplayMember = "so_phong";
            if (cbx_soPhong.Items.Count > 0)
            {
                cbx_soPhong.SelectedIndex = 0;
            }
        }

        private void dateTimePicker3_CloseUp(object sender, EventArgs e)
        {
            if (cbx_soPhong.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và phòng trước");
            }
            else
            {

                DateTime startDate = dtp_ngayBatDau.Value;
                DateTime endDate = dtp_ngayKetThuc.Value;
                DateTime ngayLap = dtp_ngayLap.Value;
                TimeSpan timeSpan = endDate - startDate;
                int daysDifference = timeSpan.Days;
                if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
                {
                    MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                    dtp_ngayKetThuc.Value = DateTime.Now;
                }
                else
                {
                    Phong p = qlp.loadThongTinPhong(cbx_soPhong.Text);
                    int maPhong = int.Parse(p.phong_id.ToString());
                    txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, maPhong).ToString();

                }
            }

        }

        private void dtp_ngayBatDau_CloseUp(object sender, EventArgs e)
        {
            if (cbx_soPhong.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và phòng trước");
            }
            else
            {

                DateTime startDate = dtp_ngayBatDau.Value;
                DateTime endDate = dtp_ngayKetThuc.Value;
                DateTime ngayLap = dtp_ngayLap.Value;
                TimeSpan timeSpan = endDate - startDate;
                int daysDifference = timeSpan.Days;
                if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
                {
                    MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                    dtp_ngayBatDau.Value = DateTime.Now;
                }
                else
                {
                    Phong p = qlp.loadThongTinPhong(cbx_soPhong.Text);
                    int maPhong = int.Parse(p.phong_id.ToString());
                    txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, maPhong).ToString();

                }
            }
        }

        private void dtp_ngayLap_CloseUp(object sender, EventArgs e)
        {
            if (cbx_soPhong.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và phòng trước");
            }
            else
            {

                DateTime startDate = dtp_ngayBatDau.Value;
                DateTime endDate = dtp_ngayKetThuc.Value;
                DateTime ngayLap = dtp_ngayLap.Value;
                TimeSpan timeSpan = endDate - startDate;
                int daysDifference = timeSpan.Days;
                if (endDate < startDate || daysDifference > 365 || ngayLap > endDate)
                {
                    MessageBox.Show("Ngày tháng trong hợp đồng không hợp lệ");
                    dtp_ngayLap.Value = DateTime.Now;
                }
                else
                {
                    Phong p = qlp.loadThongTinPhong(cbx_soPhong.Text);
                    int maPhong = int.Parse(p.phong_id.ToString());
                    txt_tienThu.Text = qlhd.tinhTienThu(startDate, endDate, maPhong).ToString();

                }
            }
        }
    }
}
