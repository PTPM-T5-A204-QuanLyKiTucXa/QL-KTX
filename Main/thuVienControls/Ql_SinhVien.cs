using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace thuVienControls
{
    public class Ql_SinhVien
    {
        QL_KTXDataContext QL_KTX = new QL_KTXDataContext();

        public Ql_SinhVien()
        {

        }


        public DataGridView loadDanhSachSinhVien()
        {
            DataGridView dgv = new DataGridView();
            var dsSinhVien = from sv in QL_KTX.SinhViens select new { sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            dgv.DataSource = dsSinhVien;
            return dgv;
        }

        public DataGridView loadDanhSachSinhVienTheoTrangThai(string trangThai)
        {
            DataGridView dgv = new DataGridView();
            var dsSinhVien = from sv in QL_KTX.SinhViens where sv.trang_thai == trangThai select new {sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            dgv.DataSource = dsSinhVien;
            return dgv;
        }

        public SinhVien loadThongTinSinhVienTheoMa(string maSV)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == maSV select sv).FirstOrDefault();
            if (sinhVien != null)
            {
                return sinhVien;
            }
            else
            {
                return null;
            }
        }
    }
}
