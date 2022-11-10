using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRepos hoaDonRepos;
        public HoaDonServices()
        {
            hoaDonRepos = new HoaDonRepos();
        }

        public string Add(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> GetAll()
        {
            throw new NotImplementedException();
        }

        public HoaDonView GetID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonView obj)
        {
            throw new NotImplementedException();
        }
    }
}
