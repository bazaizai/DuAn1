using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IAnhServices
    {
        string Add(AnhView Obj);
        string Update(AnhView Obj);
        string Delete(AnhView Obj);
        AnhView GetByID(Guid ID);
        List<AnhView> GetAll();
    }
}
