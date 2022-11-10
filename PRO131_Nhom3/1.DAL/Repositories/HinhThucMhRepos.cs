﻿using _1.DAL.Context;
using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HinhThucMhRepos
    {
        public FpolyDBContext _dbContext;
        public HinhThucMhRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HinhThucMh obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {
                _dbContext.HinhThucMhs.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Update(HinhThucMh obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.HinhThucMhs.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.HinhThucMhs.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(HinhThucMh obj)
        {

            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.HinhThucMhs.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public List<HinhThucMh> GetHinhThucMhs()
        {
            return _dbContext.HinhThucMhs.ToList();
        }
    }
}