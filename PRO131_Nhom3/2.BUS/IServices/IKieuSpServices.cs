using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKieuSpServices
    {
<<<<<<< HEAD
        string Add(KieuSpViews Obj);
        string Update(KieuSpViews Obj);
        string Delete(KieuSpViews Obj);
        KieuSpViews GetById(Guid Id);
=======
        string Add(KieuSpViews obj);
        string Update(KieuSpViews obj);
        string Delete(KieuSpViews obj);
        KieuSpViews GetID(Guid id);
>>>>>>> Hieu
        List<KieuSpViews> GetAll();
    }
}
