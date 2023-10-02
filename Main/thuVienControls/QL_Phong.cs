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
            Phong p = new Phong();
            var thongTinPhong = (from ph in QL_KTX.Phongs
                                where ph.so_phong == soPhong
                                       select new
                                       {
                                           ph.so_phong, ph.LoaiPhong, ph.tang
                                       }).SingleOrDefault();

            if(thongTinPhong!=null)
            {
                p.so_phong = thongTinPhong.so_phong;
                p.LoaiPhong = thongTinPhong.LoaiPhong;
                p.tang = thongTinPhong.tang;
            }
            return p;
        }

        public DataGridView loadDanhSachSinhVienTheoPhong(string soPhong)
        {
            DataGridView dgv = new DataGridView();
            var dsSinhVien = from sv in QL_KTX.SinhViens where sv.so_phong == soPhong select new{ sv.ho_ten, sv.ma_sinh_vien, sv.gioi_tinh, sv.email};
            dgv.DataSource = dsSinhVien;
            return dgv;
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

    }
}
