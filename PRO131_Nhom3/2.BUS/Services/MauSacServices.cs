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
        public string MaTS()
        {
            if (_iMauSacRepos.GetMauSacs().Count == 0) return "MS1";
            return "MS" + (_iMauSacRepos.GetMauSacs().Max(x => Convert.ToInt32(x.Ma.Substring(2, x.Ma.Length - 2))) + 1);

        }
        public string Add(MauSacView obj)
        {
            if (obj == null) return "thêm thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = MaTS(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Add(ms);
            return "thêm thành công";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "xóa thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Delete(ms);
            return "xóa thành công";
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

        public string Update(MauSacView obj)
        {
            if (obj == null) return "sửa thất bại";
            MauSac ms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            _iMauSacRepos.Update(ms);
            return "sửa thành công";
        }
    }
}
