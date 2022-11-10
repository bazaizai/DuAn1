using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSaleServices
    {
        string Add(ChiTietSaleView chiTietSale);
        string Update(ChiTietSaleView chiTietSale);
        string Delete(Guid id);
        List<ChiTietSaleView> GetAll();
    }
}
