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
    public class LichSuTichDiemServices:ILichSuTichDiemServices
    {
        ILichSuTichDiemRepos _iLichSuTichDiemRepos;
        public LichSuTichDiemServices()
        {
            _iLichSuTichDiemRepos = new LichSuTichDiemRepos();
        }
        public string Add(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id,
                    HeSoTich = obj.HeSoTich,
                    TrangThai = obj.TrangThai
                };
                if (_iLichSuTichDiemRepos.Add(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {
                return "Không Thành Công";
            }
        }

        public string Delete(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id
                };
                if (_iLichSuTichDiemRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {

                return "Không Thành Công";
            }
        }

        public List<LichSuTichDiemView> GetAll()
        {
            var lst = (from a in _iLichSuTichDiemRepos.GetLstichDiems()
                       select new LichSuTichDiemView()
                       {
                           Id = a.Id,
                           HeSoTich = a.HeSoTich,
                           TrangThai = a.TrangThai
                       }).ToList();
            return lst;
        }

        public LichSuTichDiemView GetByID(Guid id)
        {
            var a = _iLichSuTichDiemRepos.GetById(id);
            var x = new LichSuTichDiemView()
            {
                Id = a.Id,
                HeSoTich = a.HeSoTich,
                TrangThai = a.TrangThai
            };
            return x;
        }

        //public List<LichSuTichDiemView> Search(string obj)
        //{
        //    var lst = (from a in _iLichSuTichDiemRepos.GetLstichDiems()
        //               select new LichSuTichDiemView()
        //               {
        //                   Id = a.Id,
        //                   HeSoTich = a.HeSoTich,
        //                   TrangThai = a.TrangThai
        //               }).ToList();
        //    return lst.Where(c => c.Ma.ToLower().Contains(obj.ToLower()) || c.Ten.ToLower().Contains(obj.ToLower())).OrderBy(c => c.Ma).ToList();
        //}

        public string Update(LichSuTichDiemView obj)
        {
            try
            {
                var x = new LstichDiem()
                {
                    Id = obj.Id,
                    HeSoTich = obj.HeSoTich,
                    TrangThai = obj.TrangThai
                };
                if (_iLichSuTichDiemRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {
                return "Không Thành Công";
            }
        }
    }
}
