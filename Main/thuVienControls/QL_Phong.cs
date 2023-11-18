using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace thuVienControls
{
    public class QL_Phong
    {
        QL_KTXDataContext QL_KTX = new QL_KTXDataContext();
        public QL_Phong()
        {

        }

        public List<Phong> loadDSPhong()
        {
            var phongs = from p in QL_KTX.Phongs select p;

            return phongs.ToList();
        }

        public Phong loadThongTinPhong(string soPhong)
        {
            var thongTinPhong = QL_KTX.Phongs.Where(t => t.so_phong == soPhong).FirstOrDefault();
            return thongTinPhong;
        }

        public object loadDanhSachSinhVienTheoPhong(string soPhong)
        {
            var dsSinhVien = from sv in QL_KTX.SinhViens where sv.so_phong == soPhong select new { sv.ho_ten, sv.ma_sinh_vien, sv.gioi_tinh, sv.email };
            return dsSinhVien.ToList();
        }

        public List<Phong> LayDanhSachPhongChuaDayTheoLoaiPhong(string loaiPhong)
        {
            List<Phong> danhSachPhongChuaDay = new List<Phong>();

            foreach (Phong phong in QL_KTX.Phongs)
            {
                int idPhong = phong.phong_id;
                string soPhong = phong.so_phong;
                int i = int.Parse(phong.LoaiPhong.so_nguoi_toi_da.ToString());
               
                int soSinhVienTrongPhong = int.Parse(DemSoSinhVienTrongPhong(soPhong));

                if (kiemTraSlotPhong(soPhong) && soSinhVienTrongPhong < i &&
                    phong.LoaiPhong.ten_loai_phong == loaiPhong)
                {
                    danhSachPhongChuaDay.Add(phong);
                }
            }

            return danhSachPhongChuaDay;
        }


        public double layGiaTienPhong(int idPhong)
        {
            Phong p = QL_KTX.Phongs.Where(t => t.phong_id == idPhong).FirstOrDefault();
            return double.Parse(p.LoaiPhong.gia_phong.ToString());
        }

        public bool kiemTraSlotPhong(string soPhong)
        {
            int i = int.Parse(DemSoSinhVienTrongPhong(soPhong));
            int j = kiemTraSoNguoiToiDa(soPhong);
            if (i < j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DemSoSinhVienTrongPhong(string phongCanDem)
        {
            var soSinhVienTrongPhong = from phong in QL_KTX.Phongs
                                       join sinhvien in QL_KTX.SinhViens
                                       on phong.so_phong equals sinhvien.so_phong
                                       where phong.so_phong == phongCanDem
                                       group sinhvien by phong.so_phong into g
                                       select new
                                       {
                                           SoPhong = g.Key,
                                           SoSinhVien = g.Count()
                                       };

            var phongX = soSinhVienTrongPhong.FirstOrDefault();
            int soSinhVienTrongPhongX = (phongX != null) ? phongX.SoSinhVien : 0;
            return soSinhVienTrongPhongX.ToString();
        }

        public int demSoLuongPhong()
        {
            var Phongs = QL_KTX.Phongs.Select(t => t).ToList();
            
            if (Phongs != null)
            {
                int sl = Phongs.Count();
                return sl;
            }
            else
            {
                return 0;
            }
        }

        public int kiemTraSoNguoiToiDa(string soPhong)
        {
            var loaiPhongQuery = from phong in QL_KTX.Phongs where phong.so_phong == soPhong select new { phong.LoaiPhong.so_nguoi_toi_da };
            var loaiPhong = loaiPhongQuery.FirstOrDefault();
            if(loaiPhong != null)
            {
                int loai = (int)loaiPhong.so_nguoi_toi_da;
                return loai;
            }
            else
            {
                return 0;
            }
        }

        public object layDSLoaiPhong()
        {
            var loais = QL_KTX.LoaiPhongs.Select(t => t).ToList();
            return loais;
        }

        public List<string> LayDSTenPhong()
        {
            var tenPhongs = QL_KTX.Phongs.Select(t => t.so_phong).ToList();
            return tenPhongs;
        }

        public string TimPhongTrong(string[] tenPhong, int soNguoiToiDa)
        {
            foreach (var phong in tenPhong)
            {
                int soLuongTrongPhong = int.Parse(DemSoSinhVienTrongPhong(phong));
                int sltda = kiemTraSoNguoiToiDa(phong);
                if (soLuongTrongPhong < soNguoiToiDa && sltda == soNguoiToiDa)
                {
                    return phong;
                }
            }
            return null;
        }
    }
}
