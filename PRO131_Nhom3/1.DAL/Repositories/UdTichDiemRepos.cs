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
    public class UdTichDiemRepos : IUdTichDiemRepos
    {
        FpolyDBContext Context = new FpolyDBContext();
        public UdTichDiemRepos()
        {

        }

        public bool Add(UdtichDiem obj)
        {
            try
            {
                Context.UdtichDiems.Add(obj);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(UdtichDiem obj)
        {
            try
            {
                var temp = Context.UdtichDiems.FirstOrDefault(x => x.Id == obj.Id);
                Context.UdtichDiems.Remove(temp);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public UdtichDiem GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return Context.UdtichDiems.FirstOrDefault(s => s.Id == id);
        }

        public List<UdtichDiem> GetUuDais()
        {
            return Context.UdtichDiems.ToList();
        }

        public bool Update(UdtichDiem obj)
        {
            try
            {
                var temp = Context.UdtichDiems.FirstOrDefault(x => x.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.LoaiHinhKm = obj.LoaiHinhKm;
                temp.MucUuDai = obj.MucUuDai;
                temp.TrangThai = obj.TrangThai;
                Context.UdtichDiems.Update(temp);
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
