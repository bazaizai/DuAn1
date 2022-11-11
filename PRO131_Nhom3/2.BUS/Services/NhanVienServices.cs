using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private INhanVienRepos _iNhanVienRepos;
        private IChucVuRepos _iChucVuRepos;
        public NhanVienServices()
        {
            _iNhanVienRepos = new NhanVienRepos();
            _iChucVuRepos = new ChucVuRepos();
        }
        public string Add(NhanVienView obj)
        {
            if (obj == null) return "Thêm thất bại";
            NhanVien nv = new NhanVien()
            {
                Id = obj.Id,
                IdCv = obj.IdCv,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                Cccd = obj.Cccd,
                MatKhau = obj.MatKhau,
                Email = obj.Email,
                TaiKhoan = obj.TaiKhoan,
                TrangThai = obj.TrangThai
            };
            _iNhanVienRepos.Add(nv);
            return "thêm thành công";
        }

        public string Delete(NhanVienView obj)
        {
            if (obj == null) return "xóa thất bại";
            NhanVien nv = new NhanVien()
            {
                Id = obj.Id,
                IdCv = obj.IdCv,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                Cccd = obj.Cccd,
                MatKhau = obj.MatKhau,
                Email = obj.Email,
                TaiKhoan = obj.TaiKhoan,
                TrangThai = obj.TrangThai
            };
            _iNhanVienRepos.Delete(nv);
            return "xóa thành công";
        }

        public List<NhanVienView> GetNhanViens()
        {
            List<NhanVienView> _lstCtTinhDiem = new List<NhanVienView>();
            _lstCtTinhDiem = (
                from a in _iNhanVienRepos.GetNhanViens()
                join b in _iChucVuRepos.GetChucVus() on a.IdCv equals b.Id
                select new NhanVienView()
                {
                    Id = a.Id,
                    IdCv = b.Id,
                    MaCV = b.Ma,
                    TenCV = b.Ten,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    HoVaTen = String.Concat(a.Ho, " ", a.TenDem, " ", a.Ten),
                    GioiTinh = a.GioiTinh,
                    NgaySinh = a.NgaySinh,
                    DiaChi = a.DiaChi,
                    Sdt = a.Sdt,
                    Cccd = a.Cccd,
                    MatKhau = a.MatKhau,
                    Email = a.Email,
                    TaiKhoan = a.TaiKhoan,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstCtTinhDiem;
        }

        public string Update(NhanVienView obj)
        {
            if (obj == null) return "sửa thất bại";
            NhanVien nv = new NhanVien()
            {
                Id = obj.Id,
                IdCv = obj.IdCv,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                Cccd = obj.Cccd,
                MatKhau = obj.MatKhau,
                Email = obj.Email,
                TaiKhoan = obj.TaiKhoan,
                TrangThai = obj.TrangThai
            };
            _iNhanVienRepos.Update(nv);
            return "sửa thành công";
        }
    }
}
