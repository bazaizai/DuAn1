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
    public class MauSacServices : IMauSacServices
    {
        private IMauSacRepos _iMauSacRepos;
        public MauSacServices()
        {
            _iMauSacRepos = new MauSacRepos();
        }
        public bool Add(MauSacView obj)
        {
            var ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Add(ms);
            return true;
        }

        public bool Delete(MauSacView obj)
        {
            var ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Delete(ms);
            return true;
        }

        public List<MauSacView> GetMauSacs()
        {
            List<MauSacView> _lstMauSac = new List<MauSacView>();
            _lstMauSac = (
                from a in _iMauSacRepos.GetMauSacs()
                select new MauSacView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TrangThai = a.TrangThai
                }).ToList();
            return _lstMauSac;
        }

        public bool Update(MauSacView obj)
        {
            var ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Update(ms);
            return true;
        }
    }
}
