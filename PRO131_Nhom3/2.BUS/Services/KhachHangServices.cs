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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepos _iKhachHangRepos;
        ITichDiemRepos _iTichDiemRepos;

        public KhachHangServices()
        {
            _iKhachHangRepos = new KhachHangRepos();
            _iTichDiemRepos = new TichDiemRepos();
        }
        public string Add(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TenDem = obj.TenDem,
                    Ho = obj.Ho,
                    NgaySinh = obj.NgaySinh,
                    Sdt = obj.Sdt,
                    DiaChi = obj.DiaChi,
                    Email = obj.Email,
                    TrangThai = obj.TrangThai
                };
                if (_iKhachHangRepos.Add(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

        }

        public string Delete(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id
                };
                if (_iKhachHangRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }


        }

        public List<KhachHangView> GetAll()
        {
            var lst = (from a in _iKhachHangRepos.GetAll()
                       join b in _iTichDiemRepos.GetAll() on a.IdtichDiem equals b.Id
                       select new KhachHangView()
                       {
                           Id = a.Id,
                           Ma = a.Ma,
                           Ten = a.Ten,
                           TenDem = a.TenDem,
                           Ho = a.Ho,
                           NgaySinh = a.NgaySinh,
                           Sdt = a.Sdt,
                           DiaChi = a.DiaChi,
                           Email = a.Email,
                           SoDiem = b.SoDiem,
                           TrangThai = a.TrangThai
                       }).OrderBy(c => c.Ma).ToList();
            return lst;
        }

        public KhachHangView GetByID(Guid id)
        {
            var a = _iKhachHangRepos.GetById(id);
            var x = new KhachHangView()
            {
                Id = a.Id,
                Ma = a.Ma,
                Ten = a.Ten,
                TenDem = a.TenDem,
                Ho = a.Ho,
                NgaySinh = a.NgaySinh,
                Sdt = a.Sdt,
                DiaChi = a.DiaChi,
                Email = a.Email,
                TrangThai = a.TrangThai
            };
            return x;
        }

        public List<KhachHangView> Search(string obj)
        {
            var lst = (from a in _iKhachHangRepos.GetAll()
                       select new KhachHangView()
                       {
                           Id = a.Id,
                           Ma = a.Ma,
                           Ten = a.Ten,
                           TenDem = a.TenDem,
                           Ho = a.Ho,
                           NgaySinh = a.NgaySinh,
                           Sdt = a.Sdt,
                           DiaChi = a.DiaChi,
                           Email = a.Email,
                           TrangThai = a.TrangThai
                       }).OrderBy(c => c.Ma).ToList();
            return lst.Where(c => c.Ma.ToLower().Contains(obj.ToLower()) || c.Ten.ToLower().Contains(obj.ToLower())).OrderBy(c => c.Ma).ToList();
        }

        public string Update(KhachHangView obj)
        {
            try
            {
                var x = new KhachHang()
                {
                    Id = obj.Id,
                    Ma = obj.Ma,
                    Ten = obj.Ten,
                    TenDem = obj.TenDem,
                    Ho = obj.Ho,
                    NgaySinh = obj.NgaySinh,
                    Sdt = obj.Sdt,
                    DiaChi = obj.DiaChi,
                    Email = obj.Email,
                    TrangThai = obj.TrangThai
                };
                if (_iKhachHangRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
