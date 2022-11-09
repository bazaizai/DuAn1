﻿using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChiTietKieuSpServices : IChiTietKieuSpViewService
    {
        IChiTietKieuSpRespos _IChiTietSpRespo;
        public ChiTietKieuSpServices()
        {
            _IChiTietSpRespo = new ChiTietKieuSpRespos();
        }
        public string Add(ChiTietKieuSpView Obj) => Obj != null && _IChiTietSpRespo.Add(new ChiTietKieuSp(Obj.IdKieuSp, Obj.IdChiTietSp, Obj.TrangThai)) ? "Add success" : "Add not success";

        public string Delete(ChiTietKieuSpView Obj)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietKieuSpView> GetAll() => (from a in _IChiTietSpRespo.GetAll()
                                                   select new ChiTietKieuSpView()
                                                   {
                                                       Id = a.Id,
                                                       IdChiTietSp = a.IdChiTietSp,
                                                       IdKieuSp = a.IdKieuSp,
                                                       TrangThai = a.TrangThai
                                                   }).ToList();

        public ChiTietKieuSpView GetById(Guid Id) => GetAll().Find(x=>x.Id == Id);
        public string Update(ChiTietKieuSpView Obj)
        {
            if (Obj == null) return "Update not success";
            var x = _IChiTietSpRespo.GetById(Obj.Id);
            x.IdChiTietSp = Obj.IdChiTietSp;
            x.TrangThai = Obj.TrangThai;
            x.IdKieuSp = Obj.IdKieuSp;
            _IChiTietSpRespo.Update(x);
            return "Update success";
        }
    }
}
