﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuVienControls
{
    public class NguoiDung_DAL
    {
        QL_KTXDataContext db=new QL_KTXDataContext();
        public NguoiDung_DAL() { }
        public List<NguoiDung> getNguoiDung() 
        {
            return db.NguoiDungs.ToList();    
        }
        public List<string> layList_tenvaitro()
        {
                var list = db.VaiTros.Select(p=>p.ten_vai_tro).Distinct().ToList();
                return list;
        }
        public int laymavaitro(string tenvaitro)
        {
            var vaiTro = db.VaiTros.Where(p => p.ten_vai_tro.Contains(tenvaitro)).FirstOrDefault();
            if (vaiTro != null)
            {
                return vaiTro.vai_tro_id;
            }
            else
            {
                return -1; 
            }
        }
        public string laytenvaitro(int mavaitro)
        {
            var vaiTro = db.VaiTros.Where(p => p.vai_tro_id == mavaitro).FirstOrDefault();
            if (vaiTro != null)
            {
                return vaiTro.ten_vai_tro;
            }
            else
            {
                return "Không tìm thấy vai trò"; 
            }
        }

        public bool themTaiKhoanSinhVien(string maSV, string sdt)
        {
            var nguoiDung = db.NguoiDungs.Where(t => t.ten_nguoi_dung == maSV).FirstOrDefault();
            if (nguoiDung != null)
            {
                return false;
            }
            else
            {
                NguoiDung nd = new NguoiDung();
                nd.ten_nguoi_dung = maSV;
                nd.mat_khau = sdt;
                nd.trang_thai = true;
                nd.vai_tro_id = 2;
                db.NguoiDungs.InsertOnSubmit(nd);
                db.SubmitChanges();
            }
            return true;
        }

        public bool suaTaiKhoanSinhVien(string maSV, string sdt,int vaitro)
        {
            var nguoiDung = db.NguoiDungs.Where(t => t.ten_nguoi_dung == maSV).FirstOrDefault();
            if (nguoiDung == null)
            {
                return false;
            }
            nguoiDung.mat_khau = sdt;
            nguoiDung.trang_thai = true;
            nguoiDung.vai_tro_id = vaitro;
            db.SubmitChanges();
            return true;
        }
        public bool xoaTaiKhoanSinhVien(string maSV)
        {
            var nguoiDung = db.NguoiDungs.Where(t => t.ten_nguoi_dung == maSV).FirstOrDefault();
            if (nguoiDung == null)
            {
                return false;
            }
            db.NguoiDungs.DeleteOnSubmit(nguoiDung);
            db.SubmitChanges();

            return true;
        }
    }
}