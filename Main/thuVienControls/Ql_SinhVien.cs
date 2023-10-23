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
        QL_Phong QL_Phong = new QL_Phong();
        public Ql_SinhVien()
        {

        }

        public bool themSinhVien(string maSV,string hoTen, DateTime ngaySinh, string cccd, string gioiTinh, string sdt, string diaChi,string email)
        {
            var sinhVien = QL_KTX.SinhViens.Where(t => t.ma_sinh_vien == maSV).FirstOrDefault();
            if(sinhVien !=null)
            {
                return false;
            }
            else
            {
                SinhVien sv = new SinhVien();
                sv.ma_sinh_vien = maSV;
                sv.ho_ten = hoTen;
                sv.ngay_sinh = ngaySinh;
                sv.CCCD = cccd;
                sv.gioi_tinh = gioiTinh;
                sv.so_dien_thoai = sdt;
                sv.dia_chi = diaChi;
                sv.email = email;
                QL_KTX.SinhViens.InsertOnSubmit(sv);
                QL_KTX.SubmitChanges();
            }
            return true;
        }

        public object loadDanhSachSinhVien()
        {
            var dsSinhVien = from sv in QL_KTX.SinhViens select new { sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            return dsSinhVien.ToList();
        }

        public object loadDanhSachSinhVienTheoTrangThai(string trangThai)
        {
 
            var dsSinhVien = from sv in QL_KTX.SinhViens where sv.trang_thai == trangThai select new {sv.ma_sinh_vien, sv.ho_ten, sv.so_dien_thoai, sv.email, sv.gioi_tinh, sv.trang_thai };
            return dsSinhVien.ToList();
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

        public bool kiemTraSinhVienCoTrongPhong(string maSV, string SoPhong)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == maSV && sv.so_phong == SoPhong select sv).FirstOrDefault();
            if(sinhVien!=null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSinhVien(string ma,string hoten, DateTime ngaysinh, string gioitinh, string sdt, string diachi, string email, string sophong)
        {
            var sinhVien = (from sv in QL_KTX.SinhViens where sv.ma_sinh_vien == ma select sv).FirstOrDefault();
            if (sinhVien != null)
            {
                sinhVien.ho_ten = hoten;
                sinhVien.ngay_sinh = ngaysinh;
                sinhVien.gioi_tinh = gioitinh;
                sinhVien.so_dien_thoai = sdt;
                sinhVien.dia_chi = diachi;
                sinhVien.email = email;
                if (kiemTraSinhVienCoTrongPhong(ma, sophong))
                {
                    QL_KTX.SubmitChanges();
                    return true;
                }
                else
                {
                    if (QL_Phong.kiemTraSlotPhong(sophong))
                    {
                        sinhVien.so_phong = sophong;
                    }
                    else
                    {
                        MessageBox.Show("Phòng đã đủ người");
                        return false;
                    }
                }
                QL_KTX.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
