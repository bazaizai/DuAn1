using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
=======
>>>>>>> Hieu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KieuSpRepos : IKieuSpRepos
    {
<<<<<<< HEAD
        FpolyDBContext Context;
        public KieuSpRepos()
        {
            Context = new FpolyDBContext();
        }
        public bool Add(KieuSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.KieuSps.Add(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
=======
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
>>>>>>> Hieu
            {
                return false;
            }
        }

<<<<<<< HEAD
        public bool Delete(KieuSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.KieuSps.Remove(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<KieuSp> GetAll() => Context.KieuSps.ToList();

        public KieuSp GetById(Guid Id)=> GetAll().FirstOrDefault(x => x.Id == Id);

        public bool Update(KieuSp Obj)
        {
            if (Obj == null) return false;
            try
            {
                Context.KieuSps.Update(Obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
=======
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
>>>>>>> Hieu
            {
                return false;
            }
        }
    }
}
