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
    public class CtTichDiemRepos : ICtTichDiemRepos
    {
        FpolyDBContext Context = new FpolyDBContext();
        public CtTichDiemRepos()
        {

        }

        public bool Add(CttichDiem obj)
        {
            try
            {
                Context.CttichDiems.Add(obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(CttichDiem obj)
        {
            try
            {
                var temp = Context.CttichDiems.FirstOrDefault(x => x.Id == obj.Id);
                Context.CttichDiems.Remove(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CttichDiem GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return Context.CttichDiems.FirstOrDefault(s => s.Id == id);
        }

        public List<CttichDiem> GetUuDais()
        {
            return Context.CttichDiems.ToList();
        }

        public bool Update(CttichDiem obj)
        {
            try
            {
                var temp = Context.CttichDiems.FirstOrDefault(x => x.Id == obj.Id);
                temp.IdHoaDon = obj.IdHoaDon;
                temp.HeSoTich = obj.HeSoTich;
                temp.TrangThai = obj.TrangThai;
                Context.CttichDiems.Update(temp);
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
