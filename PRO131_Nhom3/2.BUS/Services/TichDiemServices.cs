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
    public class TichDiemServices : ITichDiemServices
    {
        ITichDiemRepos _iTichDiemRepos;
        public TichDiemServices()
        {
            _iTichDiemRepos = new TichDiemRepos();
        }
        public string Add(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id,
                    SoDiem = obj.SoDiem,
                    TrangThai = obj.TrangThai
                };
                if (_iTichDiemRepos.Add(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {
                return "Không Thành Công";
            }
        }

        public string Delete(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id
                };
                if (_iTichDiemRepos.Delete(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {

                return "Không Thành Công";
            }
        }

        public List<TichDiemView> GetAll()
        {
            var lst = (from a in _iTichDiemRepos.GetTichDiems()
                       select new TichDiemView()
                       {
                           Id = a.Id,
                           SoDiem = a.SoDiem,
                           TrangThai = a.TrangThai
                       }).ToList();
            return lst;
        }

        public TichDiemView GetByID(Guid id)
        {
            var a = _iTichDiemRepos.GetById(id);
            var x = new TichDiemView()
            {
                Id = a.Id,
                SoDiem = a.SoDiem,
                TrangThai = a.TrangThai
            };
            return x;
        }

        //public List<TichDiemView> Search(string obj)
        //{
        //    throw new NotImplementedException();
        //}

        public string Update(TichDiemView obj)
        {
            try
            {
                var x = new TichDiem()
                {
                    Id = obj.Id,
                    SoDiem = obj.SoDiem,
                    TrangThai= obj.TrangThai
                };
                if (_iTichDiemRepos.Update(x)) return "Thành Công";
                return "Không Thành Công";
            }
            catch (Exception)
            {
                return "Không Thành Công";
            }
        }
    }
}
