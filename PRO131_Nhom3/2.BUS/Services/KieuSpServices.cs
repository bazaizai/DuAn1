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
    public class KieuSpServices : IKieuSpServices
    {
        IKieuSpRepos _IKieuSpRepos;
        public KieuSpServices()
        {
            _IKieuSpRepos = new KieuSpRepos();
        }

        public string Add(KieuSpViews Obj)=> Obj != null && GetAll().All(x => x.Ten != Obj.Ten) && _IKieuSpRepos.Add(new KieuSp(Obj.Ma,Obj.Ten,Obj.TrangThai)) ? "Add success" : "Add not success";

        public string Delete(KieuSpViews Obj)=> Obj != null && _IKieuSpRepos.Delete(_IKieuSpRepos.GetAll().Find(x => x.Id == Obj.Id)) ? "Delete success" : "Delete not succsess";

        public List<KieuSpViews> GetAll() => (from a in _IKieuSpRepos.GetAll()
                                            select new KieuSpViews()
                                            {
                                                Id = a.Id,
                                                Ten = a.Ten,
                                                Ma = a.Ma,
                                                TrangThai = a.TrangThai,
                                            }).OrderBy(x=>x.Ma).ToList();

        public KieuSpViews GetById(Guid Id) => GetAll().Find(x => x.Id == Id);

        public string Update(KieuSpViews Obj)
        {
            if (Obj == null) return "Update not success";
            var x = _IKieuSpRepos.GetById(Obj.Id);
            x.Ma = Obj.Ma;
            x.TrangThai = Obj.TrangThai;
            x.Ten = Obj.Ten;
            _IKieuSpRepos.Update(x);
            return "Update success";
        }
    }
}
