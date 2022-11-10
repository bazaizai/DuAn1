﻿using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class MauSacRepos : IMauSacRepos
    {
        FpolyDBContext Context = new FpolyDBContext();
        public MauSacRepos()
        {

        }

        public bool Add(MauSac obj)
        {
            try
            {
                Context.MauSacs.Add(obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(MauSac obj)
        {
            try
            {
                var temp = Context.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
                Context.MauSacs.Remove(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return Context.MauSacs.FirstOrDefault(s => s.Id == id);
        }

        public List<MauSac> GetMauSacs()
        {
            return Context.MauSacs.ToList();
        }

        public bool Update(MauSac obj)
        {
            try
            {
                var temp = Context.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.Ten = obj.Ten;
                temp.TrangThai = obj.TrangThai;
                Context.MauSacs.Update(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}