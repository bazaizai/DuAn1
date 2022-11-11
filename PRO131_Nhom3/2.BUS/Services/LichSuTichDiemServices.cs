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
        ITichDiemRepos _iTichDiemRepos;
        ICtTichDiemRepos _iCtTichDiemRepos;
        IHoaDonRepos _iHoaDonRepos;
        public LichSuTichDiemServices()
        {
            _iLichSuTichDiemRepos = new LichSuTichDiemRepos();
            _iTichDiemRepos = new TichDiemRepos();
            _iCtTichDiemRepos = new CtTichDiemRepos();
            _iHoaDonRepos = new HoaDonRepos();
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
            catch (Exception e)
            {
                return e.Message.ToString();
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
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }

        public List<LichSuTichDiemView> GetAll()
        {
            var lst = (from a in _iLichSuTichDiemRepos.GetAll()
                       join b in _iTichDiemRepos.GetAll() on a.IdTichDiem equals b.Id
                       //join c in (from a in _iCtTichDiemRepos.GetAll()
                       //           join b in _iHoaDonRepos.GetAll() on a.IdHoaDon equals b.Id
                       //           select new )
                      
                       select new LichSuTichDiemView()
                       {
                           Id = a.Id,
                           HeSoTich = a.HeSoTich,
                           SoDiemLS = b.SoDiem,
                           SoDiemTD = b.SoDiem,
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
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
