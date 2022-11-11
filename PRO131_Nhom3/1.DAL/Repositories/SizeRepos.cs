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
    public class SizeRepos:ISizeRepos
    {
        public FpolyDBContext _dbContext;
        public SizeRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Size obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {
                _dbContext.Sizes.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Update(Size obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.Sizes.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Size1 = obj.Size1;
                tempobj.Cm = obj.Cm;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.Sizes.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(Size obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.Sizes.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public List<Size> GetSizes()
        {
            return _dbContext.Sizes.ToList();
        }

        public Size GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Sizes.FirstOrDefault(c => c.Id == id);

        }
    }
}
