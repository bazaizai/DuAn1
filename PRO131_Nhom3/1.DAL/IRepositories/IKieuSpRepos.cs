using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKieuSpRepos
    {
<<<<<<< HEAD
        bool Add(KieuSp Obj);
        bool Update(KieuSp Obj);
        bool Delete(KieuSp Obj);
        KieuSp GetById(Guid Id);
=======
        bool Add(KieuSp obj);
        bool Update(KieuSp obj);
        KieuSp GetID(Guid id);
>>>>>>> Hieu
        List<KieuSp> GetAll();
    }
}
