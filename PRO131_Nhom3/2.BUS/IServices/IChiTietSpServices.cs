using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSpServices
    {
        string Add(ChiTietSpView Obj);
        string Update(ChiTietKieuSpView Obj);
        string Delete(ChiTietKieuSpView Obj);
        ChiTietKieuSpView GetById(Guid Id);
        List<ChiTietKieuSpView> GetAll();
    }
}
