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
        bool Add(KieuSp obj);
        bool Update(KieuSp obj);
        KieuSp GetID(Guid id);
        List<KieuSp> GetAll();
    }
}
