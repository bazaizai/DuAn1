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
        string Add(KieuSpViews obj);
        string Update(KieuSpViews obj);
        string Delete(KieuSpViews obj);
        KieuSpViews GetID(Guid id);
        List<KieuSpViews> GetAll();
    }
}
