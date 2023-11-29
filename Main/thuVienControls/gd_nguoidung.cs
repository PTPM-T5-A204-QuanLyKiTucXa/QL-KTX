using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuVienControls
{
    public partial class gd_nguoidung : UserControl
    {
       NguoiDung_DAL nd=new NguoiDung_DAL();
        public gd_nguoidung()
        {
            InitializeComponent();
            Load += Gd_nguoidung_Load;
        }

        private void Gd_nguoidung_Load(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data()
        {
            cbm_trangthai.Items.Add("True");
            cbm_trangthai.Items.Add("False");



            //------------------------------------------------

            List<string> list = nd.layList_tenvaitro();
            foreach (string item in list) 
            {
                cbm_vaitro.Items.Add(item);
            }

            data_nguoidung.DataSource = nd.getNguoiDung();
            data_nguoidung.Columns[5].Visible = false;
        }

        private void data_nguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                data_nguoidung.ClearSelection();
                data_nguoidung.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = data_nguoidung.Rows[e.RowIndex];
                txt_tennguoidung.Text = selectedRow.Cells["ten_nguoi_dung"].Value.ToString();
                txt_matkhau.Text = selectedRow.Cells["mat_khau"].Value.ToString();
                cbm_trangthai.SelectedItem = selectedRow.Cells["trang_thai"].Value.ToString();
                int mavaitro = int.Parse(selectedRow.Cells["vai_tro_id"].Value.ToString());
                cbm_vaitro.SelectedItem =nd.laytenvaitro(mavaitro);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_tennguoidung.Text) || string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu ", "Thông Báo", MessageBoxButtons.OK);
            }
            else 
            {
                bool kq = nd.themTaiKhoanSinhVien(txt_tennguoidung.Text, txt_matkhau.Text);
                if (kq)
                {
                    MessageBox.Show("Tài khoản " + txt_tennguoidung.Text + " thêm thành công !", "Thông báo", MessageBoxButtons.OK);
                    load_data();
                    txt_tennguoidung.Text = "";
                    txt_matkhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Tài khoản " + txt_tennguoidung.Text + " bị trùng !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_tennguoidung.Text) || string.IsNullOrEmpty(txt_matkhau.Text)
              || string.IsNullOrEmpty(cbm_trangthai.SelectedItem.ToString())||
              string.IsNullOrEmpty(cbm_vaitro.SelectedItem.ToString()))
            {
                MessageBox.Show("Không thể sửa dữ liệu này", "Thông Báo", MessageBoxButtons.OK);
            }  
            else
            {
                DialogResult r = MessageBox.Show("Bạn muốn sửa lại thông tin", "Chú ý", MessageBoxButtons.YesNo);
                if(r==DialogResult.Yes)
                {
                    int mavaitro = nd.laymavaitro(cbm_vaitro.SelectedItem.ToString());
                   bool kq= nd.suaTaiKhoanSinhVien(txt_tennguoidung.Text, txt_matkhau.Text,mavaitro);
                    if(kq)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông Báo", MessageBoxButtons.OK);
                        load_data();
                        txt_tennguoidung.Text = "";
                        txt_matkhau.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật", "Thông Báo", MessageBoxButtons.OK);
                    }    
                }    
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
