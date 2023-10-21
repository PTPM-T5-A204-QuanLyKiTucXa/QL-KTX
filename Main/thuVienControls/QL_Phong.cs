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

        public int kiemTraLoaiPhong(string soPhong)
        {
            var loaiPhongQuery = from phong in QL_KTX.Phongs where phong.so_phong == soPhong select new { phong.LoaiPhong.loai_phong_id };
            var loaiPhong = loaiPhongQuery.FirstOrDefault();
            if(loaiPhong != null)
            {
                int loai = loaiPhong.loai_phong_id;
                if (loai == 1)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return 0;
            }
        }

        public bool kiemTraSlotPhong(string soPhong)
        {
            int i = int.Parse(DemSoSinhVienTrongPhong(soPhong));
            int j = kiemTraLoaiPhong(soPhong);
            if(i<j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
