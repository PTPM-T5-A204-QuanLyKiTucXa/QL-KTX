using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace thuVienControls
{
    public class Ql_NguoiDung
    {
        public Ql_NguoiDung()
        {

        }
        public int check_config()
        {
            if (Properties.Settings.Default.DACK == string.Empty)
            {
                return 1;
            }
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.DACK);
            try
            {
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public int check_user(string user, string pass)
        {
            string cauLenh = "select * from QL_NguoiDung where TenDangNhap ='" + user + "' and MatKhau ='" + pass + "'";
            SqlDataAdapter da_checkuser = new SqlDataAdapter(cauLenh, Properties.Settings.Default.DACK);
            DataTable dt = new DataTable();
            da_checkuser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 1; // user không tồn tại kìa mày
            }
            if (dt.Rows[0][2] == null || dt.Rows[0][2] == "False")
            {
                return 2; // hàng này không sài được mày
            }
            return 0;

        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" +
            pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            thuVienControls.Properties.Settings.Default.DACK = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            thuVienControls.Properties.Settings.Default.Save();
        }
    }
}
