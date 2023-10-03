using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form_PhanQuyen : Form
    {
        public Form_PhanQuyen()
        {
            InitializeComponent();
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

       
        private void Form_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_KTX_DATASET.VaiTro' table. You can move, or remove it, as needed.
            this.vaiTroTableAdapter.Fill(this.ql_KTX_DATASET.VaiTro);
            // TODO: This line of code loads data into the 'ql_KTX_DATASET.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.ql_KTX_DATASET.PhanQuyen);

            this.phanQuyenDKTableAdapter.Fill(this.ql_KTX_DATASET.PhanQuyenDK, (int)vaiTroDataGridView.Rows[0].Cells[0].Value);
        }

        private void vaiTroDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maNhomNguoiDung = (int)vaiTroDataGridView.CurrentRow.Cells[0].Value;
            try
            {
                this.phanQuyenDKTableAdapter.Fill(this.ql_KTX_DATASET.PhanQuyenDK, maNhomNguoiDung);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int nhomNguoiDung = (int)vaiTroDataGridView.CurrentRow.Cells[0].Value;
            int i = 0;
            foreach (DataGridViewRow item in phanQuyenDKDataGridView.Rows)
            {
                if (item.Cells[0] != null && item.Cells[0].Value != null)
                {
                    var ketQua = phanQuyenTableAdapter.KiemTraTonTai(nhomNguoiDung, (int)item.Cells[0].Value);
                    if (ketQua == null)
                    {
                        try
                        {
                            phanQuyenTableAdapter.Insert(nhomNguoiDung,
                           (int)item.Cells[0].Value, (bool)(item.Cells[2].Value));
                            i = 1;
                        }
                        catch
                        {
                            phanQuyenTableAdapter.Insert(nhomNguoiDung,
                           (int)item.Cells[0].Value, false);
                            i = 1;
                        }
                        
                    }
                    else
                    {
                        phanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), nhomNguoiDung, (int)item.Cells[0].Value);
                        i = 1;
                    }
                    
                }
            }
            if(i==1)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }
    }
}
