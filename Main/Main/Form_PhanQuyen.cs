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

        private void qL_PhanQuyenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phanQuyenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ql_KTX_DATASET);
        }

        private void Form_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_KTX_DATASET.VaiTro' table. You can move, or remove it, as needed.
            this.vaiTroTableAdapter.Fill(this.ql_KTX_DATASET.VaiTro);
            // TODO: This line of code loads data into the 'ql_KTX_DATASET.PhanQuyen' table. You can move, or remove it, as needed.
            this.phanQuyenTableAdapter.Fill(this.ql_KTX_DATASET.PhanQuyen);
            // TODO: This line of code loads data into the 'datatest1.QL_NhomNguoiDung' table. You can move, or remove it, as needed.

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nhomNguoiDung = (int)vaiTroDataGridView.CurrentRow.Cells[0].Value;
            
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
                        }
                        catch
                        {
                            phanQuyenTableAdapter.Insert(nhomNguoiDung,
                           (int)item.Cells[0].Value, false);
                        }
                    }
                    else
                    {
                        phanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), nhomNguoiDung, (int)item.Cells[0].Value);
                    }
                }
            }
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
    }
}
