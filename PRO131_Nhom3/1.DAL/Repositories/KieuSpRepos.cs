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
    public class KieuSpRepos : IKieuSpRepos
    {
        FpolyDBContext context;
        public KieuSpRepos()
        {
          context = new FpolyDBContext();
        }

        public bool Add(KieuSp obj)
        {
            try
            {
                if (obj == null) return false;
                context.KieuSps.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<KieuSp> GetAll()
        {
            return context.KieuSps.ToList();
        }

        public KieuSp GetID(Guid id)
        {
           if(id== Guid.Empty) return null;
           return context.KieuSps.FirstOrDefault(c=>c.Id == id);
        }

        public bool Update(KieuSp obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = context.KieuSps.FirstOrDefault(c => c.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                context.KieuSps.Update(temp);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
