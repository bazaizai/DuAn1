using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietKieuSpRespos : IChiTietKieuSpRespos
    {
        FpolyDBContext Context;
        public ChiTietKieuSpRespos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(ChiTietKieuSp Obj)
        {
            if(Obj == null)return false;
            Context.ChiTietKieuSps.Add(Obj);
            Context.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietKieuSp Obj)
        {
            if (Obj == null) return false;
            Context.ChiTietKieuSps.Remove(Obj);
            Context.SaveChanges();
            return true;
        }

        public List<ChiTietKieuSp> GetAll() => Context.ChiTietKieuSps.ToList();

        public ChiTietKieuSp GetById(Guid Id) => GetAll().FirstOrDefault(x => x.Id == Id);

        public bool Update(ChiTietKieuSp Obj)
        {
            if (Obj == null) return false;
            Context.ChiTietKieuSps.Update(Obj);
            Context.SaveChanges();
            return true;
        }
    }
}
