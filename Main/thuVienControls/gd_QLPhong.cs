using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using thuVienControls;

namespace thuVienControls
{
    public partial class gd_QLPhong : UserControl
    {
        private Phong phong1 = new Phong();
        private QL_Phong qL_Phong = new QL_Phong();

        public event EventHandler Gd_Controlsclick;

        public gd_QLPhong()
        {
            InitializeComponent();
            Load += Gd_QLPhong_Load;
            txt_sophong.Enabled = false;
        }

        private void Gd_QLPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public gd_QLPhong(Phong phong)
        {
            InitializeComponent();
            phong1 = phong;
            txt_sophong.Text += phong.so_phong.ToString();
            cbm_loaiphong.SelectedValue = phong.loai_phong_id;
            cbm_tang.SelectedValue = phong.tang;
            cbm_trangthai.SelectedValue = phong.trang_thai;
        }
        public void LoadData()
        {
            LoadPhong();

            foreach (int s in qL_Phong.laymaLoaiPhong_khongtrung())
            {
                cbm_loaiphong.Items.Add(s.ToString());
            }

            cbm_trangthai.Items.AddRange(new[] { "Tất Cả", "Trống", "Hết Chỗ" });
            cbm_tang.Items.AddRange(Enumerable.Range(1, 10).Select(s => s.ToString()).ToArray());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                qL_Phong.them_Phong(txt_sophong.Text, int.Parse(cbm_tang.SelectedItem.ToString()),
                    cbm_trangthai.SelectedItem.ToString(), int.Parse(cbm_loaiphong.SelectedItem.ToString()));

                MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                LoadPhong();

                ResetInputs();
            }
            else
            {
                MessageBox.Show("Bạn hãy nhập đủ dữ liệu !", "Lưu Ý", MessageBoxButtons.OK);
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrEmpty(txt_sophong.Text) &&
                   cbm_loaiphong.SelectedItem != null &&
                   cbm_tang.SelectedItem != null &&
                   cbm_trangthai.SelectedItem != null;
        }

        private void ResetInputs()
        {
            txt_sophong.Text = "";
            cbm_loaiphong.SelectedItem = null;
            cbm_tang.SelectedItem = null;
            cbm_trangthai.SelectedItem = null;
        }
        public void LoadPhong()
        {
            ResetInputs();
            flowLayoutPanel1.Controls.Clear();

            foreach (Phong p in qL_Phong.loadDSPhong())
            {
                gd_Phong gd = new gd_Phong
                {
                    BackColor = Color.Aqua,
                    SoPhong = p.so_phong
                };

                gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, qL_Phong.DemSoSinhVienTrongPhong(p.so_phong));
                gd.Controlsclick += Gd_Controlsclick;
                gd.Controlsclick_sua += Gd_Controlsclick_sua;
                gd.Controlsclick_xoa += Gd_Controlsclick_xoa;
                flowLayoutPanel1.Controls.Add(gd);
            }

            flowLayoutPanel1.AutoScroll = true;
        }
        public void load_sua(Phong phong)
        {
            txt_sophong.Text = phong.so_phong.ToString();
            cbm_loaiphong.SelectedValue = phong.loai_phong_id;
            cbm_tang.SelectedValue = phong.tang;
            cbm_trangthai.SelectedValue = phong.trang_thai;

        }
        public void load_theoboloc(List<Phong> list)
        {
            ResetInputs();
            flowLayoutPanel1.Controls.Clear();

            foreach (Phong p in list)
            {
                gd_Phong gd = new gd_Phong
                {
                    BackColor = Color.Aqua,
                    SoPhong = p.so_phong
                };

                gd.loadThongTinPhong(p.so_phong, p.LoaiPhong.ten_loai_phong, qL_Phong.DemSoSinhVienTrongPhong(p.so_phong));
                gd.Controlsclick += Gd_Controlsclick;
                gd.Controlsclick_sua += Gd_Controlsclick_sua;
                gd.Controlsclick_xoa += Gd_Controlsclick_xoa;
                flowLayoutPanel1.Controls.Add(gd);
            }

        
          

        }

        private void Gd_Controlsclick_xoa(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Gd_Controlsclick_sua(object sender, EventArgs e)
        {
            gd_Phong gd = sender as gd_Phong;
            if (gd != null)
            {
                Phong a = qL_Phong.loadThongTinPhong(gd.SoPhong);
                txt_sophong.Text +=a.so_phong.ToString();
                cbm_loaiphong.SelectedItem = a.loai_phong_id.ToString();
                cbm_tang.SelectedItem = a.tang.ToString();
                cbm_trangthai.SelectedItem =a.trang_thai;
            }
        }
        private void OnGdControlsclick()
        {
            Gd_Controlsclick?.Invoke(this, EventArgs.Empty);
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            OnGdControlsclick();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn sửa phòng" + txt_sophong.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                qL_Phong.update_Phong(txt_sophong.Text, int.Parse(cbm_tang.SelectedItem.ToString()), cbm_trangthai.SelectedItem.ToString(),
                                    int.Parse(cbm_loaiphong.SelectedItem.ToString()));
                ResetInputs();
                MessageBox.Show("Đã sửa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            LoadData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tim.Text == null)
            {
                LoadData();
            }
            if (radio_sophong.Checked)
            {
                List<Phong> phongsFiltered = qL_Phong.LocTheo_SoPhong(txt_tim.Text);
                load_theoboloc(phongsFiltered);
            }
            else if (radio_tang.Checked)
            {
                List<Phong> phongsFiltered = qL_Phong.LocTheo_Tang(int.Parse(txt_tim.Text));
                load_theoboloc(phongsFiltered);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            radio_sophong.Checked = false;
            radio_tang.Checked = false;
            txt_sophong.Text = "";
            txt_tim.Text = "";
            
        }
    }
}
