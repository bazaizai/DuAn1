using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISizeRepos
    {
        bool Add(Size obj);
        bool Update(Size obj);

        bool Delete(Size obj);
        Size GetById(Guid id);
        List<Size> GetSizes();
    }
}
