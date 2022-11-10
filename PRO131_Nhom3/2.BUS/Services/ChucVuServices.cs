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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuRepos _iChucVuRepos;
        public ChucVuServices()
        {
            _iChucVuRepos = new ChucVuRepos();
        }
        public bool Add(ChucVuView obj)
        {
            var vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iChucVuRepos.Add(vcv);
            return true;
        }

        public bool Delete(ChucVuView obj)
        {
            var vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iChucVuRepos.Delete(vcv);
            return true;
        }

        public List<ChucVuView> GetChucVus()
        {
            List<ChucVuView> _lstChucVu = new List<ChucVuView>();
            _lstChucVu = (
                from a in _iChucVuRepos.GetChucVus()
                select new ChucVuView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstChucVu;
        }

        public bool Update(ChucVuView obj)
        {
            var vcv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iChucVuRepos.Update(vcv);
            return true;
        }
    }
}
