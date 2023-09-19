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
    public partial class cauHinh : Form
    {
        public cauHinh()
        {
            InitializeComponent();
            cbx_severname.DropDown += cbx_severname_DropDown;
            cbx_database.DropDown += cbx_database_DropDown;
        }


        void cbx_database_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_database.DataSource =
            CauHinh.GetDBName(cbx_severname.Text, txt_username.Text, txt_pass.Text);
            cbx_database.DisplayMember = "name";
        }

        void cbx_severname_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_severname.DataSource = CauHinh.GetServerName();
            cbx_severname.DisplayMember = "ServerName";
        }

        private void cauHinh_Load(object sender, EventArgs e)
        {

        }
        private void cboServer_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_severname.DataSource = CauHinh.GetServerName();
            cbx_severname.DisplayMember = "ServerName";
        }

        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            cbx_database.DataSource =
            CauHinh.GetDBName(cbx_severname.Text, txt_username.Text, txt_pass.Text);
            cbx_database.DisplayMember = "name";
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            Ql_NguoiDung CauHinh = new Ql_NguoiDung();
            CauHinh.SaveConfig(cbx_severname.Text, txt_username.Text, txt_pass.Text, cbx_database.Text);
            this.Close();
        }
    }
}
